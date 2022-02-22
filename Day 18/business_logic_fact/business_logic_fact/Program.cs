using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Math_Library;

namespace business_logic_fact
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("\n Enter number :");
            n = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n Factorial is : {0}", Algebra.Factorial(n));

            Console.ReadLine();
        }
    }
}