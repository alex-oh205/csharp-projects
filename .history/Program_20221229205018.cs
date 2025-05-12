using System;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many students are in your class: ");
            int count = Convert.ToInt32(Console.ReadLine());
            string[] students = new string[count];

            Console.WriteLine("Please input the names of the students:");
            for (int i = 0; i < count; i++)
            {
                students[i] = Console.ReadLine();
            }
                
            Array.Sort(students);

            Console.WriteLine("--------------");

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine(students[i]);
            }


            // Wait before closing
            Console.ReadKey();
        }
    }
}