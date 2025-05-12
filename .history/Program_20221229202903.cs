using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] movies = {"Lord of the Rings", "Fight Club", "Interstellar", "Gladiator"};

            for (int i = 0; i < movies.Length; i++)
            {
                int rank = i + 1;
                Console.WriteLine(rank + ". " + movies[i]);
            }

            // Wait before closing
            Console.ReadKey();
        }
    }
}