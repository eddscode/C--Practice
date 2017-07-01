using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            int var1, var2;
            Console.WriteLine("Please enter a number:");
            var1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number:");
            var2 = Convert.ToInt32(Console.ReadLine());
            if (var1 > 10 || var2 > 10)
            {
                Console.WriteLine("One of the values is higher than 10.");
            }
            Console.ReadKey();
        }
    }
}
