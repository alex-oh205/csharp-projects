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
            Console.WriteLine(name + " casts " + favoriteSpell);
            spellSlots--;
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

            Console.WriteLine("Spell slots: " + wizard01.spellSlots);

            wizard01.CastSpell();

            Console.WriteLine("Spell slots: " + wizard01.spellSlots);

            // Wait before closing
            Console.ReadKey();
        }
    }
}