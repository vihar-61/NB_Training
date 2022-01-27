using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Array Declaration Section
            int[] data = new int[4];
            Console.WriteLine("\n-------- Please provide 4 numbers to store in an array and retrive at the END --------\n");

            //Reading Array data from the user
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"Enter {i + 1} number :");
                data[i] = Convert.ToInt32(Console.ReadLine());
            }

            //Printing Array Values from the data[] using foreach loop
            Console.WriteLine("\n::: The values given to the array by User are... :::");
            foreach (int d in data)
            {
                Console.WriteLine(d);
            }
            Console.ReadLine();
        }
    }
}
