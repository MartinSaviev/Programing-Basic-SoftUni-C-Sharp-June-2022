using System;

namespace Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double meters2 = double.Parse(Console.ReadLine());

            double meter = 7.61;

            double sumForYard = meters2 * meter;
            double discount = sumForYard * 18 / 100;
            double finalSum = sumForYard - discount;




            Console.WriteLine($"The final price is: {finalSum} lv.");
            Console.WriteLine($"The discount is: {discount} lv.");



        }
    }
}
