using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RPG_Characters
{
    public abstract class Character
    {
        private string Name;
        private int Level = 1;
        private PrimaryAttribute primaryAttribute;
        private SecondaryAttribute secondaryAttribute;
        private StringBuilder characterStatsString;
    }
}