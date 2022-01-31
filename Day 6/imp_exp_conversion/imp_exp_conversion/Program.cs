using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace imp_exp_conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // implicit conversion
            // Type Casting short to int

            short newShort = 10;
            int newInt1 = newShort;

            Console.WriteLine("Implicit Conversion of short to int is : {0}", newInt1);

            // Explicit Conversion
            // Casting double to int

            double newDouble = 13.37;
            int newInt2 = (int)newDouble;
            Console.WriteLine("Explicit Conversion of double to int is : {0}", newInt2);
            Console.ReadLine();
        }
    }
}
