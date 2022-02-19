using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Library
{
    public static partial class math1
    {
        public static int Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
            return sum;
        }
        public static int Mult(int a, int b)
        {
            int mult = a * b;
            Console.WriteLine(mult);
            return mult;
        }
    }
}
