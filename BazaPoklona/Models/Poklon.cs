using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace BazaPoklona.Models
{
    public partial class Poklon
    {
        public int IdPoklon { get; set; }

        [Required]
        [StringLength(40)] // odnosi se na ono ispod - naziv
        public string Naziv { get; set; }

        [Required]
        public int VrstaRobe { get; set; }

        [Required]
        [Display(Name = "Poklon kupljen")]
        public bool Kupljen { get; set; }

        [Range(0, 999.99)]
        public double? Cijena { get; set; }
        public double? Iznos { get; set; }
        public virtual VrstaRobe VrstaRobeNavigation { get; set; }
    }
}
