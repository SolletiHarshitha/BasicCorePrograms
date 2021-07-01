using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalPrograms
{
    class HarmonicNumber
    {
        public static void Readinput()
        {
            Console.WriteLine("Enter the Number : ");
            int num = Convert.ToInt32(Console.ReadLine());
            FindHarmonicValue(num);
        }
        private static void FindHarmonicValue(int num)
        {
            double sum = 1;
            for(int i=2;i<=num;i++)
            {
                sum += (double)1 / i;
            }
            Console.WriteLine("Harmonic progression upto "+num+" is : "+sum);
        }
    }
}
