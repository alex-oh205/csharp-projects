using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            double num01;
            double num02;

            Console.Write("Input a number: ");
            num01 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Input a second number: ");
            num02 = Convert.ToDouble( Console.ReadLine() );

            double result = num01 * num02;
            Console.WriteLine("The result is " + result);

            // Wait before closing
            Console.ReadKey();
        }
    }
}