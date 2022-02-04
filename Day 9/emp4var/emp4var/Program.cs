using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp4var
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;
        public static string company = "NB Health Tech";

        public void ReadData()
        {
            Console.WriteLine("\nEnter employee id :");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEnter employee name :");
            name = Console.ReadLine();

            Console.WriteLine("\nEnter employee salary :");
            salary = Convert.ToInt32(Console.ReadLine());

        }

        public void PrintData()
        {
            Console.WriteLine("\n");
            Console.WriteLine($" id : {id}, " +
                                $"name : {name}, " +
                                $"salary : {salary}, " +
                                $"company : {company}");

        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();

            //Read employee data-------------------------------------
            Console.WriteLine("\n******Reading employee data******");
            emp1.ReadData();
            emp2.ReadData();

            //Print employee data-------------------------------------
            Console.WriteLine("\n******Printing employee data******");
            emp1.PrintData();
            emp2.PrintData();

            Console.ReadLine();
        }
    }
}
