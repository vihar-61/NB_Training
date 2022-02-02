using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4classes
{
    internal class department
    {
        private int dept_id;
        private string dept_name;
        public void CreateDeptData()
        {
            Console.WriteLine("\nEnter department id : ");
            dept_id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter department name : ");
            dept_name = Console.ReadLine();
            Console.WriteLine("\n");
        }
        public void DisplayDeptData()
        {
            Console.WriteLine("\n************* Department Details *************\n");
            Console.WriteLine($"\n\t Department id : {dept_id}" +
                                $"\n\t Department name : {dept_name}");
        }
    }
}
