using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multitable_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.Write("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write(n+" x "+i+" = "+n*i+"\n");
            }
        }
    }
}
