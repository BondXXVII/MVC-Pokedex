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
    public class TrainersController : Controller
    {
        private readonly PokedexVContext _context;

        public TrainersController(PokedexVContext context)
        {
            _context = context;
        }

        // GET: Trainers
        public async Task<IActionResult> Index()
        {
            return View(await _context.TrainerStuff.ToListAsync());
        }

        // GET: Trainers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainerStuff = await _context.TrainerStuff
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainerStuff == null)
            {
                return NotFound();
            }

            return View(trainerStuff);
        }

        // GET: Trainers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Trainers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,TrainerName,TrainerImage,Badges")] TrainerStuff trainerStuff)
        {
            if (ModelState.IsValid)
            {
                _context.Add(trainerStuff);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(trainerStuff);
        }

        // GET: Trainers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainerStuff = await _context.TrainerStuff.FindAsync(id);
            if (trainerStuff == null)
            {
                return NotFound();
            }
            return View(trainerStuff);
        }

        // POST: Trainers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,TrainerName,TrainerImage,Badges")] TrainerStuff trainerStuff)
        {
            if (id != trainerStuff.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(trainerStuff);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TrainerStuffExists(trainerStuff.Id))
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
            return View(trainerStuff);
        }

        // GET: Trainers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var trainerStuff = await _context.TrainerStuff
                .FirstOrDefaultAsync(m => m.Id == id);
            if (trainerStuff == null)
            {
                return NotFound();
            }

            return View(trainerStuff);
        }

        // POST: Trainers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var trainerStuff = await _context.TrainerStuff.FindAsync(id);
            _context.TrainerStuff.Remove(trainerStuff);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TrainerStuffExists(int id)
        {
            return _context.TrainerStuff.Any(e => e.Id == id);
        }
    }
}
