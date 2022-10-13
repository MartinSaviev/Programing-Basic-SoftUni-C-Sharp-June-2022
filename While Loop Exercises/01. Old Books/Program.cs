using System;

namespace _01._Old_Books
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();

            string serchingBook = string.Empty;
            int br = -1;
            while (book != serchingBook)
            {
                if (serchingBook == "No More Books")
                {
                    Console.WriteLine($"The book you search is not here!");
                    Console.WriteLine($"You checked {br} books.");
                    break;
                }
                serchingBook = Console.ReadLine();
                br++;
            }

            if (book == serchingBook && book != "No More Books")
            {
                Console.WriteLine($"You checked {br} books and found it.");
            }
        }
    }
}
