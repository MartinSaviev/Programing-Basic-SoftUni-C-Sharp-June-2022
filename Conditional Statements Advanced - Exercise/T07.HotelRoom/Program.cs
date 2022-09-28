using System;

namespace HotelRoom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mount = Console.ReadLine();
            double apartamentForNights = double.Parse(Console.ReadLine());

            double priceForStudio = 0.0;
            double priceForApartament = 0.0;

            switch (mount)
            {
                case "May":
                case "October":
                    priceForStudio = 50.0;
                    priceForApartament = 65.0;
                    break;
                case "June":
                case "September":
                    priceForStudio = 75.20;
                    priceForApartament = 68.70;
                    break;
                case "July":
                case "August":
                    priceForStudio = 76;
                    priceForApartament = 77.0;
                    break;
            }
            if (mount == "May" || mount == "October")
            {
                if (apartamentForNights <= 7)
                {
                    priceForStudio *= apartamentForNights;
                }
                else if (apartamentForNights > 7 && apartamentForNights <= 14)
                {
                    priceForStudio = (apartamentForNights * priceForStudio);
                    priceForStudio = priceForStudio - priceForStudio * 5 / 100;
                }
                else if (apartamentForNights > 14)
                {
                    priceForStudio = apartamentForNights * priceForStudio;
                    priceForStudio = priceForStudio - priceForStudio * 30 / 100;
                }
            }

            if (mount == "June" || mount == "September")
            {
                if (apartamentForNights <= 14)
                {
                    priceForStudio = apartamentForNights * priceForStudio;
                }
                if (apartamentForNights > 14)
                {
                    priceForStudio = apartamentForNights * priceForStudio;
                    priceForStudio = priceForStudio - priceForStudio * 20 / 100;
                }
            }
            if (mount == "July" || mount == "August")
            {
                priceForStudio = apartamentForNights * priceForStudio;
            }

            switch (mount)
            {
                case "May":
                case "October":
                case "June":
                case "September":
                case "July":
                case "August":
                    break;
            }
            if (apartamentForNights <= 14)
            {
                priceForApartament = apartamentForNights * priceForApartament;
            }
            else if (apartamentForNights > 14)
            {
                priceForApartament = apartamentForNights * priceForApartament;
                priceForApartament = priceForApartament - priceForApartament * 10 / 100;
            }

            Console.WriteLine($"Apartment: {priceForApartament:f2} lv.");
            Console.WriteLine($"Studio: {priceForStudio:f2} lv.");
        }
    }
}