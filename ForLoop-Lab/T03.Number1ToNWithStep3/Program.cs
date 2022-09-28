using System;

namespace Number1ToNWithStep3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num += 3)
            {
                Console.WriteLine(num);
            }              
        }
    }
}
