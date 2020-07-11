using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
namespace Sistema_de_Capacitaciones_Virtuales.Models
{
    public class Categoria
    {
        public int Id { get; set; }
        public string NombreCategoria { get; set; }
        public List<Evento> Eventos { get; set; }
    }
}