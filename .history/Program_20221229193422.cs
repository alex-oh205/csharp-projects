using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome! Tickets are $5. Please insert cash.");

            int cash = Convert.ToInt32(Console.ReadLine());

            if (cash < 5)
            {
                Console.WriteLine("That's not enough money.");
            }
            else
            {
                Console.WriteLine("Here is your ticket.");
            }

            // Wait before closing
            Console.ReadKey();
        }
    }
}