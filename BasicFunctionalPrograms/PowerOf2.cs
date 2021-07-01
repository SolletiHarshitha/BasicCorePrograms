using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalPrograms
{
    class PowerOf2
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the number : ");
            //Initialising the number
            int num = Convert.ToInt32(Console.ReadLine());
            PrintTable(num);
        }
        private static void PrintTable(int num)
        {
            //Printing the power of 2 up to the num
            Console.WriteLine("The power of 2 is");
            for(int i=1;i<=num;i++)
            {
                Console.Write(Math.Pow(2,i)+" ");
            }
            Console.WriteLine();
        }
    }
}
