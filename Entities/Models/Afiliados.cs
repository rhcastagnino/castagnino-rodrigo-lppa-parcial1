using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace castagnino_rodrigo_lppa_parcial1.Entities.Models
{
    public class Afiliados : IdentityBase
    {
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string Apellido { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Telefono { get; set; }

        [Required]
        [MaxLength(100)]
        public string Cuit { get; set; }
    }
}