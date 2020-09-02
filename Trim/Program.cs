using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trim
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            if (input.First() == ' ')
            {
                input = input.Remove(0, 1);
            }
            if (input.Last() == ' ')
            {
                input = input.Remove(input.Length - 1);
            }

            Console.WriteLine(input);


            Console.ReadKey();
        }
    }
}
