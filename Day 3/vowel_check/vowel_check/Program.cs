using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vowel_check
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ch;
            Console.WriteLine("\n Enter any single character, to check whether it is a Vowel or Not : ");
            ch = Console.ReadLine();

            switch (ch)
            {
                case "a":
                    Console.WriteLine("Yes, Vowel");
                    break;

                case "e":
                    Console.WriteLine("Yes, Vowel");
                    break;

                case "i":
                    Console.WriteLine("Yes, Vowel");
                    break;

                case "o":
                    Console.WriteLine("Yes, Vowel");
                    break;

                case "u":
                    Console.WriteLine("Yes, Vowel");
                    break;

                default:
                    Console.WriteLine("No, Consonent");
                    break;
            }
            Console.ReadLine();
        }
    }
}
