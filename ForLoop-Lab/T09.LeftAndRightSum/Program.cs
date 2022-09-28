using System;

namespace LeftAndRightSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int sum1 = 0;
            int enterNumberOfUser = 0;

            for (int i = 1; i <= number; i++)
            {
                enterNumberOfUser = int.Parse(Console.ReadLine());
                sum += enterNumberOfUser;
            }
            for (int i = 1; i <= number; i++)
            {
                enterNumberOfUser = int.Parse(Console.ReadLine());
                sum1 += enterNumberOfUser;
            }

            if (sum == sum1)
            {
                Console.WriteLine($"Yes, sum = {sum}");
            }
            else
            {
                Console.WriteLine($"No, diff = {Math.Abs(sum - sum1)}");
            }
        }
    }
}
