using System;

namespace _05._Account_Balance
{
    internal class Program
    {
        static void Main(string[] args)
        {     
            double bankAccount = 0.0;

            string input = (Console.ReadLine());

            while (input != "NoMoreMoney")
              
            {
                double increaseSum = double.Parse(input);

                if (increaseSum<0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }

                bankAccount += increaseSum;
                Console.WriteLine($"Increase: {increaseSum:F2}");
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total: {bankAccount:F2}");       
        }
    }
}
