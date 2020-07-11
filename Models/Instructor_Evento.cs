using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Sistema_de_Capacitaciones_Virtuales.Models
{
    public class Instructor_Evento
    {
        public int Id { get; set; }
        public int CodInstructor { get; set; }
        public int CodEvento { get; set; }
        public List<Instructor> Instructores {get;set;}
        public List<Evento> Eventos {get;set;}
    }
}