using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Characters
{
    public abstract class Character
    {
        private string Name;
        private int Level;
        private PrimaryAttribute PrimaryAttribute;
        private SecondaryAttribute SecondaryAttribute;
        private StringBuilder StatsStringBuilder;

        public abstract void LevelUp();
        public abstract void Equip(Weapon weaponToEquip);
        public abstract void Equip(Armor armorToEquip);
        private abstract bool EquipPermitted(Item item);

    }
}