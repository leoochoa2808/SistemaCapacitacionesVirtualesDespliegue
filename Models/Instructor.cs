using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Sistema_de_Capacitaciones_Virtuales.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public int CodInstructor { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApelidoMaterno { get; set; }
        public string Correo { get; set; }
        public int celular { get; set; }
        public Instructor_Evento Instructor_Evento { get; set; }
        public int? Instructor_EventoId { get; set; }
    }
}