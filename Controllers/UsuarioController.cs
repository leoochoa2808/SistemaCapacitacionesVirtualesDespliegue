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
        public IActionResult Login()
        {
            return View();
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
