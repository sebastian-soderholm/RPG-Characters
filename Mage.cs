using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Characters
{
    public class Mage : Character
    {
        public override string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override int Level { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override StringBuilder StatsStringBuilder { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public override Dictionary<Slot, Item> Equipments { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override void Attack(Character targetCharacter)
        {
            throw new NotImplementedException();
        }

        public override void Equip(Weapon weapon)
        {
            throw new NotImplementedException();
        }

        public override void Equip(Armor armor)
        {
            throw new NotImplementedException();
        }

        public override bool EquipPermitted(Item item)
        {
            throw new NotImplementedException();
        }

        public override float GetDPS()
        {
            throw new NotImplementedException();
        }

        public override void LevelUp()
        {
            throw new NotImplementedException();
        }
    }
}