using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Capacitaciones_Virtuales.Models;

namespace Sistema_de_Capacitaciones_Virtuales.Controllers {
    public class HomeController : Controller {
        private readonly KleerDbContext _context;
        public HomeController (KleerDbContext context) {
            _context = context;
        }
        public IActionResult Index () {
            if (UsuarioController.R == 'P') {
                var iniciar = _context.Participantes.FirstOrDefault (U => U.Id == UsuarioController.idIniciar);

                if (iniciar != null) {
                        ViewBag.Message = UsuarioController.MsjUsu;
                        ViewBag.Rol = UsuarioController.Rol_usu;
                }
                return View ();

            } else if (UsuarioController.R == 'G') {
                var iniciar_gest = _context.Gestores.FirstOrDefault (g => g.Id == UsuarioController.idIniciar);

                if (iniciar_gest != null) {
                        ViewBag.Message = UsuarioController.MsjUsu;
                        ViewBag.Rol = UsuarioController.Rol_usu;
                }
                return View ();
            } else {
                ViewBag.Rol = " ";
                ViewBag.Message = "Iniciar Sesión";
                return View ();
            }

        }
        public IActionResult About () {
            ViewData["Message"] = "Your application description page.";

            return View ();
        }

        public IActionResult Contact () {
            ViewData["Message"] = "Your contact page.";

            return View ();
        }

        public IActionResult Privacy () {
            return View ();
        }

        [ResponseCache (Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error () {
            return View (new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}