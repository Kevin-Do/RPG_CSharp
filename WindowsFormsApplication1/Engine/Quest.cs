using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Quest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int RewardExperience { get; set; }
        public int RewardGold { get; set; }

        ///constructor
        
        public Quest(int id, string name, string description, int rewardXp, int rewardGold)
        {
            ID = id;
            Name = name;
            Description = description;
            RewardExperience = rewardXp;
            RewardGold = rewardGold;
        }

    }
}
