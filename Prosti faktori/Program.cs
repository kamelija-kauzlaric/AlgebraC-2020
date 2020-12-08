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

            Console.WriteLine("PRIME FACTORIZATION - enter a number to get its prime factors:");

            int dividend = int.Parse(Console.ReadLine());
            int factor = 2;
            List<int> primeFactorList = new List<int>();

            while (factor <= dividend)
            {
                if (dividend % factor == 0)
                {
                    primeFactorList.Add(factor);
                    dividend /= factor;
                }
                else
                {
                    factor++;
                }
            }

            Console.WriteLine("");
            if (!primeFactorList.Any())
            {
                Console.WriteLine("No primes accepted. Bye!");
            }
            else
            {
                Console.WriteLine("The prime factors are: ");
                primeFactorList.Sort();
                foreach (int a in primeFactorList)
                {
                    Console.Write(a + " ");
                }
            }

            Console.WriteLine("");
        }
    }
}

