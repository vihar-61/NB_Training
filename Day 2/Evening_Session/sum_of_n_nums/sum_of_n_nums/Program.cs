using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_n_nums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, n, sum = 0;

            Console.Write("Enter n value : ");
            n = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nThe first {0} natural number are :\n", n);
            for (i = 1; i <= n; i++)
            {
                Console.Write("{0} ", i);
                sum += i;
            }
            Console.Write("\nThe Sum of Natural Number upto {0} terms : {1} \n", n, sum);
        }
    }
}
