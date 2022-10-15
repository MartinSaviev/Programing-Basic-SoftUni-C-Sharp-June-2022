using System;

namespace _04._Sum_of_Two_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());          
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int combinationCnt = 0;
            bool comboFound = false;

            for (int firstNum = start; firstNum <= end; firstNum++)
            {
                for (int secondNum = start; secondNum <= end; secondNum++)
                {
                    combinationCnt++;

                    if (firstNum + secondNum == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationCnt} ({firstNum} + {secondNum} = {magicNum})");
                        comboFound = true;
                        break;
                    }
                }

                if (comboFound)
                {
                    break;
                }
            }

            if (!comboFound)
            {
                Console.WriteLine($"{combinationCnt} combinations - neither equals {magicNum}");

            }
        }
    }
}
