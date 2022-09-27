using System;

namespace Shop
{
    internal class Program
    {
       
        static void Main(string[] args)

        {
            string product = Console.ReadLine().ToLower();
            string town = Console.ReadLine().ToLower();
            double value = double.Parse(Console.ReadLine());

            double totalPrice = 0;

            if (town == "sofia")
            {
                if (product == "coffee")
                {
                    totalPrice = value * 0.50;
                }
                else if (product == "water")
                {
                    totalPrice = value * 0.80;
                }
                else if (product == "beer")
                {
                    totalPrice = value * 1.20;
                }
                else if (product == "sweets")
                {
                    totalPrice = value * 1.45;
                }
                else if (product == "peanuts")
                {
                    totalPrice = value * 1.60;
                }
                else
                {
                    Console.WriteLine("not valid");
                }
            }

            else if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                    totalPrice = value * 0.40;
                }
                else if (product == "water")
                {
                    totalPrice = value * 0.70;
                }
                else if (product == "beer")
                {
                    totalPrice = value * 1.15;
                }
                else if (product == "sweets")
                {
                    totalPrice = value * 1.30;
                }
                else if (product == "peanuts")
                {
                    totalPrice = value * 1.50;
                }
                else
                {
                    Console.WriteLine("not valid");
                }
            }

            else if (town == "varna")
            {
                if (product == "coffee")
                {
                    totalPrice = value * 0.45;
                }
                else if (product == "water")
                {
                    totalPrice = value * 0.70;
                }
                else if (product == "beer")
                {
                    totalPrice = value * 1.10;
                }
                else if (product == "sweets")
                {
                    totalPrice = value * 1.35;
                }
                else if (product == "peanuts")
                {
                    totalPrice = value * 1.55;
                }
                else
                {
                    Console.WriteLine("not valid");
                }
            }
            Console.WriteLine(totalPrice);
        }
    }
}