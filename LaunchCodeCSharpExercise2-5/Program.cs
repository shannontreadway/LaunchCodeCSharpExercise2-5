using System;

namespace LaunchCodeCSharpExercise2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Prompt enduser's name and greet.
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
        }
    }
}
