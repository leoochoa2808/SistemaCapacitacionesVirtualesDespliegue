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
        //variable estatica para guardar el Evento
        /* public static int idevento; */
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
       [HttpPost]
       public IActionResult VisualizarPendientes()
       {           
           return View(_context.Eventos.ToList());
       }
        
        public IActionResult VisualizarPendientes(int? id){

            if(id is null){
                return View(_context.Eventos.ToList());
            }else{
                var evento = _context.Eventos.SingleOrDefault (m => m.Id == id);
                evento.estado="Confirmado";
                evento.FechConfirmacion= DateTime.Now;
                _context.Entry (evento).State = EntityState.Modified;
                _context.SaveChanges ();
                return View(_context.Eventos.ToList());
            }

            /* try
            {
                var evento = _context.Eventos.SingleOrDefault (j => j.Id == id);
            if (evento == null) {
                return NotFound ();
            }
            _context.Remove (evento);
            _context.SaveChanges ();
            return View();
            }
            catch (System.Exception)
            {
                
                throw;
            } */
            
        }
       
    }
}
