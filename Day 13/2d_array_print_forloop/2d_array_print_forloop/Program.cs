using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_array_print_forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //initializing 2D array---------------------
            int[,] data = new int[2, 2];
            data[0, 0] = 5;
            data[0, 1] = 10;
            data[1, 0] = 15;
            data[1, 1] = 20;

            //Printing 2D array---------------------
            Console.WriteLine("\n ********** 2D array Representation **********");
            for(int i=0; i<2; i++)
            {
                for(int j=0; j<2; j++)
                {
                    Console.Write(data[i,j] + " ");
                }
                Console.Write("\n");
            }
            Console.ReadLine();
        }
    }
}