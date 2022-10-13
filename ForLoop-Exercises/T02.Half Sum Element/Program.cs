using System;

namespace T02.Half_Sum_Element
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int sumForAllNumber = 0;
            int enterNumberOfUser = 0;
            int maxNumber = 0;

            for (int i = 1; i <= n; i++)
            {
                enterNumberOfUser = int.Parse(Console.ReadLine());
                sumForAllNumber += enterNumberOfUser;
                if (enterNumberOfUser > maxNumber)
                {
                    maxNumber = enterNumberOfUser;
                }

            }

            int totalSum = sumForAllNumber - maxNumber;

            if (totalSum == maxNumber)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {totalSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(maxNumber - totalSum)}");
            }
        }
    }
}
