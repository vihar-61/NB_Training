using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace quiz_app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t**************TECH QUIZ by Vihar.D**************\t\n");

            //Variable Declaration
            int score = 0, x;
            string name;
            Console.Write("\n Enter your Name : ");
            name = Console.ReadLine();

            Console.WriteLine("********************************************************");
            Console.WriteLine($"\n HEY ! {name}, Here's a Quiz on Recent Technology");
            Console.WriteLine("********************************************************");

            //1st Question------------------------
            Console.WriteLine("\nQ1. Which is the best processor manufactured by INTEL ?");
            Console.WriteLine("\n1. i5\t\t2. i3\t\t3. i9\t\t4. i7\n");
            Console.Write("\nEnter your answer : ");
            x = Convert.ToInt32(Console.ReadLine());
            if(x == 3)
            { score += 20; }

            //2nd Question------------------------
            Console.WriteLine("\nQ2. What is Elon Musk's automobile company name ?");
            Console.WriteLine("\n1. Ford\t\t2. Tesla\t3. Honda\t4. Porsche\n");
            Console.Write("\nEnter your answer : ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 2)
            { score += 20; }

            //3rd Question------------------------
            Console.WriteLine("\nQ3. What is the current name of the social media company 'Facebook' ?");
            Console.WriteLine("\n1. Whatsapp\t2. Instagram\t3. Snapchat\t4. Meta\n");
            Console.Write("\nEnter your answer : ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 4)
            { score += 20; }

            //4th Question------------------------
            Console.WriteLine("\nQ4. Which was the first cryptocurrency ever created ?");
            Console.WriteLine("\n1. Etherium\t2. Bitcoin\t3. DogeCoin\t4. PancakeSwap\n");
            Console.Write("\nEnter your answer : ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 2)
            { score += 20; }

            //5th Question------------------------
            Console.WriteLine("\nQ5. Which of them is latest Windows OS ?");
            Console.WriteLine("\n1. Windows 11\t2. Windows Vista\t3. Windows 8\t4. Windows 98\n");
            Console.Write("\nEnter your answer : ");
            x = Convert.ToInt32(Console.ReadLine());
            if (x == 1)
            { score += 20; }

            StreamWriter sw = new StreamWriter(@"C:\Assignments_NH_Vihar\Day 15\scores.txt", true);
            sw.WriteLine("\nName : {0} \t Score : {1}", name, score);
            sw.Close();

            Console.WriteLine("********************************************************");
            Console.WriteLine("\n Congrats! Your score has been submitted");
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("\n Contact ADMIN for queries.");
            Console.WriteLine("********************************************************");

        }
    }
}
