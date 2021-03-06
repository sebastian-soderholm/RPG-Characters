using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Characters
{
    /// <summary>
    /// Character
    /// </summary>
    public abstract class Character
    {
        public abstract string Name { get; set; }
        public abstract int Level { get; set; }
        public PrimaryAttribute PrimaryAttribute { get; set; }
        public SecondaryAttribute SecondaryAttribute { get; set; }
        public abstract StringBuilder StatsStringBuilder { get; set; }
        public abstract Dictionary<Slot, Item> Equipments { get; set; }
        public enum Slot
        {
            Head,
            Body,
            Legs,
            Weapon,
        }
        /// <summary>
        /// Increse character level by 1
        /// Increase primary attributes based on character type
        /// </summary>
        public abstract void LevelUp();
        /// <summary>
        /// Print the damage character inflicts based on calculated DPS
        /// </summary>
        /// <param name="targetCharacter">Character instance that the attack is directed towards</param>
        public abstract void Attack(Character targetCharacter);
        /// <summary>
        /// Replace current weapon in Equipments property
        /// </summary>
        /// <param name="weapon">Weapon to be equipped</param>
        /// <exception cref="">InvalidWeaponException</exception>
        public abstract void Equip(Weapon weapon);
        /// <summary>
        /// Replace current armor in Equipments property
        /// </summary>
        /// <param name="weapon">Armor to be equipped</param>
        /// <exception cref="">InvalidWeaponException</exception>
        public abstract void Equip(Armor armor);
        /// <summary>
        /// Check if character can equip Item
        /// </summary>
        /// <param name="item">Item that is to be checked for equipping</param>
        /// <returns>True if item can be equipped, false otherwise</returns>
        public abstract bool EquipPermitted(Item item);
        /// <summary>
        /// Calculate and return character's damage per second (DPS)
        /// </summary>
        /// <returns>Character's DPS as float</returns>
        public abstract float GetDPS();
        /// <summary>
        /// Create a summary of character stats with StringBuilder
        /// </summary>
        /// <returns>Character stats as a string</returns>
        public virtual string GetStatsString()
        {
            return this.StatsStringBuilder.AppendFormat(
                "Character name: {0}\n" +
                "Character level: {1}\n" +
                "Strength: {2}\n" +
                "Dexterity: {3}\n" +
                "Intelligence: {4}\n" +
                "Health: {5}\n" +
                "Armor Rating: {6}\n" +
                "Elemental Resistance: {7}\n" +
                "DPS: {8}", 
                this.Name, 
                this.Level, 
                this.PrimaryAttribute,
                this.PrimaryAttribute.Strength,
                this.PrimaryAttribute.Dexterity,
                this.PrimaryAttribute.Intelligence,
                this.SecondaryAttribute.Health,
                this.SecondaryAttribute.ArmorRating,
                this.SecondaryAttribute.ElementalResistance,
                this.GetDPS()
             ).ToString();
        }

    }
}