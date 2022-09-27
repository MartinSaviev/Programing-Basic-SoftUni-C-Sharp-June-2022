using System;


namespace Figures
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string figur = Console.ReadLine();

            if (figur == "square")                  
            {
                double side = double.Parse(Console.ReadLine());
                double sum = side * side;
                Console.WriteLine("{0:f3}",sum);
            }

            else if (figur == "rectangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double sum = (side1 * side2);
                Console.WriteLine("{0:f3}",sum);
            }

            else if (figur == "circle")
            {
              
                double radius = double.Parse(Console.ReadLine());
                double sum = (Math.PI * radius * radius);
                Console.WriteLine("{0:f3}",sum);
                
            }

            else if (figur == "triangle")
            {
                double side1 = double.Parse(Console.ReadLine());
                double side2 = double.Parse(Console.ReadLine());
                double sum = (side1 * side2 / 2);
                Console.WriteLine("{0:f3}",sum);
            }
        }
    }
}
