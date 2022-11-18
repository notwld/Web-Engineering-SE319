using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    class task4
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter String: ");
            string str = Convert.ToString(Console.ReadLine());

            string reverse = "";

            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse += str[i];
            }
            Console.WriteLine("Orignal String: {0}", str);
            Console.WriteLine("Reverse String: {0}", reverse);
            
            Console.ReadKey();
        }
    }
}
