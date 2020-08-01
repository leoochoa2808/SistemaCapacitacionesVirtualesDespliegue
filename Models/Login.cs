using System;
using System.ComponentModel.DataAnnotations;

namespace Sistema_de_Capacitaciones_Virtuales.Models {
    public class Login {
        [Required]
        public String user { get; set; }

        [Required]
        public String password { get; set; }

    
    }
}