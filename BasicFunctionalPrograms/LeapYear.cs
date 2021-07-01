using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalPrograms
{
    class LeapYear
    {
        public static void ReadInput()
        {
            //Reading the year as input
            Console.WriteLine("Enter the year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            LeapYearOrNot(year);

        }
        private static void LeapYearOrNot(int year)
        {
            //Checking Leap Year or not
            if(year%4==0)
            {
                Console.WriteLine(year+" is a leap year");
            }
            else
            {
                Console.WriteLine(year+" is not a leap year");
            }
        }
    }
}
