using System;

namespace _02._Password
{
    internal class Program
    {
        static void Main(string[] args)
        {       
            string name =Console.ReadLine();
            string password = Console.ReadLine();

            string input = string.Empty;

            while (input!= password)
            {
              input = Console.ReadLine();             
            }
            Console.WriteLine($"Welcome {name}!");
        }
    }
}
