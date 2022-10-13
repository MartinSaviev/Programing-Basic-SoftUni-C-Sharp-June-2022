using System;

namespace _06._Cake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());

            int cakeSize = w * h;

            string input = Console.ReadLine();
            int cakePeieces;

            while (input != "STOP")
            {
                cakePeieces = int.Parse(input);

                if (cakeSize >= cakePeieces)
                {
                    cakeSize -= cakePeieces;
                }
                else
                {
                    Console.WriteLine($"No more cake left! You need {cakePeieces - cakeSize} pieces more.");
                    cakeSize = 0;
                    break;
                }

                input = Console.ReadLine();
            }

            if (cakeSize > 0)
            {
                Console.WriteLine($"{cakeSize} pieces are left.");
            }
        }
    }
}
