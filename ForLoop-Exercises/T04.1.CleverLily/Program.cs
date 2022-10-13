using System;

namespace T04._1.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int LiliAge = int.Parse(Console.ReadLine());
            double washMashine = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            double saveMoney = 0;
            int moneyForBirtday = 0;

            for (int burthday = 1; burthday <= LiliAge; burthday++)
            {
                if (burthday % 2 == 0)
                {
                    moneyForBirtday = burthday * 5;
                    moneyForBirtday--;
                    saveMoney += moneyForBirtday;
                }
                else if (burthday % 2 != 0)
                {
                    saveMoney += toyPrice;
                }
            }
            if (saveMoney >= washMashine)
            {
                Console.WriteLine($"Yes! {saveMoney - washMashine:f2}");
            }
            else
            {
                Console.WriteLine($"No! {washMashine - saveMoney:f2}");
            }
        }
    }
}
