using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters
{
    public class PrimaryAttributes
    {
        public int Vitality { get; set; }
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Intelligence { get; set; }

        public PrimaryAttributes(int vitality, int strength, int dexterity, int intelligence)
        {
            this.Vitality = vitality;
            this.Strength = strength;
            this.Dexterity = dexterity;
            this.Intelligence = intelligence;
        }
    }
}
