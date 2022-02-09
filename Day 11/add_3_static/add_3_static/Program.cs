using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add_3_static
{
    internal class Program
    {
        class Mathematics
        {
            public static int Add(int a, int b)
            { 
                return a + b; 
            }

            public static int Sub(int a, int b)
            {
                return a - b;
            }
            public static int Mult(int a, int b)
            {
                return a * b;
            }
            public static int Div(int a, int b)
            {
                return a / b;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n ************** Mathematics Class calling in Main Method **************");
            
            //Calling static methods using class name
            Console.WriteLine("\n Addition : {0}", Mathematics.Add(30, 10));
            Console.WriteLine("\n Subtraction : {0}", Mathematics.Sub(30, 10));
            Console.WriteLine("\n Multiplication : {0}", Mathematics.Mult(30, 10));
            Console.WriteLine("\n Division : {0}", Mathematics.Div(30, 10));
            
            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
