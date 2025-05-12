using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                double result = Math.Pow(2, i);
                Console.WriteLine(result);
            }

            // Wait before closing
            Console.ReadKey();
        }
    }
}