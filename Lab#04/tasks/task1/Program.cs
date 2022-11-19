using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task1
{
    class Program
    {
        static double area_of_circle(double radius)
        {
            return Math.PI * (Math.Pow(radius, 2));
        }
        static double area_of_triangle(double height, double baseOfTri)
        {
            return (height * baseOfTri) / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Radius: ");
            double radius = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of Circle: {0}", area_of_circle(radius));
            Console.WriteLine("Enter Height: ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Base: ");
            double baseOfTri = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Area of Triangle: {0}",
            area_of_triangle(height, baseOfTri));
            Console.ReadKey();
        }
    }
}