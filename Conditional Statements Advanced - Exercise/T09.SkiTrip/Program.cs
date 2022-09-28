using System;

namespace SkiTrip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double daysForStay = double.Parse(Console.ReadLine());
            string tipeOfroom = Console.ReadLine();
            string rating = Console.ReadLine();

            double roomForOnePerson = 18.00;

            double apartment = 25.00;
            double presidentApartment = 35.00;

            daysForStay=daysForStay-1;

            if (tipeOfroom== "apartment"&& daysForStay<10)
            {
                daysForStay = daysForStay * apartment;
                daysForStay = daysForStay-daysForStay * 30 / 100;
            }
            else if (tipeOfroom == "apartment" && daysForStay >=10 && daysForStay<=15)
            {
                daysForStay = daysForStay * apartment;
                daysForStay = daysForStay - daysForStay * 35 / 100;
            }
            else if (tipeOfroom == "apartment" && daysForStay >15)
            {
                daysForStay = daysForStay * apartment;
                daysForStay = daysForStay - daysForStay * 50 / 100;
            }
            
            if (tipeOfroom == "president apartment" && daysForStay < 10)
            {
                daysForStay = daysForStay * presidentApartment;
                daysForStay = daysForStay - daysForStay * 10 / 100;
            }
            else if (tipeOfroom == "president apartment" && daysForStay >= 10 && daysForStay <= 15)
            {
                daysForStay = daysForStay * presidentApartment;
                daysForStay = daysForStay - daysForStay * 15 / 100;
            }
            else if (tipeOfroom == "president apartment" && daysForStay > 15)
            {
                daysForStay = daysForStay * presidentApartment;
                daysForStay = daysForStay - daysForStay * 20 / 100;
            }
            else if (tipeOfroom=="room for one person")
            {
                daysForStay *= roomForOnePerson;
            }

            if (rating== "positive")
            {
                daysForStay = daysForStay + daysForStay * 25 / 100;
            }
            else if (rating== "negative")
            {
                daysForStay = daysForStay - daysForStay * 10 / 100;
            }

            Console.WriteLine($"{daysForStay:f2}");
        }   
    }
}
