namespace MissionPlanner
{
    partial class MainSerb
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
            System.Windows.Forms.MenuStrip menuStrip1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSerb));
            this.flightStatusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.simulationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.connectionControl1 = new MissionPlanner.Controls.ConnectionControl();
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.AutoSize = false;
            menuStrip1.BackColor = System.Drawing.SystemColors.WindowFrame;
            menuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            menuStrip1.GripMargin = new System.Windows.Forms.Padding(3);
            menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            menuStrip1.ImageScalingSize = new System.Drawing.Size(29, 29);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.flightStatusToolStripMenuItem,
            this.planningToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.simulationsToolStripMenuItem,
            this.connectionToolStripMenuItem});
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.MaximumSize = new System.Drawing.Size(70, 177776);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(60, 656);
            menuStrip1.Stretch = false;
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // flightStatusToolStripMenuItem
            // 
            this.flightStatusToolStripMenuItem.Checked = true;
            this.flightStatusToolStripMenuItem.CheckOnClick = true;
            this.flightStatusToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.flightStatusToolStripMenuItem.Image = global::MissionPlanner.Properties.Resources.livedata;
            this.flightStatusToolStripMenuItem.Name = "flightStatusToolStripMenuItem";
            this.flightStatusToolStripMenuItem.Size = new System.Drawing.Size(56, 33);
            this.flightStatusToolStripMenuItem.Click += new System.EventHandler(this.flightStatusToolStripMenuItem_Click);
            // 
            // planningToolStripMenuItem
            // 
            this.planningToolStripMenuItem.Image = global::MissionPlanner.Properties.Resources.plan_mission;
            this.planningToolStripMenuItem.Name = "planningToolStripMenuItem";
            this.planningToolStripMenuItem.Size = new System.Drawing.Size(56, 33);
            this.planningToolStripMenuItem.Click += new System.EventHandler(this.planningToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Image = global::MissionPlanner.Properties.Resources.settings_icon;
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(56, 33);
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // simulationsToolStripMenuItem
            // 
            this.simulationsToolStripMenuItem.Image = global::MissionPlanner.Properties.Resources.simulations;
            this.simulationsToolStripMenuItem.Name = "simulationsToolStripMenuItem";
            this.simulationsToolStripMenuItem.Size = new System.Drawing.Size(56, 33);
            this.simulationsToolStripMenuItem.Click += new System.EventHandler(this.simulationsToolStripMenuItem_Click_1);
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.connectionToolStripMenuItem.Image = global::MissionPlanner.Properties.Resources.usb_off;
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(56, 33);
            this.connectionToolStripMenuItem.Click += new System.EventHandler(this.connectionToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.connectionControl1);
            this.panel1.Controls.Add(menuStrip1);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.MaximumSize = new System.Drawing.Size(70, 177776);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(63, 660);
            this.panel1.TabIndex = 1;
            // 
            // connectionControl1
            // 
            this.connectionControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connectionControl1.BackgroundImage")));
            this.connectionControl1.Location = new System.Drawing.Point(0, 571);
            this.connectionControl1.MinimumSize = new System.Drawing.Size(200, 47);
            this.connectionControl1.Name = "connectionControl1";
            this.connectionControl1.Size = new System.Drawing.Size(238, 47);
            this.connectionControl1.TabIndex = 1;
            this.connectionControl1.Visible = false;
            // 
            // MainSerb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1259, 660);
            this.Controls.Add(this.panel1);
            this.MainMenuStrip = menuStrip1;
            this.MinimumSize = new System.Drawing.Size(843, 547);
            this.Name = "MainSerb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainSerb";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem flightStatusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planningToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem simulationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private Controls.ConnectionControl connectionControl1;
    }
}