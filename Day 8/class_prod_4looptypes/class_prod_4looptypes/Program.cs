using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_prod_4looptypes
{
    class Product
    {
        public int prod_id;
        public string prod_name;
        public int prod_price;
        public string prod_brand;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> prod = new List<Product>()
             {
             new Product() { prod_id = 1, prod_name = "ROG Strix", prod_price = 820, prod_brand = "ASUS"},
             new Product() { prod_id = 2, prod_name = "Legion 5i", prod_price = 630, prod_brand = "Lenovo"},
             new Product() { prod_id = 3, prod_name = "Pavilion", prod_price= 250, prod_brand ="HP"},
             new Product() { prod_id = 4, prod_name = "Nitro Predator", prod_price = 350, prod_brand = "Acer"}
             };

            //using for Loop----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n Output ( using for loop ) : ------------\n");
             for (int i = 0; i < prod.Count; i++)
            {
                if (prod[i].prod_price > 500)
                {
                    Console.WriteLine($"Product name = {prod[i].prod_name}, " +
                                        $"Product brand = {prod[i].prod_brand}");
                }
            }

            //using foreach Loop----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n Output ( using foreach loop ) : ------------\n");
            foreach (var p in prod)
            {
                if (p.prod_price > 500)
                    Console.WriteLine($"Product name = {p.prod_name}, " +
                                        $"Product brand ={p.prod_brand}");
            }

            //using lambda expression----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n Output ( using lambda exp ) : ------------\n");
            prod.Where(p => p.prod_price > 500).ToList().ForEach(p => Console.WriteLine($"Product name = {p.prod_name}, " +
                                                                                        $"Product brand = {p.prod_brand}"));

            //using LINQ query----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n Output ( using LINQ ) : ------------\n");
            var output = from p in prod
                         where p.prod_price > 500
                         select p;
            output.ToList().ForEach(p => Console.WriteLine($"Product name = {p.prod_name}, " +
                                                            $"Product brand = {p.prod_brand}"));
            Console.ReadLine();
        }
    }
}
