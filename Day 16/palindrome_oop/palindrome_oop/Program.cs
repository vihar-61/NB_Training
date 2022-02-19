using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_oop
{
    class Palindrome
    {
        int input;
        public int ReadData()
        {
            Console.WriteLine("\n***** Palindrome or Not *****");
            Console.WriteLine("\n Enter a number : ");
            input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        public bool Palin()
        {
            int rev = 0, r, x;
            x = input;
            while(x>0)
            {
                r = x % 10;
                x /= 10;
                rev = rev * 10 + r;
            }
            if (input == rev)
                return true;
            else
                return false;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Palindrome pal = new Palindrome();
            int input = pal.ReadData();
            bool Palin = pal.Palin();

            if(Palin == true)
                Console.WriteLine("\n Yes, its a Palindrome.");
            else
                Console.WriteLine("\n Its not a Palindrome.");

            Console.ReadLine();
        }
    }
}
