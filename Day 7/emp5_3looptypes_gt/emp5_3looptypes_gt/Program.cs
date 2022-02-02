using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace emp5_3looptypes_gt
{
    internal class Program
    {
        class employee
        {
            public int emp_id;
            public string emp_name;
            public int emp_salary;
        }

        static void Main(string[] args)
        {
            employee[] emp = new employee[]
           {
                new employee(){emp_id = 1, emp_name = "Vihar Dasari", emp_salary = 50000},
                new employee(){emp_id = 2, emp_name = "Sarath Phani", emp_salary = 45000},
                new employee(){emp_id = 3, emp_name = "Manoj Karnatapu", emp_salary = 35000},
                new employee(){emp_id = 4, emp_name = "Manoj Yekkola", emp_salary = 75000},
                new employee(){emp_id = 5, emp_name = "Pavan Chirra", emp_salary = 60000},
           };

            //using for loop----------------------------------------------------------------------------------------------
            Console.WriteLine("\n Output (>= 50,000) (using for loop) :\n");
            for (int i = 0; i < emp.Length; i++)
            {
                if (emp[i].emp_salary >= 50000)
                    Console.WriteLine($"Employee id = {emp[i].emp_id}, " +
                                        $"Employee name = {emp[i].emp_name}, " +
                                        $"Employee salary = {emp[i].emp_salary}");
            }
            //using foreach loop----------------------------------------------------------------------------------------------
            Console.WriteLine("\n Output (>= 50,000) (using foreach loop) :\n");
            foreach (var e in emp)
            {
                if (e.emp_salary >= 50000)
                    Console.WriteLine($"Employee id = {e.emp_id}, " +
                                        $"Employee name = {e.emp_name}, " +
                                        $"Employee salary = {e.emp_salary}");
            }
            //Using Lambda Expression----------------------------------------------------------------------------------------------
            Console.WriteLine("\n Output (>= 50,000) (using Lambda exp) :\n");
           
            emp.ToList().Where(e => e.emp_salary >= 50000).ToList().ForEach(e =>Console.WriteLine($"Employee id = {e.emp_id}," +
                                                                                                    $"Employee name = {e.emp_name}," +
                                                                                                    $"Employee salary = {e.emp_salary}"));
            Console.ReadLine();

        }
    }
}
