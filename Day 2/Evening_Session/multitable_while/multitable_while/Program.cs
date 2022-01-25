using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multitable_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n;
            Console.Write("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            i = 1;
            while (i <= 10)
            {
                Console.WriteLine("{0} X {1} = {2} \n", n, i, n * i);
                i++;
            }
        }
    }
}
