using System;

namespace T05.CharacterSequence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                Console.WriteLine(symbol);
            }
        }
    }
}
