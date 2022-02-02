using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cust_prod_3looptypes
{
    class customer
    {
        public int cust_id;
        public string cust_name;
        public string cust_subtype;
    }
    class product
    {
        public int prod_id;
        public string prod_name;
        public int prod_price;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customers Class----------------------------------------------------------------------
            customer[] cust = new customer[]
           {
            new customer(){ cust_id = 1, cust_name = "Vihar Dasari", cust_subtype = "Prime"},
            new customer(){ cust_id = 2, cust_name = "Pavan Chirra", cust_subtype = "General"},
            new customer(){ cust_id = 3, cust_name = "Manoj Karnatapu", cust_subtype = "Prime"}
           };

            //using for loop-----------------------------------------------------------------------
            Console.WriteLine("\n Output (using for loop) : ");
            for (int i = 0; i < cust.Length; i++)
            {
                Console.WriteLine($"Customer id = {cust[i].cust_id}, " +
                                    $"Customer name = {cust[i].cust_name}, " +
                                    $"Customer subtype = {cust[i].cust_subtype}");
            }

            //using foreach loop-----------------------------------------------------------------------
            Console.WriteLine("\n Output (using foreach loop) : ");
            foreach (var e in cust)
            {
                Console.WriteLine($"Customer id = {e.cust_id}, " +
                                    $"Customer name = {e.cust_name}, " +
                                    $"Customer subtype = {e.cust_subtype}");
            }

            //using Lambda Expression-----------------------------------------------------------------------
            Console.WriteLine("\n Output (using lambda exp) : ");
            cust.ToList().ForEach(d => Console.WriteLine($"Customer id = {d.cust_id}, " +
                                                            $"Customer name = {d.cust_name}, " +
                                                            $"Customer subtype = {d.cust_subtype}"));

            Console.WriteLine("\n****************************************************************************************\n");

            //Products Class----------------------------------------------------------------------
            product[] prod = new product[]
            {
                new product(){ prod_id = 10, prod_name = "Asus ROG", prod_price = 80000},
                new product(){ prod_id = 20, prod_name = "MSI Gaming", prod_price = 75000},
                new product(){ prod_id = 30, prod_name = "Gigabyte Gaming", prod_price = 50000}
            };

            //using for loop-----------------------------------------------------------------------
            Console.WriteLine("\n Output (using for loop) : ");
            for (int i = 0; i < prod.Length; i++)
            {
                Console.WriteLine($"Product id = {prod[i].prod_id}, " +
                                    $"Product name = {prod[i].prod_name}, " +
                                    $"Product price = {prod[i].prod_price}");
            }

            //using foreach loop-----------------------------------------------------------------------
            Console.WriteLine("\n Output (using foreach loop) : ");
            foreach (var p in prod)
            {
                Console.WriteLine($"Product id = {p.prod_id}, " +
                                    $"Product name = {p.prod_name}, " +
                                    $"Product price = {p.prod_price}");
            }

            //using Lambda Expression-----------------------------------------------------------------------
            Console.WriteLine("\n Output (using lambda exp) : ");
            prod.ToList().ForEach(d => Console.WriteLine($"Product id = {d.prod_id}, " +
                                                            $"Product name = {d.prod_name}, " +
                                                            $"Product price = {d.prod_price}"));
            Console.ReadLine();
        }
    }
}
