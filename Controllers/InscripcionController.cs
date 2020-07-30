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
    public class InscripcionController : Controller {
        private readonly KleerDbContext _context;
        public InscripcionController (KleerDbContext context) {
            _context = context;
        }
        //variable codigo es para almacenar el token generado en el método
        public static String codigo;
        //variable iduser graba la sesion del usuario
        public static int iduser;

        [HttpPost]
        public IActionResult RecuperarC (string emailR) {

            var usuario = _context.Participantes.FirstOrDefault (U => U.Correo == emailR);
            iduser = usuario.Id;
            if (usuario != null) {
                int longitud = 7;
                const string alfabeto = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                StringBuilder token = new StringBuilder ();
                Random rnd = new Random ();

                for (int i = 0; i < longitud; i++) {
                    int indice = rnd.Next (alfabeto.Length);
                    codigo = token.Append (alfabeto[indice]).ToString ();
                }

                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage ();

                msg.To.Add (emailR);
                msg.Subject = "Recuperar Contraseña";
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                //ENVIA UNA COPIA DEL CORREO
                msg.Bcc.Add ("joseacb2496@gmail.com");
                //toda estructura html es texto y css
                msg.Body =
                    "<body>" +
                    "<div id='msg'><p>INGRESE EL SIGUIENTE TOKEN</p><br><strong><h1>" + codigo + "</h1><strong></div><br>" +
                    "</body>";
                msg.BodyEncoding = System.Text.Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.From = new System.Net.Mail.MailAddress ("joseacb2496@gmail.com");

                //EL CORREO QUE VA A ENVIAR EL MENSAJE DE PRUEBA
                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient ();
                cliente.Credentials = new System.Net.NetworkCredential ("joseacb2496@gmail.com", "Peluchin24-10");
                //PUERTO QUE USA GMAIL PARA ENVIAR LOS CORREOS
                cliente.Port = 587;
                cliente.EnableSsl = true;
                //EL SERVIDOR QUE USA GMAIL PARA LOS CORREOS
                cliente.Host = "smtp.gmail.com"; //smtp particular o institucional, unicamente que pongas correo. pero se necesitas las credenciales smpt
                //eso se especifica en el web.config(appsettings.json) 

                cliente.Send (msg);
                //return View();
                return RedirectToAction ("Token");
            } else {
                TempData["Message"] = "Correo invalido";
                //return RecuperarC ("Correo invalido"); 
                return View ();
            }

        }

    }
}