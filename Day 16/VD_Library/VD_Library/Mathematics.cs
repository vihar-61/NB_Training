using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Library
{
    public class Mathematics
    {
        int a, b, input;
        //Modulus
        public int Modulus()
        {     
            Console.Write("\n Enter a : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n Enter b : ");
            b = Convert.ToInt32(Console.ReadLine());
            int x = a % b;
            //Console.WriteLine(x);
            return x;
        }

        //Factorial
        //Reading input
        public int ReadInput()
        {
            Console.Write("\n Enter a number : ");
            input = int.Parse(Console.ReadLine());
            return input;
        }

        //Returning the factorial
        public int PrintFact()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact *= i;
            }
            //Console.WriteLine(fact);
            return fact;
        }
    }
}
