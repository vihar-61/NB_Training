using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace copy_task_scheduler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\Assignments_NH_Vihar\Day 15\random.txt";

            string TaskSchedulerPath = @"C:\Assignments_NH_Vihar\Day 15\copy_folder\random.txt";
            if (File.Exists(TaskSchedulerPath))
            {
                File.Delete(TaskSchedulerPath);
            }
            File.Copy(filePath, TaskSchedulerPath);
            Console.WriteLine("\n File copied.!");
            Console.ReadKey();
        }
    }
}
