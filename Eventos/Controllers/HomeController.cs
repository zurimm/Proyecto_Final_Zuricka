using Eventos.Data;
using Eventos.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace Eventos.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public String email;
        public String pass;
        private Models.Administrador admin;
        private Controllers.AdministradorsController controlAdmin;
        private Controllers.UsuariosController usuariosControl;
        private Controllers.SoporteController soporteControl;
        public EventosContext _context;

        public HomeController(ILogger<HomeController> logger, EventosContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Validate(String? email, String? pass)
        {
            if (email != null)
            {
                Controllers.AdministradorsController controlAdmin2 = new Controllers.AdministradorsController(_context);
                if (email.Contains("@ola.admin.com"))
                {
                    bool val = controlAdmin2.validarCredencial(email, pass);
                    if (val)
                    {
                        return View("~/Views/Evento/Create.cshtml");
                    }
                    else
                    {
                        return Json("No funciona");
                    }


                }
                else
                {
                    if (email.Contains("@ola.soporte.com"))
                    {
                        Controllers.SoporteController controlSoporte2 = new Controllers.SoporteController(_context);
                        if (email.Contains("@ola.admin.com"))
                        {
                            bool val = controlSoporte2.validarCredencial(email, pass);
                            if (val)
                            {
                                return View("~/Views/Administradors/Create.cshtml");
                            }
                            else
                            {
                                return Json("No funciona");
                            }
                        }
                        else
                        {
                            return Json("No funciona");
                        }
                    }
                    else
                    {
                        Controllers.UsuariosController controlSoporte2 = new Controllers.UsuariosController(_context);
                        if (email.Contains("@ola.admin.com"))
                        {
                            bool val = controlSoporte2.validarCredencial(email, pass);
                            if (val)
                            {
                                return View("~/Views/Home/Index.cshtml");
                            }
                            else
                            {
                                return Json("No funciona");
                            }
                        }
                        else
                        {
                            return Json("No funciona");
                        }

                    }
                }
            }
            else
            {
                return Json("No funciona");
            }

        }



    }
}