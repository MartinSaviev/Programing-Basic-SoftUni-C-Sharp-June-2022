using System;

namespace T08.BasketballEquipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double year = double.Parse(Console.ReadLine());

            double sneakers = year - (0.40 * year);
            double equipment = sneakers - (0.20 * sneakers);
            double ball = 1.0 / 4 * equipment;
            double acces = 1.0 / 5 * ball;
            double sum = (year + sneakers + equipment + ball + acces);

            Console.WriteLine($"{sum}");
        }
    }
}
