using System;

namespace _4.ConvertorInchesToCenitmeters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sentimeturs = double.Parse(Console.ReadLine());
            double inch = 2.54;

            double sum = sentimeturs * inch;

            Console.WriteLine(sum);
        }

    }
}
