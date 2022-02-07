using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_overload
{
    class Maths
    {
        //Adding 2 numbers-------------------------
        public int Add(int a, int b)
        { 
            return a + b; 
        }
        //Adding 3 numbers-------------------------
        public int Add(int a, int b , int c)
        {
            return a + b + c;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Maths obj = new Maths();
            Console.WriteLine("\n Method Overloading ----------------");
            Console.WriteLine("Addition of 5 and 10 is :{0}", obj.Add(5, 10));
            Console.WriteLine("Addition of 5, 10 & 15 is :{0}", obj.Add(5, 10, 15));
            Console.ReadLine();
        }
    }
}
