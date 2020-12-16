using System;
using System.Linq;

namespace Slasticarna
{
    static public class Rerna
    {
        /// <summary>
        /// Ispis sastojaka i izračun ukupne mase kolača nakon pečenja.
        /// </summary>
        public static void Ispeci(ref Kolac kolac)
        {
            bool peceno = true;
            Console.WriteLine("Kolač je pečen! Sastojci su:");
            Console.WriteLine("");
            foreach (Sastojak sastojak in kolac.listaSastojaka)
            {
                Console.WriteLine(sastojak.ImeSastojka + " - " + sastojak.Gramaza + " g");
            }
            Console.WriteLine("");
            decimal masaKolaca = (decimal)kolac.listaSastojaka.Sum(sastojak => sastojak.Gramaza) / 1000;
            Console.Write("Ukupna masa kolača iznosi {0:F2} kg.", masaKolaca);
            Console.WriteLine("");
        }
    }
}