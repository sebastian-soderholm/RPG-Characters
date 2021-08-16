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
            Cloth,
            Leather,
            Mail,
            Plate
        }
    }
}
