using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2d_3x2array_print_forloop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //intializing and declaring 2D array-------------
            int[,] data = new int[,] { { 10, 20 }, { 20, 30 }, { 30, 40 } };

            //printing 2D array-------------
            Console.WriteLine("\n 2D array declaration in same line");
            for(int i=0; i<2; i++)
            {
                for(int j=0; j<2; j++)
                {
                    Console.Write(data[i,j] + " ");
                }
                Console.Write('\n');
            }
        }
    }
}
