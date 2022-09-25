using System;

namespace _7.Projects_Creation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int project = int.Parse(Console.ReadLine());
            int houers = project * 3;

            Console.WriteLine($"The architect {name} will need {houers} hours to complete {project} project/s.");
        }
    }
}
