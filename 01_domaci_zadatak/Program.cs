using System;

namespace _01_domaci_zadatak
{
    class Program
    {
        static void Main(string[] args)
        {
            //4.1.2 - Ispis brojeva
            //Napišite program koji na konzoli ispisuje
            //brojeve 1,2,3 svaki u novi red.
            Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);

            Console.WriteLine(" ");

            //4.1.3 - Ledište/Vrelište
            //Napišite program koji će ispisivati temperaturu ledišta i vrelišta
            //vode, svaku u novi red
            Console.WriteLine("LEDIŠTE VODE:");
            Console.WriteLine("- na razini mora = 0 °C");
            Console.WriteLine("- morska voda = -2 °C");
            Console.WriteLine("- pothlađena voda u nekim životinjama (Globodera rostochiensis) < -38 °C");
            Console.WriteLine("- pothlađena voda u nekim biljkama (Rhododendron ferrugineum) < -40 °C");
            Console.WriteLine("- pothlađene kapljice oblaka = -40 °C");

            Console.WriteLine(" ");

            Console.WriteLine("VRELIŠTE VODE:");
            Console.WriteLine("- na razini mora = 100 °C");
            Console.WriteLine("- na vrhu Mt. Everesta = 71 °C");
            Console.WriteLine("- na Marsu = −4.96 °C");
            Console.WriteLine("- u svemiru = -270.45 °C");

            Console.WriteLine(" ");

            //5.1.1 - Zbroj i razlika
            //Program koji traži unos 2 cijela broja i prikazuje
            //na ekranu njihov zbroj te razliku
            Console.WriteLine("Unesi dva cijela broja za zbrajanje i oduzimanje.");
            int a, b;
            Console.Write("Prvi broj: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Drugi broj: ");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Zbroj iznosi: {0}", a + b);
            Console.WriteLine("Razlika iznosi: {0}", a - b);

            Console.WriteLine(" ");

            //5.1.2 - Umnožak i kvocijent
            //Program koji traži unos 2 cijela broja i prikazuje 
            //umnožak i kvocijent
            Console.WriteLine("Unesi dva cijela broja za množenje i dijeljenje.");
            int c, d;
            Console.Write("Prvi broj: ");
            c = int.Parse(Console.ReadLine());
            Console.Write("Drugi broj: ");
            d = int.Parse(Console.ReadLine());
            Console.WriteLine("Umnožak iznosi: {0}", c * d);
            Console.WriteLine("Kvocijent iznosi: {0}", (decimal)c / (decimal)d);
        }
    }
}
