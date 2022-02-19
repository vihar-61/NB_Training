using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VD_Library;

namespace three_class_refer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Mathematics Class
            Console.WriteLine("\n Mathematics modulus and factorial");
            Console.WriteLine("------------------------------");
            Console.WriteLine("\n\n Calculate modulus : ");
            Mathematics m = new Mathematics();
            Console.WriteLine(m.Modulus());

            Console.WriteLine("\n\nCalculate factorial : ");
            m.ReadInput();
            Console.WriteLine(m.PrintFact());

            //Chemistry Class
            Console.WriteLine("\n\n Chemical Compositions");
            Console.WriteLine("------------------------------");
            Chemistry c = new Chemistry();
            Console.WriteLine("\n Benzene composition : ");
            c.GetBenzene();
            Console.WriteLine("\n Water composition : ");
            c.GetWater();
            Console.WriteLine("\n Methane composition : ");
            c.GetMethane();

            //Physics Class
            Console.WriteLine("\n\n Physics FinalVelocity");
            Console.WriteLine("------------------------------");
            int u = 5;
            int a = 7; 
            int t = 10;
            var p = new Physics();
            //var v = p.FinalVelocity(u, a, t);
            Console.WriteLine(p.FinalVelocity(u, a, t));

            Console.ReadLine();
        }
    }
}
