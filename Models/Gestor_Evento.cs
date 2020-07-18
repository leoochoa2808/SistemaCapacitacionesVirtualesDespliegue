using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Sistema_de_Capacitaciones_Virtuales.Models
{
    public class Gestor_Evento{
        public int Id {get; set;}
        public Gestor Gestor {get; set;}
        public int? GestorId {get; set;}
        public Evento Evento {get; set;}
        public int? EventoId {get; set;}
        public string Motivo {get; set;}

    }
}