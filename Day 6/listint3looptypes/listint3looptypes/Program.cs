using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listint3looptypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> data = new List<int>();
            int temp;
            int sum1 = 0, sum2 = 0, sum3 = 0;

            //Declaring Values to List----------------------------------------
            for (int i = 0; i <= 4; i++)
            {
                Console.Write("Enter any value into the index {0}, into the  List : ", i);
                temp = Convert.ToInt32(Console.ReadLine());
                data.Add(temp);
            }

            //Using For Loop--------------------------------------------------
            Console.WriteLine("\n\nOutput ( Using For Loop ) : ");
            Console.WriteLine("----------------------------------------------------------------------------");
            for (int i = 0; i < data.Count; i++)
            {
                sum1 = sum1 + data[i];
            }
            Console.WriteLine("\n The sum is : {0}", sum1);

            //Using Foreach Loop----------------------------------------------
            Console.WriteLine("\n\nOutput ( Using Foreach Loop ) : ");
            Console.WriteLine("----------------------------------------------------------------------------");
            foreach (var d in data)
            {
                sum2 = sum2 + d;
            }
            Console.WriteLine("\n The sum is : {0}", sum2);

            //Using Lambda Expression-----------------------------------------
            Console.WriteLine("\n\nOutput ( Using Lambda Expression ) : ");
            Console.WriteLine("----------------------------------------------------------------------------");
            data.ForEach(d => sum3 = sum3 + d);

            Console.WriteLine("\n The sum is : {0}", sum3);
            Console.ReadLine();
        }
    }
}
