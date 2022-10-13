using System;

namespace T07.Trekking_Mania
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfGropus = int.Parse(Console.ReadLine());

            int numberOfPeopleinGroup = 0;
            int allPeople = 0;
            double musala = 0;
            double monblan = 0;
            double kilimandjaro = 0;
            double k2 = 0;
            double everest = 0;

            for (int i = 1; i <= numberOfGropus; i++)
            {
                numberOfPeopleinGroup = int.Parse(Console.ReadLine());
                allPeople += numberOfPeopleinGroup;

                if (numberOfPeopleinGroup <= 5)
                {
                    musala += numberOfPeopleinGroup;
                }
                else if (numberOfPeopleinGroup > 5 && numberOfPeopleinGroup <= 12)
                {
                    monblan += numberOfPeopleinGroup;
                }
                else if (numberOfPeopleinGroup > 12 && numberOfPeopleinGroup <= 25)
                {
                    kilimandjaro += numberOfPeopleinGroup;
                }
                else if (numberOfPeopleinGroup > 25 && numberOfPeopleinGroup <= 40)
                {
                    k2 += numberOfPeopleinGroup;
                }
                else if (numberOfPeopleinGroup > 40)
                {
                    everest += numberOfPeopleinGroup;
                }
            }

            double climbMusala = musala / allPeople * 100;
            double climbMonblan = monblan / allPeople * 100;
            double climbKilimandjaro = kilimandjaro / allPeople * 100;
            double climbk2 = k2 / allPeople * 100;
            double climbEverest = everest / allPeople * 100;

            Console.WriteLine($"{climbMusala:f2}%");
            Console.WriteLine($"{climbMonblan:f2}%");
            Console.WriteLine($"{climbKilimandjaro:f2}%");
            Console.WriteLine($"{climbk2:f2}%");
            Console.WriteLine($"{climbEverest:f2}%");
        }
    }
}
