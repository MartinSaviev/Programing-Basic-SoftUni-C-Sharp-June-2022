using System;

namespace T09.FishTank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double lenght = double.Parse(Console.ReadLine());
            double width = double.Parse(Console.ReadLine());
            double height = double.Parse(Console.ReadLine());
            double percent = double.Parse(Console.ReadLine());

            double volumeAquarium = lenght * width * height;
            double volumeLiter = volumeAquarium / 1000;
            double bisySpace = percent / 100;
            double needLiter = volumeLiter * (1 - bisySpace);

            Console.WriteLine(needLiter);
        }
    }
}
