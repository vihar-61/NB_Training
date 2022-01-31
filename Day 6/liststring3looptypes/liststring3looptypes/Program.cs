using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace liststring3looptypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> data = new List<string>();
            data.Add("Vihar");
            data.Add("Manoj");
            data.Add("Vamsi");
            data.Add("Pavan");
            data.Add("Sharath");

            //Using For Loop------------------------------------------
            Console.WriteLine("\n Output ( Using For Loop ) : ");
            for (int i = 0; i < data.Count; i++)
            {
                Console.WriteLine("\t- {0} -", data[i]);
            }
            Console.WriteLine();

            //Using For Each Loop--------------------------------------
            Console.WriteLine("\n Output ( Using For Each Loop ) : ");
            foreach (var d in data)
            {
                Console.WriteLine("\t- {0} -", d);
            }
            Console.WriteLine();

            //Using Lambda Expression----------------------------------
            Console.WriteLine("\n Output ( Using Lambda Expression ) : ");
            data.ForEach(d => Console.WriteLine("\t- {0} -", d));

            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
