using System;

namespace T05.GodzillaVs.Kong
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            double budget = double.Parse(Console.ReadLine());
            int extra = int.Parse(Console.ReadLine());
            double priceForDress = double.Parse(Console.ReadLine());
        
            double decor = budget * 0.10;
            double priceForAllExtra = extra * priceForDress;

            if (extra > 150)
            {
                double discount = priceForAllExtra * 0.10;
                priceForAllExtra -= discount;
            }

            double totalPrice = priceForAllExtra + decor;

            if (budget >= totalPrice)
            {
                Console.WriteLine($"Action! \nWingard starts filming with {Math.Abs(totalPrice - budget):f2} leva left.");
            }
            
            else
            {
                Console.WriteLine($"Not enough money! \nWingard needs {Math.Abs(budget - totalPrice):f2} leva more.");
            }
        }
    }
}
