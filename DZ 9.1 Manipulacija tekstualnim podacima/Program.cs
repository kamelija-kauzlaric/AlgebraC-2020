using System;
using System.Linq;

namespace DZ_9._1_Manipulacija_tekstualnim_podacima
{
    class Program
    {
        static void Main(string[] args)
        {
            // 9.1.1 Znak u riječi
            Console.Write("Unesite jednu riječ: ");
            string rijec1 = Console.ReadLine().ToLower();
            Console.Write("Unesite jedan znak: ");
            char znak1 = Console.ReadLine().ToLower()[0];

            int ponavljanjeZnaka = rijec1.Count(a => a == znak1);
            Console.WriteLine("Vaš se znak ponavlja " + ponavljanjeZnaka + " puta u navedenoj riječi.");

            Console.WriteLine("");


            // 9.1.2 Riječ u rečenici
            Console.Write("Unesite jednu rečenicu: ");
            string recenica2 = Console.ReadLine().ToLower();
            Console.Write("Unesite jednu riječ: ");
            string rijec2 = Console.ReadLine().ToLower();

            string[] rijeci2 = recenica2.Split();
            int ponavljanjeRijeci = rijeci2.Count(b => b == rijec2);
            if (ponavljanjeRijeci == 1)
            {
                Console.WriteLine("Vaša se riječ ponavlja " + ponavljanjeRijeci + " put u navedenoj rečenici.");
            }
            else
            {
                Console.WriteLine("Vaša se riječ ponavlja " + ponavljanjeRijeci + " puta u navedenoj rečenici.");

            }
            Console.WriteLine("");


            // 9.1.3. Riječi u novi red
            Console.Write("Unesite jednu rečenicu: ");
            string recenica3 = Console.ReadLine();
            string[] rijeci3 = recenica3.Split();
            foreach (var c in rijeci3)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine("");


            // 9.1.4 Brojanje riječi
            Console.Write("Unesite jednu rečenicu: ");
            string recenica4 = Console.ReadLine();
            string[] rijeci4 = recenica4.Split();
            int brojRijeci = rijeci4.Count();
            Console.WriteLine("Broj riječi u navedenoj rečenici je " + brojRijeci + ".");

            Console.WriteLine("");


            // 9.1.5. Koliko puta se ponavlja riječ.
            Console.Write("Unesite jednu rečenicu: ");
            string recenica5 = Console.ReadLine().ToLower();
            string[] sveRijeci5 = recenica5.Split();
            string[] rijeciBezPonavljanja = sveRijeci5.Distinct().ToArray();

            Console.WriteLine("Broj ponavljanja svake riječi u rečenici:");
            foreach (var d in rijeciBezPonavljanja)
            {
                int ponavljanjeRijeci5 = sveRijeci5.Count(e => e == d);
                if (ponavljanjeRijeci5 == 1)
                {
                    Console.WriteLine("Riječ '" + d + "' ponavlja se " + ponavljanjeRijeci5 + " put u navedenoj rečenici.");
                }
                else
                {
                    Console.WriteLine("Riječ '" + d + "' ponavlja se " + ponavljanjeRijeci5 + " puta u navedenoj rečenici.");
                }
            }

            Console.WriteLine("");


            // 9.1.6 Palindrom
            Console.Write("Unesite jednu riječ ili rečenicu: ");
            string recenica6 = Console.ReadLine().ToLower();
            string Reverse(string recenica6)
            {
                char[] recenica6Obrnuto = recenica6.ToCharArray();
                Array.Reverse(recenica6Obrnuto);
                return new string(recenica6Obrnuto);
            }

            if (recenica6 == Reverse(recenica6))
            {
                Console.WriteLine("Imamo palindroma!");
            }
            else
            {
                Console.WriteLine("Nemamo palindroma!");
            }
        }
    }
}
