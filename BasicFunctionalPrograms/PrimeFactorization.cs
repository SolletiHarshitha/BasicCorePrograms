using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalPrograms
{
    class PrimeFactorization
    {
        public static void Readinput()
        {
            Console.WriteLine("Enter the Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            PrimeFactors(num);
        }
        public static void PrimeFactors(int num)
        {
            while (num % 2 == 0)
            {
                Console.Write(2 + " ");
                num /= 2;
            }

            for (int i = 3; i <= Math.Sqrt(num); i += 2)
            {
                while (num % i == 0)
                {
                    Console.Write(i + " ");
                    num /= i;
                }
            }

            if (num > 2)
                Console.Write(num);
        }
    }
}
