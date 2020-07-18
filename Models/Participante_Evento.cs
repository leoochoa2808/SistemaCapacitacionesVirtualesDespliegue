using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Sistema_de_Capacitaciones_Virtuales.Models
{
    public class Participante_Evento
    {
        public int Id { get; set; }
        public Evento Evento {get;set;}
        public int? EventoId {get; set;}
        public Participante Participante {get;set;}    
        public int? ParticipanteId { get; set; }    

        public string Comentario {get; set;}
    }
}