using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Location 
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public Item ItemRequiredToEnter { get; set; }
        public Quest QuestAvailableHere { get; set; }
        public Monster MonsterLivingHere { get; set; }

        /// locations
        public Location Cemetery { get; set; }
        public Location AbandonedChurch { get; set; }
        public Location LathanielForest { get; set; }
        public Location TownCenter { get; set; }

        /// constructor code, must pass in these 3 values
        public Location (int id, string name, string description)
        {
            ID = id;
            Name = name;
            Description = description;
        }
    }
}
