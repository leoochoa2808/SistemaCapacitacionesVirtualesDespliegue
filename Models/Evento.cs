using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Sistema_de_Capacitaciones_Virtuales.Models
{
    public class Evento
    {
        public int Id { get; set; }
        public Categoria Categoria { get; set; }
        public int? CategoriaId { get; set; }
        public string NombreEvento { get; set; }
        public DateTime? FechaInicio { get; set; }
        public DateTime? FechaFin {get; set;}
        public DateTime? HoraInicio { get; set; }
        public DateTime? HoraFin { get; set; }
        public int StockParticipantes { get; set; }
        public double Inversion { get; set; }
        public string Descripcion { get; set; }
        public string estado { get; set; }
        public DateTime? FechConfirmacion { get; set; }
        public string Frecuencia { get; set; }
        public Instructor_Evento Instructor_Evento { get; set; }
        public int? Instructor_EventoId { get; set; }
        public Participante_Evento Participante_Evento { get; set; }
        public int? Participante_EventoId { get; set; }
        

        // public int Id {get;set;}
        // public String NEvento {get;set;}  
        // public String Categoria {get; set;} 

        // [DataType(DataType.Date)]
        // public DateTime FInicio {get; set;}

        // [DataType(DataType.Date)]
        // public DateTime FFin {get; set;}
        // public String Horario {get;set;} 

        // [DataType(DataType.Time)]
        // public DateTime HInicio {get;set;} 
        
        // [DataType(DataType.Time)]
        // public DateTime HFin {get;set;} 
        // public String Instructor {get; set;}
        // public int Stock {get; set;}
        // public decimal Inversion {get; set;}
        // public string Descripcion {get; set;}



    }
}