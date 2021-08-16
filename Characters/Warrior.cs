using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Characters
{
    public class Warrior : Character
    {

        public override string Name { get; set; }
        public override int Level { get; set; }
        protected override PrimaryAttributes BasePrimaryAttributes { get; set; }
        public override PrimaryAttributes TotalPrimaryAttributes { get; set; }
        public override SecondaryAttributes SecondaryAttributes { get; set; }
        public override Dictionary<Slot, Item> Equipments { get; set; }

        /// <summary>
        /// Create Warrior instance based on level 1 stats
        /// </summary>
        /// <param name="name">Warrior's name</param>
        public Warrior(string name)
        {
            Name = name;
            Level = 1;
            BasePrimaryAttributes = new PrimaryAttributes(10,5,2,1);
            TotalPrimaryAttributes = new PrimaryAttributes(0,0,0,0);

            SecondaryAttributes = new SecondaryAttributes(
                10 * BasePrimaryAttributes.Vitality, 
                BasePrimaryAttributes.Strength + BasePrimaryAttributes.Dexterity,
                BasePrimaryAttributes.Intelligence
                );
            Equipments = new Dictionary<Slot, Item>()
            {
                { Slot.Body, null},
                { Slot.Head, null},
                { Slot.Legs, null},
                { Slot.Weapon, null}
            };
        }

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
            try
            {
                Item equippedWeapon;
                if (Equipments.TryGetValue(Slot.Weapon, out equippedWeapon) && Equipments[Slot.Weapon] != null)
                {
                    return Equipments[Slot.Weapon].GetDPS() + 1 + TotalPrimaryAttributes.Strength / 100;
                }
            }
            catch (NullReferenceException) { }
            
            return 1 + TotalPrimaryAttributes.Strength / 100;
        }

        public override void LevelUp()
        {
            throw new NotImplementedException();
        }
    }

}