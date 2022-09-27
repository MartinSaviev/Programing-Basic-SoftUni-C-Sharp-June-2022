using System;

namespace AnimalTipe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string animal = Console.ReadLine();

            switch (animal)
            {
                case "dog":
                    Console.WriteLine("mammal");
                    break;

                case "crocodile":
                case "tortoise":
                case "snake":
                    Console.WriteLine("reptile");
                    break;

                case "cat":
                    Console.WriteLine("unknown");
                    break;
            }
        }
    }
}
