using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OSPManagementSystem.Data;

namespace OSPManagementSystem.Controllers
{
    public class TrainingsController : Controller
    {
        private readonly OSPContext _context;

        public TrainingsController(OSPContext context)
        {
            _context = context;
        }

        // GET: Trainings
        public async Task<IActionResult> Index()
        {
            return View(await _context.Trainings.ToListAsync());
        }

        // GET: Trainings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var training = await _context.Trainings
                .Include(t => t.Firefighters)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (training == null)
            {
                return NotFound();
            }

            return View(training);
        }

        // GET: Trainings/Create
        public IActionResult Create()
        {
            ViewData["Firefighters"] = new MultiSelectList(_context.Firefighters.ToList(), "Id", "LastName");
            return View();
        }

        // POST: Trainings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Date")] Training training)
        {
            if (ModelState.IsValid)
            {
                // Strażacy z formularza
                var selectedIds = Request.Form["SelectedFirefighters"];
                training.Firefighters = _context.Firefighters
                    .Where(f => selectedIds.Contains(f.Id.ToString()))
                    .ToList();

                _context.Add(training);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            // Jeśli ModelState nieprawidłowy — trzeba ponownie załadować listę strażaków
            ViewData["Firefighters"] = new MultiSelectList(_context.Firefighters.ToList(), "Id", "LastName");
            return View(training);
        }

        // GET: Trainings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Trainings == null)
                return NotFound();

            var training = await _context.Trainings
                .Include(t => t.Firefighters)
                .FirstOrDefaultAsync(t => t.Id == id);

            if (training == null)
                return NotFound();

            var selectedIds = training.Firefighters.Select(f => f.Id).ToList();

            var firefighterList = _context.Firefighters
                .Select(f => new SelectListItem
                {
                    Value = f.Id.ToString(),
                    Text = f.FirstName + " " + f.LastName,
                    Selected = selectedIds.Contains(f.Id)
                }).ToList();

            ViewData["Firefighters"] = firefighterList;

            return View(training);
        }

        // POST: Trainings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Date")] Training training)
        {
            if (id != training.Id)
                return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    var trainingToUpdate = await _context.Trainings
                        .Include(t => t.Firefighters)
                        .FirstOrDefaultAsync(t => t.Id == id);

                    if (trainingToUpdate == null)
                        return NotFound();

                    trainingToUpdate.Name = training.Name;
                    trainingToUpdate.Date = training.Date;

                    var selectedIds = Request.Form["SelectedFirefighters"];
                    trainingToUpdate.Firefighters = _context.Firefighters
                        .Where(f => selectedIds.Contains(f.Id.ToString()))
                        .ToList();

                    _context.Update(trainingToUpdate);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainingExists(training.Id))
                        return NotFound();
                    else
                        throw;
                }
                return RedirectToAction(nameof(Index));
            }

            ViewData["Firefighters"] = _context.Firefighters
                .Select(f => new SelectListItem
                {
                    Value = f.Id.ToString(),
                    Text = f.FirstName + " " + f.LastName
                }).ToList();

            return View(training);
        }

        // GET: Trainings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var training = await _context.Trainings
                .FirstOrDefaultAsync(m => m.Id == id);
            if (training == null)
            {
                return NotFound();
            }

            return View(training);
        }

        // POST: Trainings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var training = await _context.Trainings.FindAsync(id);
            if (training != null)
            {
                _context.Trainings.Remove(training);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainingExists(int id)
        {
            return _context.Trainings.Any(e => e.Id == id);
        }
    }
}
