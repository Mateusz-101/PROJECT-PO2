using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using OSPManagementSystem.Data;
using OSPManagementSystem.Models;

namespace OSPManagementSystem.Controllers
{
    public class RescueActionsController : Controller
    {
        private readonly OSPContext _context;

        public RescueActionsController(OSPContext context)
        {
            _context = context;
        }

        // GET: RescueActions
        public async Task<IActionResult> Index()
        {
            return View(await _context.RescueActions.ToListAsync());
        }

        // GET: RescueActions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rescueAction = await _context.RescueActions
                .Include(r => r.Firefighters)
                .Include(r => r.Equipment) // ← ważne!
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rescueAction == null)
            {
                return NotFound();
            }

            return View(rescueAction);
        }

        // GET: RescueActions/Create
        public IActionResult Create()
        {
            ViewData["Firefighters"] = new MultiSelectList(_context.Firefighters, "Id", "LastName");
            ViewData["Equipment"] = new MultiSelectList(_context.Equipment, "Id", "Name");

            return View();
        }

        // POST: RescueActions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Date,Type,Location,Description")] RescueAction rescueAction)
        {
            if (ModelState.IsValid)
            {
                var selectedFirefighterIds = Request.Form["SelectedFirefighters"];
                rescueAction.Firefighters = _context.Firefighters
                    .Where(f => selectedFirefighterIds.Contains(f.Id.ToString()))
                    .ToList();

                var selectedEquipmentIds = Request.Form["SelectedEquipment"];
                rescueAction.Equipment = _context.Equipment
                    .Where(e => selectedEquipmentIds.Contains(e.Id.ToString()))
                    .ToList();

                _context.Add(rescueAction);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Firefighters"] = new MultiSelectList(_context.Firefighters, "Id", "LastName");
            ViewData["Equipment"] = new MultiSelectList(_context.Equipment, "Id", "Name");

            return View(rescueAction);
        }

        // GET: RescueActions/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var rescueAction = await _context.RescueActions
                .Include(r => r.Firefighters)
                .Include(r => r.Equipment)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (rescueAction == null) return NotFound();

            // Lista wybranych ID
            var selectedEquipmentIds = rescueAction.Equipment.Select(e => e.Id).ToList();

            ViewData["Firefighters"] = new MultiSelectList(_context.Firefighters, "Id", "LastName",
                rescueAction.Firefighters.Select(f => f.Id));
            ViewData["Equipment"] = new MultiSelectList(_context.Equipment.ToList(),
                "Id", "Name", selectedEquipmentIds);

            return View(rescueAction);
        }

        // POST: RescueActions/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Date,Type,Location,Description")] RescueAction rescueAction)
        {
            if (id != rescueAction.Id) return NotFound();

            var actionToUpdate = await _context.RescueActions
                .Include(r => r.Firefighters)
                .Include(r => r.Equipment)
                .FirstOrDefaultAsync(r => r.Id == id);

            if (actionToUpdate == null) return NotFound();

            if (ModelState.IsValid)
            {
                // Zaktualizuj pola podstawowe
                actionToUpdate.Date = rescueAction.Date;
                actionToUpdate.Type = rescueAction.Type;
                actionToUpdate.Location = rescueAction.Location;
                actionToUpdate.Description = rescueAction.Description;

                // Zaktualizuj strażaków
                var selectedFirefighters = Request.Form["SelectedFirefighters"];
                actionToUpdate.Firefighters = _context.Firefighters
                    .Where(f => selectedFirefighters.Contains(f.Id.ToString()))
                    .ToList();

                // Zaktualizuj sprzęt
                var selectedEquipment = Request.Form["SelectedEquipment"];
                actionToUpdate.Equipment = _context.Equipment
                    .Where(e => selectedEquipment.Contains(e.Id.ToString()))
                    .ToList();

                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["Firefighters"] = new MultiSelectList(_context.Firefighters, "Id", "LastName");
            ViewData["Equipment"] = new MultiSelectList(_context.Equipment, "Id", "Name");
            return View(rescueAction);
        }


        // GET: RescueActions/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rescueAction = await _context.RescueActions
                .Include(r => r.Firefighters)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rescueAction == null)
            {
                return NotFound();
            }

            return View(rescueAction);
        }

        // POST: RescueActions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rescueAction = await _context.RescueActions.FindAsync(id);
            if (rescueAction != null)
            {
                _context.RescueActions.Remove(rescueAction);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RescueActionExists(int id)
        {
            return _context.RescueActions.Any(e => e.Id == id);
        }
    }
}
