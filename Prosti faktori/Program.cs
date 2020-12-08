using System;
using System.Collections.Generic;
using System.Linq;

namespace Prosti_faktori
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6.2.5. Prosti faktori

            Console.WriteLine("Ovaj program zasad još ne ispisuje rastav prirodnih brojeva na proste faktore. Ali svejedno unesite željeni broj, zašto ne:");

            List<int> listaProstihFaktora = new List<int>();
            int djeljenik = int.Parse(Console.ReadLine());

            //while (djeljenik != 1)
            //{
            for (int i = 2; i < djeljenik; i++)
            {
                if (djeljenik % i == 0)
                {
                    listaProstihFaktora.Add(i);
                }
                djeljenik = djeljenik /= i;
            }
            //}

            Console.WriteLine("");
            if (!listaProstihFaktora.Any())
            {
                Console.WriteLine("Unijeli ste prosti broj! Ne može tako.");
            }
            else
            {
                Console.WriteLine("Faktori su:");
                listaProstihFaktora.Sort();
                foreach (int a in listaProstihFaktora)
                {
                    Console.Write(a + " ");
                }
            }

            Console.WriteLine("");
        }
    }
}

