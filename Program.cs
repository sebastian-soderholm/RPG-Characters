using System;

namespace RPG_Characters
{
    class RPG_Game
    {
        static void Main(string[] args)
        {
            Warrior warrior = new Warrior("TestWarrior");

            Console.WriteLine(warrior.GetStatsString());

        }
    }
}
