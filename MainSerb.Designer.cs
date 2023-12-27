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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainSerb));
            this.sideBar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStartBtn = new RJCodeAdvance.RJControls.RJCircularPictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnFlightData = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnFlightPlan = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnHWConfig = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnSoftwareConfig = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSimulation = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnConnection = new System.Windows.Forms.Button();
            this.timerMenu = new System.Windows.Forms.Timer(this.components);
            this.connectionControl1 = new MissionPlanner.Controls.ConnectionControl();
            this.sideBar.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuStartBtn)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // sideBar
            // 
            this.sideBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.sideBar.Controls.Add(this.panel2);
            this.sideBar.Controls.Add(this.panel3);
            this.sideBar.Controls.Add(this.panel4);
            this.sideBar.Controls.Add(this.panel5);
            this.sideBar.Controls.Add(this.panel6);
            this.sideBar.Controls.Add(this.panel7);
            this.sideBar.Controls.Add(this.panel8);
            this.sideBar.Controls.Add(this.connectionControl1);
            this.sideBar.Dock = System.Windows.Forms.DockStyle.Left;
            this.sideBar.ForeColor = System.Drawing.Color.Gray;
            this.sideBar.Location = new System.Drawing.Point(0, 0);
            this.sideBar.MaximumSize = new System.Drawing.Size(172, 32536);
            this.sideBar.MinimumSize = new System.Drawing.Size(65, 536);
            this.sideBar.Name = "sideBar";
            this.sideBar.Size = new System.Drawing.Size(65, 536);
            this.sideBar.TabIndex = 2;
            this.sideBar.Paint += new System.Windows.Forms.PaintEventHandler(this.sideBar_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStartBtn);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(162, 71);
            this.panel2.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Menu";
            // 
            // menuStartBtn
            // 
            this.menuStartBtn.BorderCapStyle = System.Drawing.Drawing2D.DashCap.Flat;
            this.menuStartBtn.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.menuStartBtn.BorderColor2 = System.Drawing.SystemColors.ControlDarkDark;
            this.menuStartBtn.BorderLineStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.menuStartBtn.BorderSize = 0;
            this.menuStartBtn.GradientAngle = 50F;
            this.menuStartBtn.Image = global::MissionPlanner.Properties.Resources.icons8_menu_48;
            this.menuStartBtn.Location = new System.Drawing.Point(3, 4);
            this.menuStartBtn.Name = "menuStartBtn";
            this.menuStartBtn.Size = new System.Drawing.Size(55, 55);
            this.menuStartBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.menuStartBtn.TabIndex = 0;
            this.menuStartBtn.TabStop = false;
            this.menuStartBtn.Click += new System.EventHandler(this.menuStartBtn_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnFlightData);
            this.panel3.Location = new System.Drawing.Point(3, 80);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(164, 52);
            this.panel3.TabIndex = 4;
            // 
            // btnFlightData
            // 
            this.btnFlightData.FlatAppearance.BorderSize = 0;
            this.btnFlightData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlightData.ForeColor = System.Drawing.Color.Transparent;
            this.btnFlightData.Image = global::MissionPlanner.Properties.Resources.dashboard_layout_50;
            this.btnFlightData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlightData.Location = new System.Drawing.Point(3, 1);
            this.btnFlightData.Name = "btnFlightData";
            this.btnFlightData.Padding = new System.Windows.Forms.Padding(0, 10, 10, 10);
            this.btnFlightData.Size = new System.Drawing.Size(159, 51);
            this.btnFlightData.TabIndex = 5;
            this.btnFlightData.Text = "                  Mission Status";
            this.btnFlightData.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlightData.UseVisualStyleBackColor = true;
            this.btnFlightData.Click += new System.EventHandler(this.btnFlightData_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnFlightPlan);
            this.panel4.Location = new System.Drawing.Point(3, 138);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(164, 52);
            this.panel4.TabIndex = 5;
            // 
            // btnFlightPlan
            // 
            this.btnFlightPlan.FlatAppearance.BorderSize = 0;
            this.btnFlightPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFlightPlan.ForeColor = System.Drawing.Color.White;
            this.btnFlightPlan.Image = global::MissionPlanner.Properties.Resources.plan_50;
            this.btnFlightPlan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlightPlan.Location = new System.Drawing.Point(3, 1);
            this.btnFlightPlan.Name = "btnFlightPlan";
            this.btnFlightPlan.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btnFlightPlan.Size = new System.Drawing.Size(159, 51);
            this.btnFlightPlan.TabIndex = 5;
            this.btnFlightPlan.Text = "                  Mission Plan";
            this.btnFlightPlan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFlightPlan.UseVisualStyleBackColor = true;
            this.btnFlightPlan.Click += new System.EventHandler(this.btnFlightPlan_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnHWConfig);
            this.panel5.ForeColor = System.Drawing.Color.Transparent;
            this.panel5.Location = new System.Drawing.Point(3, 196);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(164, 52);
            this.panel5.TabIndex = 6;
            // 
            // btnHWConfig
            // 
            this.btnHWConfig.FlatAppearance.BorderSize = 0;
            this.btnHWConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHWConfig.ForeColor = System.Drawing.Color.White;
            this.btnHWConfig.Image = global::MissionPlanner.Properties.Resources.settings_50;
            this.btnHWConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHWConfig.Location = new System.Drawing.Point(3, 1);
            this.btnHWConfig.Name = "btnHWConfig";
            this.btnHWConfig.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btnHWConfig.Size = new System.Drawing.Size(159, 51);
            this.btnHWConfig.TabIndex = 5;
            this.btnHWConfig.Text = "                  Settings";
            this.btnHWConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHWConfig.UseVisualStyleBackColor = true;
            this.btnHWConfig.Click += new System.EventHandler(this.btnHWConfig_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnSoftwareConfig);
            this.panel6.Location = new System.Drawing.Point(3, 254);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(164, 52);
            this.panel6.TabIndex = 7;
            // 
            // btnSoftwareConfig
            // 
            this.btnSoftwareConfig.FlatAppearance.BorderSize = 0;
            this.btnSoftwareConfig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSoftwareConfig.ForeColor = System.Drawing.Color.White;
            this.btnSoftwareConfig.Image = global::MissionPlanner.Properties.Resources.configurations_50;
            this.btnSoftwareConfig.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoftwareConfig.Location = new System.Drawing.Point(3, 1);
            this.btnSoftwareConfig.Name = "btnSoftwareConfig";
            this.btnSoftwareConfig.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btnSoftwareConfig.Size = new System.Drawing.Size(159, 51);
            this.btnSoftwareConfig.TabIndex = 5;
            this.btnSoftwareConfig.Text = "                  Configurations";
            this.btnSoftwareConfig.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSoftwareConfig.UseVisualStyleBackColor = true;
            this.btnSoftwareConfig.Click += new System.EventHandler(this.btnSoftwareConfig_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.btnSimulation);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(3, 312);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(164, 52);
            this.panel7.TabIndex = 8;
            // 
            // btnSimulation
            // 
            this.btnSimulation.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSimulation.FlatAppearance.BorderSize = 0;
            this.btnSimulation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimulation.ForeColor = System.Drawing.Color.White;
            this.btnSimulation.Image = global::MissionPlanner.Properties.Resources.simulation_50;
            this.btnSimulation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimulation.Location = new System.Drawing.Point(5, 3);
            this.btnSimulation.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.btnSimulation.Name = "btnSimulation";
            this.btnSimulation.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btnSimulation.Size = new System.Drawing.Size(159, 51);
            this.btnSimulation.TabIndex = 5;
            this.btnSimulation.Text = "                  Simulations";
            this.btnSimulation.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSimulation.UseVisualStyleBackColor = true;
            this.btnSimulation.Click += new System.EventHandler(this.button5_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.btnConnection);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(3, 370);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(164, 52);
            this.panel8.TabIndex = 9;
            // 
            // btnConnection
            // 
            this.btnConnection.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnConnection.FlatAppearance.BorderSize = 0;
            this.btnConnection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnection.ForeColor = System.Drawing.Color.White;
            this.btnConnection.Image = global::MissionPlanner.Properties.Resources.connect_50;
            this.btnConnection.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnection.Location = new System.Drawing.Point(5, 3);
            this.btnConnection.Name = "btnConnection";
            this.btnConnection.Padding = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.btnConnection.Size = new System.Drawing.Size(159, 51);
            this.btnConnection.TabIndex = 5;
            this.btnConnection.Text = "                  Connections";
            this.btnConnection.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConnection.UseVisualStyleBackColor = true;
            this.btnConnection.Click += new System.EventHandler(this.btnConnection_Click);
            // 
            // timerMenu
            // 
            this.timerMenu.Interval = 1;
            this.timerMenu.Tick += new System.EventHandler(this.timerMenu_Tick);
            // 
            // connectionControl1
            // 
            this.connectionControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.connectionControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("connectionControl1.BackgroundImage")));
            this.connectionControl1.Location = new System.Drawing.Point(2, 427);
            this.connectionControl1.Margin = new System.Windows.Forms.Padding(2);
            this.connectionControl1.MinimumSize = new System.Drawing.Size(150, 38);
            this.connectionControl1.Name = "connectionControl1";
            this.connectionControl1.Size = new System.Drawing.Size(178, 38);
            this.connectionControl1.TabIndex = 1;
            this.connectionControl1.Visible = false;
            this.connectionControl1.Load += new System.EventHandler(this.connectionControl1_Load);
            // 
            // MainSerb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 536);
            this.Controls.Add(this.sideBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(636, 452);
            this.Name = "MainSerb";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainSerb";
            this.sideBar.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.menuStartBtn)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion
        private Controls.ConnectionControl connectionControl1;
        private System.Windows.Forms.FlowLayoutPanel sideBar;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnFlightData;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button btnFlightPlan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnHWConfig;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnSoftwareConfig;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnSimulation;
        private System.Windows.Forms.Label label1;
        private RJCodeAdvance.RJControls.RJCircularPictureBox menuStartBtn;
        private System.Windows.Forms.Timer timerMenu;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnConnection;
    }
}