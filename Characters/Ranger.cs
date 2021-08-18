using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Characters
{
    public class Ranger : Character
    {
        /// <summary>
        /// Types of items that Ranger can equip
        /// </summary>
        public enum equippableItems
        {
            WEAPON_BOW, ARMOR_MAIL, ARMOR_LEATHER
        }
        /// <summary>
        /// Create Ranger instance based on level 1 stats
        /// </summary>
        /// <param name="name">Ranger's name</param>
        public Ranger(string name)
        {
            Name = name;
            Level = 1;
            BasePrimaryAttributes = new PrimaryAttributes(1, 7, 1, 8);
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
        /// Increase Ranger's level by 1
        /// Increase primary attributes based on character type
        /// </summary>
        public override void LevelUp()
        {
            Level++;
            BasePrimaryAttributes.Strength += 1;
            BasePrimaryAttributes.Dexterity += 5;
            BasePrimaryAttributes.Intelligence += 1;
            BasePrimaryAttributes.Vitality += 2;
        }
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
        /// Equip armor in given Slot if armor type and level meet Ranger's requirements
        /// </summary>
        /// <param name="armorToEquip">Armor that Ranger tries to equip</param>
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
        /// Calculate Ranger's damage per second (DPS). Primary attribute strength affects Ranger's DPS.
        /// </summary>
        /// <returns>Ranger's damage per second (DPS)</returns>
        public override float GetDPS()
        {
            if (Equipment[Slot.SLOT_WEAPON] != null)
            {
                return Equipment[Slot.SLOT_WEAPON].GetDPS() +
                    1 + (BasePrimaryAttributes.Strength + TotalPrimaryAttributes.Strength) / 100;
            }
            return 1;
        }
    }
}