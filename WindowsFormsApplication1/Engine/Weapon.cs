using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Weapon : Item
    {
        public string Description { get; set; }
        public int MinimumDamage { get; set; }
        public int MaximumDamage { get; set; }
        public int CriticalDamage { get; set; }

        public Weapon (int id, string name, string namePlural, string description, int minDMG, int maxDMG, int critDMG) : base(id, name, namePlural)
        {
            Description = description;
            MinimumDamage = minDMG;
            MaximumDamage = maxDMG;
            CriticalDamage = critDMG;
        }
    }
}
