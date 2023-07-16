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
    public class cat_eventoController : Controller
    {
        private readonly EventosContext _context;

        public cat_eventoController(EventosContext context)
        {
            _context = context;
        }

        // GET: cat_evento
        public async Task<IActionResult> Index()
        {
              return _context.cat_evento != null ? 
                          View(await _context.cat_evento.ToListAsync()) :
                          Problem("Entity set 'EventosContext.cat_evento'  is null.");
        }

        // GET: cat_evento/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.cat_evento == null)
            {
                return NotFound();
            }

            var cat_evento = await _context.cat_evento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cat_evento == null)
            {
                return NotFound();
            }

            return View(cat_evento);
        }

        // GET: cat_evento/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: cat_evento/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre_Cat,Precio_cat_Entrada,contraseña_cat")] cat_evento cat_evento)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cat_evento);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cat_evento);
        }

        // GET: cat_evento/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.cat_evento == null)
            {
                return NotFound();
            }

            var cat_evento = await _context.cat_evento.FindAsync(id);
            if (cat_evento == null)
            {
                return NotFound();
            }
            return View(cat_evento);
        }

        // POST: cat_evento/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre_Cat,Precio_cat_Entrada,contraseña_cat")] cat_evento cat_evento)
        {
            if (id != cat_evento.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cat_evento);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!cat_eventoExists(cat_evento.Id))
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
            return View(cat_evento);
        }

        // GET: cat_evento/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.cat_evento == null)
            {
                return NotFound();
            }

            var cat_evento = await _context.cat_evento
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cat_evento == null)
            {
                return NotFound();
            }

            return View(cat_evento);
        }

        // POST: cat_evento/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.cat_evento == null)
            {
                return Problem("Entity set 'EventosContext.cat_evento'  is null.");
            }
            var cat_evento = await _context.cat_evento.FindAsync(id);
            if (cat_evento != null)
            {
                _context.cat_evento.Remove(cat_evento);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool cat_eventoExists(int id)
        {
          return (_context.cat_evento?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
