using RPG_Characters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace RPG_Test
{
    public class ItemTests
    {
        [Fact]
        public void Equip_EquipCharacterWithTooHighLevelWeapon_ShouldReturnInvalidWeaponException()
        {
            //Arrange
            Weapon testWarriorWeapon = new Weapon("testWarriorWeapon", 2, 2, 1, Weapon.WeaponType.WEAPON_AXE);
            Warrior warrior = new Warrior("TestWarrior");

            Weapon testMageWeapon = new Weapon("testMageWeapon", 2, 2, 1, Weapon.WeaponType.WEAPON_STAFF);
            Mage mage = new Mage("TestMage");

            Weapon testRangerWeapon = new Weapon("testRangerWeapon", 2, 2, 1, Weapon.WeaponType.WEAPON_BOW);
            Ranger ranger = new Ranger("TestRanger");

            Weapon testRogueWeapon = new Weapon("testRogueWeapon", 2, 2, 1, Weapon.WeaponType.WEAPON_DAGGER);
            Rogue rogue = new Rogue("TestRogue");

            //Act
            Action actWarrior = () => warrior.Equip(testWarriorWeapon);
            Action mageWarrior = () => mage.Equip(testMageWeapon);
            Action rangerWarrior = () => ranger.Equip(testRangerWeapon);
            Action rogueWarrior = () => rogue.Equip(testRogueWeapon);

            //Assert
            Assert.Throws<InvalidWeaponException>(actWarrior);
            Assert.Throws<InvalidWeaponException>(mageWarrior);
            Assert.Throws<InvalidWeaponException>(rangerWarrior);
            Assert.Throws<InvalidWeaponException>(rogueWarrior);
        }
        [Fact]
        public void Equip_EquipCharacterWithTooHighLevelArmor_ShouldReturnInvalidArmorException()
        {
            //Arrange
            Armor testWarriorArmor = new Armor("testWarriorArmor", 2, Armor.ArmorType.ARMOR_PLATE, 2, 2, 1, 2);
            Warrior warrior = new Warrior("TestWarrior");

            Armor testMageArmor = new Armor("testMageArmor", 2, Armor.ArmorType.ARMOR_CLOTH, 2, 2, 1, 2);
            Mage mage = new Mage("TestMage");

            Armor testRangerArmor = new Armor("testRangerArmor", 2, Armor.ArmorType.ARMOR_LEATHER, 2, 2, 1, 2);
            Ranger ranger = new Ranger("TestRanger");

            Armor testRogueArmor = new Armor("testRogueArmor", 2, Armor.ArmorType.ARMOR_LEATHER, 2, 2, 1, 2);
            Rogue rogue = new Rogue("TestRogue");

            //Act
            Action actWarrior = () => warrior.Equip(testWarriorArmor, Character.Slot.SLOT_BODY);
            Action mageWarrior = () => mage.Equip(testMageArmor, Character.Slot.SLOT_BODY);
            Action rangerWarrior = () => ranger.Equip(testRangerArmor, Character.Slot.SLOT_BODY);
            Action rogueWarrior = () => rogue.Equip(testRogueArmor, Character.Slot.SLOT_BODY);

            //Assert
            Assert.Throws<InvalidArmorException>(actWarrior);
            Assert.Throws<InvalidArmorException>(mageWarrior);
            Assert.Throws<InvalidArmorException>(rangerWarrior);
            Assert.Throws<InvalidArmorException>(rogueWarrior);
        }
        [Fact]
        public void Equip_EquipCharacterWithWrongWeaponType_ShouldReturnInvalidWeaponException()
        {
            //Arrange
            Weapon testWarriorWeapon = new Weapon("testWarriorWeapon", 2, 2, 1, Weapon.WeaponType.WEAPON_BOW);
            Warrior warrior = new Warrior("TestWarrior");

            Weapon testMageWeapon = new Weapon("testMageWeapon", 2, 2, 1, Weapon.WeaponType.WEAPON_BOW);
            Mage mage = new Mage("TestMage");

            Weapon testRangerWeapon = new Weapon("testRangerWeapon", 2, 2, 1, Weapon.WeaponType.WEAPON_STAFF);
            Ranger ranger = new Ranger("TestRanger");

            Weapon testRogueWeapon = new Weapon("testRogueWeapon", 2, 2, 1, Weapon.WeaponType.WEAPON_AXE);
            Rogue rogue = new Rogue("TestRogue");

            //Act
            Action actWarrior = () => warrior.Equip(testWarriorWeapon);
            Action mageWarrior = () => mage.Equip(testMageWeapon);
            Action rangerWarrior = () => ranger.Equip(testRangerWeapon);
            Action rogueWarrior = () => rogue.Equip(testRogueWeapon);

            //Assert
            Assert.Throws<InvalidWeaponException>(actWarrior);
            Assert.Throws<InvalidWeaponException>(mageWarrior);
            Assert.Throws<InvalidWeaponException>(rangerWarrior);
            Assert.Throws<InvalidWeaponException>(rogueWarrior);
        }
        [Fact]
        public void Equip_EquipCharacterWithWrongArmorType_ShouldReturnInvalidArmorException()
        {
            //Arrange
            Armor testWarriorArmor = new Armor("testWarriorArmor", 2, Armor.ArmorType.ARMOR_CLOTH, 2, 2, 1, 2);
            Warrior warrior = new Warrior("TestWarrior");

            Armor testMageArmor = new Armor("testMageArmor", 2, Armor.ArmorType.ARMOR_PLATE, 2, 2, 1, 2);
            Mage mage = new Mage("TestMage");

            Armor testRangerArmor = new Armor("testRangerArmor", 2, Armor.ArmorType.ARMOR_CLOTH, 2, 2, 1, 2);
            Ranger ranger = new Ranger("TestRanger");

            Armor testRogueArmor = new Armor("testRogueArmor", 2, Armor.ArmorType.ARMOR_CLOTH, 2, 2, 1, 2);
            Rogue rogue = new Rogue("TestRogue");

            //Act
            Action actWarrior = () => warrior.Equip(testWarriorArmor, Character.Slot.SLOT_BODY);
            Action mageWarrior = () => mage.Equip(testMageArmor, Character.Slot.SLOT_BODY);
            Action rangerWarrior = () => ranger.Equip(testRangerArmor, Character.Slot.SLOT_BODY);
            Action rogueWarrior = () => rogue.Equip(testRogueArmor, Character.Slot.SLOT_BODY);

            //Assert
            Assert.Throws<InvalidArmorException>(actWarrior);
            Assert.Throws<InvalidArmorException>(mageWarrior);
            Assert.Throws<InvalidArmorException>(rangerWarrior);
            Assert.Throws<InvalidArmorException>(rogueWarrior);
        }
        [Fact]
        public void Equip_EquipCharacterWithValidWeapon_ShouldReturnSuccessMessage()
        {
            //Arrange
            Weapon testWarriorWeapon = new Weapon("testWarriorWeapon", 1, 2, 1, Weapon.WeaponType.WEAPON_BOW);
            Warrior warrior = new Warrior("TestWarrior");

            Weapon testMageWeapon = new Weapon("testMageWeapon", 1, 2, 1, Weapon.WeaponType.WEAPON_BOW);
            Mage mage = new Mage("TestMage");

            Weapon testRangerWeapon = new Weapon("testRangerWeapon", 1, 2, 1, Weapon.WeaponType.WEAPON_STAFF);
            Ranger ranger = new Ranger("TestRanger");

            Weapon testRogueWeapon = new Weapon("testRogueWeapon", 1, 2, 1, Weapon.WeaponType.WEAPON_AXE);
            Rogue rogue = new Rogue("TestRogue");

            string expect = "New weapon equipped!";

            //Act
            string actualWarrior = warrior.Equip(testWarriorWeapon);
            string actualMage = warrior.Equip(testWarriorWeapon);
            string actualRanger = warrior.Equip(testWarriorWeapon);
            string actualRogue = warrior.Equip(testWarriorWeapon);

            //Assert
            Assert.Equal(expect, actualWarrior);
            Assert.Equal(expect, actualMage);
            Assert.Equal(expect, actualRanger);
            Assert.Equal(expect, actualRogue);
        }
        [Fact]
        public void Equip_EquipCharacterWithValidArmor_ShouldReturnSuccessMessage()
        {
            //Arrange
            Armor testWarriorArmor = new Armor("testWarriorArmor", 1, Armor.ArmorType.ARMOR_PLATE, 2, 2, 1, 2);
            Warrior warrior = new Warrior("TestWarrior");

            Armor testMageArmor = new Armor("testMageArmor", 1, Armor.ArmorType.ARMOR_CLOTH, 2, 2, 1, 2);
            Mage mage = new Mage("TestMage");

            Armor testRangerArmor = new Armor("testRangerArmor", 1, Armor.ArmorType.ARMOR_LEATHER, 2, 2, 1, 2);
            Ranger ranger = new Ranger("TestRanger");

            Armor testRogueArmor = new Armor("testRogueArmor", 1, Armor.ArmorType.ARMOR_LEATHER, 2, 2, 1, 2);
            Rogue rogue = new Rogue("TestRogue");

            string expect = "New armor equipped!";

            //Act
            string actualWarrior = warrior.Equip(testWarriorArmor, Character.Slot.SLOT_BODY);
            string actualMage = mage.Equip(testMageArmor, Character.Slot.SLOT_BODY);
            string actualRanger = ranger.Equip(testRangerArmor, Character.Slot.SLOT_BODY);
            string actualRogue = rogue.Equip(testRogueArmor, Character.Slot.SLOT_BODY);

            //Assert
            Assert.Equal(expect, actualWarrior);
            Assert.Equal(expect, actualMage);
            Assert.Equal(expect, actualRanger);
            Assert.Equal(expect, actualRogue);
        }
        [Fact]
        public void GetDPS_GetDPSIfNoWeaponEquipped_ShouldReturnDPS()
        {
            //Arrange
            Warrior warrior = new Warrior("TestWarrior");
            double expectWarrior = 1.05;

            Mage mage = new Mage("TestMage");
            double expectMage = 1;

            Ranger ranger = new Ranger("TestRanger");
            double expectRanger = 1.01;

            Rogue rogue = new Rogue("TestRogue");
            double expectRogue = 1.02;

            //Act
            double actualWarrior = warrior.GetDPS();
            double actualMage = mage.GetDPS();
            double actualRanger = ranger.GetDPS();
            double actualRogue = rogue.GetDPS();

            //Assert
            Assert.Equal(expectWarrior, actualWarrior);
            Assert.Equal(expectMage, actualMage);
            Assert.Equal(expectRanger, actualRanger);
            Assert.Equal(expectRogue, actualRogue);
        }
        [Fact]
        public void GetDPS_GetDPSIfValidWeaponEquiped_ShouldReturnCorrectDPS()
        {         
            //Arrange
            Weapon testWarriorWeapon = new Weapon("testWarriorWeapon", 2, 2, 1, Weapon.WeaponType.WEAPON_AXE);
            Warrior warrior = new Warrior("TestWarrior");
            double expectWarrrior = (7.0 * 1.0) * (1.0 + (5.0 / 100));

            Weapon testMageWeapon = new Weapon("testMageWeapon", 1, 2, 1, Weapon.WeaponType.WEAPON_STAFF);
            Mage mage = new Mage("TestMage");
            double expectMage = (7.0 * 1.0) * (1.0 + (5.0 / 100));

            Weapon testRangerWeapon = new Weapon("testRangerWeapon", 1, 2, 1, Weapon.WeaponType.WEAPON_BOW);
            Ranger ranger = new Ranger("TestRanger");
            double expectRanger = (7.0 * 1.0) * (1.0 + (5.0 / 100));

            Weapon testRogueWeapon = new Weapon("testRogueWeapon", 1, 2, 1, Weapon.WeaponType.WEAPON_SWORD);
            Rogue rogue = new Rogue("TestRogue");
            double expectRogue = (7.0 * 1.0) * (1.0 + (5.0 / 100));

            //Act
            warrior.Equip(testWarriorWeapon);
            mage.Equip(testMageWeapon);
            ranger.Equip(testRangerWeapon);
            rogue.Equip(testRogueWeapon);

            double actualWarrior = warrior.GetDPS();
            double actualMage = mage.GetDPS();
            double actualRanger = ranger.GetDPS();
            double actualRogue = rogue.GetDPS();

            //Assert
            Assert.Equal(expectWarrrior, actualWarrior);
            Assert.Equal(expectMage, actualMage);
            Assert.Equal(expectRanger, actualRanger);
            Assert.Equal(expectRogue, actualRogue);
        }
        [Fact]
        public void GetDPS_GetDPSIfValidWeaponAndArmorEquiped_ShouldReturnCorrectDPS()
        {
            //Arrange
            Armor testWarriorArmor = new Armor("testWarriorArmor", 1, Armor.ArmorType.ARMOR_PLATE, 2, 2, 1, 2);
            Weapon testWarriorWeapon = new Weapon("testWarriorWeapon", 2, 2, 1, Weapon.WeaponType.WEAPON_AXE);
            Warrior warrior = new Warrior("TestWarrior");
            double expectWarrrior = (7.0 * 1.0) * (1.0 + (5.0 / 100));

            Armor testMageArmor = new Armor("testMageArmor", 1, Armor.ArmorType.ARMOR_CLOTH, 2, 2, 1, 2);
            Weapon testMageWeapon = new Weapon("testMageWeapon", 1, 2, 1, Weapon.WeaponType.WEAPON_STAFF);
            Mage mage = new Mage("TestMage");
            double expectMage = (7.0 * 1.0) * (1.0 + (5.0 / 100));

            Armor testRangerArmor = new Armor("testRangerArmor", 1, Armor.ArmorType.ARMOR_LEATHER, 2, 2, 1, 2);
            Weapon testRangerWeapon = new Weapon("testRangerWeapon", 1, 2, 1, Weapon.WeaponType.WEAPON_BOW);
            Ranger ranger = new Ranger("TestRanger");
            double expectRanger = (7.0 * 1.0) * (1.0 + (5.0 / 100));

            Armor testRogueArmor = new Armor("testRogueArmor", 1, Armor.ArmorType.ARMOR_LEATHER, 2, 2, 1, 2);
            Weapon testRogueWeapon = new Weapon("testRogueWeapon", 1, 2, 1, Weapon.WeaponType.WEAPON_SWORD);
            Rogue rogue = new Rogue("TestRogue");
            double expectRogue = (7.0 * 1.0) * (1.0 + (5.0 / 100));

            //Act
            warrior.Equip(testWarriorWeapon);
            mage.Equip(testMageWeapon);
            ranger.Equip(testRangerWeapon);
            rogue.Equip(testRogueWeapon);

            warrior.Equip(testWarriorArmor, Character.Slot.SLOT_BODY);
            mage.Equip(testMageArmor, Character.Slot.SLOT_BODY);
            ranger.Equip(testRangerArmor, Character.Slot.SLOT_BODY);
            rogue.Equip(testRogueArmor, Character.Slot.SLOT_BODY);

            double actualWarrior = warrior.GetDPS();
            double actualMage = mage.GetDPS();
            double actualRanger = ranger.GetDPS();
            double actualRogue = rogue.GetDPS();

            //Assert
            Assert.Equal(expectWarrrior, actualWarrior);
            Assert.Equal(expectMage, actualMage);
            Assert.Equal(expectRanger, actualRanger);
            Assert.Equal(expectRogue, actualRogue);
        }
    }
}
