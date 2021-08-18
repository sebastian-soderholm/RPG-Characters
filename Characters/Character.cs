using System;
using System.Collections.Generic;
using System.Text;

namespace RPG_Characters
{
    public abstract class Character
    {
        public string Name { get; set; }
        public int Level { get; set; }
        /// <summary>
        /// BasePrimaryAttributes are calculated based on character type and level
        /// </summary>
        public PrimaryAttributes BasePrimaryAttributes { get; set; }
        /// <summary>
        /// TotalPrimaryAttributes = BasePrimaryAttributes + equipment bonuses
        /// </summary>
        public PrimaryAttributes TotalPrimaryAttributes { get; set; }
        /// <summary>
        /// Secondary attributes are calculated based on BasePrimaryAttributes and equipped items
        /// </summary>
        public SecondaryAttributes SecondaryAttributes { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Dictionary<Slot, Item> Equipment { get; set; }
        public enum Slot
        {
            SLOT_HEAD, SLOT_BODY, SLOT_LEGS, SLOT_WEAPON
        }

        /// <summary>
        /// Increase Character's level by 1
        /// Increase primary attributes based on character type
        /// </summary>
        public abstract void LevelUp();
        /// <summary>
        /// Increase Character's level by given value.
        /// </summary>
        /// <param name="levelIncrease">Number by which character's level should be increased</param>
        /// <exception cref="ArgumentException">ArgumentException</exception>
        public void IncreaseLevelBy(int levelIncrease)
        {
            if (levelIncrease <= 0)
            {
                throw new ArgumentException();
            }
            else
            {
                for (int i = 0; i<levelIncrease; i++)
                {
                    Level += levelIncrease;
                    LevelUp();
                }
                
            }
                
        }
        
        /// <summary>
        /// Return the physical damage character inflicts based on calculated DPS and targets armor rating
        /// </summary>
        /// <param name="targetCharacter">Character instance that the attack is directed towards</param>
        public float Attack()
        {
            return GetDPS();
        }
        /// <summary>
        /// Calculate the actual damage inflicted and remove calculated damage from character's Health attribute
        /// </summary>
        /// <param name="damageToDefend">The amount of damage attacker tries to inflict</param>
        public void TakeDamage(double damageToDefend)
        {
            //Calculate actual inflicted damage and subtract value from defender's Health attribute
            //SecondaryAttributes.Health -= Math.Abs(damageToDefend - SecondaryAttributes.ArmorRating / 100);
        }
        /// <summary>
        /// Replace current weapon in Equipment property
        /// </summary>
        /// <param name="weapon">Weapon to be equipped</param>
        /// <exception cref="InvalidWeaponException">InvalidWeaponException</exception>
        public abstract string Equip(Weapon weaponToEquip);
        /// <summary>
        /// Replace current armor in Equipment property
        /// </summary>
        /// <param name="armor">Armor to be equipped</param>
        /// <exception cref="InvalidArmorException">InvalidArmorException</exception>
        public abstract string Equip(Armor armorToEquip, Slot armorSlot);
        /// <summary>
        /// Calculate and return character's damage per second (DPS)
        /// </summary>
        /// <returns>Character's DPS as double</returns>
        public abstract float GetDPS();
        /// <summary>
        /// Return summary of Character stats
        /// </summary>
        /// <returns>Character stats as a string</returns>
        public override string ToString()
        {
            StringBuilder statsStringBuilder = new StringBuilder();

            return statsStringBuilder.AppendFormat(
                $"Character name: {Name}\n" +
                $"Character level: {Level}\n" +
                $"Strength: {BasePrimaryAttributes.Strength + TotalPrimaryAttributes.Strength}\n" +
                $"Dexterity: {BasePrimaryAttributes.Dexterity + TotalPrimaryAttributes.Dexterity}\n" +
                $"Intelligence: {BasePrimaryAttributes.Intelligence + TotalPrimaryAttributes.Intelligence}\n" +
                $"Health: {SecondaryAttributes.Health}\n" +
                $"Armor Rating: {SecondaryAttributes.ArmorRating}\n" +
                $"Elemental Resistance: {SecondaryAttributes.ElementalResistance}\n" +
                $"DPS: {GetDPS()}\n" + "\n"
             ).ToString();
        }
    }
}