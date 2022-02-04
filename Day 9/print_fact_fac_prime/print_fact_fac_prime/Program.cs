using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace print_fact_fac_prime
{
    class Math_ops
    {
        private int input;
        private int i;
        public void ReadData()
        {
            Console.Write("enter a number to calculate : ");
            input = Convert.ToInt32(Console.ReadLine());
        }

        //Print factorial-------------------------------------------------------
        public void Factorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact *= i;
            }
            Console.WriteLine($"\nfactorial of {input} is : {fact}");
        }

        //Print factors-------------------------------------------------------
        public void Factor()
        {
            Console.Write($"\nfactors of {input} are : ");
            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    Console.Write("\t{0}", i);
            }
        }

        //Print prime or not-----------------------------------------------------
        public void Prime()
        {
            for (i = 2; i < input; i++)
            {
                if (input % i == 0)
                    break;
            }
            if (i == input)
                Console.WriteLine($"\n{input} is a Prime Number");
            else
                Console.WriteLine($"\n{input} is NOT a Prime Number");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Math_ops m1 = new Math_ops();
            m1.ReadData();
            m1.Factorial();
            m1.Factor();
            m1.Prime();
            Console.ReadLine();
        }
    }
}
