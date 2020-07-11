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

        //metodo para listar las listas para el combobox. El nombre del método tenia el mismo nombre que la vista.
       public IActionResult Evento () {
           ViewBag.Categorias = _context.Categorias.ToList();
           ViewBag.Instructores = _context.Instructores.ToList();
           return View("Evento");
       }

       [HttpPost]
       public IActionResult Evento (Evento e){
           ViewBag.Eventos = _context.Eventos.ToList();
           if (ModelState.IsValid) {
                _context.Add (e);
                _context.SaveChanges ();
                return View();
            } else
                return View ();

       }
        
        // public IActionResult CrearEvento (Evento e) {
                       
        // }
    }
}