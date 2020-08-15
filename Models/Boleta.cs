using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Capacitaciones_Virtuales.Models {
    public class Boleta {
        public int Id { get; set; }
        public int cod_boleta { get; set; }
        public DateTime fec_emi { get; set; }
        public string cursos_detalle { get; set;}
        public string montocursos_detalle { get; set;}
        public double monto_pagado { get; set;}
    }
}