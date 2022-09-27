using System;

namespace Trade_Commissions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            double sale = double.Parse(Console.ReadLine());
            double discount = 0;

            if (town == "Sofia")
            {
                if (0 <= sale && sale <= 500)
                {
                    discount = sale * 5 / 100;
                }
                else if (500 < sale && sale <= 1000)
                {
                    discount = sale * 7 / 100;
                }
                else if (1000 < sale && sale <= 10000)
                {
                    discount = sale * 8 / 100;
                }
                else if (sale > 10000)
                {
                    discount = sale * 12 / 100;
                }
            }

            else if (town == "Plovdiv")
            {
                if (0 <= sale && sale <= 500)
                {
                    discount = sale * 5.5 / 100;
                }
                else if (500 < sale && sale <= 1000)
                {
                    discount = sale * 8 / 100;
                }
                else if (1000 < sale && sale <= 10000)
                {
                    discount = sale * 12 / 100;
                }
                else if (sale > 10000)
                {
                    discount = sale * 14.5 / 100;
                }
            }

            else if (town == "Varna")
            {
                if (0 <= sale && sale <= 500)
                {
                    discount = sale * 4.5 / 100;
                }
                else if (500 < sale && sale <= 1000)
                {
                    discount = sale * 7.5 / 100;
                }
                else if (1000 < sale && sale <= 10000)
                {
                    discount = sale * 10 / 100;
                }
                else if (sale > 10000)
                {
                    discount = sale * 13 / 100;
                }
            }

            if ((town == "Sofia" || town == "Plovdiv" || town == "Varna") && discount != 0)
            {
                Console.WriteLine($"{discount:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}