using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Customer---------------------------------------------
            customer cust1 = new customer();                                           
            Console.WriteLine("Enter Customer Details : ");
            cust1.CreateCustData();

            //Product----------------------------------------------
            product prod1 = new product();
            Console.WriteLine("Enter Product Details : ");
            prod1.CreateProdData();

            //Seller-----------------------------------------------
            seller sell1 = new seller();
            Console.WriteLine("Enter Seller Details : ");
            sell1.CreateSellData();

            //Department-------------------------------------------
            department dept1 = new department();
            Console.WriteLine("Enter Department Details : ");        
            dept1.CreateDeptData();

            cust1.DisplayCustData();                                                    
            prod1.DisplayProdData();
            sell1.DisplaySellData();
            dept1.DisplayDeptData();
            
            Console.WriteLine("\n*********************** EXECUTION TERMINATED ***********************");
            Console.ReadLine();
        }
    }
}
