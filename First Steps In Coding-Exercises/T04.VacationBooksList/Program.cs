using System;

namespace T04.VacationBooksList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pageOfBook = int.Parse(Console.ReadLine());
            int pageOfHouer = int.Parse(Console.ReadLine());
            int daysReadBook = int.Parse(Console.ReadLine());

            int timeOfRead = pageOfBook / pageOfHouer;
            int HouerOfday = timeOfRead / daysReadBook;

            Console.WriteLine(HouerOfday);
        }
    }
}
