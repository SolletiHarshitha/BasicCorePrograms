using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalPrograms
{
    class QuotientAndRemainder
    {
        public static void ReadInput()
        {
            Console.WriteLine("Enter the Dividend and Divisor : ");
            //Initialising the Dividend and Divisor
            int dividend = Convert.ToInt32(Console.ReadLine());
            int divisor = Convert.ToInt32(Console.ReadLine());
            FindQuotient(dividend,divisor);
        }
        private static void FindQuotient(int dividend,int divisor)
        {
            //computing the quotient and remainder
            int quotient = dividend / divisor;
            int remainder = dividend % divisor;
            Console.WriteLine("The Quotient is : "+quotient);
            Console.WriteLine("The Remainder is : "+remainder);
        }
    }
}
