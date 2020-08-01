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
        

        public IActionResult Cursos()
        {
            return View();
        }

        public IActionResult DCurso1()
        {
            return View();
        }



    }
}