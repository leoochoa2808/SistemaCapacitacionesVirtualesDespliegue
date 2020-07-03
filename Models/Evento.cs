using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Sistema_de_Capacitaciones_Virtuales.Models
{
    public class Evento
    {
        public int Id {get;set;}
        public String NEvento {get;set;}  
        public String Categoria {get; set;} 

        [DataType(DataType.Date)]
        public DateTime FInicio {get; set;}

        [DataType(DataType.Date)]
        public DateTime FFin {get; set;}
        public String Horario {get;set;} 

        [DataType(DataType.Time)]
        public DateTime HInicio {get;set;} 
        
        [DataType(DataType.Time)]
        public DateTime HFin {get;set;} 
        public String Instructor {get; set;}
        public int Stock {get; set;}
        public decimal Inversion {get; set;}
        public string Descripcion {get; set;}



    }
}