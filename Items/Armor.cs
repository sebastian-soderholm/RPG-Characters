using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters
{
    public class Armor : Item
    {
        public ArmorType Type { get; set; }
        public PrimaryAttributes PrimaryItemAttributes { get; set; }

        public enum ArmorType
        {
            ARMOR_CLOTH,
            ARMOR_LEATHER,
            ARMOR_MAIL,
            ARMOR_PLATE
        }
        /// <summary>
        /// Armor can be equipped in one of three character slots. Armor increases the TotalPrimary attributes of a character.
        /// </summary>
        /// <param name="name">Name of the character</param>
        /// <param name="requiredLevel">Minimum required level to equip armor.</param>
        /// <param name="armorType">Type of armor</param>
        /// <param name="strength">Increase in character's strength when armor is equipped</param>
        /// <param name="dexterity">Increase in character's dexterity when armor is equipped</param>
        /// <param name="intelligence">Increase in character's intelligence when armor is equipped</param>
        /// <param name="vitality">Increase in character's vitality when armor is equipped</param>
        public Armor(string name, int requiredLevel, ArmorType armorType, int strength, int dexterity, int intelligence, int vitality)
        {
            Name = name;
            RequiredLevel = requiredLevel;
            Type = armorType;
            PrimaryItemAttributes = new PrimaryAttributes(strength, dexterity, intelligence, vitality);
        }
    }
}
