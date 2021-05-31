using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace castagnino_rodrigo_lppa_parcial1.Entities.Models
{
    public class IdentityBase
    {
        [Key]
        public int Id { get; set; }
    }
}