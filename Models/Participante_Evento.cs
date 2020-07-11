using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Sistema_de_Capacitaciones_Virtuales.Models
{
    public class Participante_Evento
    {
        public int Id { get; set; }
        public int CodParticipante { get; set; }
        public int CodEvento { get; set; }
        public List<Evento> Eventos {get;set;}
        public List<Participante> Participantes {get;set;}
        public int? Participante_EventoId { get; set; }
    }
}