using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ctocsprgms
{
    internal class Program
    {

        static void Main(string[] args)
        {
            //Variable Declaration Section
            int n, i, j;

            Console.WriteLine("\n----- Welcome To Printing Right Angle Triangle Using Stars -----");

            Console.Write("\n Enter no. of rows to be Printed : ");
            n = Convert.ToInt32(Console.ReadLine());

            //Logic Section
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.Write("\n");
            }

            Console.WriteLine("\n\n ----- Developed by VD © -----");
            Console.ReadLine();
        }



















    }
}

