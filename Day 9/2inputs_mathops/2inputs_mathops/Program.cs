using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2inputs_mathops
{
    class BasicMath
    {
        private int a, b;
        private int temp;
        public void ReadData()
        {
            Console.WriteLine("\nEnter 2 numbers : \n");
            Console.Write("Enter a value : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter b balue : ");
            b = Convert.ToInt32(Console.ReadLine());
        }
        
        //Addition-----------------------------------------------------------
        public void add()
        {
            temp = a + b;
            Console.WriteLine($"\nSum of {a} + {b} is : {temp}");
        }
        
        //Differnece-----------------------------------------------------------
        public void diff()
        {
            temp = a - b;
            Console.WriteLine($"\nDifference of {a} - {b} is :{temp}");
        }
        
        //Product-----------------------------------------------------------
        public void prod()
        {
            temp = a * b;
            Console.WriteLine($"\nProduct of {a} * {b} is : {temp}");
        }
        
        //Division-----------------------------------------------------------
        public void div()
        {
            temp = a / b;
            Console.WriteLine($"\nDivision of {a} / {b} is : {temp}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            BasicMath m2 = new BasicMath();
            m2.ReadData();
            m2.add();
            m2.diff();
            m2.prod();
            m2.div();
            Console.ReadLine();
        }
    }
}
