
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[4, 4];
            int sum = 0;
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    arr[i, j] = i + j;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (i == j)
                    {
                        sum = sum + arr[i, j];
                    }
                }
            }
            Console.WriteLine("Sum of diagonals is " + sum);
            Console.ReadLine();
        }
    }
}