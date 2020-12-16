using System;
using System.Collections.Generic;

namespace Slasticarna
{
    public class Kolac
    {
        public List<Sastojak> listaSastojaka = new List<Sastojak>();

        public Kolac(string imeKolaca)
        {
            ImeKolaca = imeKolaca;
        }

        public string ImeKolaca { get; set; }

        private static int brojInstanci = 1;

        public Kolac()
        {
            brojInstanci++;
        }

        public static int BrojInstanci
        {
            get { return brojInstanci; }
        }

        /// <summary>
        /// Dodavanje sastojka u listu unutar novog objekta Kolač.
        /// </summary>
        internal void DodajSastojak(string imeSastojka, int gramaza)
        {
            Sastojak sastojak = new Sastojak(imeSastojka, gramaza);
            listaSastojaka.Add(sastojak);
        }
    }
}