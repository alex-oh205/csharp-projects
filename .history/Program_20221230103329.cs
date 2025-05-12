using System;
using System.Collections.Generic;

namespace My_Awesome_Program
{
    class Wizard
    {
        public string name;
        public string favoriteSpell;
        public int spellSlots;
        public float experience;

        public void CastSpell()
        {
            if (spellSlots > 0)
            {
                Console.WriteLine(name + " casts " + favoriteSpell);
                spellSlots--;
                experience += 0.3f;
            } else
            {
                Console.WriteLine(name + " is out of spell slots.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wizard wizard01 = new Wizard();
            wizard01.name = "Parry Hopper";
            wizard01.favoriteSpell = "Unexpecto Patronum";
            wizard01.spellSlots = 2;
            wizard01.experience = 0f;

            wizard01.CastSpell();
            wizard01.CastSpell();
            wizard01.CastSpell();

            Console.WriteLine("Experience: " + wizard01.experience);

            // Wait before closing
            Console.ReadKey();
        }
    }
}