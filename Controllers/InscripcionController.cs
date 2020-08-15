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
        public static int iduser = UsuarioController.idIniciar;
    
        public IActionResult PreInscribir (int? idE, int? idU) {

            var evento = _context.Eventos.FirstOrDefault (e => e.Id == idE);
            var usuario = _context.Participantes.FirstOrDefault (p => p.Id == idU);
            var destino_correo = usuario.Correo;
            iduser = usuario.Id;
            /* idevento = evento.Id; */
            if (usuario != null && evento != null) {
                int longitud = 7;
                const string alfabeto = "0123456789"; //"ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"
                StringBuilder token = new StringBuilder ();
                Random rnd = new Random ();

                for (int i = 0; i < longitud; i++) {
                    int indice = rnd.Next (alfabeto.Length);
                    codigo = token.Append (alfabeto[indice]).ToString ();
                }

                System.Net.Mail.MailMessage msg = new System.Net.Mail.MailMessage ();

                msg.To.Add (destino_correo);
                msg.Subject = "Pre Inscripción Curso - ABC";
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                //ENVIA UNA COPIA DEL CORREO
                msg.Bcc.Add ("joseacb2496@gmail.com");
                //toda estructura html es texto y css
                msg.Body =
                    "<body>" +
                    "<div id='msg'><p>SE HA REALIZADO SU PREINSCRIPCION CON EL SIGUIENTE CÓDIGO DE PAGO: </p><br><strong><h1>" + codigo + "</h1><strong></div><br>" +
                    "<div>Monto a Pagar por el Curso de:</div>" +evento.NombreEvento +"  "+ evento.Inversion +
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

                var pago = new Pago ();
                pago.EventoId = evento.Id;
                pago.CodPago = Int32.Parse (codigo);
                pago.ParticipanteId = usuario.Id;
                pago.FechaEmision = DateTime.Now;
                //DateTime fecha = DateTime.Now.AddDays(7);
                pago.FechaVenc = DateTime.Now.AddDays (7);
                pago.MontoPago = evento.Inversion;
                pago.estado_pago = "Pago Pendiente";
                pago.TipoPagoId = 1;
                //return View();
                _context.Add (pago);
                _context.SaveChanges ();
                return RedirectToAction ("PreInscripcionCursos");
            } else {
                TempData["Message"] = "Correo invalido";
                //return RecuperarC ("Correo invalido"); 
                return NotFound ();
            }
        }
        public static double MontoPagar;
        [HttpGet]
        public IActionResult PreInscripcionCursos () {

            var usuario = _context.Participantes.FirstOrDefault (u => u.Id == iduser);
            var lista = _context.Pagos.Where (u => u.ParticipanteId == usuario.Id && u.estado_pago == "Pago Pendiente").Include (e => e.Evento).Include (t => t.TipoPago).Include (e => e.Evento.Categoria).ToList ();
            double monto_estimado = 0;
            foreach (Pago pago in lista) {
                monto_estimado = monto_estimado + pago.Evento.Inversion;
            }
            TempData["Monto"] = monto_estimado;
            MontoPagar = monto_estimado;
            return View (lista);

        }

        public IActionResult CursosInscritos () {
            TempData["idusu"] = iduser;
            var usuario = _context.Participantes.SingleOrDefault (u => u.Id == iduser);
            var lista = _context.Pagos.Where (u => u.ParticipanteId == usuario.Id && u.estado_pago == "Cancelado").Include (e => e.Evento).Include (t => t.TipoPago).Include (e => e.Evento.Categoria).ToList ();
            return View (lista);
        }

    }
}