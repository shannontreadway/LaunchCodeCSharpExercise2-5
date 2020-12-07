using System;

namespace NumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is the rectangle length?");
            double length = double.Parse(Console.ReadLine());
            Console.WriteLine("What is the rectangle width?");
            double width = double.Parse(Console.ReadLine());
            double rectangleArea = length * width;
            Console.WriteLine("The area of the rectangle is " + rectangleArea + ".");
        }
    }
}
