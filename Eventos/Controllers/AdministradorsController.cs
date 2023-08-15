using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Eventos.Data;
using Eventos.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.CodeAnalysis.CSharp.Syntax;

namespace Eventos.Controllers
{
    public class AdministradorsController : Controller
    {
        public EventosContext _context;


        public AdministradorsController(EventosContext context)
        {
            _context = context;
        }

        // GET: Administradors
        public async Task<IActionResult> Index()
        {
              return _context.Administrador != null ? 
                          View(await _context.Administrador.ToListAsync()) :
                          Problem("Entity set 'EventosContext.Administrador'  is null.");
        }

        // GET: Administradors/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Administrador == null)
            {
                return NotFound();
            }

            var administrador = await _context.Administrador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (administrador == null)
            {
                return NotFound();
            }

            return View(administrador);
        }

        // GET: Administradors/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Administradors/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nombre_Adm,email_Adm,contraseña_Adm")] Administrador administrador)
        {
            if (ModelState.IsValid)
            {
                _context.Add(administrador);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(administrador);
        }

        // GET: Administradors/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Administrador == null)
            {
                return NotFound();
            }

            var administrador = await _context.Administrador.FindAsync(id);
            if (administrador == null)
            {
                return NotFound();
            }
            return View(administrador);
        }

        // POST: Administradors/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nombre_Adm,email_Adm,contraseña_Adm")] Administrador administrador)
        {
            if (id != administrador.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(administrador);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AdministradorExists(administrador.Id))
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
            return View(administrador);
        }

        // GET: Administradors/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Administrador == null)
            {
                return NotFound();
            }

            var administrador = await _context.Administrador
                .FirstOrDefaultAsync(m => m.Id == id);
            if (administrador == null)
            {
                return NotFound();
            }

            return View(administrador);
        }

        // POST: Administradors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Administrador == null)
            {
                return Problem("Entity set 'EventosContext.Administrador'  is null.");
            }
            var administrador = await _context.Administrador.FindAsync(id);
            if (administrador != null)
            {
                _context.Administrador.Remove(administrador);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AdministradorExists(int id)
        {
          return (_context.Administrador?.Any(e => e.Id == id)).GetValueOrDefault();
        }

        [HttpPost]
        public ActionResult test()
        {
            return Json("Email controler");
        }

        public bool validarCredencial(String? email, String? pass) {

            if (_context.Administrador.Any(u => u.email_Adm == email))
            {


                if (_context.Administrador.Any(u => u.contraseña_Adm == pass))
                {
                    return true;

                }
                else
                {
                    return false;
                }


            }
            else { 
            return false;
            }



        }

     
    }
}


