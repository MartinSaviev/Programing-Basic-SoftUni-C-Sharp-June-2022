using System;

namespace WorkingHouers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aroundTheClock = int.Parse(Console.ReadLine());
            string dayOfWeek = Console.ReadLine();

            if (aroundTheClock >= 10 && aroundTheClock <= 18)
            {
                switch (dayOfWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":
                    case "Saturday":
                        Console.WriteLine("open");
                        break;

                    default:
                        Console.WriteLine("closed");
                        break;
                }            
            }
            else
            {
                Console.WriteLine("closed");
            }
        }
    }
}
