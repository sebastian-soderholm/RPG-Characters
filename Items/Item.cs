using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RPG_Characters
{
    public abstract class Item
    {
        public string Name { get; set; }
        public int RequiredLevel { get; set; }

        /// <summary>
        /// Return DPS value of item.
        /// </summary>
        /// <returns>DPS value as int. For items without DPS, return 0. </returns>
        public virtual int GetDPS() { return 0; } 
        
    }
}
