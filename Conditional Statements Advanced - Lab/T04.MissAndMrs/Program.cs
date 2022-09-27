using System;

namespace MissAndMrs_
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double age = double.Parse(Console.ReadLine());
            string titles = Console.ReadLine();

            if (age >= 16)
            {
                if (titles == "m")
                {
                    Console.WriteLine("Mr.");
                }
            }

            if (age < 16)
            {
                if (titles == "m")
                {
                    Console.WriteLine("Master");
                }
            }

            if (age >= 16)
            {
                if (titles == "f")
                {
                    Console.WriteLine("Ms.");
                }
            }

            if (age < 16)
            {
                if (titles == "f")
                {
                    Console.WriteLine("Miss");
                }
            }
        }
    }
}
