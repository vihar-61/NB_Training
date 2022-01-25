using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace add2num
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("please enter the Number1");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the Number2");
            b = Convert.ToInt32(Console.ReadLine());
            int c;
            c = a + b;
            Console.WriteLine("Sum of two Numbers:" + c.ToString());
            Console.ReadLine();
        }
    }
}
