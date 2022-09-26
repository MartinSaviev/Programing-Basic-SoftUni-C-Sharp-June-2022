using System;

namespace T0._1_UsdToBgnConvertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal usd = decimal.Parse(Console.ReadLine());
            decimal bgn = (usd * 1.79549m);

            Console.WriteLine(bgn);

        }
    }
}
