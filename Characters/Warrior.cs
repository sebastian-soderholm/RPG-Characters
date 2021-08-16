﻿using System;
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
        public enum equippableItems
        {
            WEAPON_AXE, WEAPON_HAMMER, WEAPON_SWORD, ARMOR_MAIL, ARMOR_PLATE
        }

        /// <summary>
        /// Create Warrior instance based on level 1 stats
        /// </summary>
        /// <param name="name">Warrior's name</param>
        public Warrior(string name)
        {
            Name = name;
            Level = 1;
            BasePrimaryAttributes = new PrimaryAttributes(5, 2, 1, 10);
            TotalPrimaryAttributes = new PrimaryAttributes(0,0,0,0);

            SecondaryAttributes = new SecondaryAttributes(
                10 * BasePrimaryAttributes.Vitality, 
                BasePrimaryAttributes.Strength + BasePrimaryAttributes.Dexterity,
                BasePrimaryAttributes.Intelligence
                );
            Equipments = new Dictionary<Slot, Item>()
            {
                { Slot.SLOT_BODY, null},
                { Slot.SLOT_HEAD, null},
                { Slot.SLOT_LEGS, null},
                { Slot.SLOT_WEAPON, null}
            };
        }

        public override void Attack(Character targetCharacter)
        {
            throw new NotImplementedException();
        }

        public override void Equip(Weapon weaponToEquip)
        {
            if (equippableItems.IsDefined(weaponToEquip.Type))
            {
                Equipments[Slot.SLOT_WEAPON] = weaponToEquip;
            }
            else
            {
                throw new InvalidWeaponException(weaponToEquip);
            }
        }

        public override void Equip(Armor armorToEquip)
        {
            if (equippableItems.IsDefined(armorToEquip.Type))
            {
                Equipments[Slot.SLOT_WEAPON] = armorToEquip;
            }
            else
            {
                throw new InvalidArmorException(armorToEquip);
            }
        }
        public override double GetDPS()
        {
            if (Equipments[Slot.SLOT_WEAPON] != null)
            {
                //Console.WriteLine("BasePrimaryAttributes.Strength: ", BasePrimaryAttributes.Strength);
                return Equipments[Slot.SLOT_WEAPON].GetDPS() + 1 + (double)BasePrimaryAttributes.Strength / 100;
            }
            Console.WriteLine("BasePrimaryAttributes.Strength: " + BasePrimaryAttributes.Strength);
            return 1 + (double)BasePrimaryAttributes.Strength / 100;
        }

        public override void LevelUp()
        {
            throw new NotImplementedException();
        }
    }

}