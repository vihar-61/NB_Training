using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace div_3except_super
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int a, b, c;
                Console.WriteLine("\n enter dividend value : ");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\n enter divisor value to divide {a} : ");
                b = Convert.ToInt32(Console.ReadLine());
                c = a / b;
                Console.WriteLine($"\n division of {a} / {b} is {c}");
                Console.ReadLine();
            }
            //Overflow Exception-----------------------------------------
            catch (OverflowException)
            {
                Console.WriteLine("\n Please enter the number in range of 0 - 50000");
            }
            //DivideByZero Exception-----------------------------------------
            catch (DivideByZeroException)
            {
                Console.WriteLine("\n Please enter divisor value != 0");
            }
            //Format Exception-----------------------------------------
            catch (FormatException)
            {
                Console.WriteLine("\n Please enter integers only");
            }
            catch (Exception)
            {
                Console.WriteLine("\n Error 404, Please contact ADMIN.");
            }
            finally
            {
                Console.WriteLine("\n\n\n\n\n\n*********** Developed by Vihar D ***********");
                Console.ReadLine();
            }
        }
    }
}
