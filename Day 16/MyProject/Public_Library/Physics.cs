using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Public_Library
{
    public static class Physics
    {
        public static int FinalVelocity(int u, int a, int t)
        {
            int v = u + a * t;
            Console.WriteLine(v);
            return v;
        }
        public  static int Energy(int m, int c)
        {
            double C = c * c;
            double e = m * C;
            Console.WriteLine(e);
            return (int)e;
        }
    }
}