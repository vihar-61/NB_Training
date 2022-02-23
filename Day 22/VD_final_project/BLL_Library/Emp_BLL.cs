using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DAL_Library;

namespace BLL_Library
{
    public class Emp_BLL
    {
        public static bool AddEmployee(int emp_id, string emp_name, int emp_salary, int emp_age)
        {
            var result = Emp_DAL.AddEmployee(emp_id, emp_name, emp_salary, emp_age);
            return result;
        }

        public static List<String> GetEmployeeByID(int id)
        {
            var result = Emp_DAL.GetEmployeeByID(id);
            return result;
        }

        public static List<String> GetEmployeeByName(string name)
        {
            var result = Emp_DAL.GetEmployeeByName(name);
            return result;
        }

        public static String[] GetAllEmployees()
        {
            var result = Emp_DAL.GetAllEmployees();
            return result;
        }
    }
}
