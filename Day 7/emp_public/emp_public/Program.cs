using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp_public
{
    class employee
    {
        public int emp_id;
        public string emp_name;
        public int emp_age;
        public int emp_salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            employee emp = new employee()
            {
                emp_id = 5000,
                emp_name = "Vihar Dasari",
                emp_age = 23,
                emp_salary = 10000
            };
            Console.WriteLine($"\n Employee id = {emp.emp_id}" +
                                $"\n Employee name = {emp.emp_name}" +
                                $"\n Employee age = {emp.emp_age}" +
                                $"\n Employee salary = {emp.emp_salary}" );
            Console.ReadLine();
        }
    }
}
