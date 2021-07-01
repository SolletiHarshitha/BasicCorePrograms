using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalPrograms
{
    class Swap
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter two numbers : ");
            //Initialising the Dividend and Divisor
            int numOne = Convert.ToInt32(Console.ReadLine());
            int numTwo = Convert.ToInt32(Console.ReadLine());
            SwapTwoNumbers(numOne, numTwo);
        }
        private static void SwapTwoNumbers(int n1,int n2)
        {
            Console.WriteLine("Before swapping : " + n1 + ", "+n2);
            //swapping two numbers
            int temp = n1;
            n1 = n2;
            n2 = temp;
            Console.WriteLine("After swapping : "+n1+", "+n2);
        }
    }
}
