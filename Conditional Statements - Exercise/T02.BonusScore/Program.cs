using System;

namespace T02.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entryPoint = int.Parse(Console.ReadLine());

            double bonus = 0.0;

            if (entryPoint <= 100)
            {
                bonus = 5;
            }
            else if (entryPoint > 1000)
            {
                bonus = entryPoint * 0.1;
            }
            else
            {
                bonus = (entryPoint * 0.2);
            }
            if (entryPoint % 2 == 0)
            {
                bonus = bonus + 1;
            }
            else if (entryPoint % 10 == 5)
            {
                bonus += 2;
            }
            Console.WriteLine(bonus);
            Console.WriteLine(entryPoint + bonus);
        }
    }
}
