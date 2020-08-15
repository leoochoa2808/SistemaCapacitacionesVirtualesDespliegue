using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Sistema_de_Capacitaciones_Virtuales.Models;

namespace Sistema_de_Capacitaciones_Virtuales.Controllers {
    public class UsuarioController : Controller {
        private readonly KleerDbContext _context;
        public UsuarioController (KleerDbContext context) {
            _context = context;
        }
        public static int idIniciar;
        public IActionResult Login (string message) {
            //TempData["idusu"] = Convert.ToInt32(iniciar.Id);
            TempData["Message"] = message;
            return View ();
        }
        public static String MsjUsu;
        public static String Rol_usu;
        public static char R;
        [HttpPost]
        public IActionResult Login (string user, string pasw) {

            var gest = _context.Gestores.FirstOrDefault (G => G.Gestor_Usuario == user && G.Gestor_Contra == pasw);
            var part = _context.Participantes.FirstOrDefault (P => P.username == user && P.pass == pasw);

            if (gest != null || part != null) {
                if (gest is null) {
                    idIniciar = part.Id;
                    Rol_usu = "Participante";
                    MsjUsu = "Hola, " + part.PrimerNombre;
                    R = 'P';
                    return RedirectToAction ("Index", "Home");
                } else {
                    idIniciar = gest.Id;
                    MsjUsu = "Gestor, "+gest.PrimerNombre;
                    R = 'G';
                    if (gest.Rol == "GerenteEventos") {
                        Rol_usu = "GerenteEventos";

                    } else if (gest.Rol == "OrganizadorEventos") {
                        Rol_usu = "OrganizadorEventos";
                    } else if (gest.Rol == "Recepcionista") {
                        Rol_usu = "Recepcionista";
                    } else {
                        Rol_usu = "GestorFinanzas";
                    }
                    return RedirectToAction ("Index", "Home");
                }

            } else {
                return Login ("Usuario o contraseña incorrectos");
            }

        }

        public IActionResult Registrar () {
            return View ();
        }

        [HttpPost]
        public IActionResult Registrar (Participante p) {
            if (ModelState.IsValid) {
                _context.Add (p);
                _context.SaveChanges ();
                return RedirectToAction ("Index", "Home");
            } else
                return View (p);
        }

    }
}