using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace const2_emp
{
    internal class Program
    {
        class Employee
        {
            public int id;
            public string name;
            public int salary;
            public static string company = "NB HealthCare";

            //Default Constructor-----------------------------------
            public Employee()
            {
                this.id = 0;
                this.name = null;
                this.salary = 0;
            }

            //Constructor with values-----------------------------------                     
            public Employee(int emp_id, string emp_name, int emp_salary)
            {
                this.id = emp_id;
                this.name = emp_name;
                this.salary = emp_salary;
            }

            //Reading Data-----------------------------------
            public void ReadData()
            {
                Console.Write("\nEnter employee id : ");
                id = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nEnter employee name : ");
                name = Console.ReadLine();

                Console.Write("\nEnter employee salary : ");
                salary = Convert.ToInt32(Console.ReadLine());
            }

            //Printing Data-----------------------------------
            public void PrintData()
            {
                Console.WriteLine("\n");
                Console.WriteLine($"\nid : {id}, " +
                    $"\nname : {name}, " +
                    $"\nsalary : {salary}, " +
                    $"\ncompany :{company}");
            }
        }
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee(61, "Vihar Dasari", 40000);

            emp1.ReadData();
            Console.WriteLine("\n********** Printing using default constructor **********");
           
            emp1.PrintData();
            Console.WriteLine("\n********** Printing using constructor **********");
           
            emp2.PrintData();
            Console.ReadLine();

        }
    }
}
