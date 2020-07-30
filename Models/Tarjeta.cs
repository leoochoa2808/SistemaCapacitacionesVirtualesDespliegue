using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Sistema_de_Capacitaciones_Virtuales.Models {
    public class Tarjeta {

        public int Id { get; set;}
        [StringLength(16)]
        public char NroTarjeta { get; set;}

        public DateTime? FechaVenc_Tarjeta { get; set;}
        [StringLength(3)]
        public char CVV {get; set;}
        public string Direccion { get; set;}
        public int Cel_Contacto { get; set;}
        public Double Saldo_Tarjeta { get; set;}

    }
}