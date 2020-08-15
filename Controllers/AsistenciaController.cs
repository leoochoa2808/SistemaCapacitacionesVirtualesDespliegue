using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Capacitaciones_Virtuales.Models;

namespace Sistema_de_Capacitaciones_Virtuales.Controllers {
    public class AsistenciaController : Controller {
        private readonly KleerDbContext _context;
        public AsistenciaController (KleerDbContext context) {
            _context = context;
        }

        public IActionResult AsistenciaCbo(){
            ViewBag.Eventos = _context.Eventos.ToList ();
            return View();
        }

        [HttpPost]
        public IActionResult AsistenciaPorEvento (int ? idE) {
            if (idE != null) {

                var info = from pa in _context.Participante_Eventos
                join e in _context.Eventos on pa.EventoId equals e.Id
/*                 join p in _context.Pagos on pa.ParticipanteId equals p.Id */
                where pa.EventoId == idE /* && p.estado_pago == "Cancelado" */
                select pa;
                var lista = info.Include (e => e.Evento).Include (u => u.Participante).
                Where (p => p.EventoId == idE).ToList ();

                /*                 var lista = _context.Pagos.Include (e => e.Evento).Include (u => u.Participante)
                                    .Where (p => p.EventoId == idE && p.estado_pago == "Cancelado").ToList (); */
                string nombre_evento = "";
                int contador_participantes = 0;
                foreach (Participante_Evento p in lista) {
                    nombre_evento = p.Evento.NombreEvento;
                    contador_participantes++;
                }
                TempData["nro_participante"] = contador_participantes;
                TempData["nom_evento"] = nombre_evento;
                return View (lista);
            } else {
                return NotFound ();
            }
        }

        public IActionResult MarcarAsistencia(int? idP, int? idE){

            if (idP != null) {
                ViewBag.Message = UsuarioController.MsjUsu;
                ViewBag.Rol = UsuarioController.Rol_usu;

                var part = _context.Participante_Eventos.SingleOrDefault (m => m.ParticipanteId == idP && m.EventoId==idE);

                if(part!=null){
                    part.Comentario = "Asistió";
                }

                _context.Entry (part).State = EntityState.Modified;
                _context.SaveChanges ();

                return RedirectToAction ("AsistenciaPorEvento");

            }
            return View ("AsistenciaPorEvento");

        }

    }
}