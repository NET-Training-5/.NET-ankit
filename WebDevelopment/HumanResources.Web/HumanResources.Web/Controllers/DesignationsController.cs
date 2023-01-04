﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HumanResources.Web.Models;

namespace HumanResources.Web.Controllers
{
    public class DesignationsController : Controller
    {
        private readonly HRDbContext _context = new();

        //public DesignationsController(HRDbContext context)
        //{
        //    _context = context;
        //}

        // GET: Designations
        public async Task<IActionResult> Index()
        {
              return _context.designations != null ? 
                          View(await _context.designations.ToListAsync()) :
                          Problem("Entity set 'HRDbContext.designations'  is null.");
        }

        // GET: Designations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.designations == null)
            {
                return NotFound();
            }

            var designation = await _context.designations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (designation == null)
            {
                return NotFound();
            }

            return View(designation);
        }

        // GET: Designations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Designations/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,status")] Designation designation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(designation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(designation);
        }

        // GET: Designations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.designations == null)
            {
                return NotFound();
            }

            var designation = await _context.designations.FindAsync(id);
            if (designation == null)
            {
                return NotFound();
            }
            return View(designation);
        }

        // POST: Designations/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,status")] Designation designation)
        {
            if (id != designation.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(designation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!DesignationExists(designation.Id))
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
            return View(designation);
        }

        // GET: Designations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.designations == null)
            {
                return NotFound();
            }

            var designation = await _context.designations
                .FirstOrDefaultAsync(m => m.Id == id);
            if (designation == null)
            {
                return NotFound();
            }

            return View(designation);
        }

        // POST: Designations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.designations == null)
            {
                return Problem("Entity set 'HRDbContext.designations'  is null.");
            }
            var designation = await _context.designations.FindAsync(id);
            if (designation != null)
            {
                _context.designations.Remove(designation);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool DesignationExists(int id)
        {
          return (_context.designations?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
