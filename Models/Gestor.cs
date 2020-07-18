using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace Sistema_de_Capacitaciones_Virtuales.Models
{
    public class Gestor{
        public int Id {get; set;}
        public int CodGestor{get;set;}
        public string PrimerNombre {get; set;}
        public string SegundoNombre {get; set;}
        public string ApellidoPaterno {get; set;}
        public string ApellidoMaterno {get; set;}
        public string Correo {get; set;}
        public string Celular {get; set;}
        public string Gestor_Usuario {get; set;}
        public string Gestor_Contra {get; set;}
        public string Rol {get; set;}
        public List<Gestor_Evento> Gestor_Eventos {get; set;}        

    }
}