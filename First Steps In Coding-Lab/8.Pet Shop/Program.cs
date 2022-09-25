using System;

namespace _8.Pet_Shop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double NumberOfdogsMeal = double.Parse(Console.ReadLine());
            double NumberOfcatsMeal = double.Parse(Console.ReadLine());

            double dogs = 2.50;
            int cats = 4;

            double sumDogs = NumberOfdogsMeal * dogs;
            double sumCats = NumberOfcatsMeal * cats;

            double finalSum = sumDogs + sumCats;
            Console.WriteLine($"{finalSum} lv.");


        }
    }
}
