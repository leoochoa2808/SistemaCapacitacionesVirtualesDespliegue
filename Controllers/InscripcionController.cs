using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Net.Mail;
using System.Net;
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

        
        public IActionResult PreInscripcionCursos (int? idE, int? idU) {

            var evento = _context.Eventos.FirstOrDefault(e =>e.Id == idE);
            var usuario = _context.Participantes.FirstOrDefault(p => p.Id == idU);
            var destino_correo = usuario.Correo;
            iduser = usuario.Id;
            if (usuario != null && evento != null) {
                int longitud = 7;
                const string alfabeto =  "0123456789";//"ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                StringBuilder token = new StringBuilder ();
                Random rnd = new Random ();

                for (int i = 0; i < longitud; i++) {
                    int indice = rnd.Next (alfabeto.Length);
                    codigo = token.Append (alfabeto[indice]).ToString ();
                }
                SmtpClient smtp = new SmtpClient("stmp.gmail.com",587);
                smtp.Credentials = new NetworkCredential("joseacb2496@gmail.com","Peluchin24-10");
                smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtp.EnableSsl = true;
                smtp.UseDefaultCredentials = false;

                MailMessage msg = new MailMessage ();

                msg.From = new MailAddress("joseacb2496@gmail.com","Preinscripción curso - ABC");
                msg.To.Add(new MailAddress(destino_correo));
                msg.Subject = "Preinscripción curso - ABC";
                msg.IsBodyHtml = true;
                //ENVIA UNA COPIA DEL CORREO
                msg.Bcc.Add ("joseacb2496@gmail.com");
                //toda estructura html es texto y css
                msg.Body =
                    "<body>" +
                    "<div id='msg'><p>SE HA REALIZADO SU PREINSCRIPCION CON EL SIGUIENTE CÓDIGO DE PAGO: </p><br><strong><h1>" + codigo + "</h1><strong></div><br>" +
                    "</body>";

                smtp.Send (msg);


 /*                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage ();

                msg.To.Add (destino_correo);
                msg.Subject = "Preinscripción curso - ABC";
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                //ENVIA UNA COPIA DEL CORREO
                msg.Bcc.Add ("FlashGameEnterprise@gmail.com");
                //toda estructura html es texto y css
                msg.Body =
                    "<body>" +
                    "<div id='msg'><p>SE HA REALIZADO SU PREINSCRIPCION CON EL SIGUIENTE CÓDIGO DE PAGO: </p><br><strong><h1>" + codigo + "</h1><strong></div><br>" +
                    "</body>";
                msg.BodyEncoding = System.Text.Encoding.UTF8;
                msg.IsBodyHtml = true;
                msg.From = new System.Net.Mail.MailAddress ("FlashGameEnterprise@gmail.com");

                //EL CORREO QUE VA A ENVIAR EL MENSAJE DE PRUEBA
                System.Net.Mail.SmtpClient cliente = new System.Net.Mail.SmtpClient ();
                cliente.Credentials = new System.Net.NetworkCredential ("FlashGameEnterprise@gmail.com", "Queteimporta123");
                //PUERTO QUE USA GMAIL PARA ENVIAR LOS CORREOS
                cliente.Port = 587;
                cliente.EnableSsl = true;
                //EL SERVIDOR QUE USA GMAIL PARA LOS CORREOS
                cliente.Host = "smtp.gmail.com"; //smtp particular o institucional, unicamente que pongas correo. pero se necesitas las credenciales smpt
                //eso se especifica en el web.config(appsettings.json) 

                cliente.Send (msg); */
                var p = new Pago ();
                p.EventoId = evento.Id;
                p.CodPago = Int32.Parse(codigo);
                p.ParticipanteId = usuario.Id;
                p.FechaEmision = DateTime.Now;
                //DateTime fecha = DateTime.Now.AddDays(7);
                p.FechaVenc = DateTime.Now.AddDays(7);
                p.MontoPago = evento.Inversion;
                p.estado_pago = "Pago Pendiente";

                //return View();
                _context.Add(p);
                _context.SaveChanges();
                return RedirectToAction ("ModalPrueba", "Inscripción");
            } else {
                TempData["Message"] = "Correo invalido";
                //return RecuperarC ("Correo invalido"); 
                return NotFound ();
            }

        }

        public IActionResult ModalPrueba()
        {
            return View();
        }
        

    }
}