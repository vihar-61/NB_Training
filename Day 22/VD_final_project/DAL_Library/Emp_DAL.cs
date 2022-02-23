using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Library
{
    public static class Emp_DAL
    {
        public static string filepath = "C:\\Assignments_NH_Vihar\\Day 22\\Employees.txt";

        //Adding Employee-----------------------------------
        public static bool AddEmployee(int emp_id, string emp_name, int emp_salary, int emp_age)
        {
            try
            {
                string textContent = string.Concat(emp_id, ",", emp_name, ",", emp_salary, ",", emp_age);
                File.AppendAllText(filepath, textContent + Environment.NewLine);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        //Searching by ID-----------------------------------
        public static List<String> GetEmployeeByID(int id)
        {
            var allEmployees = File.ReadAllLines(filepath);
            bool isFound = false;
            List<string> employeeFound = new List<string>();

            foreach(string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if(Convert.ToInt32(empDetails[0]) == id)
                {
                    isFound = true;
                    employeeFound.Add(employee);
                    break;
                }
            }
            return employeeFound;
        }

        //Searching by name-----------------------------------
        public static List<String> GetEmployeeByName(string name)
        {
            var allEmployees = File.ReadAllLines(filepath);
            List<string> employeeFound = new List<string>();

            foreach (string employee in allEmployees)
            {
                var empDetails = employee.Split(',');
                if (empDetails[1].Contains(name))
                {
                    employeeFound.Add(employee);
                }
            }
            return employeeFound;
        }

        //Displaying all employees-----------------------------------
        public static String[] GetAllEmployees()
        {
            var allEmployees = File.ReadAllLines(filepath);
            return allEmployees;
        }
    }
}
