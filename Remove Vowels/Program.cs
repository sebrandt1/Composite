using System;
using System.Linq;

namespace Remove_Vowels
{
    class Program
    {
        static void Main(string[] args)
        {
            string vowels = "aeiouyAEIOUY";

            string input = Console.ReadLine();
            string removedVowels = new string(input.Where(x => !vowels.Contains(x)).ToArray());

            Console.WriteLine(removedVowels);

            Console.ReadKey();
        }
    }
}
