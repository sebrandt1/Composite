using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asterisk
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> dice1 = new List<int>();
            dice1.AddRange(Enumerable.Range(1, 6));

            dice1.ForEach(x => dice1.ForEach(y => Console.WriteLine($"{x},{y}")));


            Console.ReadKey();
        }
    }
}
