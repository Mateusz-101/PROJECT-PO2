﻿using System;
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
    public class FirefightersController : Controller
    {
        private readonly OSPContext _context;

        public FirefightersController(OSPContext context)
        {
            _context = context;
        }

        // GET: Firefighters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Firefighters.ToListAsync());
        }

        // GET: Firefighters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firefighter = await _context.Firefighters
                .Include(f => f.Trainings)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (firefighter == null)
            {
                return NotFound();
            }

            return View(firefighter);
        }

        // GET: Firefighters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Firefighters/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,FirstName,LastName,BirthDate,Phone,Email,Rank,IsActive")] Firefighter firefighter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(firefighter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(firefighter);
        }

        // GET: Firefighters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firefighter = await _context.Firefighters.FindAsync(id);
            if (firefighter == null)
            {
                return NotFound();
            }
            return View(firefighter);
        }

        // POST: Firefighters/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,FirstName,LastName,BirthDate,Phone,Email,Rank,IsActive")] Firefighter firefighter)
        {
            if (id != firefighter.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(firefighter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!FirefighterExists(firefighter.Id))
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
            return View(firefighter);
        }

        // GET: Firefighters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var firefighter = await _context.Firefighters
                .Include(f => f.Trainings)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (firefighter == null)
            {
                return NotFound();
            }

            return View(firefighter);
        }

        // POST: Firefighters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var firefighter = await _context.Firefighters.FindAsync(id);
            if (firefighter != null)
            {
                _context.Firefighters.Remove(firefighter);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool FirefighterExists(int id)
        {
            return _context.Firefighters.Any(e => e.Id == id);
        }
    }
}
