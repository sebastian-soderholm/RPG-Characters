using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters
{
    public class Weapon : Item
    {
        public int BaseDamage { get; set; }
        public int AttacksPerSecond { get; set; }
        public WeaponType Type { get; set; }
        public enum WeaponType
        {
            WEAPON_AXE,
            WEAPON_BOW,
            WEAPON_DAGGER,
            WEAPON_HAMMER,
            WEAPON_STAFF,
            WEAPON_SWORD,
            WEAPON_WAND,
        }
        /// <summary>
        /// A weapon can be equipped in a character's weapon slot and it increases the damage dealt when a character attacks.
        /// </summary>
        /// <param name="name">Weapon name</param>
        /// <param name="requiredLevel">Minimum required level to equip armor.</param>
        /// <param name="baseDamage">The base damage used to calculate the weapons's DPS</param>
        /// <param name="attacksPerSecond">Attacks per second used to calculate the weapon's DPS</param>
        /// <param name="weaponType">Type of weapon</param>
        public Weapon(String name, int requiredLevel, int baseDamage, int attacksPerSecond, WeaponType weaponType)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            BaseDamage = baseDamage;
            AttacksPerSecond = attacksPerSecond;
            Type = weaponType;
        }
        /// <summary>
        /// Calculate the weapon's Damage Per Second (DPS) 
        /// </summary>
        /// <returns>Return DPS as int</returns>
        public override int GetDPS()
        {
            return BaseDamage * AttacksPerSecond;
        }
    }
}
