using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4classes
{
    internal class seller
    {
        private int sell_id;
        private string sell_name;
        private string sell_address;
        private string sell_type;
        public void CreateSellData()
        {
            Console.WriteLine("\nEnter seller id : ");
            sell_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter seller name : ");
            sell_name = Console.ReadLine();

            Console.WriteLine("\nEnter seller address : ");
            sell_address = Console.ReadLine();

            Console.WriteLine("\nEnter seller type : ");
            sell_type = Console.ReadLine();
            Console.WriteLine("\n");
        }
        public void DisplaySellData()
        {
            Console.WriteLine("\n************* Seller Details *************\n");
            Console.WriteLine($"\n\tSeller id : {sell_id}" +
                                $"\n\tSeller name : {sell_name}" +
                                $"\n\tSeller address : {sell_address}" +
                                $"\n\tSeller type : {sell_type}");
        }
    }
}
