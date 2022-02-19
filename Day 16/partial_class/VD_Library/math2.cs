using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Library
{
    public static partial class math2
    {
        public static int Factorial(int x)
        {
            int fact = 1;
            for(int i = 1; i <= x; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
}
