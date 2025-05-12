using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string userName = Console.ReadLine();

            Console.WriteLine("Hello " + userName + ", nice to meet you!");

            // Wait before closing
            Console.ReadKey();
        }
    }
}