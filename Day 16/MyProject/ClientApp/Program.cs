using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VD_Library;
using Public_Library;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mathematics
            Console.WriteLine("\n ------Mathematics------");
            Console.Write("\n Factorial of 5 = "); 
                Mathematics.Factorial(5);
            Console.Write("\n Sum of 20 + 10 = ");
                Mathematics.Add(20, 10);
            Console.Write("\n Product of 25 x 5 = "); 
                Mathematics.Mult(25, 5);

            //Physics
            Console.WriteLine("\n ------Physics------");
            Console.Write("\n Final velocity = "); 
                Physics.FinalVelocity(5, 5, 5);
            Console.Write("\n Energy = ");
            Physics.Energy(10, 3);

            //Chemistry
            Console.WriteLine("\n ------Chemistry------");
            Console.Write("\n Benzene = ");
                Chemistry.Benzene();
            Console.Write("\n Methane = ");
                Chemistry.Methane();
            Console.Write("\n Water = ");
                Chemistry.Water();

            Console.ReadLine();
        }
    }
}