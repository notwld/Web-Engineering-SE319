using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static double calculator(double a, String op, double b)
        {
            if (op == "+")
            {
                return a + b;
            }
            else if (op == "-")
            {
                return a - b;
            }
            else if (op == "*")
            {
                return a * b;
            }
            else if (op == "/")
            {
                return a / b;
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter op: ");
            String op = Console.ReadLine();
            Console.WriteLine("Enter b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Result : {0}", calculator(a, op, b));
            Console.ReadKey();
        }
    }
}
