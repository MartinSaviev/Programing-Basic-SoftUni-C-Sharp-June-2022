using System;

namespace NewHouse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string flowers = Console.ReadLine();



            string flowerType = Console.ReadLine();
            int numFlowers = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double pricePerFlower = 0;
            double totalPrice = 0;

            switch (flowerType)
            {
                case "Roses":
                    pricePerFlower = 5;

                    if (numFlowers > 80)
                    {
                        totalPrice = (numFlowers * pricePerFlower) - (numFlowers * pricePerFlower) * 0.10;
                    }
                    else
                    {
                        totalPrice = (numFlowers * pricePerFlower);
                    }
                    break;

                case "Dahlias":
                    pricePerFlower = 3.80;

                    if (numFlowers > 90)
                    {
                        totalPrice = (numFlowers * pricePerFlower) - (numFlowers * pricePerFlower) * 0.15;
                    }
                    else
                    {
                        totalPrice = (numFlowers * pricePerFlower);
                    }
                    break;

                case "Tulips":
                    pricePerFlower = 2.80;
                    if (numFlowers > 80)
                    {
                        totalPrice = (numFlowers * pricePerFlower) - (numFlowers * pricePerFlower) * 0.15;
                    }
                    else
                    {
                        totalPrice = (numFlowers * pricePerFlower);
                    }
                    break;

                case "Narcissus":
                    pricePerFlower = 3;
                    if (numFlowers < 120)
                    {
                        totalPrice = (numFlowers * pricePerFlower) + (numFlowers * pricePerFlower) * 0.15;
                    }
                    else
                    {
                        totalPrice = (numFlowers * pricePerFlower);
                    }
                    break;

                case "Gladiolus":
                    pricePerFlower = 2.5;
                    if (numFlowers < 80)
                    {
                        totalPrice = (numFlowers * pricePerFlower) + (numFlowers * pricePerFlower) * 0.2;
                    }
                    else
                    {
                        totalPrice = (numFlowers * pricePerFlower);
                    }
                    break;
            }
            if (budget >= totalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {numFlowers} {flowerType} and {(budget - totalPrice):F2} leva left.");
            }
            else
            {
                Console.WriteLine($"Not enough money, you need {(totalPrice - budget):F2} leva more.");
            }
        }
    }
}
