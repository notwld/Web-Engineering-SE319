using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    class task5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter target: ");
            int target = Convert.ToInt32(Console.ReadLine());
            int[] arr = { 1, 3, 5, 6 };
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == target)
                {
                    Console.WriteLine("Found");
                    break;
                }
                else
                {
                    Console.WriteLine("NotFound");

                }
            }
            Console.ReadKey();
        }
    }
}
