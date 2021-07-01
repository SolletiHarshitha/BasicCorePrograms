using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalPrograms
{
    class FlipCoin
    {
        public static void ReadInput()
        {
            //Number of times to flip a coin
            Console.WriteLine("Enter the number of time to flip the coin : ");
            int num = Convert.ToInt32(Console.ReadLine());
            FindPercentage(num);
            
        }
        private static void FindPercentage(int num)
        {
            Random random = new Random();
            int tail = 0, head = 0;
            for(int flip=0;flip<num;flip++)
            {
                //Randomly choosing the coin value
                double coinValue = random.NextDouble();
                if (coinValue < 0.5)
                {
                    tail++;
                }
                else
                {
                    head++;
                }
            }
            double tailPercentage = (double)tail / num * 100;
            double headPercentage = (double)head / num * 100;
            //Printing the percentage of heads and tails
            Console.WriteLine("The percentage of tails is : "+tailPercentage);
            Console.WriteLine("The percentage of heads is : "+headPercentage);
        }
    }
}
