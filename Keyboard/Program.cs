using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Keyboard
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string removed = input.Remove(input.Length - 1);

            Console.WriteLine(removed);


            Console.ReadKey();
        }
    }
}
