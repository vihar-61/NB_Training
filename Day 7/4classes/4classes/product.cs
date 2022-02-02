using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4classes
{
    internal class product
    {
        private int prod_id;
        private string prod_name;
        private string prod_brand;
        private int prod_price;
        public void CreateProdData()
        {
            Console.WriteLine("\nEnter the product id : ");
            prod_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter the product name : ");
            prod_name = Console.ReadLine();

            Console.WriteLine("\nEnter the product brand : ");
            prod_brand = Console.ReadLine();

            Console.WriteLine("\nEnter the product Price : ");
            prod_price = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\n");
        }

        public void DisplayProdData()
        {
            Console.WriteLine("\n************* Product Details *************\n");
            Console.WriteLine($"\n\tProduct id : {prod_id}" +
                                $"\n\tProduct name : {prod_name}" +
                                $"\n\tProduct brand : {prod_brand}" +
                                $"\n\tProduct price : {prod_price}");
        }
    }
}
