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

        public SecondaryAttributes(int health, int armorRating, int elementalResistance)
        {
            this.Health = health;
            this.ArmorRating = armorRating;
            this.ElementalResistance = elementalResistance;
        }

    }
}
