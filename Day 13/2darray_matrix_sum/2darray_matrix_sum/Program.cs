using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2darray_matrix_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program obj = new Program();
            obj.TwoArraySum();
            Console.ReadLine();
        }

        void TwoArraySum()
        {
            Console.WriteLine("\n enter no. of rows and columns : ");
            int arrlen = Convert.ToInt32(Console.ReadLine());

            int[,] arr1 = new int[arrlen, arrlen];
            int[,] arr2 = new int[arrlen, arrlen];
            int[,] arrsum = new int[arrlen, arrlen];

            //-------------------------------------------------------------------------------
            //First matrix---------------------
            for (int i = 0; i < arrlen; i++)
            {
                for (int j = 0; j < arrlen; j++)
                {
                    Console.WriteLine("\n array index [{0}][{1}] : ", i, j);
                    arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n-----------------------");

            Console.WriteLine("\n first array is : ");
            for (int i = 0; i < arrlen; i++)
            {
                for (int j = 0; j < arrlen; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(arr1[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + arr1[i, j]);
                    }
                }
                Console.WriteLine();
            }

            //-------------------------------------------------------------------------------
            //Second matrix---------------------
            for (int i = 0; i < arrlen; i++)
            {
                for (int j = 0; j < arrlen; j++)
                {
                    Console.WriteLine("\n array index [{0}][{1}] : ", i, j);
                    arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\n-----------------------");

            Console.WriteLine("\n second array is : ");
            for (int i = 0; i < arrlen; i++)
            {
                for (int j = 0; j < arrlen; j++)
                {
                    if (j == 0)
                    {
                        Console.Write(arr2[i, j]);
                    }
                    else
                    {
                        Console.Write(" " + arr2[i, j]);
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n-------------------------------------------------------------------------------");
            Console.WriteLine("\n want to add these arrays : ( Y / N )");

            string input = Convert.ToString(Console.ReadLine());
            if(input.ToUpper() == "Y")
            {
                for(int i = 0;i < arrlen; i++)
                {
                    for(int j = 0;j < arrlen; j++)
                    {
                        arrsum[i, j] = arr1[i, j] + arr2[i, j];
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine("\n sum of arrays is :");
                Console.WriteLine("\n------------------------------------");
                for(int i = 0; i<arrlen; i++)
                {
                    for(int j = 0;j < arrlen; j++)
                    {
                        if(j == 0)
                        {
                            Console.Write(arrsum[i, j]);
                        }
                        else
                        {
                            Console.Write(" " + arrsum[i, j]);
                        }
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("\n Execution ended.");
            }

        }
    }
}
