using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylist_sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList data = new ArrayList();
            int sum = 0;

            data.Add(5);
            data.Add(10);
            data.Add(15);
            data.Add(20);
            data.Add(25);

            foreach (var d in data)
            {
                sum = sum + (int)d;
            }

            Console.WriteLine("The Sum of Array List items is : {0}", sum);
            Console.ReadLine();
        }
    }
}
