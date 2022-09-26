using System;

namespace T07.FoodDelivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double chikenMenu = double.Parse(Console.ReadLine());
            double fishMenu = double.Parse(Console.ReadLine());
            double veganMenu = double.Parse(Console.ReadLine());

            double PriceChikenMenu = chikenMenu * 10.35;
            double PriceFishMenu = fishMenu * 12.40;
            double PriceVeganMenu = veganMenu * 8.15;
            double priceForAllMenu = (PriceChikenMenu + PriceFishMenu + PriceVeganMenu);
            double delivery = 2.50;
            double dessert = priceForAllMenu * 0.2;

            double totalPriceDelivery = priceForAllMenu + dessert + delivery;

            Console.WriteLine(totalPriceDelivery);
        }
    }
}
