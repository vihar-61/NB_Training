using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3var2meth_read_print
{
    class Employee
    {
        public int id;
        public string name;
        public int salary;

        public void ReadEmp()
        {
            Console.WriteLine("Enter id :");
            id = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter name :");
            name = Console.ReadLine();
            
            Console.WriteLine("Enter salary :");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void PrintEmp()
        {
            Console.WriteLine($"id={id},name={name},salary={salary}");
            //Console.WriteLine("id={0},name={1},salary={2}", id, name, salary);
            //Console.WriteLine("id =" + id + ", Name =" + name + ", salary =" + salary);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.ReadEmp();
            emp1.PrintEmp();

            Console.ReadLine();
        }
    }
}
