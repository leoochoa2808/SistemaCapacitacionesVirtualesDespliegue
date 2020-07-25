using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Capacitaciones_Virtuales.Models {
    public class Usuario {

        public int Id { get; set; }

        [Required]
        public String nombre { get; set; }

        [Required]
        public String apellido { get; set; }

        [Required]
        public String email { get; set; }

        [Required]
        public String username { get; set; }

        [Required]
        public String password { get; set; }

        [DataType (DataType.Date)]
        [Required]
        public DateTime fecha { get; set; }

        [Required]
        public String pais { get; set; }
        public String rol { get; set; }
    }
}