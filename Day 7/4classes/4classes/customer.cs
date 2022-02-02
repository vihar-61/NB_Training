using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4classes
{
    internal class customer
    {
        private int cust_id;
        private string cust_name;
        private string cust_subtype;
        private long cust_phno;
        
        public void CreateCustData()
        {
            Console.WriteLine("\nEnter customer id : ");
            cust_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter customer name : ");
            cust_name = Console.ReadLine();

            Console.WriteLine("\nEnter customer subscription type : ");
            cust_subtype = Console.ReadLine();

            Console.WriteLine("\nEnter customer phone no. : ");
            cust_phno = (int)Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("\n");
        }
        public void DisplayCustData()
        {
            Console.WriteLine("\n************* Customer Details *************\n");
            Console.WriteLine($"\n\tCustomer id : {cust_id}" +
                                $"\n\tCustomer name : {cust_name}" +
                                $"\n\tSubscription type : {cust_subtype}" +
                                $"\n\tPhone no. : {cust_phno}");
        }
    }
}
