using System;

namespace _07._Min_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;

            string minNumber = Console.ReadLine();

            while (minNumber!="Stop")
            {
                int input = int.Parse(minNumber);

                if (input< min)
                {
                    min = input;
                }

                minNumber = Console.ReadLine();
            }
            Console.WriteLine(min);
        }
    }
}
