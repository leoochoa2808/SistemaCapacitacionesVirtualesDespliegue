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
        public IActionResult RegistroPago () {
            TempData["MontoPago"] = InscripcionController.MontoPagar;
            return View ();
        }
        public static int codigo_boleta;
        public IActionResult RegistroPagoCurso (Tarjeta tar) {

            if(ModelState.IsValid){
                var pagos = _context.Pagos.Where (p => p.ParticipanteId == iduser && p.estado_pago == "Pago Pendiente").ToList ();
                var tarjetas = _context.Tarjetas.SingleOrDefault (t => t.NroTarjeta == tar.NroTarjeta && t.CVV==tar.CVV);
                var boleta = new Boleta();
                //se genera el codigo para la tabla boleta
                int longitud = 8;
                const string alfabeto = "0123456789"; //"ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
                StringBuilder token = new StringBuilder ();
                Random rnd = new Random ();

                for (int i = 0; i < longitud; i++) {
                    int indice = rnd.Next (alfabeto.Length);
                    codigo_boleta = Int32.Parse(token.Append (alfabeto[indice]).ToString ()) ;
                }

                //recorremos el listado de pagoss
                foreach (Pago p in pagos) {
                    if (p.estado_pago == "Pago Pendiente") {
                        /* DateTime.Today.ToString("dd-MM-yyyy"); */
                        boleta.cod_boleta = codigo_boleta;
                        boleta.fec_emi = DateTime.Now;
                        _context.Add(boleta);
                        _context.SaveChanges ();
                        p.estado_pago = "Cancelado";
                        p.BoletaId = boleta.Id;
                        _context.Entry (p).State = EntityState.Modified;
                        _context.SaveChanges ();
                    }
                }

                return RedirectToAction ("CursosInscritos", "Inscripcion"); 
            }else{
                return RedirectToAction ("CursosInscritos", "Inscripcion"); 
            }   

        }

    }
}