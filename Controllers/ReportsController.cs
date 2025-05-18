using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using OSPManagementSystem.Data;
using OSPManagementSystem.Models;
using Rotativa.AspNetCore;
using System.Drawing;


namespace OSPManagementSystem.Controllers
{
    public class ReportsController : Controller
    {
        private readonly OSPContext _context;

        public ReportsController(OSPContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var firefighters = await _context.Firefighters
                .Include(f => f.RescueActions)
                .Include(f => f.Trainings)
                .Include(f => f.Schedules)
                .ToListAsync();

            var firefighterActivities = firefighters.Select(f => new FirefighterActivity
            {
                FirefighterName = f.FirstName + " " + f.LastName,
                RescueActionsCount = f.RescueActions?.Count ?? 0,
                TrainingsCount = f.Trainings?.Count ?? 0,
                SchedulesCount = f.Schedules?.Count ?? 0
            }).ToList();

            var report = new ReportViewModel
            {
                FirefighterActivities = firefighterActivities,
                TotalRescueActions = await _context.RescueActions.CountAsync(),
                TotalTrainings = await _context.Trainings.CountAsync(),
                TotalSchedules = await _context.Schedules.CountAsync()
            };

            return View(report);
        }

        [HttpGet]
        public async Task<IActionResult> ExportToPdf()
        {
            var firefighters = await _context.Firefighters
                .Include(f => f.RescueActions)
                .Include(f => f.Trainings)
                .Include(f => f.Schedules)
                .ToListAsync();

            var firefighterActivities = firefighters.Select(f => new FirefighterActivity
            {
                FirefighterName = f.FirstName + " " + f.LastName,
                RescueActionsCount = f.RescueActions?.Count ?? 0,
                TrainingsCount = f.Trainings?.Count ?? 0,
                SchedulesCount = f.Schedules?.Count ?? 0
            }).ToList();

            var report = new ReportViewModel
            {
                FirefighterActivities = firefighterActivities,
                TotalRescueActions = await _context.RescueActions.CountAsync(),
                TotalTrainings = await _context.Trainings.CountAsync(),
                TotalSchedules = await _context.Schedules.CountAsync()
            };

            return new ViewAsPdf("ExportToPdf", report)
            {
                FileName = "RaportOSP.pdf"
            };
        }

        [HttpGet]
        public async Task<IActionResult> ExportToExcel()
        {
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

            var firefighters = await _context.Firefighters
                .Include(f => f.RescueActions)
                .Include(f => f.Trainings)
                .Include(f => f.Schedules)
                .ToListAsync();

            var data = firefighters.Select(f => new
            {
                Imię = f.FirstName,
                Nazwisko = f.LastName,
                Szkolenia = f.Trainings?.Count ?? 0,
                Akcje = f.RescueActions?.Count ?? 0,
                Dyżury = f.Schedules?.Count ?? 0
            }).ToList();

            using var package = new ExcelPackage();
            var worksheet = package.Workbook.Worksheets.Add("Raport");

            // Wstaw dane
            worksheet.Cells["A1"].LoadFromCollection(data, true);

            // Styl nagłówków
            using (var range = worksheet.Cells[1, 1, 1, 5])
            {
                range.Style.Font.Bold = true;
                range.Style.Fill.PatternType = ExcelFillStyle.Solid;
                range.Style.Fill.BackgroundColor.SetColor(Color.FromArgb(0, 128, 0));
                range.Style.Font.Color.SetColor(Color.White);
            }

            worksheet.Cells.AutoFitColumns();

            var stream = new MemoryStream(package.GetAsByteArray());
            return File(stream, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "RaportStrazakow.xlsx");
        }
    }
}
