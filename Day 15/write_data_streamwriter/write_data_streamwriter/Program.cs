using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace write_data_streamwriter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creating a file using StreamWriter class
            StreamWriter sw = new StreamWriter(@"C:\Assignments_NH_Vihar\Day 15\streamwriter_ex.txt");
            sw.WriteLine("Hi this is VD");
            sw.WriteLine("\n Bunch of random text.");
            sw.Close();
            Console.WriteLine("\n File is written.");

            StreamWriter sw1 = new StreamWriter(@"C:\Assignments_NH_Vihar\Day 15\streamwriter_ex.txt", true);
            sw1.WriteLine("\n New object of StreamWriter class");
            sw1.WriteLine("\n More and more bunch of random text.");
            sw1.Close();
            Console.WriteLine("\n Data appended to file.");

            Console.ReadKey();
        }
    }
}
