using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input
            string input = Console.ReadLine();
            //reverse the input and create a new string out of it
            string reverse = new string(input.ToCharArray().Reverse().ToArray());
            Console.WriteLine(reverse);

            Console.ReadKey();
        }
    }
}
