using System;

namespace T03.Histogram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int enterNumbers = 0;

            double P1 = 0;
            double p2 = 0;
            double p3 = 0;
            double p4 = 0;
            double p5 = 0;

            for (int i = 1; i <= n; i++)
            {
                enterNumbers = int.Parse(Console.ReadLine());

                if (enterNumbers < 200)
                {
                    P1++;
                }
                else if (enterNumbers <= 399)
                {
                    p2++;
                }
                else if (enterNumbers <= 599)
                {
                    p3++;
                }
                else if (enterNumbers <= 799)
                {
                    p4++;
                }
                else if (enterNumbers >= 800)
                {
                    p5++;
                }
            }

            P1 = P1 / n * 100;
            p2 = p2 / n * 100;
            p3 = p3 / n * 100;
            p4 = p4 / n * 100;
            p5 = p5 / n * 100;

            Console.WriteLine($"{P1:f2}%");
            Console.WriteLine($"{p2:f2}%");
            Console.WriteLine($"{p3:f2}%");
            Console.WriteLine($"{p4:f2}%");
            Console.WriteLine($"{p5:f2}%");
        }
    }
}
