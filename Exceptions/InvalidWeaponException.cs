using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Characters
{
    [Serializable]
    public class InvalidWeaponException : Exception
    {
        public InvalidWeaponException(){}

        public InvalidWeaponException(Weapon weapon) : base(String.Format("Character can not equip weapon: {0}", weapon))
        {

        }
    }
}
