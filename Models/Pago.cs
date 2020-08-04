using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace Sistema_de_Capacitaciones_Virtuales.Models {
    public class Pago {

        public int Id { get; set; }
        public int CodPago { get; set; }
        public DateTime? FechaEmision { get; set; }
        public DateTime? FechaVenc { get; set;}
        public string estado_pago { get; set; }
        public Double MontoPago { get; set;}
        public TipoPago TipoPago { get; set; }
        public int? TipoPagoId { get; set; }
        public Participante Participante { get; set;}
        public int? ParticipanteId { get; set;}
        public Evento Evento {get; set;}
        public int? EventoId { get; set;}

    }

}