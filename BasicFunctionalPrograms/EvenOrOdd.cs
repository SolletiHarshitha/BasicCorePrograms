using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalPrograms
{
    class EvenOrOdd
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the number : ");
            //Initialising the number 
            int num = Convert.ToInt32(Console.ReadLine());
            FindEvenOrOdd(num);
        }
        private static void FindEvenOrOdd(int num)
        {
            //Checking if the number is even or odd
            if(num%2==0)
            {
                Console.WriteLine(num+" is a even number");
            }
            else
            {
                Console.WriteLine(num+" is a odd number");
            }
        }
    }
}
