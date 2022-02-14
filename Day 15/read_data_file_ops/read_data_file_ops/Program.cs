using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace read_data_file_ops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a file 
            StreamWriter sw = new StreamWriter(@"C:\Assignments_NH_Vihar\Day 15\streamwriter_ex.txt", true);
            sw.WriteLine("\n Object of StreamWriter");
            sw.WriteLine("\n Bunch of random text.");
            sw.Close();
            Console.WriteLine("\n File is appended.");

            //Reading the file
            StreamReader sr = new StreamReader(@"C:\Assignments_NH_Vihar\Day 15\streamwriter_ex.txt");
            sr.ReadToEnd();
            sr.Close();
            Console.WriteLine("\n File is read.");

            Console.ReadKey();
        }
    }
}
