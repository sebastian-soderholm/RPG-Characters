using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters
{
    public class SecondaryAttributes
    {
        public int Health { get; set; }
        public int ArmorRating { get; set; }
        public int ElementalResistance { get; set; }
        public static SecondaryAttributes operator + (SecondaryAttributes lhs, SecondaryAttributes rhs)
            => new SecondaryAttributes(
                lhs.Health + rhs.Health,
                lhs.ArmorRating + rhs.ArmorRating,
                lhs.ElementalResistance + rhs.ElementalResistance);
        public static SecondaryAttributes operator + (SecondaryAttributes lhs, int b)
            => new SecondaryAttributes(
                lhs.Health + b,
                lhs.ArmorRating + b,
                lhs.ElementalResistance + b);
        public static bool operator == (SecondaryAttributes lhs, SecondaryAttributes rhs)
            =>  lhs.Health == rhs.Health &&
                lhs.ArmorRating == rhs.ArmorRating &&
                lhs.ElementalResistance == rhs.ElementalResistance;
        public static bool operator != (SecondaryAttributes lhs, SecondaryAttributes rhs)
            => lhs.Health != rhs.Health &&
                lhs.ArmorRating != rhs.ArmorRating &&
                lhs.ElementalResistance != rhs.ElementalResistance;
        public override bool Equals(Object a)
        {
            return a is SecondaryAttributes b &&
                Health == b.Health &&
                ArmorRating == b.ArmorRating &&
                ElementalResistance == b.ElementalResistance;
        }

        /// <summary>
        /// SecondaryAttributes determine a characters defence and survival capabilities.
        /// </summary>
        /// <param name="health">Character's totla health. When health reaches zero, character dies.</param>
        /// <param name="armorRating">Character's ability to resist physical damage.</param>
        /// <param name="elementalResistance">Character's ability to resist magic damage.</param>
        public SecondaryAttributes(int health, int armorRating, int elementalResistance)
        {
            Health = health;
            ArmorRating = armorRating;
            ElementalResistance = elementalResistance;
        }

    }
}
