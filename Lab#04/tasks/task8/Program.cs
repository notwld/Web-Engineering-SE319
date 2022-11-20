using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task8
{
    class Circle
    {
        public double radius;
        public double area;
        public Circle(double radius)
        {
            this.radius = radius;
        }
        public double Area()
        {
            area = 3.14 * radius * radius;
            return area;
        }
    }
    class Triangle
    {
        public double base1;
        public double height;
        public double area;
        public Triangle(double base1, double height)
        {
            this.base1 = base1;
            this.height = height;
        }
        public double Area()
        {
            area = 0.5 * base1 * height;
            return area;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Circle c = new Circle(5);
            Console.WriteLine("The area of the circle is: " + c.Area());
            Triangle t = new Triangle(5, 6);
            Console.WriteLine("The area of the triangle is: " + t.Area());
            Console.ReadLine();
        }
    }
}
