using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public class Player : LivingCreatures
    {
        public int Gold { get; set; }
        public int ExperiencePoints { get; set; }
        public int Level { get; set; }
        public string Job { get; set; }
        public string Name { get; set; }

        // Lists //

        public List <InventoryItem> Inventory { get; set; }
        public List <PlayerQuest> Quests { get; set; }

        public Player(int gold, int xp, int level, string job, int CurrentHealth, int MaximumHealth, string pName) : base (CurrentHealth, MaximumHealth)
        {
            Gold = gold;
            ExperiencePoints = xp;
            Level = level;
            Job = job;
            Name = pName;
            Inventory = new List<InventoryItem>();
            Quests = new List<PlayerQuest>();

        }
    }
}
