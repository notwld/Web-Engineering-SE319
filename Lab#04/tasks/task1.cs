using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace tasks
{
    class task1
    {
        static double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        static double TriangleArea(double height, double baseOfTri)
        {
            return (height * baseOfTri) / 2;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the radius of the circle");
            double radius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the height of the triangle");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the base of the triangle");
            double baseOfTri = Convert.ToDouble(Console.ReadLine());

            double areaOfCircle = CircleArea(radius);
            double areaOfTriangle = TriangleArea(height, baseOfTri);

            Console.WriteLine("The area of the circle is {0}", areaOfCircle);
            Console.WriteLine("The area of the triangle is {0}", areaOfTriangle);

            Console.ReadKey();
        }
    }
}