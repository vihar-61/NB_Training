using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2darray_matrix_product
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, j, k, r1, r2, c1, c2, sum = 0;

            int[,] arr1 = new int[100, 100];
            int[,] arr2 = new int[100, 100];
            int[,] arrprod = new int[100, 100];

            Console.WriteLine("\n--------------Multiplication of 2 matrices--------------");

            Console.WriteLine("\n enter 1st matrix no. of rows and columns : ");
            Console.WriteLine("\nrows : ");
            r1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\ncolumns : ");
            c1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n enter 2nd matrix no. of rows and columns : ");
            Console.WriteLine("\nrows : ");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\ncolumns : ");
            c2 = Convert.ToInt32(Console.ReadLine());

            if(c1 != r2)
            {
                Console.WriteLine("\n Multiplication not executable ( column of 1 should be equal to row of 2)");
            }
            else
            {
                //First Matrix-----------------------
                Console.WriteLine("\n enter 1st matrix elements : ");
                for (i = 0; i < r1; i++)
                {
                    for (j = 0; j < c1; j++)
                    {
                        Console.WriteLine($"element - [{i}],[{j}] : ");
                        arr1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("\n First matrix is :");
                for (i = 0; i < r1; i++)
                {
                    Console.WriteLine("\n");
                    for (j = 0; j < c1; j++)
                    {
                        Console.WriteLine("{0}\t", arr1[i, j]);
                    }
                    Console.WriteLine("\n");
                }

                //Second Matrix-----------------------
                Console.WriteLine("\n enter 2nd matrix elements : ");
                for (i = 0; i < r2; i++)
                {
                    Console.WriteLine("\n");
                    for (j = 0; j < c2; j++)
                    {
                        Console.WriteLine($"element - [{i}],[{j}] : ");
                        arr2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("\n Second matrix is :");
                for (i = 0; i < r2; i++)
                {
                    Console.WriteLine("\n");
                    for (j = 0; j < c2; j++)
                    {
                        Console.WriteLine("{0}\t", arr2[i, j]);
                    }
                    Console.WriteLine("\n");
                }

                //Matrix Multiplication-----------------------
                for (i = 0; i < r1; i++)
                    for (j = 0; j < c2; j++)
                        arrprod[i, j] = 0;

                for(i = 0; i < r1; i++)
                {
                    for(j = 0; j < c2; j++)
                    {
                        sum = 0;
                        for(k = 0; k < c1; k++)
                        {
                            sum = sum + arr1[i, k] * arr2[k, j];
                        }
                        arrprod[i, j] = sum;
                    }
                }
                Console.WriteLine("\n Product of matrices is : ");
                for(i = 0; i < r1; i++)
                {
                    Console.WriteLine("\n");
                    for(j=0; j < c2; j++)
                    {
                        Console.WriteLine("{0}\t", arrprod[i, j]);
                    }
                }
                Console.WriteLine("\n");
            }

        }
    }
}
