using System;

namespace T04.CleverLily
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ageLily = int.Parse(Console.ReadLine());
            decimal mashineWash = decimal.Parse(Console.ReadLine());
            int priceForToy = int.Parse(Console.ReadLine());

            int moneyPerCurrentBirthday = 10;

            decimal savedMoney = 0;
            int brToys = 0;
            for (int burthday = 1; burthday <= ageLily; burthday++)
            {
                if (burthday % 2 != 0)
                {
                    brToys++;
                }
                else
                {
                    savedMoney += moneyPerCurrentBirthday;
                    savedMoney--;
                    moneyPerCurrentBirthday += 10;

                }
            }
            savedMoney += brToys * priceForToy;

            if (savedMoney >= mashineWash)
            {
                Console.WriteLine($"Yes! {savedMoney - mashineWash:f2}");
            }
            else
            {
                Console.WriteLine($"No! {mashineWash - savedMoney}");
            }
        }
    }
}
