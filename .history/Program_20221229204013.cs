using System;
using System.Collections.Generic;

namespace My_Awesome_Program
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> shoppingList = new List<string>();

            shoppingList.Add("Dreams");
            shoppingList.Add("Miracles");
            shoppingList.Add("Rainbows");
            shoppingList.Add("Pony");

            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            shoppingList.Remove("Dreams");
            shoppingList.RemoveAt(1);

            Console.WriteLine("-------------");
            
            for (int i = 0; i < shoppingList.Count; i++)
            {
                Console.WriteLine(shoppingList[i]);
            }

            // Wait before closing
            Console.ReadKey();
        }
    }
}