using System;

namespace Journey
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            string distance = "";
            string rest = "";
            double moneySpent = 0.0;

            if (season == "summer")
            {
                if (budget <= 100)
                {
                    rest = "Camp";
                    distance = "Bulgaria";
                    moneySpent = budget * 30 / 100;

                }
                else if (budget > 100 && budget <= 1000)
                {
                    rest = "Camp";
                    distance = "Balkans";
                    moneySpent = budget * 40 / 100;
                }
                else
                {
                    rest = "Hotel";
                    distance = "Europe";
                    moneySpent = budget * 90 / 100;
                }
            }

            else if (season == "winter")
            {
                if (budget <= 100)
                {
                    rest = "Hotel";
                    distance = "Bulgaria";
                    moneySpent = budget * 70 / 100;
                }
                else if (budget > 100 && budget <= 1000)
                {
                    rest = "Hotel";
                    distance = "Balkans";
                    moneySpent = budget * 80 / 100;
                }
                else
                {
                    rest = "Hotel";
                    distance = "Europe";
                    moneySpent = budget * 90 / 100;
                }
            }
            Console.WriteLine($"Somewhere in {distance}");
            Console.WriteLine($"{rest} - {moneySpent:f2}");
        }
    }
}
