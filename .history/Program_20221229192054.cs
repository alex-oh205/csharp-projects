using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            int num01;
            int num02;

            Console.Write("Input a number: ");
            
            num01 = Convert.ToInt32( Console.ReadLine() );

            // Wait before closing
            Console.ReadKey();
        }
    }
}