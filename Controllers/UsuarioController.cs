using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Capacitaciones_Virtuales.Models;
using Microsoft.EntityFrameworkCore;

namespace Sistema_de_Capacitaciones_Virtuales.Controllers
{
    public class UsuarioController : Controller
    {       
        private readonly KleerDbContext _context;
        public UsuarioController (KleerDbContext context) {
            _context = context;
        }   
        public static int idIniciar;
        public IActionResult Login()
        {
            //TempData["idusu"] = Convert.ToInt32(iniciar.Id);
            return View();
        }

        [HttpPost]
        public IActionResult Login (string user, string pasw) {

            var part = _context.Participantes.FirstOrDefault (P => P.username == user && P.pass == pasw);
            var gest = _context.Gestores.FirstOrDefault(G => G.Gestor_Usuario == user && G.Gestor_Contra == pasw);
            
            return RedirectToAction("Login");
            
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Participante p)
        {
         if (ModelState.IsValid) {
                _context.Add (p);
                _context.SaveChanges ();
                return RedirectToAction ("Index", "Home");
            } else
        return View (p);
        }
      
    }
}
