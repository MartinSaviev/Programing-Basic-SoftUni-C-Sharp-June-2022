using System;

namespace Odd_Even_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int oddSum = 0;
            int evenSum = 0;
            for (int position = 1; position <= n; position++)
            {
                int num = int.Parse(Console.ReadLine());
                if (position % 2 == 0) evenSum += num;
                else oddSum += num;


            }
            if (oddSum==evenSum)
            {
                Console.WriteLine("Yes");
                Console.WriteLine("Sum = " + oddSum);
            }
            else
            {
                Console.WriteLine("No");
                Console.WriteLine("Diff = {0} ",Math.Abs(oddSum-evenSum));
            }
        }
    }
}
