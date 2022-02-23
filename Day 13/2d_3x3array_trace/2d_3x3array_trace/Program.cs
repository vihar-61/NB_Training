using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_3x3array_trace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] data = new int[,] { { 10, 20, 30 }, { 40, 50, 60 }, { 70, 80, 90 } };
            int sum = 0;

            Console.WriteLine("\n array entered : ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write("\t" + data[i, j] + " ");
                }
                Console.Write("\n");
            }
            

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        sum = sum + data[i, j];
                    }
                }
            }
            Console.WriteLine("\n Trace of the array : {0}", sum);
            Console.ReadLine();
        }
    }
}
