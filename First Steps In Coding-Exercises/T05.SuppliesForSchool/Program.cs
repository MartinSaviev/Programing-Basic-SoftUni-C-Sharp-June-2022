using System;

namespace T05.SuppliesForSchool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pen = int.Parse(Console.ReadLine());
            int marker = int.Parse(Console.ReadLine());
            int preparation = int.Parse(Console.ReadLine());
            int percentDiscount = int.Parse(Console.ReadLine());

            double packagePen = pen * 5.80;
            double packageMarker = marker * 7.20;
            double pricePreparation = preparation * 1.20;
            double sumAllProduct = (packagePen + packageMarker + pricePreparation);
            double discount = sumAllProduct * percentDiscount / 100;
            double totalPrice = sumAllProduct - discount;

            Console.WriteLine($"{totalPrice}");
        }
    }
}
