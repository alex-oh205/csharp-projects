using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }

            // Wait before closing
            Console.ReadKey();
        }
    }
}