using System;

namespace T06.Oscars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string actorNmae = Console.ReadLine();
            double pointAcademy = double.Parse(Console.ReadLine());
            int numberRate = int.Parse(Console.ReadLine());

            string rate = string.Empty;

            double sum = 0;
            double pointRate = 0;

            for (int i = 1; i <= numberRate; i++)
            {
                rate = Console.ReadLine();
                pointRate = double.Parse(Console.ReadLine());

                sum = rate.Length * pointRate / 2;
                pointAcademy += sum;

                if (pointAcademy >= 1250.5)
                {
                    Console.WriteLine($"Congratulations, {actorNmae} got a nominee for leading role with {pointAcademy:f1}!");
                    break;
                }             
            }
            if (pointAcademy <= 1250.5)
            {
                Console.WriteLine($"Sorry, {actorNmae} you need {1250.5 - pointAcademy:f1} more!");
            }
        }
    }
}
