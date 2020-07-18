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
    public class EventoController : Controller
    {
        private readonly KleerDbContext _context;
        public EventoController(KleerDbContext context) {
            _context = context;
        }
       public IActionResult CrearEvento()
       {
           ViewBag.Categorias = _context.Categorias.ToList();
           ViewBag.Instructores = _context.Instructores.ToList();
           return View();
       }

       [HttpPost]
       public IActionResult CrearEvento(Evento e){
           if (ModelState.IsValid) { 
               e.estado = "Por confirmar";
                _context.Add (e);
                _context.SaveChanges();
                return RedirectToAction("Index","Home");
            } else
                return View (e);
       }
       public IActionResult VisualizarPendientes()
       {           
           return View(_context.Eventos.ToList());
       }
    }
}
