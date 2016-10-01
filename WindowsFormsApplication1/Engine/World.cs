using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine
{
    public static class World
    {
        public static readonly List<Item> Items = new List<Item>();
        public static readonly List<Monster> Monsters = new List<Monster>();
        public static readonly List<Quest> Quests = new List<Quest>();
        public static readonly List<Location> Locations = new List<Location>();

        public const int ITEM_ID_RUSTY_SWORD = 1;
        public const int ITEM_ID_PARCHMENT_PAPER = 2; // cultist
        public const int ITEM_ID_RAGGED_CLOTH = 3; // cultist

        public const int ITEM_ID_ECTOPLASM = 4; //ghoul
        public const int ITEM_ID_DEMONIC_CORE = 5; //ghoul

        public const int ITEM_ID_CLUB = 6;
        public const int ITEM_ID_HEALING_POTION = 7;
        public const int ITEM_ID_DEAD_FLESH = 8; //zombie
        public const int ITEM_ID_ROTTEN_ABSCESS = 9; //zombie
        public const int ITEM_ID_NECRONOMICON = 10;

        public const int MONSTER_ID_CULTIST = 1;
        public const int MONSTER_ID_GHOUL = 2;
        public const int MONSTER_ID_NIGHT_WALKER = 3;

        public const int QUEST_ID_CLEAR_ALCHEMIST_GARDEN = 1;
        public const int QUEST_ID_CLEAR_FARMERS_FIELD = 2;

        public const int LOCATION_ID_HOME = 1;
        public const int LOCATION_ID_TOWN_SQUARE = 2;
        public const int LOCATION_ID_GUARD_POST = 3;
        public const int LOCATION_ID_ALCHEMIST_HUT = 4;
        public const int LOCATION_ID_ALCHEMISTS_GARDEN = 5;
        public const int LOCATION_ID_FARMHOUSE = 6;
        public const int LOCATION_ID_FARM_FIELD = 7;
        public const int LOCATION_ID_BRIDGE = 8;
        public const int LOCATION_ID_SPIDER_FIELD = 9;

        public const int ITEM_ID_SILVER_PISTOL = 10;
        public const int ITEM_ID_BLESSED_RIFLE = 11;

        static World()
        {
            PopulateItems();
            PopulateMonsters();
            PopulateQuests();
            PopulateLocations();
        }

        private static void PopulateItems()
        {
            Items.Add(new Weapon(ITEM_ID_RUSTY_SWORD, "Rusty sword", "Rusty swords", "A Rusty sword", 0, 5, 9));
            Items.Add(new Item(ITEM_ID_PARCHMENT_PAPER, "Torn page of parchment", "Torn pages of parchment"));
            Items.Add(new Item(ITEM_ID_RAGGED_CLOTH, "Blood-soaked piece of cloth", "Blood-soaked pieces of cloth"));

            Items.Add(new Item(ITEM_ID_ECTOPLASM, "Chunk of black tar-like goo", "Chunks of black tar-like goo"));
            Items.Add(new Item(ITEM_ID_DEMONIC_CORE, "Chunk of pulsating flesh", "Chunks of pulsating flesh"));

            Items.Add(new Weapon(ITEM_ID_CLUB, "Wooden Club", "Wooden Clubs", "A battered slab of wood", 3, 10, 15));
            Items.Add(new Weapon(ITEM_ID_SILVER_PISTOL,"Silver Pistol", "Silver Pistols", "A short snout revolver", 9, 18, 27)); // new item
            Items.Add(new Weapon(ITEM_ID_BLESSED_RIFLE, "Firearm Long Rifle", "Firearm Long Rifles", "The Vampire Hunter Special with cross encrusted bullets", 66, 77, 1337)); // new item
            Items.Add(new HealingPotion(ITEM_ID_HEALING_POTION, "Healing potion", "Healing potions", 35));

            Items.Add(new Item(ITEM_ID_DEAD_FLESH, "Lump of disgusting human flesh", "Lumps of disgusting human flesh"));
            Items.Add(new Item(ITEM_ID_ROTTEN_ABSCESS, "Pool of excreted pus", "Pool of excreted pus"));
            Items.Add(new Item(ITEM_ID_NECRONOMICON, "Luciferian manuscript worshipping Eosphoros", "Luciferian manuscripts worshipping Eosphoros"));
        }

        private static void PopulateMonsters()
        {
            Monster cultist = new Monster(MONSTER_ID_CULTIST, "Satanic Worshipper", "A dark hooded figure crosses your path, blood symbols splatter its ragged garments... ", 3, 3, 5, 5, 5);  // CULTIST
            cultist.LootTable.Add(new LootItem(ItemByID(ITEM_ID_PARCHMENT_PAPER), 35, false));
            cultist.LootTable.Add(new LootItem(ItemByID(ITEM_ID_RAGGED_CLOTH), 85, true));

            Monster ghoul = new Monster(MONSTER_ID_GHOUL, "Black Apparition", "A hulking figure phases into perspective, it distorts the air and ground, expelling caustic fumes...", 20, 7, 0, 20, 20); //GHOUL
            ghoul.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ECTOPLASM), 75, true));
            ghoul.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DEMONIC_CORE), 45, true));

            Monster nightWalker = new Monster(MONSTER_ID_NIGHT_WALKER, "Zombified Walking Corpse", "A putrid stench penetrates the mist, out stumbles a rotting decomposing human covered in bite marks...", 7, 5, 5, 2, 2); //ZOMBIE
            nightWalker.LootTable.Add(new LootItem(ItemByID(ITEM_ID_DEAD_FLESH), 95, true));
            nightWalker.LootTable.Add(new LootItem(ItemByID(ITEM_ID_ROTTEN_ABSCESS), 95, true));

            //TODO: BOSS VAMPIRE

            Monsters.Add(cultist);
            Monsters.Add(ghoul);
            Monsters.Add(nightWalker);
        }

        private static void PopulateQuests()
        {
            Quest clearAlchemistGarden =
                new Quest(
                    QUEST_ID_CLEAR_ALCHEMIST_GARDEN,
                    "Investigate the Lab",
                    "People have gone missing on errands heading north. I'm really worried, do you think you could find my three friends? Bring back anything you can!", 20, 10);

            clearAlchemistGarden.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_DEAD_FLESH), 3));

            clearAlchemistGarden.RewardItem = ItemByID(ITEM_ID_SILVER_PISTOL);

            Quest clearFarmersField =
                new Quest(
                    QUEST_ID_CLEAR_FARMERS_FIELD,
                    "Whose using the barn?",
                    "I can't believe Farm Head John is dead... Something supernatural is going on. *sobs* Sorry to ask, but can you figure out why people are still going to his farm house?", 30, 20);

            clearFarmersField.QuestCompletionItems.Add(new QuestCompletionItem(ItemByID(ITEM_ID_PARCHMENT_PAPER), 1));

            clearFarmersField.RewardItem = ItemByID(ITEM_ID_NECRONOMICON);
            clearFarmersField.RewardItem = ItemByID(ITEM_ID_BLESSED_RIFLE);

            Quests.Add(clearAlchemistGarden);
            Quests.Add(clearFarmersField);
        }

        private static void PopulateLocations()
        {
            // Create each location
            Location home = new Location(LOCATION_ID_HOME, "Home", "Your rented room. This place is moldy and the wood is falling apart...");

            Location townSquare = new Location(LOCATION_ID_TOWN_SQUARE, "Town square", "Cobblestoned town center with a few loiters and empty stores... ");

            Location alchemistHut = new Location(LOCATION_ID_ALCHEMIST_HUT, "Alchemist's hut", "Toxic chemicals and flumes waft in the air. You can't help but cover your nose. There a lot of dissected flesh... humans?");
            alchemistHut.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_ALCHEMIST_GARDEN);

            Location alchemistsGarden = new Location(LOCATION_ID_ALCHEMISTS_GARDEN, "Alchemist's garden", "There are guttural moans in the far distance...? There's blood and abnormal growths everywhere!");
            alchemistsGarden.MonsterLivingHere = MonsterByID(MONSTER_ID_NIGHT_WALKER);

            Location farmhouse = new Location(LOCATION_ID_FARMHOUSE, "Farmhouse", "There is a small farmhouse, with a farmer in front.");
            farmhouse.QuestAvailableHere = QuestByID(QUEST_ID_CLEAR_FARMERS_FIELD);

            Location farmersField = new Location(LOCATION_ID_FARM_FIELD, "Farmer's field", "Fields of cultivated cornstalks, there's a large circle clearing and faint sounds of chanting far away.");
            farmersField.MonsterLivingHere = MonsterByID(MONSTER_ID_CULTIST);

            Location guardPost = new Location(LOCATION_ID_GUARD_POST, "Guard post", "A hooded figure with red-glowing eyes. He has a chain around his neck. His piercing gaze seemingly on guard.", ItemByID(ITEM_ID_NECRONOMICON));

            Location bridge = new Location(LOCATION_ID_BRIDGE, "Bridge", "A stone bridge crosses a wide river.");

            Location spiderField = new Location(LOCATION_ID_SPIDER_FIELD, "Forest", "You see spider webs covering covering the trees in this forest. The trees are wilted with dark burn marks everywhere.");
            spiderField.MonsterLivingHere = MonsterByID(MONSTER_ID_GHOUL);

            // Link the locations together
            home.LocationToNorth = townSquare;

            townSquare.LocationToNorth = alchemistHut;
            townSquare.LocationToSouth = home;
            townSquare.LocationToEast = guardPost;
            townSquare.LocationToWest = farmhouse;

            farmhouse.LocationToEast = townSquare;
            farmhouse.LocationToWest = farmersField;

            farmersField.LocationToEast = farmhouse;

            alchemistHut.LocationToSouth = townSquare;
            alchemistHut.LocationToNorth = alchemistsGarden;

            alchemistsGarden.LocationToSouth = alchemistHut;

            guardPost.LocationToEast = bridge;
            guardPost.LocationToWest = townSquare;

            bridge.LocationToWest = guardPost;
            bridge.LocationToEast = spiderField;

            spiderField.LocationToWest = bridge;

            // Add the locations to the static list
            Locations.Add(home);
            Locations.Add(townSquare);
            Locations.Add(guardPost);
            Locations.Add(alchemistHut);
            Locations.Add(alchemistsGarden);
            Locations.Add(farmhouse);
            Locations.Add(farmersField);
            Locations.Add(bridge);
            Locations.Add(spiderField);
        }

        public static Item ItemByID(int id)
        {
            foreach (Item item in Items)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }

        public static Monster MonsterByID(int id)
        {
            foreach (Monster monster in Monsters)
            {
                if (monster.ID == id)
                {
                    return monster;
                }
            }

            return null;
        }

        public static Quest QuestByID(int id)
        {
            foreach (Quest quest in Quests)
            {
                if (quest.ID == id)
                {
                    return quest;
                }
            }

            return null;
        }

        public static Location LocationByID(int id)
        {
            foreach (Location location in Locations)
            {
                if (location.ID == id)
                {
                    return location;
                }
            }

            return null;
        }
    }
}
