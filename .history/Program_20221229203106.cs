using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = new string[4];

            Console.WriteLine("Type in four movies: ");

            movies[0] = Console.ReadLine();
            movies[1] = Console.ReadLine();
            movies[2] = Console.ReadLine();
            movies[3] = Console.ReadLine();

            // Wait before closing
            Console.ReadKey();
        }
    }
}