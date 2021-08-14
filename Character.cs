using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Characters
{
    /// <summary>
    /// Character summary...
    /// </summary>
    public abstract class Character
    {
        public abstract string Name { get; set; }
        private int Level;
        private PrimaryAttribute PrimaryAttribute;
        private SecondaryAttribute SecondaryAttribute;
        private StringBuilder StatsStringBuilder = new StringBuilder();
        private Dictionary<Slot, Item> Equipment = new Dictionary<Slot, Item>();
        private enum Slot
        {
            Head,
            Body,
            Legs,
            Weapon,
        }

        public abstract void LevelUp();
        public abstract void Equip(Weapon weaponToEquip);
        public abstract void Equip(Armor armorToEquip);
        public abstract bool EquipPermitted(Item item);
        public abstract float GetDPS();
        public virtual string GetStatsString()
        {
            this.StatsStringBuilder.AppendFormat(
                "Character name: {0}\n" +
                "Character level: {1}\n" +
                "Strength: \n" +
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
             );

            return this.StatsStringBuilder.ToString();
        }

    }
}