using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_override_new
{
    class EnglishGreet
    {
        //Print Hi-----------------------
        public void PrintHi()
        {
            Console.WriteLine("Hi");
        }
        //Print Hello-----------------------
        public void PrintHello()
        {
            Console.WriteLine("Hello");
        }
        //Print Good Morning-----------------------
        public void PrintGM()
        {
            Console.WriteLine("Good Morning");
        }
    }

    //Print Subhodhayam-----------------------
    class TeluguGreet : EnglishGreet
    {
        public new void PrintGM()
        {
            Console.WriteLine("Subhodhayam");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TeluguGreet obj = new TeluguGreet();
            Console.WriteLine("\n Method Overriding using new keyword-----------");
            obj.PrintHi();
            obj.PrintHello();
            obj.PrintGM();
            Console.ReadLine();
        }
    }
}
