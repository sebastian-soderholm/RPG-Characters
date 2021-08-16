using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters
{
    public class Weapon : Item
    {
        public Weapon(int baseDamage, int attacksPerSecond)
        {
            BaseDamage = baseDamage;
            AttacksPerSecond = attacksPerSecond;
        }
        public int BaseDamage { get; set; }
        public int AttacksPerSecond { get; set; }

        public WeaponType Type { get; set; }

        public enum WeaponType
        {
            Axe,
            Bow,
            Dagger,
            Hammer,
            Staff,
            Sword,
            Wand,
        }
        public override int GetDPS()
        {
            return BaseDamage * AttacksPerSecond;
        }


    }
}
