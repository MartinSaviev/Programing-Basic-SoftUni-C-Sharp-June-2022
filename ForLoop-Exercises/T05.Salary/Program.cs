using System;

namespace T05.Salary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int site = int.Parse(Console.ReadLine());
            int salary = int.Parse(Console.ReadLine());

            for (int tabs = 0; tabs < site; tabs++)
            {
                string openTabs = Console.ReadLine();

                switch (openTabs)
                {
                    case "Facebook":
                        salary -= 150;
                        break;
                    case "Instagram":
                        salary -= 100;
                        break;
                    case "Reddit":
                        salary -= 50;
                        break;
                }
            }
            if (salary > 0)
            {
                Console.WriteLine(salary);
            }
            else
            {
                Console.WriteLine("You have lost your salary.");
            }
        }
    }
}
