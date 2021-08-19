using RPG_Characters;
using System;
using System.Collections.Generic;
using Xunit;

namespace RPG_Test
{
    public class CharacterTests
    {
        [Fact]
        public void GetLevel_GetWarriorLevel_ShouldReturnOne()
        {
            //Arrange
            Warrior warrior = new Warrior("TestWarrior");
            int expected = 1;

            //Act
            int actual = warrior.Level;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetLevel_GetWarriorLevelAfterLevelUp_ShouldReturnTwo()
        {
            //Arrange
            Warrior warrior = new Warrior("TestWarrior");
            int expected = 2;

            //Act
            warrior.LevelUp();
            int actual = warrior.Level;

            //Assert
            Assert.Equal(expected, actual);
        }
        [Theory]
        [InlineData(0)]
        [InlineData(-1)]
        [InlineData(-9165921)]
        public void IncreaseLevelBy_GetWarriorLevelWhenCustomIncrease_ShouldReturnArgumentException(int levelIncrease)
        {
            //Arrange
            Warrior warrior = new Warrior("TestWarrior");

            //Act
            Action act = () => warrior.IncreaseLevelBy(levelIncrease);

            //Assert
            Assert.Throws<ArgumentException>(act);
        }
        [Fact]
        public void GetWarriorBasePrimaryAttributes_GetWarriorBasePrimaryAttributesAfterInstantiation_ShouldReturnLevelOneStats()
        {
            //Arrange
            Warrior warrior = new Warrior("TestWarrior");
            int expectedStrength = 5;
            int expectedDexterity = 2;
            int expectedIntelligence = 1;
            int expectedVitality = 10;

            //Act
            int actualStrength = warrior.BasePrimaryAttributes.Strength;
            int actualDexterity = warrior.BasePrimaryAttributes.Dexterity;
            int actualIntelligence = warrior.BasePrimaryAttributes.Intelligence;
            int actualVitality = warrior.BasePrimaryAttributes.Vitality;

            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
            Assert.Equal(expectedVitality, actualVitality);
        }
        [Fact]
        public void GetMageBasePrimaryAttributes_GetMageBasePrimaryAttributesAfterInstantiation_ShouldReturnLevelOneStats()
        {
            //Arrange
            Mage mage = new Mage("TestMage");
            int expectedStrength = 1;
            int expectedDexterity = 1;
            int expectedIntelligence = 8;
            int expectedVitality = 5;

            //Act
            int actualStrength = mage.BasePrimaryAttributes.Strength;
            int actualDexterity = mage.BasePrimaryAttributes.Dexterity;
            int actualIntelligence = mage.BasePrimaryAttributes.Intelligence;
            int actualVitality = mage.BasePrimaryAttributes.Vitality;

            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
            Assert.Equal(expectedVitality, actualVitality);
        }
        [Fact]
        public void GetRangerBasePrimaryAttributes_GetRangerBasePrimaryAttributesAfterInstantiation_ShouldReturnLevelOneStats()
        {
            //Arrange
            Ranger ranger = new Ranger("TestRanger");
            int expectedStrength = 1;
            int expectedDexterity = 7;
            int expectedIntelligence = 1;
            int expectedVitality = 8;

            //Act
            int actualStrength = ranger.BasePrimaryAttributes.Strength;
            int actualDexterity = ranger.BasePrimaryAttributes.Dexterity;
            int actualIntelligence = ranger.BasePrimaryAttributes.Intelligence;
            int actualVitality = ranger.BasePrimaryAttributes.Vitality;

            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
            Assert.Equal(expectedVitality, actualVitality);
        }
        [Fact]
        public void GetRogueBasePrimaryAttributes_GetRogueBasePrimaryAttributesAfterInstantiation_ShouldReturnLevelOneStats()
        {
            //Arrange
            Rogue rogue = new Rogue("TestRogue");
            int expectedStrength = 2;
            int expectedDexterity = 6;
            int expectedIntelligence = 1;
            int expectedVitality = 8;

            //Act
            int actualStrength = rogue.BasePrimaryAttributes.Strength;
            int actualDexterity = rogue.BasePrimaryAttributes.Dexterity;
            int actualIntelligence = rogue.BasePrimaryAttributes.Intelligence;
            int actualVitality = rogue.BasePrimaryAttributes.Vitality;

            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
            Assert.Equal(expectedVitality, actualVitality);
        }
        [Fact]
        public void GetWarriorBasePrimaryAttributes_GetWarriorBasePrimaryAttributesAfterLevelup_ShouldReturnLevelTwoStats()
        {
            //Arrange
            Warrior warrior = new Warrior("TestWarrior");
            int expectedStrength = 8;
            int expectedDexterity = 4;
            int expectedIntelligence = 2;
            int expectedVitality = 15;

            //Act
            warrior.LevelUp();
            int actualStrength = warrior.BasePrimaryAttributes.Strength;
            int actualDexterity = warrior.BasePrimaryAttributes.Dexterity;
            int actualIntelligence = warrior.BasePrimaryAttributes.Intelligence;
            int actualVitality = warrior.BasePrimaryAttributes.Vitality;

            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
            Assert.Equal(expectedVitality, actualVitality);
        }
        [Fact]
        public void GetMageBasePrimaryAttributes_GetMageBasePrimaryAttributesAfterLevelup_ShouldReturnLevelTwoStats()
        {
            //Arrange
            Mage mage = new Mage("TestMage");
            int expectedStrength = 2;
            int expectedDexterity = 2;
            int expectedIntelligence = 13;
            int expectedVitality = 8;

            //Act
            mage.LevelUp();
            int actualStrength = mage.BasePrimaryAttributes.Strength;
            int actualDexterity = mage.BasePrimaryAttributes.Dexterity;
            int actualIntelligence = mage.BasePrimaryAttributes.Intelligence;
            int actualVitality = mage.BasePrimaryAttributes.Vitality;

            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
            Assert.Equal(expectedVitality, actualVitality);
        }
        [Fact]
        public void GetRangerBasePrimaryAttributes_GetRangerBasePrimaryAttributesAfterLevelup_ShouldReturnLevelTwoStats()
        {
            //Arrange
            Ranger ranger = new Ranger("TestRanger");
            int expectedStrength = 2;
            int expectedDexterity = 12;
            int expectedIntelligence = 2;
            int expectedVitality = 10;

            //Act
            ranger.LevelUp();
            int actualStrength = ranger.BasePrimaryAttributes.Strength;
            int actualDexterity = ranger.BasePrimaryAttributes.Dexterity;
            int actualIntelligence = ranger.BasePrimaryAttributes.Intelligence;
            int actualVitality = ranger.BasePrimaryAttributes.Vitality;

            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
            Assert.Equal(expectedVitality, actualVitality);
        }
        [Fact]
        public void GetRogueBasePrimaryAttributes_GetRogueBasePrimaryAttributesAfterLevelup_ShouldReturnLevelTwoStats()
        {
            //Arrange
            Rogue rogue = new Rogue("TestRogue");
            int expectedStrength = 3;
            int expectedDexterity = 10;
            int expectedIntelligence = 2;
            int expectedVitality = 11;

            //Act
            rogue.LevelUp();
            int actualStrength = rogue.BasePrimaryAttributes.Strength;
            int actualDexterity = rogue.BasePrimaryAttributes.Dexterity;
            int actualIntelligence = rogue.BasePrimaryAttributes.Intelligence;
            int actualVitality = rogue.BasePrimaryAttributes.Vitality;

            //Assert
            Assert.Equal(expectedStrength, actualStrength);
            Assert.Equal(expectedDexterity, actualDexterity);
            Assert.Equal(expectedIntelligence, actualIntelligence);
            Assert.Equal(expectedVitality, actualVitality);
        }
        [Fact]
        public void GetWarriorSecondaryAttributes_GetWarriorSecondaryAttributesAfterLevelup_ShouldReturnLevelTwoStats()
        {
            //Arrange
            Warrior warrior = new Warrior("TestWarrior");
            int expectedHealth = 100;
            int expectedArmorRating = 7;
            int expectedElementalResistance = 1;

            //Act
            warrior.LevelUp();
            double actualHealth = warrior.SecondaryAttributes.Health;
            int actualArmorRating = warrior.SecondaryAttributes.ArmorRating;
            int actualElementalResistance = warrior.SecondaryAttributes.ElementalResistance;

            //Assert
            Assert.Equal(expectedHealth, actualHealth);
            Assert.Equal(expectedArmorRating, actualArmorRating);
            Assert.Equal(expectedElementalResistance, actualElementalResistance);
        }
        [Fact]
        public void GetMageSecondaryAttributes_GetMageSecondaryAttributesAfterLevelup_ShouldReturnLevelTwoStats()
        {
            //Arrange
            Mage mage = new Mage("TestMage");
            int expectedHealth = 50;
            int expectedArmorRating = 2;
            int expectedElementalResistance = 8;

            //Act
            mage.LevelUp();
            double actualHealth = mage.SecondaryAttributes.Health;
            int actualArmorRating = mage.SecondaryAttributes.ArmorRating;
            int actualElementalResistance = mage.SecondaryAttributes.ElementalResistance;

            //Assert
            Assert.Equal(expectedHealth, actualHealth);
            Assert.Equal(expectedArmorRating, actualArmorRating);
            Assert.Equal(expectedElementalResistance, actualElementalResistance);
        }
        [Fact]
        public void GetRangerSecondaryAttributes_GetRangerSecondaryAttributesAfterLevelup_ShouldReturnLevelTwoStats()
        {
            //Arrange
            Ranger ranger = new Ranger("TestRanger");
            int expectedHealth = 80;
            int expectedArmorRating = 8;
            int expectedElementalResistance = 1;

            //Act
            ranger.LevelUp();
            double actualHealth = ranger.SecondaryAttributes.Health;
            int actualArmorRating = ranger.SecondaryAttributes.ArmorRating;
            int actualElementalResistance = ranger.SecondaryAttributes.ElementalResistance;

            //Assert
            Assert.Equal(expectedHealth, actualHealth);
            Assert.Equal(expectedArmorRating, actualArmorRating);
            Assert.Equal(expectedElementalResistance, actualElementalResistance);
        }
        [Fact]
        public void GetRogueSecondaryAttributes_GetRogueSecondaryAttributesAfterLevelup_ShouldReturnLevelTwoStats()
        {
            //Arrange
            Rogue rogue = new Rogue("TestRogue");
            int expectedHealth = 80;
            int expectedArmorRating = 8;
            int expectedElementalResistance = 1;

            //Act
            rogue.LevelUp();
            double actualHealth = rogue.SecondaryAttributes.Health;
            int actualArmorRating = rogue.SecondaryAttributes.ArmorRating;
            int actualElementalResistance = rogue.SecondaryAttributes.ElementalResistance;

            //Assert
            Assert.Equal(expectedHealth, actualHealth);
            Assert.Equal(expectedArmorRating, actualArmorRating);
            Assert.Equal(expectedElementalResistance, actualElementalResistance);
        }
    }
}
