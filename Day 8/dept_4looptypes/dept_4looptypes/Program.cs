using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dept_4looptypes
{
    class Department
    {
        public int dept_id;
        public string dept_name;
        public int dept_empCount;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            List<Department> dept = new List<Department>()
            {
             new Department() {dept_id = 1, dept_name = "Manager", dept_empCount = 10},
             new Department() {dept_id = 2, dept_name = "Administration", dept_empCount = 50},
             new Department() {dept_id = 3, dept_name = "Logistics", dept_empCount = 200},
             new Department() {dept_id = 4, dept_name = "Packaging", dept_empCount = 350}
            };

            //using for Loop----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n Output ( using for loop ) : ------------\n");
            for (int i = 0; i < dept.Count; i++)
            {
                if (dept[i].dept_empCount > 50)
                {
                    Console.WriteLine($"Department id = {dept[i].dept_id}, " +
                                        $"Department name = {dept[i].dept_name}");
                }
            }

            //using foreach Loop----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n Output ( using foreach loop ) : ------------\n");
            foreach (var d in dept)
            {
                if (d.dept_empCount > 50)
                {
                    Console.WriteLine($"Department id = {d.dept_id}, " +
                                        $"Department name = {d.dept_name}");
                }
            }

            //using lambda expression----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n Output ( using lambda exp ) : ------------\n");
            dept.Where(d => d.dept_empCount > 50).ToList().ForEach(d => Console.WriteLine($"Department id = {d.dept_id}, " +
                                                                                            $"Department name = {d.dept_name}"));

            //using LINQ query----------------------------------------------------------------------------------------------------------------------------
            Console.WriteLine("\n Output ( using LINQ ) : ------------\n");
            var output = from d in dept
                         where d.dept_empCount > 50
                         select d;
            output.ToList().ForEach(d => Console.WriteLine($"Department id = {d.dept_id}, " +
                                                            $"Department name = {d.dept_name}"));
            Console.ReadLine();
        }
    }
}
