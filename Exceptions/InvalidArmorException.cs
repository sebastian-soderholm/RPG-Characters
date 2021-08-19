using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters
{
    [Serializable]
    public class InvalidArmorException : Exception
    {
        public InvalidArmorException(){}

        public InvalidArmorException(Armor armor) : base(String.Format("Character can not equip armor: {0}", armor)){}
    }
}
