using System;

namespace T02._1.BonusScore
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double num = int.Parse(Console.ReadLine());
            double poitEven = 0;
            double numFinishFive = 0;
            double bonus1 = 0;
            double bonus2 = 0;
            double bonus3 = 0;

            if (num <= 100)
            {
                bonus1 += 5;
            }
            else if (num <= 1000)
            {
                bonus2 = num * 0.20;
            }
            else
            {
                bonus3 = num * 0.10;
            }

            if (num % 2 == 0)
            {
                poitEven++;
            }
            if (num % 10 == 5)
            {
                numFinishFive += 2;
            }
            double totalBonus = poitEven + numFinishFive + bonus1 + bonus2 + bonus3;
            double totalSum = num + totalBonus;

            Console.WriteLine(totalBonus);
            Console.WriteLine(totalSum);
        }
    }
}
