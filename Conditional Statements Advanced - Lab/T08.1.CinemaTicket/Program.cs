using System;

namespace CinemaTicketSwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayOfWeekPrice = Console.ReadLine();

            switch (dayOfWeekPrice)
            {
                case "Monday":
                case "Tuesday":
                case "Friday":
                    Console.WriteLine("12");
                    break;
                case "Wednesday":
                case "Thursday":
                    Console.WriteLine("14");
                    break;
                case "Saturday":
                    Console.WriteLine("16");
                    break;
                case "Sunday":
                    Console.WriteLine("16");
                    break;
            }
        }
    }
}
