﻿using System;
using System.Linq;

namespace Slasticarna
{
    static public class Rerna
    {
        public static void Ispeci(ref Kolac kolac)
        {
            kolac.Pecenost = true;
            brojIspecenihKolaca++;
        }

        private static int brojIspecenihKolaca;
        public static int BrojIspecenihKolaca
        {
            get { return brojIspecenihKolaca; }
        }
    }
}
