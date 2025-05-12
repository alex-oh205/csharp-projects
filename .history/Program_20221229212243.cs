using System;
using System.Collections.Generic;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence: ");
            string sentence = Console.ReadLine();
            
            Console.WriteLine("There are " + getWordCount(sentence) + " words in that sentence.");

            // Wait before closing
            Console.ReadKey();
        }

        static int getWordCount(string text)
        {
            return text.Split(" ").Length;
        }
    }
}