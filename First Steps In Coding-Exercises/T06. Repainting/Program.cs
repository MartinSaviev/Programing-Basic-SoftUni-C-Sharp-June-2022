using System;

namespace T06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nylon = double.Parse(Console.ReadLine());
            double paint = double.Parse(Console.ReadLine());
            double thinner = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());

            double priceNylon = (nylon * 1.50) + 3;
            double pricePaint = (paint * 14.50);
            double priceThiner = thinner * 5;
            double bag = 0.40;
            double Paint = pricePaint * 0.1;
            double priceAllMats = priceNylon + pricePaint + Paint + priceThiner + bag;
            double oneHourWork = priceAllMats * 0.3;
            double priceWorkers = oneHourWork * hours;
            double totalPrice = priceAllMats + priceWorkers;

            Console.WriteLine($"{totalPrice}");
        }
    }
}
