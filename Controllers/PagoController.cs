using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Capacitaciones_Virtuales.Models;

namespace Sistema_de_Capacitaciones_Virtuales.Controllers {
    public class PagoController : Controller {

        private readonly KleerDbContext _context;
        public PagoController (KleerDbContext context) {
            _context = context;
        }

        public IActionResult RegistroPago(){
            return View();
        }
    }
}