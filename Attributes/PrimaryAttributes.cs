using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters
{
    public class PrimaryAttributes
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }
        public int Vitality { get; set; }
        /// <summary>
        /// Create PrimaryAttributes object intance with given values
        /// </summary>
        /// <param name="strength">Strength value as integer</param>
        /// <param name="dexterity">Dexterity value as integer</param>
        /// <param name="intelligence">Intelligence value as integer</param>
        /// <param name="vitality">Vitality value as integer</param>
        public PrimaryAttributes(int strength, int dexterity, int intelligence, int vitality)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Vitality = vitality;
        }
        /// <summary>
        /// Add two PrimaryAttributes together
        /// </summary>
        /// <param name="lhs">Left hand side variable</param>
        /// <param name="rhs">Right hand side variable</param>
        /// <returns>new PrimaryAttributes instance with added values</returns>
        public static PrimaryAttributes operator +(PrimaryAttributes lhs, PrimaryAttributes rhs)
           => new PrimaryAttributes(
               lhs.Strength + rhs.Strength,
               lhs.Dexterity + rhs.Dexterity,
               lhs.Intelligence + rhs.Intelligence,
               lhs.Vitality + rhs.Vitality);
        /// <summary>
        /// Add an integer value to all PrimaryAttributes
        /// </summary>
        /// <param name="lhs">Left hand side variable</param>
        /// <param name="rhs">Right hand side variable</param>
        /// <returns>new PrimaryAttributes instance with added values</returns>
        public static PrimaryAttributes operator +(PrimaryAttributes lhs, int rhs)
            => new PrimaryAttributes(
                lhs.Strength + rhs,
                lhs.Dexterity + rhs,
                lhs.Intelligence + rhs,
                lhs.Vitality + rhs);
        /// <summary>
        /// Check if all PrimaryAttributes values are equal between two instances
        /// </summary>
        /// <param name="lhs">Left hand side variable</param>
        /// <param name="rhs">Right hand side variable</param>
        /// <returns>true if all PrimaryAttributes values are equal, otherwise false</returns>
        public static bool operator ==(PrimaryAttributes lhs, PrimaryAttributes rhs)
            => lhs.Strength == rhs.Strength &&
                lhs.Dexterity == rhs.Dexterity &&
                lhs.Intelligence == rhs.Intelligence &&
                lhs.Vitality == rhs.Vitality;
        /// <summary>
        /// Check if all PrimaryAttributes values are not equal between two instances
        /// </summary>
        /// <param name="lhs">Left hand side variable</param>
        /// <param name="rhs">Right hand side variable</param>
        /// <returns>true if all PrimaryAttributes values not are equal, otherwise false</returns>
        public static bool operator !=(PrimaryAttributes lhs, PrimaryAttributes rhs)
            => lhs.Strength != rhs.Strength &&
                lhs.Dexterity != rhs.Dexterity &&
                lhs.Intelligence != rhs.Intelligence &&
                lhs.Vitality != rhs.Vitality;
        /// <summary>
        /// Check if PrimaryAttributes object type and values are equal
        /// </summary>
        /// <param name="a">PrimaryAttributes instance that Equals() method is called upon</param>
        /// <returns>true if object type and values are equal, otherwise false</returns>
        public override bool Equals(Object a)
        {
            return a is PrimaryAttributes b &&
                Strength == b.Strength &&
                Dexterity == b.Dexterity &&
                Intelligence == b.Intelligence &&
                Vitality == b.Vitality;
        }
    }
}
