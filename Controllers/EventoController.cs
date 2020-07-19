using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Sistema_de_Capacitaciones_Virtuales.Models;
using Microsoft.EntityFrameworkCore;
using System.Text;

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

       
       public IActionResult VisualizarPendientes(int? id)
       {
            if (id is null)
            {
                return View(_context.Eventos.ToList()); 
            }
                try
                {
                    var evento = _context.Eventos.SingleOrDefault (m => m.Id == id);
                    evento.estado="Confirmado";
                    _context.Entry (evento).State = EntityState.Modified;
                    _context.SaveChanges ();
                    return View(_context.Eventos.ToList());  
                }
                catch (System.Exception)
                {
                    //Ingresar mensaje de error
                    return View(_context.Eventos.ToList());  
                }
               
           
            
            
       }

       
    }
}
