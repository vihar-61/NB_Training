using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_override_virtual
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
        public virtual void PrintGM()
        {
            Console.WriteLine("Good Morning");
        }
    }

    //Print Subhodhayam-----------------------
    class TeluguGreet : EnglishGreet
    {
        public override void PrintGM()
        {
            Console.WriteLine("Subhodhayam");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            TeluguGreet obj = new TeluguGreet();
            EnglishGreet obj2 = new EnglishGreet();
            Console.WriteLine("\n Method Overriding using " +
                              "virtual and override keywords-----------");
            obj.PrintHi();
            obj.PrintHello();
            obj2.PrintGM();
            obj.PrintGM();
            Console.ReadLine();
        }
    }
}
