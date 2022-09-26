using System;

namespace T03.DepositCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double increase = deposit * percent / 100;

            double increaseForOneMoth = increase / 12;

            double sum = deposit + months * increaseForOneMoth;

            Console.WriteLine($"{sum:f2}");
        }
    }
}
