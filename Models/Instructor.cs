using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Sistema_de_Capacitaciones_Virtuales.Models
{
    public class Instructor
    {
        public int Id { get; set; }
        public string CodInstructor { get; set; }
        public string PrimerNombre { get; set; }
        public string SegundoNombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public string Celular { get; set; }
        public List<Instructor_Evento> Instructor_Eventos { get; set; }
    }
}