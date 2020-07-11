using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Sistema_de_Capacitaciones_Virtuales.Models
{
    public class Instructor_Evento
    {
        public int Id { get; set; }        
        public Instructor Instructor {get;set;}
        public int? InstructorId { get; set; }
        public Evento Evento {get;set;}
        public int? EventoId {get;set;}
    }
}