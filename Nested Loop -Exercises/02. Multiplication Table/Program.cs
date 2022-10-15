using System;

namespace _02._Multiplication_Table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int firstNumber = 1; firstNumber <= 10; firstNumber++)
            {
                for (int secoundNumber = 1; secoundNumber <=10; secoundNumber++)
                {
                    Console.WriteLine($"{firstNumber} * {secoundNumber} = {firstNumber*secoundNumber}");
                }
            }
        }
    }
}
