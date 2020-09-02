using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_A_s
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int aCount = input.Count(x => x == 'a');

            Console.WriteLine(aCount);



            Console.ReadKey();
        }
    }
}
