using System;

namespace T10._1.OddEvenSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int evenSum = 0;
            int oddSum = 0;
            int enterNumberOfUser = 0;

            for (int i = 1; i <= n; i++)
            {
                enterNumberOfUser = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    evenSum += enterNumberOfUser;
                }
                else
                {
                    oddSum += enterNumberOfUser;
                }
            }

            if (evenSum == oddSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine($"Sum = {evenSum}");
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine($"Diff = {Math.Abs(evenSum - oddSum)}");
            }
        }
    }
}



