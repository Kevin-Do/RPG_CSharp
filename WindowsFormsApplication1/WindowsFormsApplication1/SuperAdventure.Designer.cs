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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblGold = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblXP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.player_name = new System.Windows.Forms.Label();
            this.lblPlayerJob = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 61);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Health";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 27);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "Level";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 22);
            this.label3.TabIndex = 3;
            this.label3.Text = "XP";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblLevel
            // 
            this.lblLevel.AccessibleName = "";
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(151, 27);
            this.lblLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(0, 22);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.UseMnemonic = false;
            this.lblLevel.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblGold
            // 
            this.lblGold.AutoSize = true;
            this.lblGold.Location = new System.Drawing.Point(151, 137);
            this.lblGold.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGold.Name = "lblGold";
            this.lblGold.Size = new System.Drawing.Size(0, 22);
            this.lblGold.TabIndex = 8;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.Location = new System.Drawing.Point(151, 61);
            this.lblHealth.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(0, 22);
            this.lblHealth.TabIndex = 7;
            this.lblHealth.UseMnemonic = false;
            // 
            // lblXP
            // 
            this.lblXP.AutoSize = true;
            this.lblXP.Location = new System.Drawing.Point(151, 100);
            this.lblXP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblXP.Name = "lblXP";
            this.lblXP.Size = new System.Drawing.Size(0, 22);
            this.lblXP.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 137);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 22);
            this.label8.TabIndex = 5;
            this.label8.Text = "Gold";
            // 
            // pictureBox1
            // 
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(494, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(381, 271);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // player_name
            // 
            this.player_name.AutoSize = true;
            this.player_name.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.player_name.Location = new System.Drawing.Point(24, 487);
            this.player_name.Name = "player_name";
            this.player_name.Size = new System.Drawing.Size(0, 30);
            this.player_name.TabIndex = 11;
            this.player_name.Click += new System.EventHandler(this.label4_Click_1);
            // 
            // lblPlayerJob
            // 
            this.lblPlayerJob.AutoSize = true;
            this.lblPlayerJob.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerJob.Location = new System.Drawing.Point(24, 517);
            this.lblPlayerJob.Name = "lblPlayerJob";
            this.lblPlayerJob.Size = new System.Drawing.Size(0, 22);
            this.lblPlayerJob.TabIndex = 12;
            // 
            // SuperAdventure
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(891, 556);
            this.Controls.Add(this.lblPlayerJob);
            this.Controls.Add(this.player_name);
            this.Controls.Add(this.pictureBox1);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SuperAdventure";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Highgate Hysteria";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.SuperAdventure_Load);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label player_name;
        private System.Windows.Forms.Label lblPlayerJob;
    }
}

