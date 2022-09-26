using System;

namespace T0._2RadiusToDegreesConvertor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double gradus = (radians * 180 / Math.PI);

            Console.WriteLine(gradus);


        }
    }
}
