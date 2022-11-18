using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    class task3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter start: ");
            int start = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter end: ");
            int end = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nOdd Number");

            while (start <= end)
            {
                if (start % 2 == 1)
                {
                    Console.WriteLine("Odd: {0}", start);
                }
                else
                {
                    Console.WriteLine("Even: {0}", start);
                }
            }
            Console.ReadKey();
        }
    }
}

