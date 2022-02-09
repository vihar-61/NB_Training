using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interface_isshapes
{
    interface IShape
    {
        int calcPerimeter();
        int calcArea();
    }

    //Circle--------------------------------------------------
    class Circle : IShape
    {
        private int radius;
        public void ReadRadius()
        {
            Console.Write("\nenter radius value : ");
            radius = Convert.ToInt32(Console.ReadLine());
        }
        public int calcArea()
        {
            return 22 * radius * radius / 7;
        }
        public int calcPerimeter()
        {
            return 2 * 22 * radius / 7;
        }
    }

    //Square--------------------------------------------------
    class Square : IShape
    {
        private int side;
        public void ReadSide()
        {
            Console.Write("\nenter side of square : ");
            side = Convert.ToInt32(Console.ReadLine());
        }
        public int calcPerimeter()
        {
            return 4 * side;
        }
        public int calcArea()
        {
            return side * side;
        }
    }

    //Rectangle--------------------------------------------------
    class Rectangle : IShape
    {
        private int length;
        private int width;
        public void ReadSide()
        {
            Console.Write("\nenter length of rectangle : ");
            length = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nenter width of a rectangle : ");
            width = Convert.ToInt32(Console.ReadLine());
        }
        public int calcPerimeter()
        {
            return 2 * (length + width);
        }
        public int calcArea()
        {
            return length * width;
        }
    }

    //Triangle--------------------------------------------------
    class Triangle : IShape
    {
        private int a;
        private int b;
        private int c;
        public void ReadSides()
        {
            Console.WriteLine("\n****************************************************");
            Console.Write("\nenter side a of a Triangle : ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nenter side b of a Triangle : ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nenter side c of a Triangle : ");
            c = Convert.ToInt32(Console.ReadLine());
        }
        public int calcPerimeter()
        {
            return a + b + c;
        }
        public int calcArea()
        {
            double semiperimeter = (a + b + c) / 2;
            double Area = Math.Sqrt(semiperimeter * (semiperimeter - a) * 
                                    (semiperimeter - b) * (semiperimeter - c));
            return Convert.ToInt32(Area);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circ = new Circle();
            circ.ReadRadius();
            Console.WriteLine("------------------");
            Console.WriteLine($"\nPerimeter of Circle is : {circ.calcPerimeter()}");
            Console.WriteLine($"\nArea of Circle is : {circ.calcArea()}");
            Console.WriteLine("\n****************************************************");

            Square sq = new Square();
            sq.ReadSide();
            Console.WriteLine("------------------");
            Console.WriteLine($"\nPerimeter of Square is : {sq.calcPerimeter()}");
            Console.WriteLine($"\nArea of Square is : {sq.calcArea()}");
            Console.WriteLine("\n****************************************************");

            Rectangle rect = new Rectangle();
            rect.ReadSide();
            Console.WriteLine("------------------");
            Console.WriteLine($"\nPerimeter of Rectangle is : {rect.calcPerimeter()}");
            Console.WriteLine($"\nArea of Rectangle is : {rect.calcArea()}");
            Console.WriteLine("\n****************************************************");

            Triangle tri = new Triangle();
            tri.ReadSides();
            Console.WriteLine("------------------");
            Console.WriteLine($"\nPerimeter of given Triangle is : {tri.calcPerimeter()}");
            Console.WriteLine($"\nArea of Triangle is : {tri.calcArea()}");
            Console.WriteLine("\n****************************************************");

            Console.ReadLine();
        }
    }
}
