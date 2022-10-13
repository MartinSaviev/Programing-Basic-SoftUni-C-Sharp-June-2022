using System;

namespace _03._Sum_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int maxNumber = int.Parse(Console.ReadLine());

            int number = 0;
            int sum = 0;

            while (sum < maxNumber)
            {
                number =int.Parse(Console.ReadLine());
                sum = sum + number;          
            }
            Console.WriteLine(sum);
        }
    }
}
