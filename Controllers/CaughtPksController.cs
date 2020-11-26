using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PokedexV.Data;
using PokedexV.Models;

namespace PokedexV.Controllers
{
    public class CaughtPksController : Controller
    {
        private readonly PokedexVContext _context;

        public CaughtPksController(PokedexVContext context)
        {
            _context = context;
        }

        // GET: CaughtPks
        public async Task<IActionResult> Index()
        {
            return View(await _context.CaughtPk.ToListAsync());
        }

        // GET: CaughtPks/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caughtPk = await _context.CaughtPk
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caughtPk == null)
            {
                return NotFound();
            }

            return View(caughtPk);
        }

        // GET: CaughtPks/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CaughtPks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CaughtName,CaughtDexNum")] CaughtPk caughtPk)
        {
            if (ModelState.IsValid)
            {
                _context.Add(caughtPk);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(caughtPk);
        }

        // GET: CaughtPks/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caughtPk = await _context.CaughtPk.FindAsync(id);
            if (caughtPk == null)
            {
                return NotFound();
            }
            return View(caughtPk);
        }

        // POST: CaughtPks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CaughtName,CaughtDexNum")] CaughtPk caughtPk)
        {
            if (id != caughtPk.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(caughtPk);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CaughtPkExists(caughtPk.Id))
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
            return View(caughtPk);
        }

        // GET: CaughtPks/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var caughtPk = await _context.CaughtPk
                .FirstOrDefaultAsync(m => m.Id == id);
            if (caughtPk == null)
            {
                return NotFound();
            }

            return View(caughtPk);
        }

        // POST: CaughtPks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var caughtPk = await _context.CaughtPk.FindAsync(id);
            _context.CaughtPk.Remove(caughtPk);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CaughtPkExists(int id)
        {
            return _context.CaughtPk.Any(e => e.Id == id);
        }
    }
}
