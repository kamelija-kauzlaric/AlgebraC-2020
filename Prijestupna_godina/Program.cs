using System;

namespace Prijestupna_godina
{
    class Program
    {
        static void Main(string[] args)
        {
            // Zadatak 5.3.6.

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
            Console.WriteLine("");

            Console.WriteLine("PROVJERI JE LI TVOJA GODINA PRIJESTUPNA");
            Console.WriteLine("");

            Console.WriteLine("Unesi svoju godinu ili 'kraj' za izlaz.");
            Console.WriteLine("");
            while (true)
            {
                string input = Console.ReadLine();
                if (input.ToLower() == "kraj")
                {
                    break;
                }
                int korisnikova_godina = Convert.ToInt32(input);
                if (korisnikova_godina % 4 == 0 && korisnikova_godina % 100 != 0)
                {
                    Console.WriteLine("Godina je prijestupna! Unesi novu godinu ili 'kraj' za izlaz.");
                    Console.WriteLine("");
                }
                else if (korisnikova_godina % 400 == 0)
                {
                    Console.WriteLine("Godina je prijestupna! Unesi novu godinu ili 'kraj' za izlaz.");
                    Console.WriteLine("");
                }
                else
                {
                    Console.WriteLine("Godina NIJE prijestupna! Unesi novu godinu ili 'kraj' za izlaz.");
                    Console.WriteLine("");
                }

            }

        }
    }
}
