using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eventos.Data;
using Eventos.Models;

namespace Eventos.Controllers
{
    public class SoporteController : Controller
    {
        private readonly EventosContext _context;

        public SoporteController(EventosContext context)
        {
            _context = context;
        }

        // GET: Soporte
        public async Task<IActionResult> Index()
        {
              return _context.Soporte != null ? 
                          View(await _context.Soporte.ToListAsync()) :
                          Problem("Entity set 'EventosContext.Soporte'  is null.");
        }

        // GET: Soporte/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Soporte == null)
            {
                return NotFound();
            }

            var soporte = await _context.Soporte
                .FirstOrDefaultAsync(m => m.Id == id);
            if (soporte == null)
            {
                return NotFound();
            }

            return View(soporte);
        }

        // GET: Soporte/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Soporte/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre_Soporte,email_Soporte,contraseña_Soporte")] Soporte soporte)
        {
            if (ModelState.IsValid)
            {
                _context.Add(soporte);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(soporte);
        }

        // GET: Soporte/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Soporte == null)
            {
                return NotFound();
            }

            var soporte = await _context.Soporte.FindAsync(id);
            if (soporte == null)
            {
                return NotFound();
            }
            return View(soporte);
        }

        // POST: Soporte/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre_Soporte,email_Soporte,contraseña_Soporte")] Soporte soporte)
        {
            if (id != soporte.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(soporte);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SoporteExists(soporte.Id))
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
            return View(soporte);
        }

        // GET: Soporte/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Soporte == null)
            {
                return NotFound();
            }

            var soporte = await _context.Soporte
                .FirstOrDefaultAsync(m => m.Id == id);
            if (soporte == null)
            {
                return NotFound();
            }

            return View(soporte);
        }

        // POST: Soporte/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Soporte == null)
            {
                return Problem("Entity set 'EventosContext.Soporte'  is null.");
            }
            var soporte = await _context.Soporte.FindAsync(id);
            if (soporte != null)
            {
                _context.Soporte.Remove(soporte);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SoporteExists(int id)
        {
          return (_context.Soporte?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
