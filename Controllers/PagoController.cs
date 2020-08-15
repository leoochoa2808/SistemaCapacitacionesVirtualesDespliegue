using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
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
        public static int iduser = InscripcionController.iduser;
        public static double monto_pagar_boleta = InscripcionController.MontoPagar;
        public IActionResult RegistroPago () {
            TempData["MontoPago"] = InscripcionController.MontoPagar;
            return View ();
        }
        public static int codigo_boleta;
        public IActionResult RegistroPagoCurso (Tarjeta tar) {

            if (ModelState.IsValid) {

                var pagos = _context.Pagos.Where (p => p.ParticipanteId == iduser && p.estado_pago == "Pago Pendiente").ToList ();
                var tarjetas = _context.Tarjetas.SingleOrDefault (t => t.NroTarjeta == tar.NroTarjeta && t.CVV == tar.CVV);
                var boleta = new Boleta ();
                //se genera el codigo para la tabla boleta
                int longitud = 8;
                const string alfabeto = "0123456789"; //"ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
                StringBuilder token = new StringBuilder ();
                Random rnd = new Random ();

                for (int i = 0; i < longitud; i++) {
                    int indice = rnd.Next (alfabeto.Length);
                    codigo_boleta = Int32.Parse (token.Append (alfabeto[indice]).ToString ());
                }
                boleta.cod_boleta = codigo_boleta;
                boleta.fec_emi = DateTime.Now;
                /*                 boleta.cursos_detalle = "CURSO1,CURSO2,CURSO3,"; */
                //funcion split para separar los cursos usando una coma CUACKIZI WAS HERE 
                /* foreach (var word in words) {
                    System.Console.WriteLine ($"<{word}>");
                } */
                boleta.cursos_detalle = "";
                boleta.montocursos_detalle = "";
                boleta.monto_pagado = monto_pagar_boleta;
                //recorremos el listado de pagoss
                foreach (Pago p in pagos) {
                    var eventos = _context.Eventos.SingleOrDefault (e => e.Id == p.EventoId);
                    if (eventos != null) {
                        /* boleta.cursos_detalle = boleta.cursos_detalle + p.Evento.NombreEvento + ","; */
                        boleta.cursos_detalle = boleta.cursos_detalle + eventos.NombreEvento + ",";
                        boleta.montocursos_detalle = boleta.montocursos_detalle + eventos.Inversion + ",";
                    }
                }
                boleta.cursos_detalle = boleta.cursos_detalle.Substring (0, boleta.cursos_detalle.Length - 1);
                boleta.montocursos_detalle = boleta.montocursos_detalle.Substring (0, boleta.montocursos_detalle.Length - 1);
                /* Console.WriteLine (substring); */
                _context.Add (boleta);
                _context.SaveChanges ();
                foreach (Pago pa in pagos) {

                    if (pa.estado_pago == "Pago Pendiente") {
                        /* DateTime.Today.ToString("dd-MM-yyyy"); */
                        pa.estado_pago = "Cancelado";
                        pa.BoletaId = boleta.Id;
                        _context.Entry (pa).State = EntityState.Modified;
                        _context.SaveChanges ();
                    }
                }

                return RedirectToAction ("CursosInscritos", "Inscripcion");
            } else {
                return RedirectToAction ("CursosInscritos", "Inscripcion");
            }

        }

        public IActionResult PagosPendientesPorEventoCbo () {
            ViewBag.Eventos = _context.Eventos.ToList ();
            return View ();
        }
        /*         public static int contador_participantes; */
        [HttpPost]
        public IActionResult ListaPagosPendientesPorEvento (int? idE) {

            if (idE != null) {
                var lista = _context.Pagos.Include (e => e.Evento).Include (u => u.Participante)
                    .Where (p => p.EventoId == idE && p.estado_pago == "Pago Pendiente").ToList ();
                string nombre_evento = "";
                int contador_participantes = 0;
                foreach (Pago p in lista) {
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

        public IActionResult PagosRealizadosPorEventoCbo () {
            ViewBag.Eventos = _context.Eventos.ToList ();
            return View ();
        }

        [HttpPost]
        public IActionResult ListaPagosRealizadosPorEvento (int? idE) {

            if (idE != null) {
                var lista = _context.Pagos.Include (e => e.Evento).Include (u => u.Participante)
                    .Where (p => p.EventoId == idE && p.estado_pago == "Cancelado").ToList ();
                string nombre_evento = "";
                int contador_participantes = 0;
                foreach (Pago p in lista) {
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

        public IActionResult BoletasPorEventoCbo () {
            ViewBag.Eventos = _context.Eventos.ToList ();
            return View ();
        }

        [HttpPost]
        public IActionResult BoletasPorEvento (int ? idE) {
            if (idE != null) {

                var info = from pa in _context.Pagos
                join b in _context.Boletas on pa.BoletaId equals b.Id
                select pa;
                var lista = info.Include (e => e.Evento).Include (u => u.Participante).Include (b => b.Boleta).
                Where (p => p.EventoId == idE).ToList ();

                /*                 var lista = _context.Pagos.Include (e => e.Evento).Include (u => u.Participante)
                                    .Where (p => p.EventoId == idE && p.estado_pago == "Cancelado").ToList (); */
                string nombre_evento = "";
                int contador_participantes = 0;
                foreach (Pago p in lista) {
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

        public IActionResult BoletaDetalle (int? idU) {
            var datos = (from b in _context.Boletas
            join pa in _context.Pagos
            on b.Id equals pa.BoletaId where pa.ParticipanteId == idU select b).Distinct();
            /* var datos = from pa in _context.Pagos
            join b in _context.Boletas on pa.BoletaId equals b.Id
            where pa.ParticipanteId == idU select pa; */

            var lista = datos.ToList();
            /* var lista = datos.Distinct ().ToList (); */

            string[] c_d;
            string[] mc_d;

            foreach (Boleta b in lista) {
                c_d = b.cursos_detalle.Split (',');
                mc_d = b.montocursos_detalle.Split (',');
                ViewBag.cd = c_d;
                ViewBag.mc = mc_d;
            }

            return View (lista);

        }

    }
}