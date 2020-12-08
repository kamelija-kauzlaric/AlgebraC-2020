using System;

namespace Prijestupna_godina
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadatak 5.2.8.

            Console.WriteLine("PRIJESTUPNE GODINE");
            Console.WriteLine("");
            Console.WriteLine("Sve prijestupne godine od 1900. do 2007. su: ");

            for (int godina = 1900; godina <= 2007; godina++)
            {
                if (godina % 4 == 0 && godina % 100 != 0)
                {
                    Console.Write(godina + " ");
                }
                else if (godina % 400 == 0)
                {
                    Console.Write(godina + " ");
                }
            }

            Console.WriteLine("");
            Console.WriteLine("");

            // Zadatak 5.3.6.

            Console.WriteLine("Pritisni ENTER za provjeru godine koje želiš ili unesi 'kraj' za izlaz.");

            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "kraj")
                {
                    break;
                }
                Console.WriteLine("Unesi novu godinu.");
                int korisnikova_godina = int.Parse(Console.ReadLine());
                if (korisnikova_godina % 4 == 0 && korisnikova_godina % 100 != 0)
                {
                    Console.WriteLine("Godina je prijestupna! Ponovi ENTER ili upiši 'kraj'.");
                    Console.WriteLine("");
                }
                else if (korisnikova_godina % 400 == 0)
                {
                    Console.WriteLine("Godina je prijestupna! Ponovi ENTER ili upiši 'kraj'.");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Godina NIJE prijestupna! Ponovi ENTER ili upiši 'kraj'.");
                    Console.WriteLine("");
                }
            }
        }
    }
}
