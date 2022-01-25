using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apowerb
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int basenum, expo, i, power;

            // Reading number
            Console.Write("Enter base number: ");
            basenum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter exponenet number: ");
            expo = Convert.ToInt32(Console.ReadLine());

            //caculating power of given number
            power = 1;
            for (i = 1; i <= expo; i++)
                power = power * basenum;

            Console.Write("Power : " + power);
            Console.ReadLine();
        }
    }
}
