using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2darray_read_print
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[2, 2];

            //reading array values-------------
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write($"\n enter array value at ({i},{j}) :");
                    data[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //printing array values-------------
            Console.WriteLine("\n Entered array : ");
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write("\t" + data[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine("\n");
        }
    }
}
