using System;
using System.Collections.Generic;

namespace RPG_Characters
{
    public class Rogue : Character
    {
        /// <summary>
        /// Types of items that Rogue can equip
        /// </summary>
        public enum equippableItems
        {
            WEAPON_DAGGER, WEAPON_SWORD, ARMOR_MAIL, ARMOR_LEATHER
        }
        /// <summary>
        /// Create Rogue instance based on level 1 stats
        /// </summary>
        /// <param name="name">Rogue's name</param>
        public Rogue(string name)
        {
            Name = name;
            Level = 1;
            BasePrimaryAttributes = new PrimaryAttributes(2, 6, 1, 8);
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
        /// Increase Rogue's level by 1
        /// Increase primary attributes based on character type
        /// </summary>
        public override void LevelUp()
        {
            Level++;
            BasePrimaryAttributes.Strength += 1;
            BasePrimaryAttributes.Dexterity += 4;
            BasePrimaryAttributes.Intelligence += 1;
            BasePrimaryAttributes.Vitality += 3;
        }
        /// <summary>
        /// Equip weapon if type and level meet Rogue's requirements
        /// </summary>
        /// <param name="weaponToEquip">Weapon that Rogue tries to equip</param>
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
                return "New weapon equipped!";
            }
        }
        /// <summary>
        /// Equip armor in given Slot if armor type and level meet Rogue's requirements
        /// </summary>
        /// <param name="armorToEquip">Armor that Rogue tries to equip</param>
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
        /// Calculate Rogue's damage per second (DPS). Primary attribute strength affects Rogue's DPS.
        /// </summary>
        /// <returns>Rogue's damage per second (DPS)</returns>
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