using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Monster : LivingCreatures
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int MaximumDamage { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }

        public Monster (int id, string name, string description, int maxDMG, int rewardXP, int rewardGold, int currentHP, int maxHP) : base(currentHP, maxHP)
        {
            ID = id;
            Name = name;
            Description = description;
            MaximumDamage = maxDMG;
            RewardExperience = rewardXP;
            RewardGold = rewardGold;
        }
    }
}
