using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Library
{
    public static class Mathematics
    {
        public static int Factorial(int n)
        {
            int fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            Console.WriteLine(fact);
            return fact;
        }
        public static int Add(int a, int b)
        {
            int sum = a + b;
            Console.WriteLine(sum);
            return a + b;
        }
        public static int Mult(int a, int b)
        {
            int mult = a * b;
            Console.WriteLine(mult);
            return a * b;
        }
    }
}