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

        public static PrimaryAttributes operator + (PrimaryAttributes lhs, PrimaryAttributes rhs)
            => new PrimaryAttributes(
                lhs.Strength + rhs.Strength,
                lhs.Dexterity + rhs.Dexterity,
                lhs.Intelligence + rhs.Intelligence,
                lhs.Vitality + rhs.Vitality);
        public static PrimaryAttributes operator +(PrimaryAttributes lhs, int rhs)
            => new PrimaryAttributes(
                lhs.Strength + rhs,
                lhs.Dexterity + rhs,
                lhs.Intelligence + rhs,
                lhs.Vitality + rhs);
        public static bool operator == (PrimaryAttributes lhs, PrimaryAttributes rhs)
            => lhs.Strength == rhs.Strength &&
                lhs.Dexterity == rhs.Dexterity &&
                lhs.Intelligence == rhs.Intelligence &&
                lhs.Vitality == rhs.Vitality;
        public static bool operator != (PrimaryAttributes lhs, PrimaryAttributes rhs)
            => lhs.Strength != rhs.Strength &&
                lhs.Dexterity != rhs.Dexterity &&
                lhs.Intelligence != rhs.Intelligence &&
                lhs.Vitality != rhs.Vitality;
        public override bool Equals(Object a)
        {
            return a is PrimaryAttributes b &&
                Strength == b.Strength &&
                Dexterity == b.Dexterity &&
                Intelligence == b.Intelligence &&
                Vitality == b.Vitality;
        }

        public PrimaryAttributes(int strength, int dexterity, int intelligence, int vitality)
        {
            Strength = strength;
            Dexterity = dexterity;
            Intelligence = intelligence;
            Vitality = vitality;
        }
    }
}
