using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumavg_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] data = new int[5];
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter any number into an array index of {i}th Position :");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            foreach (int d in data)
            {
                sum = sum + d;
            }

            Console.WriteLine($"The sum of the Array Items is : {sum}");
            Console.WriteLine($"The average of the Array Items is : {sum / 5}");

            Console.ReadLine();
        }
    }
}
