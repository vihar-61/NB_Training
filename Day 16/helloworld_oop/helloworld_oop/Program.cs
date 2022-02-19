using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helloworld_oop
{
    class HelloWorld
    {
        public void PrintText()
        {
            Console.WriteLine("Hello World***!!");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld helloWorld = new HelloWorld();
            helloWorld.PrintText();
        }
    }
}
