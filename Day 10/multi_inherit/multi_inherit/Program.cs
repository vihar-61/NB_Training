using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multi_inherit
{
    class Algebra
    {
        //Addition of 2 numbers------------------------------------------------------
        public int Add(int a, int b)
        {
            return a + b;
        }
        //Subtraction of 2 numbers------------------------------------------------------
        public int Subt(int a, int b)
        {
            return a - b;
        }
    }
    //Inheriting TotalMath (Child Class) from Algebra (Parent Class)
    class TotalMath : Algebra
    {
        //Mutltiplication of  2 numbers------------------------------------------------------
        public int Mult(int a, int b)
        {
            return a * b;
        }
    }
    //Inheriting TotalMath (Child Class) from Algebra (Parent Class)
    class OverallMath : TotalMath
    {
        //Division of  2 numbers------------------------------------------------------
        public int Div(int a, int b)
        {
            return a / b;
        }
        //Modulus of 2 numbers------------------------------------------------------
        public int Mod(int a, int b)
        {
            return a % b;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            OverallMath math = new OverallMath();
            Console.WriteLine("\n Multi-Level Inheritance ------------------------------------------------------\n");
            Console.WriteLine("\n Sum of 9 and 6 is {0}", math.Add(9, 6));
            Console.WriteLine("\n Difference of 9 and 6 is {0}", math.Subt(9, 6));
            Console.WriteLine("\n Product of 9 and 6 is {0}", math.Mult(9, 6));
            Console.WriteLine("\n Division of 15 and 3 is {0}", math.Div(15, 3));
            Console.WriteLine("\n Modulus of 9 and 6 is {0}", math.Mod(9, 6));
            Console.ReadLine();
        }
    }
}
