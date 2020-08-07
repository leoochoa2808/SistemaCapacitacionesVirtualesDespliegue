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
        public static int iduser = InscripcionController.iduser;
        public IActionResult RegistroPago () {
            TempData["MontoPago"] = InscripcionController.MontoPagar;
            return View ();
        }

        public IActionResult RegistroPagoCurso (Tarjeta tar) {

            if(ModelState.IsValid){
                var pagos = _context.Pagos.Where (p => p.ParticipanteId == iduser && p.estado_pago == "Pago Pendiente").ToList ();
                var tarjetas = _context.Tarjetas.SingleOrDefault (t => t.NroTarjeta == tar.NroTarjeta && t.CVV==tar.CVV);

                foreach (Pago p in pagos) {
                    if (p.estado_pago == "Pago Pendiente") {
/*                         var tabla_pagos = _context.Pagos.SingleOrDefault (ta => ta.Id == iduser);
                        tabla_pagos.estado_pago = "Cancelado"; */
                        p.estado_pago = "Cancelado";
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