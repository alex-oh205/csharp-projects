using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Random numberGen = new Random();

            int roll = 0;
            int attempts = 0;

            while(roll != 6) {
                roll = numberGen.Next(1, 7);
                Console.WriteLine("You rolled: " + roll);
                attempts++;
            }

            Console.WriteLine("It took you " + attempts + " attempts to roll a six.");

            // Wait before closing
            Console.ReadKey();
        }
    }
}