using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BLL_Library;

namespace VD_ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Employee Menu-------------------------------
            int ch;
            string choice;
            do
            {
                Console.WriteLine("*********************************************");
                Console.WriteLine("Employee Management Application");
                Console.WriteLine("*********************************************");
                Console.WriteLine("1. Add Employee :");
                Console.WriteLine("2. Search Employee by ID :");
                Console.WriteLine("3. Search Employee by name :");
                Console.WriteLine("4. Display all Employees :");
                Console.WriteLine("\nEnter your choice :");

                ch = Convert.ToInt32(Console.ReadLine());
                switch(ch)
                {
                    case 1 :
                        AddEmployee();
                        break;
                    case 2 :
                        SearchEmployeeByID();
                        break;
                    case 3 :
                        SearchEmployeeByName();
                        break;
                    case 4 :
                        DisplayAllEmployees();
                        break;
                    default:
                        Console.WriteLine("Invalid Choice !!");
                        break;
                }
                Console.WriteLine("Do you wish to continue (y/n) :");
                choice = Console.ReadLine();
            }while(choice.Equals("y"));
        }

        //Adding Employee Details-------------------------------
        public static void AddEmployee()
        {
            int id, salary, age;
            string name;

            Console.WriteLine("Enter ID :");
            id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name :");
            name = Console.ReadLine();
            Console.WriteLine("Enter Salary :");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Age :");
            age = Convert.ToInt32(Console.ReadLine());

            //Call BLL method
            var result = Emp_BLL.AddEmployee(id, name, salary, age);

            if(result)
                Console.WriteLine("Employee Details Saved Successfully !!");
            else
                Console.WriteLine("Error Occured !!");
        }

        //Searching Employees by ID-------------------------------
        public static void SearchEmployeeByID()
        {
            int id;
            Console.WriteLine("Enter Search ID :");
            id = Convert.ToInt32(Console.ReadLine());

            var result = Emp_BLL.GetEmployeeByID(id);

            if(result.Count == 0)
                Console.WriteLine("NO records exists with this ID !!");
            else
            {
                result.ForEach(e => Console.WriteLine(e));
            }
        }

        //Searching Employees by Name-------------------------------
        public static void SearchEmployeeByName()
        {
            string name;
            Console.WriteLine("Enter Search Name :");
            name=Console.ReadLine();

            var result = Emp_BLL.GetEmployeeByName(name);

            if(result.Count == 0)
                Console.WriteLine("No records exists with this Name !!");
            else
            {
                result.ForEach (e => Console.WriteLine(e));
            }

        }

        //Displaying All Employees-------------------------------
        public static void DisplayAllEmployees()
        {
            var employees = Emp_BLL.GetAllEmployees();
            Console.WriteLine();
            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
