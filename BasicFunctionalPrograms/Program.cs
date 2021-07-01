using System;

namespace BasicFunctionalPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose an Option : ");
            Console.WriteLine("1.Flip Coin");
            Console.WriteLine("2.Leap Year");
            Console.WriteLine("3.Power Of 2");
            Console.WriteLine("4.Harmonic Number");
            Console.WriteLine("5.Prime Factorization");
            Console.WriteLine("6.Find Quotient and Remainder");
            Console.WriteLine("7.Swap two Numbers");
            Console.WriteLine("8.Even or Odd");
            Console.WriteLine("9.Vowel or Consonant");
            Console.WriteLine("10.Largest Among Three Numbers");
            Console.WriteLine("Enter an option : ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    FlipCoin.ReadInput();
                    break;
                case 2:
                    LeapYear.ReadInput();
                    break;
                case 3:
                    PowerOf2.ReadInput();
                    break;
                case 4:
                    HarmonicNumber.Readinput();
                    break;
                case 5:
                    PrimeFactorization.Readinput();
                    break;
                case 6:
                    QuotientAndRemainder.ReadInput();
                    break;
                case 7:
                    Swap.ReadInput();
                    break;
                case 8:
                    EvenOrOdd.ReadInput();
                    break;
                case 9:
                    VowelOrConsonant.ReadInput();
                    break;
                case 10:
                    LargestAmongThree.ReadInput();
                    break;
                default:
                    Console.WriteLine("Choose a valid option");
                    break;
            }
            
            Console.WriteLine();
            
            Console.WriteLine();
            
            Console.WriteLine();
           
            Console.WriteLine();
            
            Console.WriteLine();
            
            Console.WriteLine();
            
            Console.WriteLine();
            
            Console.WriteLine();
            
            Console.WriteLine();
            
        }
    }
}
