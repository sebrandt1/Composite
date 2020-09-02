using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Dash
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string final = string.Empty;

            for(int i = 0; i < input.Length; i++)
            {
                final += input[i] + "-";
            }
            final = final.Remove(final.Length - 1);

            Console.WriteLine(final);


            Console.ReadKey();
        }
    }
}
