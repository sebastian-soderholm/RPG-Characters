using System;

namespace RPG_Characters
{
    class RPG_Game
    {
        static void Main(string[] args)
        {
            Warrior AttackWarrior = new Warrior("AttackWarrior");
            Warrior DefendWarrior = new Warrior("DefendWarrior");

            //Console.WriteLine(AttackWarrior.GetStatsString());
            Console.WriteLine(DefendWarrior.ToString());

            for (int i=0; i<100; i++)
            {
                AttackWarrior.Attack(DefendWarrior);
                //If Character died from attack, print info and delete instance 
                if (DefendWarrior.SecondaryAttributes.Health <= 0)
                {
                    Console.WriteLine($"Character {DefendWarrior.Name} died!");
                    DefendWarrior = null;
                    break;
                }
                AttackWarrior.LevelUp();
                Console.WriteLine(DefendWarrior.ToString());
            }
            
            try
            {

            }
            catch (InvalidWeaponException e)
            {
                //Character cannot equip item
                Console.WriteLine($"Character cannot equip item: {e}");

            }
            
        }
    }
}
