using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Declaration
            int sum = 0;
            int[] data = new int[5];

            //Readng data from user
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Enter the {i + 1} number :");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Logic for adding items using foreach
            foreach (int i in data)
            {
                sum = sum + i;
            }

            //Printing sum of items using foreach
            Console.WriteLine($"The sum of all Items in an array is {sum}");

            Console.ReadLine();
        }
    }
}
