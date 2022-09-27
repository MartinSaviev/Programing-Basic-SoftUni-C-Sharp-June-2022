using System;

namespace T04.ToyShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double priceForExcursion = double.Parse(Console.ReadLine());
            double numberPuzle = double.Parse(Console.ReadLine());
            double numberDolls = double.Parse(Console.ReadLine());
            double numberBears = double.Parse(Console.ReadLine());
            double numberMinions = double.Parse(Console.ReadLine());
            double numberTruck = double.Parse(Console.ReadLine());

            double puzle = 2.60;
            double dols = 3.00;
            double bear = 4.10;
            double minion = 8.20;
            double truck = 2.00;

            double discount = 0;
            double rent = 0;

            double priceAllToys = numberPuzle * puzle + numberDolls * dols +
                numberBears * bear + numberMinions * minion + numberTruck * truck;

            double numberAllToys = numberPuzle + numberDolls + numberBears + numberMinions + numberTruck;


            if (numberAllToys >= 50)
            {
                discount = priceAllToys * 0.25;
                priceAllToys -= discount;
            }

            rent = priceAllToys * 0.10;
            priceAllToys -= rent;
            double moneyLeft = priceAllToys - priceForExcursion;

            if (priceAllToys >= priceForExcursion)
            {
                Console.WriteLine($"Yes! {moneyLeft:f2} lv left.");
            }
            else
            {
                Console.WriteLine($"Not enough money! {Math.Abs(priceForExcursion - priceAllToys):f2} lv needed.");
            }
        }
    }
}
