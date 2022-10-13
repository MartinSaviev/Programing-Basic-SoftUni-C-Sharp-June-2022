using System;

namespace _02._Exam_Preparation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numPoor = int.Parse(Console.ReadLine());

            string nameOfExam = string.Empty;
            double grade = 0;
            double sumOfAllGrade = 0;
            double numberPoorGrade = 0;
            double averageGrade = 0;
            bool flag = true;
            string lastExam = string.Empty;

            while (numberPoorGrade < numPoor)
            {
                lastExam = nameOfExam;
                nameOfExam = Console.ReadLine();

                if (nameOfExam == "Enough")
                {

                    Console.WriteLine($"Average score: {sumOfAllGrade / averageGrade:f2}");
                    Console.WriteLine($"Number of problems: {averageGrade}");
                    Console.WriteLine($"Last problem: {lastExam}");
                    flag = false;
                    break;

                }
                grade = int.Parse(Console.ReadLine());
                sumOfAllGrade += grade;
                averageGrade++;

                if (grade <= 4)
                {
                    numberPoorGrade++;
                }

            }
            if (flag)
            {              
                Console.WriteLine($"You need a break, {numberPoorGrade} poor grades.");
            }
        }
    }
}
