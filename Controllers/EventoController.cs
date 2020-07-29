using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Capacitaciones_Virtuales.Models;

namespace Sistema_de_Capacitaciones_Virtuales.Controllers {
    public class EventoController : Controller {
        private readonly KleerDbContext _context;
        public EventoController (KleerDbContext context) {
            _context = context;
        }
        //variable estatica para guardar el Evento
        /* public static int idevento; */
        public IActionResult CrearEvento () {
            ViewBag.Categorias = _context.Categorias.ToList ();
            ViewBag.Instructores = _context.Instructores.ToList ();
            return View ();
        }

        [HttpPost]
        public IActionResult CrearEvento (Evento e) {
            if (ModelState.IsValid) {
                e.estado = "Pendiente";
                _context.Add (e);
                _context.SaveChanges ();
                return RedirectToAction ("Index", "Home");
            } else
                return View (e);
        }
        #region Visualizar Pendientes

        [HttpGet]
        public IActionResult VisualizarPendientes () {
            TempData["est1"]=1; //es el estado para Confirmar el evento
            TempData["est2"]=2; //es el estado para Rechazar el evento
            return View (_context.Eventos.Include(x=>x.Categoria).Where(x=>x.estado=="Pendiente").ToList());
        }

        public IActionResult CambioEstadoCR (int? id, int? est) {

            if(id != null && est != null){

                var evento = _context.Eventos.SingleOrDefault (m => m.Id == id);

                if (est == 1 && evento.estado == "Pendiente" && evento.estado !="Rechazado") {
                    evento.estado = "Confirmado";
                    evento.FechConfirmacion = DateTime.Now;
                } else if (est == 2 && evento.estado == "Pendiente" && evento.estado != "Confirmado") {
                    evento.estado = "Rechazado";
                }
                _context.Entry (evento).State = EntityState.Modified;
                _context.SaveChanges ();

                return RedirectToAction("VisualizarPendientes");

            }
            return View("VisualizarPendientes");

        }

        public IActionResult DetallePendiente (int? idevento)
        {
            var evento = _context.Eventos.SingleOrDefault (m => m.Id == idevento);
            if(evento==null) return NotFound();
            return View(evento);
        }

        public IActionResult DetalleConfirmado (int? idevento)
        {
            var evento = _context.Eventos.SingleOrDefault (m => m.Id == idevento);
            if(evento==null) return NotFound();
            return View(evento);   
        }
        #endregion
        #region Visualizar Confirmados

        [HttpGet]
        public IActionResult VisualizarConfirmados () {
            TempData["est1"]=1; //es el estado para Cancelar el evento
            return View (_context.Eventos.Include(x=>x.Categoria).Where(x=>x.estado=="Confirmado").ToList());
        }

        public IActionResult CambioEstadoCC (int? id, int? est) {

            if(id != null && est != null){

                var evento = _context.Eventos.SingleOrDefault (m => m.Id == id);

                if (est == 1 && evento.estado == "Confirmado" && evento.estado !="Cancelado") {
                    evento.estado = "Cancelado";
                    evento.FechConfirmacion = DateTime.Now;
                } 
                _context.Entry (evento).State = EntityState.Modified;
                _context.SaveChanges ();

                return RedirectToAction("VisualizarConfirmados");

            }
            return View("VisualizarConfirmados");

        }

        #endregion
        #region Visualizar Todo

        [HttpGet]
        public IActionResult VisualizarTodo () {
            
            return View (_context.Eventos.Include(x=>x.Categoria).ToList());
        }
        #endregion



       
    }
}