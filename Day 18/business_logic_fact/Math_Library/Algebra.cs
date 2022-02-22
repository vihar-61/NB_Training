using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_Library
{
    public class Algebra
    {
        public static int Factorial(int n)
        {
            int fact = 1;
            if (n == 0)
                return 1;
            else if (n > 7)
                return -999;
            else if (n < 0)
                return - 9999;
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    fact *= i;
                }
                return fact;
            }
            //return 0;
        }
        public static bool IsPalindrome(int n)
        {
            int rev = 0, rem, x;
            x = n;
            while(x > 0)
            {
                rem = x % 10;
                x /= 10;
                rev = rev * 10 + rem;
            }
            if (n == rev)
                return true;
            else
                return false;
        }
    }
}
