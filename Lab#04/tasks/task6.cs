using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    class tas6
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= 5; j++)
                {
                    if (j >= i)
                    {
                        k = j - i + 1;
                        Console.Write(k);
                    }
                    else
                    {
                        k = i - j + 1;
                        Console.Write(k);
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}

