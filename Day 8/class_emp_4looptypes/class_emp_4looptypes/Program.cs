using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_emp_4looptypes
{
    class Employee
    {
        public int emp_id;
        public string emp_name;
        public int emp_salary;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> emp = new List<Employee>()
             {
                new Employee(){emp_id = 1, emp_name = "Vihar Dasari", emp_salary = 50000},
                new Employee(){emp_id = 2, emp_name = "Sarath Phani", emp_salary = 45000},
                new Employee(){emp_id = 3, emp_name = "Manoj Karnatapu", emp_salary = 35000},
                new Employee(){emp_id = 4, emp_name = "Manoj Yekkola", emp_salary = 75000},
                new Employee(){emp_id = 5, emp_name = "Pavan Chirra", emp_salary = 60000},
             };

            //using for Loop--------------------------------------------------------------
            Console.WriteLine("\n Output (using for loop ) : ------------\n");
             for (int i = 0; i < emp.Count; i++)
             {
                Console.WriteLine($"Employee id = {emp[i].emp_id}, " +
                                    $"Employee name = {emp[i].emp_name}, " +
                                    $"Employee salary = {emp[i].emp_salary}");
             }

            //using foreach Loop--------------------------------------------------------------
            Console.WriteLine("\n Output (using foreach loop ) : ------------\n");
            foreach (var e in emp)
            {
                Console.WriteLine($"Employee id = {e.emp_id}, " +
                                    $"Employee name = {e.emp_name}, " +
                                    $"Employee salary = {e.emp_salary}");
            }

            //using lambda expression--------------------------------------------------------------
            Console.WriteLine("\n Output (using lambda exp ) : ------------\n");
            emp.ForEach(e => Console.WriteLine($"Employee id = {e.emp_id}, " +
                                                $"Employee name = {e.emp_name}, " +
                                                $"Employees salary = {e.emp_salary}"));

            //using LINQ query--------------------------------------------------------------
            Console.WriteLine("\n Output (using LINQ ) : ------------\n");
            var output = from e in emp
                         select e;
            output.ToList().ForEach(e => Console.WriteLine($"Employee id = {e.emp_id}, " +
                                                            $"Employee name = {e.emp_name}, " +
                                                            $"Employee salary = {e.emp_salary}"));
            Console.ReadLine();
        }
    }
}