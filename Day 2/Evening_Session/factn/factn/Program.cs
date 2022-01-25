using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, fact = 1, number;
            Console.Write("Enter a number : ");
            number = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= number; i++)
                fact *= i;

            Console.Write("The Factorial of {0} is: {1}\n", number, fact);
        }
    }
}
