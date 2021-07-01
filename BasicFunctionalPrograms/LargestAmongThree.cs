using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalPrograms
{
    class LargestAmongThree
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter three number : ");
            //Initialising the numbers 
            int numOne = Convert.ToInt32(Console.ReadLine());
            int numTwo = Convert.ToInt32(Console.ReadLine());
            int numThree = Convert.ToInt32(Console.ReadLine());
            Largest(numOne,numTwo,numThree);
        }
        private static void Largest(int n1,int n2,int n3)
        {
            //Checking largest among three numbers
            if(n1>n2 && n1>n3)
            {
                Console.WriteLine(n1+" is the largest number");
            }
            else if(n2>n3)
            {
                Console.WriteLine(n2+" is the largest number");
            }
            else
            {
                Console.WriteLine(n3+" is the largest number");
            }
        }
    }
}
