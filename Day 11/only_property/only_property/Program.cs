using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace only_property
{
    class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }

        public int Salary
        {
            get
            {
                if (Designation == "M")
                    return 90000;
                else if (Designation == "HR")
                    return 45000;
                else if (Designation == "TL")
                    return 75000;
                else
                    return 30000;
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n *************** NB Salary Details ( using Properties ) ***************");

            Employee emp = new Employee();
            emp.ID = 10;
            emp.Name = "Mohan N";
            emp.Designation = "M";
            Console.WriteLine($"\n {emp.ID}\t {emp.Name}\t\t {emp.Salary}");

            Employee emp1 = new Employee();
            emp1.ID = 20;
            emp1.Name = "JayaKrishna M";
            emp1.Designation = "TL";
            Console.WriteLine($"\n {emp1.ID}\t {emp1.Name}\t\t {emp1.Salary}");

            Employee emp2 = new Employee();
            emp2.ID = 30;
            emp2.Name = "Ushaa S";
            emp2.Designation = "HR";
            Console.WriteLine($"\n {emp2.ID}\t {emp2.Name}\t\t {emp2.Salary}");

            Employee emp3 = new Employee();
            emp3.ID = 40;
            emp3.Name = "Vihar D";
            emp3.Designation = "SD";
            Console.WriteLine($"\n {emp3.ID}\t {emp3.Name}\t\t {emp3.Salary}");

            Console.ReadLine();
        }
    }
}
