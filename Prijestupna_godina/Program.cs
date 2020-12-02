using System;
using System.Linq;

namespace Prijestupna_godina
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadatci 5.2.8. i 5.3.6.

            Console.WriteLine("PRIJESTUPNE GODINE");
            Console.WriteLine("");

            Console.WriteLine("Sve prijestupne godine od 1900. do 2007. su: ");

            for (int godina = 1900; godina <= 2007; godina++)
            {
                if (godina % 4 == 0 && godina % 100 != 0)
                {
                    Console.WriteLine(godina);
                }
                else if (godina % 400 == 0)
                {
                    Console.WriteLine(godina);
                }
            }

            Console.WriteLine("");

            Console.Write("Unesi godinu da vidiš je li prijestupna: ");
            int korisnikova_godina = int.Parse(Console.ReadLine());

            if (korisnikova_godina % 4 == 0 && korisnikova_godina % 100 != 0)
            {
                Console.WriteLine("Godina je prijestupna!");
            }
            else if (korisnikova_godina % 400 == 0)
            {
                Console.WriteLine("Godina je prijestupna!");
            }
            else
            {
                Console.WriteLine("Godina NIJE prijestupna!");
            }
        }
    }
}
