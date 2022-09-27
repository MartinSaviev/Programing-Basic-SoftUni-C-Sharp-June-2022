using System;

namespace FrutiesShop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string frutis = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double priceFruits = double.Parse(Console.ReadLine());

            if (frutis == "banana")
            {
                switch (dayOfWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":

                        Console.WriteLine($"{priceFruits * 2.50:f2}");
                        break;

                    case "Sunday":
                    case "Saturday":

                        Console.WriteLine($"{priceFruits * 2.70:f2}");

                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else if (frutis == "apple")
            {
                switch (dayOfWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":

                        Console.WriteLine($"{priceFruits * 1.20:f2}");
                        break;
                    case "Sunday":
                    case "Saturday":

                        Console.WriteLine($"{priceFruits * 1.25:f2}");

                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else if (frutis == "orange")
            {
                switch (dayOfWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":

                        Console.WriteLine($"{priceFruits * 0.85:f2}");
                        break;
                    case "Sunday":
                    case "Saturday":

                        Console.WriteLine($"{priceFruits * 0.90:f2}");

                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else if (frutis == "grapefruit")
            {
                switch (dayOfWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":

                        Console.WriteLine($"{priceFruits * 1.45:f2}");
                        break;
                    case "Sunday":
                    case "Saturday":

                        Console.WriteLine($"{priceFruits * 1.60:f2}");

                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else if (frutis == "kiwi")
            {
                switch (dayOfWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":

                        Console.WriteLine($"{priceFruits * 2.70:f2}");
                        break;
                    case "Sunday":
                    case "Saturday":

                        Console.WriteLine($"{priceFruits * 3.00:f2}");

                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }

            else if (frutis == "pineapple")
            {
                switch (dayOfWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":

                        Console.WriteLine($"{priceFruits * 5.50:f2}");
                        break;
                    case "Sunday":
                    case "Saturday":

                        Console.WriteLine($"{priceFruits * 5.60:f2}");

                        break;
                    default:
                        Console.WriteLine("error");
                        break;

                }
            }

            else if (frutis == "grapes")
            {
                switch (dayOfWeek)
                {
                    case "Monday":
                    case "Tuesday":
                    case "Wednesday":
                    case "Thursday":
                    case "Friday":

                        Console.WriteLine($"{priceFruits * 3.85:f2}");
                        break;
                    case "Sunday":
                    case "Saturday":

                        Console.WriteLine($"{priceFruits * 4.20:f2}");
                        break;
                    default:
                        Console.WriteLine("error");
                        break;
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
