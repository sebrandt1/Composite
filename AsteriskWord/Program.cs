using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsteriskWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string final = string.Empty;

            for(int i = 0; i < input.Length; i++)
            {
                final += i % 2 == 1 ? '*' : input[i];
            }

            Console.WriteLine(final);

            Console.ReadKey();
        }
    }
}
