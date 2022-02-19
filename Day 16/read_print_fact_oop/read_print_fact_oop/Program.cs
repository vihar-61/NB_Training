using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace read_print_fact_oop
{
    class Factorial
    {
        int input;

        //Reading input
        public int ReadInput()
        {
            Console.Write("\nEnter a number : ");
            input = int.Parse(Console.ReadLine());
            return input;
        }

        //Returning the factorial
        public int PrintFact()
        {
            int fact = 1;
            for(int i = 1 ; i <= input; i++)
            { 
                fact *= i;
            }
            return fact;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Factorial fact = new Factorial();
            int input = fact.ReadInput();
            Console.WriteLine("\nFactorial of {0} is : {1} ", input, fact.PrintFact());
            
            Console.ReadKey();
        }

    }
}
