using System;

namespace FishBoat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int budget = int.Parse(Console.ReadLine());
            string seаson = Console.ReadLine();
            int fisherMan = int.Parse(Console.ReadLine());

            double price = 0.0;
            switch (seаson)
            {
                case "Spring":
                    price = 3000;
                    break;
                case "Summer":
                case "Autumn":
                    price = 4200;
                    break;

                default:
                    price = 2600;
                    break;
            }
            if (fisherMan <= 6)
            {
                price = price - price * 10 / 100;
            }
            else if (fisherMan <= 11)
            {
                price = price - price * 15 / 100;
            }
            else
            {
                price = price - price * 25 / 100;
            }

            if (fisherMan % 2 == 0 && seаson != "Autumn")
            {
                price = price - price * 5 / 100;
            }
            if (price <= budget)
            {
                Console.WriteLine($"Yes! You have {budget - price:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! You need {price - budget:f2} leva.");
            }
        }
    }
}
