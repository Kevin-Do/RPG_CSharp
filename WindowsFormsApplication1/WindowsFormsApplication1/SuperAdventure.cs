using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Engine;

namespace WindowsFormsApplication1
{
    public partial class SuperAdventure : Form
    {
        private Player _player;
        private Monster _currentMonster;

        public SuperAdventure()
        {
            InitializeComponent();

            _player = new Player(5, 0, 1, "Deputy", 100, 100, "Kathie Tucson");
            MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
            LocationPicture(_player.CurrentLocation);
            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_RUSTY_SWORD), 1));

            lblHealth.Text = _player.CurrentHealth.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblXP.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
            player_name.Text = _player.Name.ToString();
            lblPlayerJob.Text = _player.Job.ToString();


        }

        private void btnNorth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToNorth);
            LocationPicture(_player.CurrentLocation);
        }


        private void btnSouth_Click(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToSouth);
            LocationPicture(_player.CurrentLocation);
        }

        private void LocationPicture(Location newLocation)
        {
  
            switch (newLocation.ID)
            {
                case 1:
                    pictureBox2.Image = Image.FromFile(@"C:\Users\krusa\OneDrive\Documents\Visual Studio 2015\Projects\VampSharp-RPG\WindowsFormsApplication1\WindowsFormsApplication1\Resources\Antique-Italian-Tower-Room.jpg");
                    break;
                case 2:
                    pictureBox2.Image = Image.FromFile(@"C:\Users\krusa\OneDrive\Documents\Visual Studio 2015\Projects\VampSharp-RPG\WindowsFormsApplication1\WindowsFormsApplication1\Resources\12-abandoned-town-large-squ.jpg");
                    break;
                case 3:
                    pictureBox2.Image = Image.FromFile(@"C:\Users\krusa\OneDrive\Documents\Visual Studio 2015\Projects\VampSharp-RPG\WindowsFormsApplication1\WindowsFormsApplication1\Resources\3079554813_2a040dc629_b.jpg");
                    break;
                case 4:
                    pictureBox2.Image = Image.FromFile(@"C:\Users\krusa\OneDrive\Documents\Visual Studio 2015\Projects\VampSharp-RPG\WindowsFormsApplication1\WindowsFormsApplication1\Resources\alchemy_lab_by_jonsmith512-d993woi.jpg");
                    break;
                case 5:
                    pictureBox2.Image = Image.FromFile(@"C:\Users\krusa\OneDrive\Documents\Visual Studio 2015\Projects\VampSharp-RPG\WindowsFormsApplication1\WindowsFormsApplication1\Resources\adec725b82a5560754d30a33b725984a.jpg");
                    break;
                case 6:
                    pictureBox2.Image = Image.FromFile(@"C:\Users\krusa\OneDrive\Documents\Visual Studio 2015\Projects\VampSharp-RPG\WindowsFormsApplication1\WindowsFormsApplication1\Resources\beebo-wallace,house-fall-abandoned-home-rural-nc-farm-country-northcarolina-cornstalks-pittcounty-pittcountync.jpg");
                    break;
                case 7:
                    pictureBox2.Image = Image.FromFile(@"C:\Users\krusa\OneDrive\Documents\Visual Studio 2015\Projects\VampSharp-RPG\WindowsFormsApplication1\WindowsFormsApplication1\Resources\corn-maze.jpg");
                    break;
                case 8:
                    pictureBox2.Image = Image.FromFile(@"C:\Users\krusa\OneDrive\Documents\Visual Studio 2015\Projects\VampSharp-RPG\WindowsFormsApplication1\WindowsFormsApplication1\Resources\e3a5500b4523e1494994e49ce5d269ca.jpg");
                    break;
                case 9:
                    pictureBox2.Image = Image.FromFile(@"C:\Users\krusa\OneDrive\Documents\Visual Studio 2015\Projects\VampSharp-RPG\WindowsFormsApplication1\WindowsFormsApplication1\Resources\Art-dark-car-forest-night-ride-bush-the-moon-mercedes-spider-horror.jpg");
                    break;
            }
        }
        private void MoveTo(Location newLocation)
        {
            //Does the location have any required items
            if (!_player.HasRequiredItemToEnterThisLocation(newLocation))
            {
                rtbMessages.Text += "The hooded figure shakes angrily at you, YOU NEED A " + newLocation.ItemRequiredToEnter.Name + "! GET OUT!" + Environment.NewLine;
                return;
            }

            // Update the player's current location
            _player.CurrentLocation = newLocation;

            // Show/hide available movement buttons
            btnNorth.Visible = (newLocation.LocationToNorth != null);
            btnEast.Visible = (newLocation.LocationToEast != null);
            btnSouth.Visible = (newLocation.LocationToSouth != null);
            btnWest.Visible = (newLocation.LocationToWest != null);

            // Display current location name and description
            rtbLocation.Text = newLocation.Name + Environment.NewLine;
            rtbLocation.Text += newLocation.Description + Environment.NewLine;

            // Completely heal the player
            //_player.CurrentHealth = _player.MaximumHealth;

            // Update Hit Points in UI
            lblHealth.Text = _player.CurrentHealth.ToString();

            // Does the location have a quest?
            if (newLocation.QuestAvailableHere != null)
            {
                // See if the player already has the quest, and if they've completed it
                bool playerAlreadyHasQuest = _player.HasThisQuest(newLocation.QuestAvailableHere);
                bool playerAlreadyCompletedQuest = _player.CompletedThisQuest(newLocation.QuestAvailableHere);

                // See if the player already has the quest
                if (playerAlreadyHasQuest)
                {
                    // If the player has not completed the quest yet
                    if (!playerAlreadyCompletedQuest)
                    {
                        // See if the player has all the items needed to complete the quest
                        bool playerHasAllItemsToCompleteQuest = _player.HasAllQuestCompletionItems(newLocation.QuestAvailableHere);

                        // The player has all items required to complete the quest
                        if (playerHasAllItemsToCompleteQuest)
                        {
                            // Display message
                            rtbMessages.Text += Environment.NewLine;
                            rtbMessages.Text += "You completed the '" + newLocation.QuestAvailableHere.Name + "' quest." + Environment.NewLine;
                            _player.Inventory.Add(new InventoryItem(World.ItemByID(World.ITEM_ID_HEALING_POTION), 5));

                            // Remove quest items from inventory
                            _player.RemoveQuestCompletionItems(newLocation.QuestAvailableHere);

                            // Give quest rewards
                            rtbMessages.Text += "The quest has given you: " + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardExperience.ToString() + " experience points" + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardGold.ToString() + " gold" + Environment.NewLine;
                            rtbMessages.Text += newLocation.QuestAvailableHere.RewardItem.Name + Environment.NewLine;
                            rtbMessages.Text += Environment.NewLine;

                            _player.ExperiencePoints += newLocation.QuestAvailableHere.RewardExperience;
                            _player.Gold += newLocation.QuestAvailableHere.RewardGold;

                            // Add the reward item to the player's inventory
                            _player.AddItemToInventory(newLocation.QuestAvailableHere.RewardItem);

                            // Mark the quest as completed
                            _player.MarkQuestCompleted(newLocation.QuestAvailableHere);
                        }
                    }
                }
                else
                {
                    // The player does not already have the quest

                    // Display the messages
                    rtbMessages.Text += Environment.NewLine +"A villager asks you to help them with ..." + newLocation.QuestAvailableHere.Name + "." + Environment.NewLine;
                    rtbMessages.Text += Environment.NewLine + newLocation.QuestAvailableHere.Description + Environment.NewLine;
                    rtbMessages.Text += "To complete it, return with:" + Environment.NewLine;
                    foreach (QuestCompletionItem qci in newLocation.QuestAvailableHere.QuestCompletionItems)
                    {
                        if (qci.Quantity == 1)
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.Name + Environment.NewLine;
                        }
                        else
                        {
                            rtbMessages.Text += qci.Quantity.ToString() + " " + qci.Details.NamePlural + Environment.NewLine;
                        }
                    }
                    rtbMessages.Text += Environment.NewLine;

                    // Add the quest to the player's quest list
                    _player.Quests.Add(new PlayerQuest(newLocation.QuestAvailableHere, false)); //questional false
                }
            }

            // Does the location have a monster?
            if (newLocation.MonsterLivingHere != null)
            {

                rtbMessages.Text += "You see a " + newLocation.MonsterLivingHere.Name + Environment.NewLine;

                // Make a new monster, using the values from the standard monster in the World.Monster list
                Monster standardMonster = World.MonsterByID(newLocation.MonsterLivingHere.ID);

                _currentMonster = new Monster(standardMonster.ID, standardMonster.Name, standardMonster.Description, standardMonster.MaximumDamage,
                    standardMonster.RewardExperience, standardMonster.RewardGold, standardMonster.CurrentHealth, standardMonster.MaximumHealth);

                foreach (LootItem lootItem in standardMonster.LootTable)
                {
                    _currentMonster.LootTable.Add(lootItem);
                }

                cboWeapons.Visible = true;
                cboPotions.Visible = true;
                btnUseWeapon.Visible = true;
                btnUsePotion.Visible = true;

                cboWeapons.Enabled = true;
                cboPotions.Enabled = true;
                btnUseWeapon.Enabled = true;
                btnUsePotion.Enabled = true;
            }
            else
            {
                _currentMonster = null;

                cboWeapons.Enabled = false;
                cboPotions.Enabled = false;
                btnUseWeapon.Enabled = false;
                btnUsePotion.Enabled = false;

            }

            // Refresh player's inventory list
            UpdateInventoryListInUI();

            // Refresh player's quest list
            UpdateQuestListInUI();

            // Refresh player's weapons combobox
            UpdateWeaponListInUI();

            // Refresh player's potions combobox
            UpdatePotionListInUI();
        }

        private void UpdateInventoryListInUI()
        {
            dgvInventory.RowHeadersVisible = false;

            dgvInventory.ColumnCount = 2;
            dgvInventory.Columns[0].Name = "Item";
            dgvInventory.Columns[0].Width = 197;
            dgvInventory.Columns[1].Name = "Quantity";

            dgvInventory.Rows.Clear();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Quantity > 0)
                {
                    dgvInventory.Rows.Add(new[] { inventoryItem.Details.Name, inventoryItem.Quantity.ToString() });
                }
            }
        }

        private void UpdateQuestListInUI()
        {
            dgvQuests.RowHeadersVisible = false;

            dgvQuests.ColumnCount = 2;
            dgvQuests.Columns[0].Name = "Quest";
            dgvQuests.Columns[0].Width = 197;
            dgvQuests.Columns[1].Name = "Completed";

            dgvQuests.Rows.Clear();

            foreach (PlayerQuest playerQuest in _player.Quests)
            {
                dgvQuests.Rows.Add(new[] { playerQuest.Details.Name, playerQuest.IsCompleted.ToString() });
            }
        }

        private void UpdateWeaponListInUI()
        {
            List<Weapon> weapons = new List<Weapon>();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is Weapon)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        weapons.Add((Weapon)inventoryItem.Details);
                    }
                }
            }

            if (weapons.Count == 0)
            {
                // The player doesn't have any weapons, so hide the weapon combobox and "Use" button
                cboWeapons.Enabled = false;
                btnUseWeapon.Enabled = false;
            }
            else
            {
                cboWeapons.DataSource = weapons;
                cboWeapons.DisplayMember = "Name";
                cboWeapons.ValueMember = "ID";

                cboWeapons.SelectedIndex = 0;
            }
        }

        private void UpdatePotionListInUI()
        {
            List<HealingPotion> healingPotions = new List<HealingPotion>();

            foreach (InventoryItem inventoryItem in _player.Inventory)
            {
                if (inventoryItem.Details is HealingPotion)
                {
                    if (inventoryItem.Quantity > 0)
                    {
                        healingPotions.Add((HealingPotion)inventoryItem.Details);
                    }
                }
            }

            if (healingPotions.Count == 0)
            {
                // The player doesn't have any potions, so hide the potion combobox and "Use" button
                cboPotions.Enabled = false;
                btnUsePotion.Enabled = false;
            }
            else
            {
                cboPotions.DataSource = healingPotions;
                cboPotions.DisplayMember = "Name";
                cboPotions.ValueMember = "ID";

                cboPotions.SelectedIndex = 0;
            }
        }

      



        private void btnEast_Click_1(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToEast);
            LocationPicture(_player.CurrentLocation);
        }

        private void btnWest_Click_1(object sender, EventArgs e)
        {
            MoveTo(_player.CurrentLocation.LocationToWest);
            LocationPicture(_player.CurrentLocation);
        }


        private void btnUseWeapon_Click_1(object sender, EventArgs e)
        {
            // Get the currently selected weapon from the cboWeapons ComboBox
            Weapon currentWeapon = (Weapon)cboWeapons.SelectedItem;

            // Determine the amount of damage to do to the monster
            int damageToMonster = RandomNumberGenerator.NumberBetween(currentWeapon.MinimumDamage, currentWeapon.MaximumDamage);

            // Apply the damage to the monster's CurrentHealth
            _currentMonster.CurrentHealth -= damageToMonster;

            // Display message
            rtbMessages.Text += "You hit the " + _currentMonster.Name + " for " + damageToMonster.ToString() + " points." + Environment.NewLine;

            // Check if the monster is dead
            if (_currentMonster.CurrentHealth <= 0)
            {
                // Monster is dead
                rtbMessages.Text += Environment.NewLine;
                rtbMessages.Text += "You defeated the " + _currentMonster.Name + Environment.NewLine;

                // Give player experience points for killing the monster
                _player.ExperiencePoints += _currentMonster.RewardExperience;
                rtbMessages.Text += "You receive " + _currentMonster.RewardExperience.ToString() + " experience points" + Environment.NewLine;

                // Give player gold for killing the monster 
                _player.Gold += _currentMonster.RewardGold;
                rtbMessages.Text += "You receive " + _currentMonster.RewardGold.ToString() + " gold" + Environment.NewLine;

                // Get random loot items from the monster
                List<InventoryItem> lootedItems = new List<InventoryItem>();

                // Add items to the lootedItems list, comparing a random number to the drop percentage
                foreach (LootItem lootItem in _currentMonster.LootTable)
                {
                    if (RandomNumberGenerator.NumberBetween(1, 100) <= lootItem.DropPercentage)
                    {
                        lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                    }
                }

                // If no items were randomly selected, then add the default loot item(s).
                if (lootedItems.Count == 0)
                {
                    foreach (LootItem lootItem in _currentMonster.LootTable)
                    {
                        if (lootItem.IsDefaultItem)
                        {
                            lootedItems.Add(new InventoryItem(lootItem.Details, 1));
                        }
                    }
                }

                // Add the looted items to the player's inventory
                foreach (InventoryItem inventoryItem in lootedItems)
                {
                    _player.AddItemToInventory(inventoryItem.Details);

                    if (inventoryItem.Quantity == 1)
                    {
                        rtbMessages.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.Name + Environment.NewLine;
                    }
                    else
                    {
                        rtbMessages.Text += "You loot " + inventoryItem.Quantity.ToString() + " " + inventoryItem.Details.NamePlural + Environment.NewLine;
                    }
                }

                // Refresh player information and inventory controls
                lblHealth.Text = _player.CurrentHealth.ToString();
                lblGold.Text = _player.Gold.ToString();
                lblXP.Text = _player.ExperiencePoints.ToString();
                lblLevel.Text = _player.Level.ToString();

                UpdateInventoryListInUI();
                UpdateWeaponListInUI();
                UpdatePotionListInUI();

                // Add a blank line to the messages box, just for appearance.
                rtbMessages.Text += Environment.NewLine;

                // Move player to current location (to heal player and create a new monster to fight)
                MoveTo(_player.CurrentLocation);
            }
            else
            {
                // Monster is still alive

                // Determine the amount of damage the monster does to the player
                int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

                // Display message
                rtbMessages.Text += "The " + _currentMonster.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;

                // Subtract damage from player
                _player.CurrentHealth -= damageToPlayer;

                // Refresh player data in UI
                lblHealth.Text = _player.CurrentHealth.ToString();

                if (_player.CurrentHealth <= 0)
                {
                    // Display message
                    rtbMessages.Text += "The " + _currentMonster.Name + " killed you." + Environment.NewLine;

                    // Move player to "Home"
                    MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
                }
            }
        }

        private void btnUsePotion_Click_1(object sender, EventArgs e)
        {
            // Get the currently selected potion from the combobox
            HealingPotion potion = (HealingPotion)cboPotions.SelectedItem;

            // Add healing amount to the player's current hit points
            _player.CurrentHealth = (_player.CurrentHealth + potion.AmountToHeal);

            // CurrentHealth cannot exceed player's MaximumHealth
            if (_player.CurrentHealth > _player.MaximumHealth)
            {
                _player.CurrentHealth = _player.MaximumHealth;
            }

            // Remove the potion from the player's inventory
            foreach (InventoryItem ii in _player.Inventory)
            {
                if (ii.Details.ID == potion.ID)
                {
                    ii.Quantity--;
                    break;
                }
            }

            // Display message
            rtbMessages.Text += "You drink a " + potion.Name + Environment.NewLine;

            // Monster gets their turn to attack

            // Determine the amount of damage the monster does to the player
            int damageToPlayer = RandomNumberGenerator.NumberBetween(0, _currentMonster.MaximumDamage);

            // Display message
            rtbMessages.Text += "The " + _currentMonster.Name + " did " + damageToPlayer.ToString() + " points of damage." + Environment.NewLine;

            // Subtract damage from player
            _player.CurrentHealth -= damageToPlayer;

            if (_player.CurrentHealth <= 0)
            {
                // Display message
                rtbMessages.Text += "The " + _currentMonster.Name + " killed you." + Environment.NewLine;

                // Move player to "Home"
                MoveTo(World.LocationByID(World.LOCATION_ID_HOME));
            }

            // Refresh player data in UI
            lblHealth.Text = _player.CurrentHealth.ToString();
            UpdateInventoryListInUI();
            UpdatePotionListInUI();
        }

        private void rtbMessages_TextChanged(object sender, EventArgs e)
        {

            // set the current caret position to the end
            rtbMessages.SelectionStart = rtbMessages.Text.Length;
            // scroll it automatically
            rtbMessages.ScrollToCaret();
        
        }

    }
}
