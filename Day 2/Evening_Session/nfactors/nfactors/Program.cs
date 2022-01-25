using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nfactors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, x;
            Console.WriteLine("enter a number :");
            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The factors of {0} are : ",num);
            for (x = 1; x <= num; x++)
            {
                if (num % x == 0)
                {
                    Console.WriteLine(x);
                }
            }
            Console.ReadLine();
        }
    }
}
