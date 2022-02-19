using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VD_Library
{
    public class Physics
    {
        public int FinalVelocity(int u, int a, int t)
        {
            int v = u + a * t;
            Console.WriteLine("\n Final Velocity : ", v);
            return v;
        }
    }
}
