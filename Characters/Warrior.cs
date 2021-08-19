using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Characters
{
    public class Warrior : Character
    {
        /// <summary>
        /// Types of items that Warriors can equip
        /// </summary>
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
            TotalPrimaryAttributes = new PrimaryAttributes(0, 0, 0, 0);

            SecondaryAttributes = new SecondaryAttributes(
                10 * BasePrimaryAttributes.Vitality, 
                BasePrimaryAttributes.Strength + BasePrimaryAttributes.Dexterity,
                BasePrimaryAttributes.Intelligence
                );

            Equipment = new Dictionary<Slot, Item>()
            {
                { Slot.SLOT_BODY, null},
                { Slot.SLOT_HEAD, null},
                { Slot.SLOT_LEGS, null},
                { Slot.SLOT_WEAPON, null}
            };
        }

        /// <summary>
        /// Increase Warrior's level by 1
        /// Increase primary attributes based on character type
        /// </summary>
        public override void LevelUp()
        {
            Level++;
            BasePrimaryAttributes.Strength += 3;
            BasePrimaryAttributes.Dexterity += 2;
            BasePrimaryAttributes.Intelligence += 1;
            BasePrimaryAttributes.Vitality += 5;
        }

        /// <summary>
        /// Equip weapon if type and level meet Warrior's requirements
        /// </summary>
        /// <param name="weaponToEquip">Weapon that Warrior tries to equip</param>
        public override string Equip(Weapon weaponToEquip)
        {
            if (equippableItems.IsDefined(weaponToEquip.Type) && Level >= weaponToEquip.RequiredLevel)
            {
                Equipment[Slot.SLOT_WEAPON] = weaponToEquip;
                return "New weapon equipped!";
            }
            else
            {
                throw new InvalidWeaponException(weaponToEquip);
            }
        }
        /// <summary>
        /// Equip armor in given Slot if armor type and level meet Warrior's requirements
        /// </summary>
        /// <param name="armorToEquip">Armor that warrior tries to equip</param>
        /// <param name="armorSlot">Slot in which warrier tries to equip armor</param>
        public override string Equip(Armor armorToEquip, Slot armorSlot)
        {
            if (equippableItems.IsDefined(armorToEquip.Type) && Level >= armorToEquip.RequiredLevel &&
                (armorSlot == Slot.SLOT_BODY ||
                armorSlot == Slot.SLOT_HEAD ||
                armorSlot == Slot.SLOT_HEAD))
            {
                Equipment[Slot.SLOT_WEAPON] = armorToEquip;
                //Armor increases character's TotalPrimaryAttributes
                TotalPrimaryAttributes += armorToEquip.PrimaryItemAttributes;
                return "New armor equipped!";
            }
            else
            {
                throw new InvalidArmorException(armorToEquip);
            }
        }
        /// <summary>
        /// Calculate Warrior's damage per second (DPS). Primary attribute strength affects warrior's DPS.
        /// </summary>
        /// <returns>Warrior's damage per second (DPS)</returns>
        public override double GetDPS()
        {
            if (Equipment[Slot.SLOT_WEAPON] != null)
            {
                return Equipment[Slot.SLOT_WEAPON].GetDPS() + 1 + (BasePrimaryAttributes.Strength + TotalPrimaryAttributes.Strength) / 100;
            }
            return 1 + ((double)(BasePrimaryAttributes.Strength + (double)TotalPrimaryAttributes.Strength) / 100);
        }
    }
}