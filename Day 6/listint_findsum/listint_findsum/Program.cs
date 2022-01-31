using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listint_findsum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int sum = 0;

            data.Add(5);
            data.Add(10);
            data.Add(15);
            data.Add(20);
            data.Add(25);

            foreach (int i in data)
            {
                sum = sum + i;
            }

            Console.WriteLine("The sum Of the items is : {0}", sum);
            Console.ReadLine();
        }
    }
}
