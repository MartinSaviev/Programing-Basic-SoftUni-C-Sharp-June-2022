using System;

namespace _06._Max_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            int max = int.MinValue;
            string text = Console.ReadLine();

            while (text!="Stop")
            {                         
                int number = int.Parse(text);

                if (number>max)
                {
                    max = number;
                }

                text = Console.ReadLine();
            }

            Console.WriteLine(max);
        }
    }
}
