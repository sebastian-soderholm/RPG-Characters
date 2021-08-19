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
        /// <summary>
        /// Create SecondaryAttributes object intance with given values. 
        /// </summary>
        /// <param name="health">SecondaryAttributes health value</param>
        /// <param name="armorRating">SecondaryAttributes Armor Rating value</param>
        /// <param name="elementalResistance">SecondaryAttributes Elemental Resistance value</param>
        public SecondaryAttributes(int health, int armorRating, int elementalResistance)
        {
            Health = health;
            ArmorRating = armorRating;
            ElementalResistance = elementalResistance;
        }
        /// <summary>
        /// Add two SecondaryAttributes values together
        /// </summary>
        /// <param name="lhs">Left hand side variable</param>
        /// <param name="rhs">Right hand side variable</param>
        /// <returns>new SecondaryAttributes instance with added values</returns>
        public static SecondaryAttributes operator + (SecondaryAttributes lhs, SecondaryAttributes rhs)
            => new SecondaryAttributes(
                lhs.Health + rhs.Health,
                lhs.ArmorRating + rhs.ArmorRating,
                lhs.ElementalResistance + rhs.ElementalResistance);
        /// <summary>
        /// Add an integer value to all SecondaryAttributes
        /// </summary>
        /// <param name="lhs">Left hand side variable</param>
        /// <param name="rhs">Right hand side variable</param>
        /// <returns>new SecondaryAttributes instance with added values</returns>
        public static SecondaryAttributes operator + (SecondaryAttributes lhs, int b)
            => new SecondaryAttributes(
                lhs.Health + b,
                lhs.ArmorRating + b,
                lhs.ElementalResistance + b);
        /// <summary>
        /// Check if all SecondaryAttributes values are not equal between two instances
        /// </summary>
        /// <param name="lhs">Left hand side variable</param>
        /// <param name="rhs">Right hand side variable</param>
        /// <returns>true if all SecondaryAttributes values not are equal, otherwise false</returns>
        public static bool operator == (SecondaryAttributes lhs, SecondaryAttributes rhs)
            =>  lhs.Health == rhs.Health &&
                lhs.ArmorRating == rhs.ArmorRating &&
                lhs.ElementalResistance == rhs.ElementalResistance;
        /// <summary>
        /// Check if all SecondaryAttributes values are not equal between two instances
        /// </summary>
        /// <param name="lhs">Left hand side variable</param>
        /// <param name="rhs">Right hand side variable</param>
        /// <returns>true if all SecondaryAttributes values not are equal, otherwise false</returns>
        public static bool operator != (SecondaryAttributes lhs, SecondaryAttributes rhs)
            => lhs.Health != rhs.Health &&
                lhs.ArmorRating != rhs.ArmorRating &&
                lhs.ElementalResistance != rhs.ElementalResistance;
        /// <summary>
        /// Check if SecondaryAttributes object type and values are equal
        /// </summary>
        /// <param name="a">PrimaryAttributes instance that Equals() method is called upon</param>
        /// <returns>true if object type and values are equal, otherwise false</returns>
        public override bool Equals(Object a)
        {
            return a is SecondaryAttributes b &&
                Health == b.Health &&
                ArmorRating == b.ArmorRating &&
                ElementalResistance == b.ElementalResistance;
        }
    }
}
