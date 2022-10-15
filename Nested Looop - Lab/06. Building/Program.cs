using System;

namespace _06._Building
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int floors = int.Parse(Console.ReadLine());
            int apartments = int.Parse(Console.ReadLine());

            for (int fl = floors; fl >= 1; fl--)
            {
                for (int ap = 0; ap < apartments; ap++)
                {
                    if (fl == floors)
                    {
                        Console.Write($"L{fl}{ap} ");
                    }
                    else if (fl % 2 != 0)
                    {
                        Console.Write($"A{fl}{ap} ");
                    }
                    else if (fl % 2 == 0)
                    {
                        Console.Write($"O{fl}{ap} ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}
