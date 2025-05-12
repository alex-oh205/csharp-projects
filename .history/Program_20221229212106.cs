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
            
            Console.WriteLine("There are " + getWordCount(sentence) + " in that sentence.");
        }

        static int getWordCount(string text)
        {
            return text.Split(" ").Length;
        }
    }
}