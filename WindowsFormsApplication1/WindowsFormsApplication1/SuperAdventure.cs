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

        public SuperAdventure()
        {
            InitializeComponent();
            /// initialize location
            Location location = new Location(1, "Rolahouse Waters Investigators", 
                "A once esteemed agency, veteran London detectives come here to relax in a peaceful town.");
           
            _player = new Player(5, 0, 1, "Deputy", 100, 100, "Kathie Tucson");
  

            lblHealth.Text = _player.CurrentHealth.ToString();
            lblGold.Text = _player.Gold.ToString();
            lblXP.Text = _player.ExperiencePoints.ToString();
            lblLevel.Text = _player.Level.ToString();
            player_name.Text = _player.Name.ToString();
            lblPlayerJob.Text = _player.Job.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void SuperAdventure_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNorth_Click(object sender, EventArgs e)
        {

        }
    }
}
