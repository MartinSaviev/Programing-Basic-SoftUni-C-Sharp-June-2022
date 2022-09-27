using System;

namespace SmallShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string town = Console.ReadLine();
            double price = double.Parse(Console.ReadLine());

            switch (product + town)
            {

                case "coffee" + "Sofia":
                    Console.WriteLine(price * 0.50);
                    break;
                case "water" + "Sofia":
                    Console.WriteLine(price * 0.80);
                    break;
                case "beer" + "Sofia":
                    Console.WriteLine(price * 1.20);
                    break;
                case "sweets" + "Sofia":
                    Console.WriteLine(price * 1.45);
                    break;

                case "peanuts" + "Sofia":
                    Console.WriteLine(price * 1.60);
                    break;

                case "coffee" + "Plovdiv":
                    Console.WriteLine(price * 0.40);
                    break;
                case "water" + "Plovdiv":
                    Console.WriteLine(price * 0.70);
                    break;
                case "beer" + "Plovdiv":
                    Console.WriteLine(price * 1.15);
                    break;
                case "sweets" + "Plovdiv":
                    Console.WriteLine(price * 1.30);
                    break;
                case "peanuts" + "Plovdiv":
                    Console.WriteLine(price * 1.50);
                    break;

                case "coffee" + "Varna":
                    Console.WriteLine(price * 0.45);
                    break;
                case "water" + "Varna":
                    Console.WriteLine(price * 0.70);
                    break;
                case "beer" + "Varna":
                    Console.WriteLine(price * 1.10);
                    break;
                case "sweets" + "Varna":
                    Console.WriteLine(price * 1.35);
                    break;
                case "peanuts" + "Varna":
                    Console.WriteLine(price * 1.55);
                    break;
            }
        }
    }
}
