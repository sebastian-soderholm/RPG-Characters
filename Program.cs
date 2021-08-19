using System;

namespace RPG_Characters
{
    class RPG_Game
    {
        static void Main(string[] args)
        {
            Armor testArmor = new Armor("Common cloth", 1, Armor.ArmorType.ARMOR_CLOTH, 2, 2, 1, 2);
            Weapon testWeapon = new Weapon("TestAxe", 1, 3, 2, Weapon.WeaponType.WEAPON_AXE);
            Warrior warrior = new Warrior("TestWarrior");
            double expect = (double)(7 * (1 + ((double)(5 + 2) / 100)));

            //Act
            warrior.Equip(testWeapon);
            //warrior.Equip(testArmor, Character.Slot.SLOT_BODY);
            Console.WriteLine("This is the character DPS: " + warrior.GetDPS());

            //for (int i=0; i<3; i++)
            //{

            //    Console.WriteLine($"AttackWarrior inflicted {AttackWarrior.Attack()} amount of damage!");

            //    ////If Character died from attack, print info and delete instance 
            //    //if (DefendWarrior.SecondaryAttributes.Health <= 0)
            //    //{
            //    //    Console.WriteLine($"Character {DefendWarrior.Name} died!");
            //    //    DefendWarrior = null;
            //    //    break;
            //    //}

            //    AttackWarrior.LevelUp();
            //    Console.WriteLine(DefendWarrior.ToString());
            //}
            
        }
    }
}
