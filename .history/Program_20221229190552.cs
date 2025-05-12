using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Skynet";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WindowHeight = 40;

            Console.WriteLine("Hello, what's your name?");

            Console.ReadLine();

            Console.WriteLine("My name is RX-9000. \nI'm an AI sent from the future to destroy mankind.");
            Console.WriteLine("What is your favorite color?");
            
            Console.ReadKey();
        }
    }
}