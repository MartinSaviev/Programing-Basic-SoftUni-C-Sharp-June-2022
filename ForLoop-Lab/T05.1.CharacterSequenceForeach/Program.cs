using System;

namespace Symbols
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbols = Console.ReadLine();

            foreach (char letter in symbols)
            {
                Console.WriteLine(letter);
            }
        }
    }
}
