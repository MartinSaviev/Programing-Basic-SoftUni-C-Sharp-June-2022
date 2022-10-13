using System;

namespace T08.Tennis_Ranklist
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numberTournamens = int.Parse(Console.ReadLine());
            int startPointsOfRangList = int.Parse(Console.ReadLine());

            string finishTournament = string.Empty;
            double average = 0;
            double firstFinishTournament = 0;

            for (int i = 1; i <= numberTournamens; i++)
            {
                finishTournament = Console.ReadLine();

                if (finishTournament == "W")
                {
                    startPointsOfRangList += 2000;
                    average += 2000;
                    firstFinishTournament++;
                }
                else if (finishTournament == "F")
                {
                    startPointsOfRangList += 1200;
                    average += 1200;
                }
                else
                {
                    startPointsOfRangList += 720;
                    average += 720;
                }
            }

            double procent = (firstFinishTournament / numberTournamens) * 100;

            Console.WriteLine($"Final points: {startPointsOfRangList}");
            Console.WriteLine($"Average points: {Math.Floor(average / numberTournamens)}");
            Console.WriteLine($"{(procent):f2}%");
        }
    }
}
