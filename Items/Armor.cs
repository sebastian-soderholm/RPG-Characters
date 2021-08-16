using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters
{
    public class Armor : Item
    {
        public ArmorType Type { get; set; }
        public enum ArmorType
        {
            ARMOR_CLOTH,
            ARMOR_LEATHER,
            ARMOR_MAIL,
            ARMOR_PLATE
        }
    }
}
