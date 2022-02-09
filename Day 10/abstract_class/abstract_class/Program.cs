using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    //Abstract class----------------------------
    abstract class Salary
    {
        //For calculating PF ----------------------------
        public int GetPF(int basic)
        {
            return 12 * basic / 100;
        }
        //For calculating HRA----------------------------
        public int GetHRA(int basic)
        {
            return 40 * basic / 100;
        }
        //For Calculating CA----------------------------
        public abstract int GetCA();

        //For Calculating SA----------------------------
        public abstract int GetSA();

    }
    // Facebook Salary Allowance----------------------------
    class FacebookMeta : Salary
    {
        public override int GetCA()
        {
            return 4000;
        }
        public override int GetSA()
        {
            return 5000;
        }
    }
    // Amazon Salary Allowance----------------------------
    class Amazon : Salary
    {
        public override int GetCA()
        {
            return 8000;
        }
        public override int GetSA()
        {
            return 9000;
        }
    }
    // Netflix Salary Allowance----------------------------
    class Netflix : Salary
    {
        public override int GetCA()
        {
            return 10000;
        }
        public override int GetSA()
        {
            return 12000;
        }
    }
    // Google Salary Allowance----------------------------
    class Google : Salary
    {
        public override int GetCA()
        {
            return 14000;
        }
        public override int GetSA()
        {
            return 16000;
        }
    }
    internal class Program
    {
        // FANG Salary Allowances----------------------------
        // FacebookMeta
        // Amazon
        // Netflix
        // Google
        static void Main(string[] args)
        {
            Console.WriteLine("Process Completed !!");
            Console.ReadLine();

        }
    }
}
