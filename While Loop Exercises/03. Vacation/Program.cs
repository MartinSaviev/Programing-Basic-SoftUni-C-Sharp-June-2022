using System;

namespace _03._Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double neededMoney = double.Parse(Console.ReadLine());
            double avaliableMoney = double.Parse(Console.ReadLine());

            int daysCount = 0;
            int spendCount = 0;

            string input;
            double money;

            while (avaliableMoney < neededMoney)
            {
                input = Console.ReadLine();
                money = double.Parse(Console.ReadLine());
                daysCount++;

                if (input == "save")
                {
                    avaliableMoney += money;

                    spendCount = 0;
                }
                else
                {
                    spendCount++;

                    if (spendCount == 5)
                    {
                        Console.WriteLine($"You can't save the money.");
                        Console.WriteLine($"{daysCount}");
                        break;
                    }

                    avaliableMoney -= money;

                    if (avaliableMoney < 0)
                    {
                        avaliableMoney = 0;
                    }
                }
            }

            if (avaliableMoney >= neededMoney)
            {
                Console.WriteLine($"You saved the money for {daysCount} days.");
            }
        }
    }
}
