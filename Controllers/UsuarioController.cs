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
    public class UsuarioController : Controller
    {       
        private readonly KleerDbContext _context;
        public UsuarioController (KleerDbContext context) {
            _context = context;
        }   
        public static int idIniciar;
        public IActionResult Login(string message)
        {
            //TempData["idusu"] = Convert.ToInt32(iniciar.Id);
            TempData["Message"] = message;
            return View();
        }
        public static String NombreUsu;
        public static String Rol_usu;
        [HttpPost]
        public IActionResult Login (string user, string pasw) {

            var part = _context.Participantes.FirstOrDefault (P => P.username == user && P.pass == pasw);
            var gest = _context.Gestores.FirstOrDefault(G => G.Gestor_Usuario == user && G.Gestor_Contra == pasw);

            if(part != null && gest is null){
                idIniciar = part.Id;
                Rol_usu = "Participante";
                part.username = user;
                part.pass = pasw;
                NombreUsu = part.PrimerNombre;

                return RedirectToAction("Index","Home");

            }else if(gest !=null && part is null){
                idIniciar = gest.Id;         
                gest.Gestor_Usuario = user;
                gest.Gestor_Contra = pasw;
                NombreUsu = gest.PrimerNombre;
 
                if(gest.Rol == "GerenteEventos"){
                    ViewBag.Rol = "GerenteEventos";
                }else if(gest.Rol == "OrganizadorEventos"){
                    ViewBag.Rol= "OrganizadorEventos";
                }else if(gest.Rol == "Recepcionista"){
                    ViewBag.Rol = "Recepcionista";
                }else{
                    ViewBag.Rol = "Gestor de Finanzas";
                }
                return RedirectToAction("Index","Home");
            }else{
                return Login("Usuario o contraseña incorrectos");
            }
            
        }

        public IActionResult Registrar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Registrar(Participante p)
        {
         if (ModelState.IsValid) {
                _context.Add (p);
                _context.SaveChanges ();
                return RedirectToAction ("Index", "Home");
            } else
        return View (p);
        }
      
    }
}
