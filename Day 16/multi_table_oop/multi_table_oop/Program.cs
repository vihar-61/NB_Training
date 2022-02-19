using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_table_oop
{
    class MultiTable
    {
        int input;
        public int ReadData()
        {
            Console.WriteLine("\n Enter a number : ");
            input = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n*****Multiplication Table of {0}*****", input);
            return input;
        }

        public void PrintData()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} x {1} = {2}", input, i, input * i);
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiTable mt = new MultiTable(); //Creating object
            mt.ReadData(); //Reading Input
            mt.PrintData(); //Getting Output

            Console.ReadLine();
        }
    }
}
