using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10methods_file_ops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Assigning a file path---------------------
            string filePath = @"C:\Users\vihar\Desktop\random\random.txt";

            //Creating a file---------------------
            StreamWriter sw = File.CreateText(filePath);
            sw.WriteLine("Hi, This is Vihar");
            sw.WriteLine("\nRandom Text !! (using WriteLine)");
            sw.Write("\nAnother random text !! (using Write)");
            sw.Write("\nContinued.....");
            sw.Close();

            //Appending a text---------------------
            sw = File.AppendText(filePath);
            sw.Write("\nAppending");
            sw.Write("\nrandom");
            sw.Write("\ntext message");
            Console.WriteLine("\n File is appended");
            sw.Close();

            //Reading a file---------------------
            StreamReader sr = File.OpenText(filePath);
            string x;
            Console.WriteLine("\n File reading");
            while((x = sr.ReadLine()) != null)
            {
                Console.WriteLine(x);
            }
            sr.Close();

            string fileNewPath = @"C:\Assignments_NH_Vihar\Day 15\random.txt";
            //Moving a file---------------------
            if (File.Exists(fileNewPath))
            {
                File.Delete(fileNewPath);
            }
            Console.WriteLine("\n deleting old path of text file...");
            File.Move(filePath, fileNewPath);
            Console.WriteLine("\n File path moved !");

            //Copying a text file---------------------
            File.Copy(fileNewPath, filePath);
            Console.WriteLine("\n File copied !");

            //Opening a text file---------------------
            File.OpenText(filePath).Close();
            Console.WriteLine("\n File opened without errors");

            string appendText = "\n adding AppendAllText method";
            File.AppendAllText(filePath, appendText, Encoding.UTF8);

            Console.WriteLine("\n Extra text appended");
            string readText = File.ReadAllText(filePath);

            Console.WriteLine("\n Reading all text from text file");
            Console.WriteLine(readText);
            Console.ReadLine();

        }
    }
}
