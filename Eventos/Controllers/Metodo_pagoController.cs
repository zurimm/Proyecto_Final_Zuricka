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
    public class Metodo_pagoController : Controller
    {
        private readonly EventosContext _context;

        public Metodo_pagoController(EventosContext context)
        {
            _context = context;
        }

        // GET: Metodo_pago
        public async Task<IActionResult> Index()
        {
              return _context.Metodo_pago != null ? 
                          View(await _context.Metodo_pago.ToListAsync()) :
                          Problem("Entity set 'EventosContext.Metodo_pago'  is null.");
        }

        // GET: Metodo_pago/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Metodo_pago == null)
            {
                return NotFound();
            }

            var metodo_pago = await _context.Metodo_pago
                .FirstOrDefaultAsync(m => m.Id == id);
            if (metodo_pago == null)
            {
                return NotFound();
            }

            return View(metodo_pago);
        }

        // GET: Metodo_pago/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Metodo_pago/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Numero_Tarjeta,Fecha_vencimiento,CVV,Nombre_tarjeta")] Metodo_pago metodo_pago)
        {
            if (ModelState.IsValid)
            {
                _context.Add(metodo_pago);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(metodo_pago);
        }

        // GET: Metodo_pago/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Metodo_pago == null)
            {
                return NotFound();
            }

            var metodo_pago = await _context.Metodo_pago.FindAsync(id);
            if (metodo_pago == null)
            {
                return NotFound();
            }
            return View(metodo_pago);
        }

        // POST: Metodo_pago/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Numero_Tarjeta,Fecha_vencimiento,CVV,Nombre_tarjeta")] Metodo_pago metodo_pago)
        {
            if (id != metodo_pago.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(metodo_pago);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!Metodo_pagoExists(metodo_pago.Id))
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
            return View(metodo_pago);
        }

        // GET: Metodo_pago/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Metodo_pago == null)
            {
                return NotFound();
            }

            var metodo_pago = await _context.Metodo_pago
                .FirstOrDefaultAsync(m => m.Id == id);
            if (metodo_pago == null)
            {
                return NotFound();
            }

            return View(metodo_pago);
        }

        // POST: Metodo_pago/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Metodo_pago == null)
            {
                return Problem("Entity set 'EventosContext.Metodo_pago'  is null.");
            }
            var metodo_pago = await _context.Metodo_pago.FindAsync(id);
            if (metodo_pago != null)
            {
                _context.Metodo_pago.Remove(metodo_pago);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool Metodo_pagoExists(int id)
        {
          return (_context.Metodo_pago?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
