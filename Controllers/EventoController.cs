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
            ViewBag.Message = UsuarioController.MsjUsu;
            ViewBag.Rol = UsuarioController.Rol_usu;
            ViewBag.Categorias = _context.Categorias.ToList ();
            ViewBag.Instructores = _context.Instructores.ToList ();
            return View ();
        }

        [HttpPost]
        public IActionResult CrearEvento (Evento e) {
            ViewBag.Message = UsuarioController.MsjUsu;
            ViewBag.Rol = UsuarioController.Rol_usu;
            if (ModelState.IsValid) {
                if (e.FechaInicio > DateTime.Now && e.FechaInicio < e.FechaFin) {
                    e.estado = "Pendiente";
                    _context.Add (e);
                    _context.SaveChanges ();
                }

                return RedirectToAction ("Index", "Home");
            } else
                return View (e);
        }
        #region Visualizar Pendientes

        [HttpGet]
        public IActionResult VisualizarPendientes () {
            ViewBag.Message = UsuarioController.MsjUsu;
            ViewBag.Rol = UsuarioController.Rol_usu;
            TempData["est1"] = 1; //es el estado para Confirmar el evento
            TempData["est2"] = 2; //es el estado para Rechazar el evento
            return View (_context.Eventos.Include (x => x.Categoria).Where (x => x.estado == "Pendiente").ToList ());
        }

        public IActionResult CambioEstadoCR (int? id, int? est) {

            if (id != null && est != null) {
                ViewBag.Message = UsuarioController.MsjUsu;
                ViewBag.Rol = UsuarioController.Rol_usu;

                var evento = _context.Eventos.SingleOrDefault (m => m.Id == id);

                if (est == 1 && evento.estado == "Pendiente" && evento.estado != "Rechazado") {
                    evento.estado = "Confirmado";
                    evento.FechConfirmacion = DateTime.Now;
                } else if (est == 2 && evento.estado == "Pendiente" && evento.estado != "Confirmado") {
                    evento.estado = "Rechazado";
                }
                _context.Entry (evento).State = EntityState.Modified;
                _context.SaveChanges ();

                return RedirectToAction ("VisualizarPendientes");

            }
            return View ("VisualizarPendientes");

        }

        public IActionResult DetallePendiente (int? idevento) {
            ViewBag.Message = UsuarioController.MsjUsu;
            ViewBag.Rol = UsuarioController.Rol_usu;
            var evento = _context.Eventos.SingleOrDefault (m => m.Id == idevento);
            if (evento == null) return NotFound ();
            return View (evento);
        }

        public static int idE;
        public IActionResult DetalleConfirmado (int? id) {
            ViewBag.Message = UsuarioController.MsjUsu;
            ViewBag.Rol = UsuarioController.Rol_usu;

            ViewBag.Categorias = _context.Categorias.ToList ();
            ViewBag.Instructores = _context.Instructores.ToList ();
            var evento = _context.Eventos.Include (x => x.Categoria).Include (x => x.Instructor).SingleOrDefault (m => m.Id == id);
            idE = evento.Id;
            if (evento == null) return NotFound ();
            return View (evento);
        }

        [HttpPost]
        public IActionResult ModificarEvento (Evento e) {
            ViewBag.Message = UsuarioController.MsjUsu;
            ViewBag.Rol = UsuarioController.Rol_usu;
            var evento = _context.Eventos.Include (x => x.Categoria).Include (x => x.Instructor).SingleOrDefault (m => m.Id == idE);
            if (ModelState.IsValid) {
                evento.NombreEvento = e.NombreEvento;
                evento.CategoriaId = e.CategoriaId;
                evento.Frecuencia = e.Frecuencia;
                evento.FechaInicio = e.FechaInicio;
                evento.FechaFin = e.FechaFin;
                evento.Inversion = e.Inversion;
                evento.HoraInicio = e.HoraInicio;
                evento.HoraFin = e.HoraFin;
                evento.StockParticipantes = e.StockParticipantes;
                evento.InstructorId = e.InstructorId;
                evento.Descripcion = e.Descripcion;
                _context.Entry (evento).State = EntityState.Modified;
                _context.SaveChanges ();
                return RedirectToAction ("VisualizarConfirmados");
            } else {
                TempData["Message"] = "Datos incompletos";
                return View ();
            }
        }
        #endregion
        #region Visualizar Confirmados

        [HttpGet]
        public IActionResult VisualizarConfirmados () {

            ViewBag.Message = UsuarioController.MsjUsu;
            ViewBag.Rol = UsuarioController.Rol_usu;
            TempData["est1"] = 1; //es el estado para Cancelar el eventoNADA

            return View (_context.Eventos.Include (x => x.Categoria).Where (x => x.estado == "Confirmado").ToList ());
        }

        public IActionResult CambioEstadoCC (int? id, int? est) {

            if (id != null && est != null) {

                ViewBag.Message = UsuarioController.MsjUsu;
                ViewBag.Rol = UsuarioController.Rol_usu;

                var evento = _context.Eventos.SingleOrDefault (m => m.Id == id);

                if (est == 1 && evento.estado == "Confirmado" && evento.estado != "Cancelado") {
                    evento.estado = "Cancelado";
                    evento.FechConfirmacion = DateTime.Now;
                }
                _context.Entry (evento).State = EntityState.Modified;
                _context.SaveChanges ();

                return RedirectToAction ("VisualizarConfirmados");

            }
            return View ("VisualizarConfirmados");

        }

        #endregion        

        #region Visualizar Todo
        public IActionResult VisualizarTodo () => View (_context.Eventos.Include (x => x.Categoria).ToList ());
        #endregion

    }
}