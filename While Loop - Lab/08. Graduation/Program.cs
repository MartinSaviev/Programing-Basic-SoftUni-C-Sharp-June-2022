using System;

namespace _08._Graduation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();

            double grade = 0;
            int course = 1;
            int cutCounter = 0;
            bool hasGraduated = true;
            double averageGrade = 0;

            while (course <= 12)
            {
                grade = double.Parse(Console.ReadLine());
                averageGrade += grade;
                if (grade < 4)
                {
                    if (cutCounter > 0)
                    {
                        Console.WriteLine($"{studentName} has been excluded at {--course} grade");
                        hasGraduated = false;
                        break;
                    }
                    cutCounter++;
                }
                course++;
            }

            if (hasGraduated)
            {
                averageGrade /= 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
            }
        }
    }
}
