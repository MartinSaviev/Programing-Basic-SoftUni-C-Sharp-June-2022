using System;

namespace _8.Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int examHour = int.Parse(Console.ReadLine());
            int examMin = int.Parse(Console.ReadLine());

            examMin = examMin + examHour * 60;

            int arrivalHour = int.Parse(Console.ReadLine());
            int arrivalMin = int.Parse(Console.ReadLine());

            arrivalMin = arrivalMin + arrivalHour * 60;

            int differene = examMin - arrivalMin;

            if (differene >= 0 && differene <= 30)
            {
                Console.WriteLine("On time");
                if (differene != 0)
                {
                    Console.WriteLine($"{differene} minutes before the start");
                }
            }
            else if (differene > 30)
            {
                Console.WriteLine("Early");
                if (differene < 60)
                {
                    Console.WriteLine($"{differene} minutes before the start");
                }
                else
                {
                    int diffHours = differene / 60;
                    int diffMin = differene % 60;
                    Console.WriteLine($"{diffHours}:{diffMin:d2} hours before the start");
                }
            }
            else
            {
                Console.WriteLine("Late");
            }
            differene = Math.Abs(differene);
            if (differene < 60)
            {
                Console.WriteLine($"{differene} minutes after the start");
            }
            else
            {
                int diffHours = differene / 60;
                int diffMin = differene % 60;
                Console.WriteLine($"{diffHours}:{diffMin:d2} hours after the start");
            }
        }
    }
}
