using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Capacitaciones_Virtuales.Models;

namespace Sistema_de_Capacitaciones_Virtuales.Controllers {
    public class CursoController : Controller {

        private readonly KleerDbContext _context;
        public CursoController (KleerDbContext context) {
            _context = context;
        }
<<<<<<< HEAD
        public IActionResult Cursos()
        {
            TempData["idusu"] = 13;
            return View(_context.Eventos.Include (x => x.Categoria).Include (x => x.Instructor).ToList());
=======
        public IActionResult Cursos () {
            ViewBag.Message = UsuarioController.MsjUsu;
            ViewBag.Rol = UsuarioController.Rol_usu;
            return View (_context.Eventos.Include (x => x.Categoria).Include (x => x.Instructor).ToList ());
>>>>>>> rama_jose
        }

        public IActionResult CursoDetalle (int? idE) {
            ViewBag.Message = UsuarioController.MsjUsu;
            ViewBag.Rol = UsuarioController.Rol_usu;
            TempData["idusu"] = UsuarioController.idIniciar;
            TempData["ide"] = idE;
            var evento = _context.Eventos.SingleOrDefault (m => m.Id == idE);
            if (evento == null) return NotFound ();
            return View (evento);

        }

    }
}