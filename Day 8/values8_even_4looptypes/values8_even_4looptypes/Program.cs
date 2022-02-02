using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace values8_even_4looptypes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<int> data = new List<int>() { 65,89,41,78,16,84,39,67,22,64 };
            
            //using for loop------------------------------------------------------------
            Console.WriteLine("\n Output (using for loop ) : ------------\n");
            for (int i = 0; i < data.Count; i++)
            {
                if (data[i] % 2 == 0)
                    Console.WriteLine("\t{0}", data[i]);
            }

            //using foreach loop------------------------------------------------------------
            Console.WriteLine("\n Output (using foreach loop ) : ------------\n");
            foreach (var d in data)
            {
                if (d % 2 == 0)
                    Console.WriteLine("\t{0}", d);
            }

            //using lambda expression------------------------------------------------------------
            Console.WriteLine("\n Output (using lambda exp ) : ------------\n");
            data.Where(x => x % 2 == 0).ToList().ForEach(x => Console.WriteLine("\t{0}", x));

            //using LINQ query------------------------------------------------------------
            Console.WriteLine("\n Output (using LINQ ) : ------------\n");
            var output = from d in data
                         where d % 2 == 0
                         select d;
            output.ToList().ForEach(x => Console.WriteLine("\t{0}", x));
            Console.ReadLine();
        }
    }
}
