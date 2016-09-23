namespace WindowsFormsApplication1
{
    partial class SuperAdventure
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SuperAdventure));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblXP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.player_name = new System.Windows.Forms.Label();
            this.lblPlayerJob = new System.Windows.Forms.Label();
            this.cboWeapons = new System.Windows.Forms.ComboBox();
            this.cboPotions = new System.Windows.Forms.ComboBox();
            this.btnUseWeapon = new System.Windows.Forms.Button();
            this.btnUsePotion = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.rtbMessages = new System.Windows.Forms.RichTextBox();
            this.rtbLocation = new System.Windows.Forms.RichTextBox();
            this.dgvInventory = new System.Windows.Forms.DataGridView();
            this.dgvQuests = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 238);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 204);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 277);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "XP";
            // 
            // lblLevel
            // 
            this.lblLevel.AccessibleName = "";
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(151, 204);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 22);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.UseMnemonic = false;
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(151, 314);
            this.lblGold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 22);
            this.lblGold.TabIndex = 8;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(151, 238);
            this.lblHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(0, 22);
            this.lblHealth.TabIndex = 7;
            this.lblHealth.UseMnemonic = false;
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.Location = new System.Drawing.Point(151, 277);
            this.lblXP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(0, 22);
            this.lblXP.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 314);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Gold";
            // 
            // player_name
            // 
            this.player_name.AutoSize = true;
            this.player_name.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_name.Location = new System.Drawing.Point(24, 130);
            this.player_name.Name = "player_name";
            this.player_name.Size = new System.Drawing.Size(0, 30);
            this.player_name.TabIndex = 11;
            // 
            // lblPlayerJob
            // 
            this.lblPlayerJob.AutoSize = true;
            this.lblPlayerJob.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerJob.Location = new System.Drawing.Point(24, 160);
            this.lblPlayerJob.Name = "lblPlayerJob";
            this.lblPlayerJob.Size = new System.Drawing.Size(0, 22);
            this.lblPlayerJob.TabIndex = 12;
            // 
            // cboWeapons
            // 
            this.cboWeapons.FormattingEnabled = true;
            this.cboWeapons.Location = new System.Drawing.Point(697, 620);
            this.cboWeapons.Name = "cboWeapons";
            this.cboWeapons.Size = new System.Drawing.Size(121, 30);
            this.cboWeapons.TabIndex = 14;
            // 
            // cboPotions
            // 
            this.cboPotions.FormattingEnabled = true;
            this.cboPotions.Location = new System.Drawing.Point(696, 668);
            this.cboPotions.Name = "cboPotions";
            this.cboPotions.Size = new System.Drawing.Size(121, 30);
            this.cboPotions.TabIndex = 15;
            // 
            // btnUseWeapon
            // 
            this.btnUseWeapon.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUseWeapon.Location = new System.Drawing.Point(600, 620);
            this.btnUseWeapon.Name = "btnUseWeapon";
            this.btnUseWeapon.Size = new System.Drawing.Size(75, 30);
            this.btnUseWeapon.TabIndex = 16;
            this.btnUseWeapon.Text = "Fight!";
            this.btnUseWeapon.UseVisualStyleBackColor = true;
            this.btnUseWeapon.Click += new System.EventHandler(this.btnUseWeapon_Click_1);
            // 
            // btnUsePotion
            // 
            this.btnUsePotion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUsePotion.Location = new System.Drawing.Point(600, 668);
            this.btnUsePotion.Name = "btnUsePotion";
            this.btnUsePotion.Size = new System.Drawing.Size(75, 30);
            this.btnUsePotion.TabIndex = 17;
            this.btnUsePotion.Text = "Heal!";
            this.btnUsePotion.UseVisualStyleBackColor = true;
            this.btnUsePotion.Click += new System.EventHandler(this.btnUsePotion_Click_1);
            // 
            // btnNorth
            // 
            this.btnNorth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnNorth.Location = new System.Drawing.Point(696, 473);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(69, 30);
            this.btnNorth.TabIndex = 18;
            this.btnNorth.Text = "North";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnEast
            // 
            this.btnEast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEast.Location = new System.Drawing.Point(769, 517);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(69, 30);
            this.btnEast.TabIndex = 19;
            this.btnEast.Text = "East";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click_1);
            // 
            // btnSouth
            // 
            this.btnSouth.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSouth.Location = new System.Drawing.Point(696, 565);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(69, 30);
            this.btnSouth.TabIndex = 20;
            this.btnSouth.Text = "South";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnWest.Location = new System.Drawing.Point(619, 517);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(69, 30);
            this.btnWest.TabIndex = 21;
            this.btnWest.Text = "West";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click_1);
            // 
            // rtbMessages
            // 
            this.rtbMessages.Location = new System.Drawing.Point(891, 23);
            this.rtbMessages.Name = "rtbMessages";
            this.rtbMessages.ReadOnly = true;
            this.rtbMessages.Size = new System.Drawing.Size(241, 672);
            this.rtbMessages.TabIndex = 22;
            this.rtbMessages.Text = "";
            this.rtbMessages.TextChanged += new System.EventHandler(this.rtbMessages_TextChanged);
            // 
            // rtbLocation
            // 
            this.rtbLocation.Location = new System.Drawing.Point(29, 613);
            this.rtbLocation.Name = "rtbLocation";
            this.rtbLocation.ReadOnly = true;
            this.rtbLocation.Size = new System.Drawing.Size(500, 82);
            this.rtbLocation.TabIndex = 23;
            this.rtbLocation.Text = "";
            // 
            // dgvInventory
            // 
            this.dgvInventory.AllowUserToAddRows = false;
            this.dgvInventory.AllowUserToDeleteRows = false;
            this.dgvInventory.AllowUserToResizeColumns = false;
            this.dgvInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInventory.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvInventory.Enabled = false;
            this.dgvInventory.Location = new System.Drawing.Point(29, 354);
            this.dgvInventory.MultiSelect = false;
            this.dgvInventory.Name = "dgvInventory";
            this.dgvInventory.ReadOnly = true;
            this.dgvInventory.RowHeadersVisible = false;
            this.dgvInventory.RowTemplate.Height = 24;
            this.dgvInventory.Size = new System.Drawing.Size(197, 249);
            this.dgvInventory.TabIndex = 24;
            // 
            // dgvQuests
            // 
            this.dgvQuests.AllowUserToAddRows = false;
            this.dgvQuests.AllowUserToDeleteRows = false;
            this.dgvQuests.AllowUserToResizeColumns = false;
            this.dgvQuests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvQuests.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvQuests.Enabled = false;
            this.dgvQuests.Location = new System.Drawing.Point(232, 473);
            this.dgvQuests.MultiSelect = false;
            this.dgvQuests.Name = "dgvQuests";
            this.dgvQuests.ReadOnly = true;
            this.dgvQuests.RowHeadersVisible = false;
            this.dgvQuests.RowTemplate.Height = 24;
            this.dgvQuests.Size = new System.Drawing.Size(297, 130);
            this.dgvQuests.TabIndex = 25;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 89);
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1144, 725);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dgvQuests);
            this.Controls.Add(this.dgvInventory);
            this.Controls.Add(this.rtbLocation);
            this.Controls.Add(this.rtbMessages);
            this.Controls.Add(this.btnWest);
            this.Controls.Add(this.btnSouth);
            this.Controls.Add(this.btnEast);
            this.Controls.Add(this.btnNorth);
            this.Controls.Add(this.btnUsePotion);
            this.Controls.Add(this.btnUseWeapon);
            this.Controls.Add(this.cboPotions);
            this.Controls.Add(this.cboWeapons);
            this.Controls.Add(this.lblPlayerJob);
            this.Controls.Add(this.player_name);
            this.Controls.Add(this.lblGold);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblXP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SuperAdventure";
            this.Opacity = 0.98D;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highgate Hysteria";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dgvInventory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvQuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblGold;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblXP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label player_name;
        private System.Windows.Forms.Label lblPlayerJob;
        private System.Windows.Forms.ComboBox cboWeapons;
        private System.Windows.Forms.ComboBox cboPotions;
        private System.Windows.Forms.Button btnUseWeapon;
        private System.Windows.Forms.Button btnUsePotion;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.RichTextBox rtbMessages;
        private System.Windows.Forms.RichTextBox rtbLocation;
        private System.Windows.Forms.DataGridView dgvInventory;
        private System.Windows.Forms.DataGridView dgvQuests;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

