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
    public class EquipmentUsageHistoriesController : Controller
    {
        private readonly OSPContext _context;

        public EquipmentUsageHistoriesController(OSPContext context)
        {
            _context = context;
        }

        // GET: EquipmentUsageHistories
        public async Task<IActionResult> Index()
        {
            var oSPContext = _context.EquipmentUsageHistories.Include(e => e.Equipment);
            return View(await oSPContext.ToListAsync());
        }

        // GET: EquipmentUsageHistories/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentUsageHistory = await _context.EquipmentUsageHistories
                .Include(e => e.Equipment)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipmentUsageHistory == null)
            {
                return NotFound();
            }

            return View(equipmentUsageHistory);
        }

        // GET: EquipmentUsageHistories/Create
        public IActionResult Create(int? equipmentId)
        {
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "Id", "Name", equipmentId);
            return View();
        }

        // POST: EquipmentUsageHistories/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,EquipmentId,UsedDate,Notes")] EquipmentUsageHistory equipmentUsageHistory)
        {
            if (ModelState.IsValid)
            {
                _context.Add(equipmentUsageHistory);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "Id", "Id", equipmentUsageHistory.EquipmentId);
            return View(equipmentUsageHistory);
        }

        // GET: EquipmentUsageHistories/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentUsageHistory = await _context.EquipmentUsageHistories.FindAsync(id);
            if (equipmentUsageHistory == null)
            {
                return NotFound();
            }
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "Id", "Id", equipmentUsageHistory.EquipmentId);
            return View(equipmentUsageHistory);
        }

        // POST: EquipmentUsageHistories/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,EquipmentId,UsedDate,Notes")] EquipmentUsageHistory equipmentUsageHistory)
        {
            if (id != equipmentUsageHistory.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(equipmentUsageHistory);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EquipmentUsageHistoryExists(equipmentUsageHistory.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["EquipmentId"] = new SelectList(_context.Equipment, "Id", "Id", equipmentUsageHistory.EquipmentId);
            return View(equipmentUsageHistory);
        }

        // GET: EquipmentUsageHistories/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var equipmentUsageHistory = await _context.EquipmentUsageHistories
                .Include(e => e.Equipment)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (equipmentUsageHistory == null)
            {
                return NotFound();
            }

            return View(equipmentUsageHistory);
        }

        // POST: EquipmentUsageHistories/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var equipmentUsageHistory = await _context.EquipmentUsageHistories.FindAsync(id);
            if (equipmentUsageHistory != null)
            {
                _context.EquipmentUsageHistories.Remove(equipmentUsageHistory);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EquipmentUsageHistoryExists(int id)
        {
            return _context.EquipmentUsageHistories.Any(e => e.Id == id);
        }
    }
}
