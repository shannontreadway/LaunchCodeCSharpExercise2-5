using System;

namespace MoreNumericTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many miles did you drive?");
            int milesDriven = int.Parse(Console.ReadLine());
            Console.WriteLine("How many gallons did it take to fill the gas tank?");
            double gallons = double.Parse(Console.ReadLine());
            double milesPerGallon = milesDriven / gallons;
            Console.WriteLine("Your car averaged " + milesPerGallon + " miles per gallon.");
        }
    }
}
