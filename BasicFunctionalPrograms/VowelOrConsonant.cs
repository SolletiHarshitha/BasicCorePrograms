using System;
using System.Collections.Generic;
using System.Text;

namespace BasicFunctionalPrograms
{
    class VowelOrConsonant
    {
        public static void ReadInput()
        {
            //Number of times to flip a coin
            Console.WriteLine("Enter an alphabet : ");
            char alpha = Convert.ToChar(Console.ReadLine());
            FindAlphabet(alpha);
        }
        private static void FindAlphabet(char ch)
        {
            switch(ch)
            {
                case 'A':
                case 'a':
                case 'E':
                case 'e':
                case 'I':
                case 'i':
                case 'O':
                case 'o':
                case 'U':
                case 'u':
                    Console.WriteLine(ch+" is Vowel");
                    break;
                default:
                    Console.WriteLine(ch+" is Consonant");
                    break;
            }
        }
    }
}
