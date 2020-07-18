using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Sistema_de_Capacitaciones_Virtuales.Models
{//comentario 
    public class Evento
    {
        public int Id { get; set; }
        public Categoria Categoria { get; set; }
        public int? CategoriaId { get; set; }
        public string NombreEvento { get; set; }
        //[DataType(DataType.Date)]
        public DateTime? FechaInicio { get; set; }
        //[DataType(DataType.Date)]
        public DateTime? FechaFin {get; set;}
        //[DataType(DataType.Date)]
        public DateTime? HoraInicio { get; set; }
        //[DataType(DataType.Date)]
        public DateTime? HoraFin { get; set; }
        public int StockParticipantes { get; set; }
        public double Inversion { get; set; }
        public string Descripcion { get; set; }
        public string estado { get; set; }
        //[DataType(DataType.Date)]
        public DateTime? FechConfirmacion { get; set; }
        public string Frecuencia { get; set; }
        public List<Instructor_Evento> Instructor_Eventos { get; set; }
        public List<Participante_Evento> Participante_Eventos { get; set; }       

       


    }
}