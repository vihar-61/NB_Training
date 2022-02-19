using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VD_Library;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\n Sum of 20 + 10 = ");
            math1.Add(20, 10);
            Console.Write("\n Product of 25 x 5 = ");
            math1.Mult(25, 5);

            Console.WriteLine("\n Factorial of 6 = {0}", math2.Factorial(6));

            Console.ReadLine();

        }
    }
}
