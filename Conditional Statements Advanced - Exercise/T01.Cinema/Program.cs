using System;

namespace Conditional_Statements_Advanced___Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string cinema = Console.ReadLine();
            int rows = int.Parse(Console.ReadLine());
            int colums = int.Parse(Console.ReadLine());

            double income = 0.0;
            double sum = rows * colums;

            if (cinema == "Premiere")
            {
                income = sum * 12.00;
            }
            else if (cinema == "Normal")
            {
                income = sum * 7.50;
            }
            else
            {
                income = sum * 5.00;
            }
            Console.WriteLine($"{income:f2} leva");
        }
    }
}
