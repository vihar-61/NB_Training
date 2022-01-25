using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multitable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.Write("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} X {1} = {2} \n", n, i, n * i);
            }
        }
    }
}
