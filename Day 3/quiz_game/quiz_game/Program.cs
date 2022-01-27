using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quiz_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t\t ____::: Welcome To The Quiz Program : Vihar D :::____\t\t\t\n");
            //Variable Declaration Section
            int score = 0, ans;
            string name;
            Console.Write("  Enter The Name Of The Participant :  ");
            name = Console.ReadLine();
            Console.WriteLine("\n\n=====================================================================================================================");
            Console.WriteLine($"\n\t\tHi {name}, You are About To begin The Quiz on M\n");
            Console.WriteLine("=====================================================================================================================\n");

            //Question No:1
            Console.WriteLine("\nQ1.What is the only four legged mammal that can kneel on all fours?");
            Console.WriteLine("\n1. Horse  2. Cow  3. Giraffe  4. Kneel\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 4)
                score += 20;

            //Question No:2
            Console.WriteLine("\n\nQ2. hat is the name of the most sacred river in India?");
            Console.WriteLine("\n1. Yangtzee 2. Ganges  3. Amazon  4. Mekong\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 2)
                score += 20;

            //Question No:3
            Console.WriteLine("\n\nQ3. Which of the 5 senses is the first to develop?");
            Console.WriteLine("\n1. Smell 2. Taste  3. Sight  4. Hearing\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 1)
                score += 20;

            //Question No:4
            Console.WriteLine("\n\nQ4. In what year did Apple start selling the first iPhones?");
            Console.WriteLine("\n1. 2000 2. 2004  3. 2007  4. 2010\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;

            //Question No:5
            Console.WriteLine("\n\nQ5. The opposite sides of a dice add up to this numbe");
            Console.WriteLine("\n1. 6 2. 12  3. 7  4. 9\n");
            Console.Write("\nEnter Your Answer :  ");
            ans = Convert.ToInt32(Console.ReadLine());

            if (ans == 3)
                score += 20;


            if (score >= 60)
            {
                Console.WriteLine("\n\n=====================================================================================================================\n");
                Console.WriteLine("\n\t  ____:::*** Congratulations {0}, you got {1}% in the Quiz ***:::____\n", name, score);
                Console.WriteLine("\n=====================================================================================================================\n");
            }
            else
            {
                Console.WriteLine("\n\n=====================================================================================================================\n");
                Console.WriteLine("\n\tSorry {0}, you have Scored {1}% in the Quiz. Try Again..!\n", name, score);
                Console.WriteLine("\n=====================================================================================================================\n");
            }
            Console.ReadLine();
        }
    }
}
