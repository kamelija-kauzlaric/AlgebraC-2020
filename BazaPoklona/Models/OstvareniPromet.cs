using System;
using System.Collections.Generic;

#nullable disable

namespace BazaPoklona.Models
{
    public partial class OstvareniPromet
    {
        public string Naziv { get; set; }
        public int VrstaRobe { get; set; }
        public double UkupnoLovePoVrstiRobe { get; set; }
    }
}
