using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters
{
    public abstract class Item
    {
        private string Name;
        private int RequiredLevel;

        //Armor can be equipped in any non-weapon slot, and weapons can only be equipped in a weapon slot
        private enum Slot
        {
            Head,
            Body,
            Legs,
            Weapon,
        }

    }
}
