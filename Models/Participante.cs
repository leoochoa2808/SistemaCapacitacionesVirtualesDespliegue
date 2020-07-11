using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Sistema_de_Capacitaciones_Virtuales.Models
{
    public class Participante
    {
        public int Id { get; set; }
        public string CodParticipante { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public List<Participante_Evento> Participante_Eventos { get; set; }
    }
}