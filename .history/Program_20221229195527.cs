using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                Console.WriteLine(i);
            }

            // Wait before closing
            Console.ReadKey();
        }
    }
}