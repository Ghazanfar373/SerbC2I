namespace MissionPlanner.Swarm
{
    partial class FormationControl
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
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.PNL_status = new System.Windows.Forms.FlowLayoutPanel();
            this.timer_status = new System.Windows.Forms.Timer(this.components);
            this.but_auto = new MissionPlanner.Controls.MyButton();
            this.BUT_Updatepos = new MissionPlanner.Controls.MyButton();
            this.BUT_Start = new MissionPlanner.Controls.MyButton();
            this.but_guided = new MissionPlanner.Controls.MyButton();
            this.BUT_Arm = new MissionPlanner.Controls.MyButton();
            this.BUT_leader = new MissionPlanner.Controls.MyButton();
            this.BUT_Disarm = new MissionPlanner.Controls.MyButton();
            this.CMB_mavs = new System.Windows.Forms.ComboBox();
            this.BUT_Takeoff = new MissionPlanner.Controls.MyButton();
            this.BUT_Land = new MissionPlanner.Controls.MyButton();
            this.flowLayoutPanelSwarm = new System.Windows.Forms.FlowLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.But_ArmAll = new MissionPlanner.Controls.MyButton();
            this.grid1 = new MissionPlanner.Swarm.Grid();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.flowLayoutPanelSwarm.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_status
            // 
            this.PNL_status.AutoScroll = true;
            this.PNL_status.Location = new System.Drawing.Point(547, 3);
            this.PNL_status.Name = "PNL_status";
            this.PNL_status.Size = new System.Drawing.Size(79, 177);
            this.PNL_status.TabIndex = 11;
            // 
            // timer_status
            // 
            this.timer_status.Enabled = true;
            this.timer_status.Interval = 200;
            this.timer_status.Tick += new System.EventHandler(this.timer_status_Tick);
            // 
            // but_auto
            // 
            this.but_auto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_auto.Location = new System.Drawing.Point(3, 136);
            this.but_auto.Name = "but_auto";
            this.but_auto.Size = new System.Drawing.Size(130, 29);
            this.but_auto.TabIndex = 24;
            this.but_auto.Text = "Auto Mode  (exl leader)";
            this.but_auto.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.but_auto.UseVisualStyleBackColor = true;
            this.but_auto.Click += new System.EventHandler(this.but_auto_Click);
            // 
            // BUT_Updatepos
            // 
            this.BUT_Updatepos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BUT_Updatepos.Enabled = false;
            this.BUT_Updatepos.Location = new System.Drawing.Point(139, 136);
            this.BUT_Updatepos.Name = "BUT_Updatepos";
            this.BUT_Updatepos.Size = new System.Drawing.Size(80, 29);
            this.BUT_Updatepos.TabIndex = 22;
            this.BUT_Updatepos.Text = "Update Pos";
            this.BUT_Updatepos.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_Updatepos.UseVisualStyleBackColor = true;
            this.BUT_Updatepos.Click += new System.EventHandler(this.BUT_Updatepos_Click);
            // 
            // BUT_Start
            // 
            this.BUT_Start.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BUT_Start.Enabled = false;
            this.BUT_Start.Location = new System.Drawing.Point(139, 102);
            this.BUT_Start.MaximumSize = new System.Drawing.Size(0, 28);
            this.BUT_Start.Name = "BUT_Start";
            this.BUT_Start.Size = new System.Drawing.Size(80, 28);
            this.BUT_Start.TabIndex = 20;
            this.BUT_Start.Text = "Start";
            this.BUT_Start.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_Start.UseVisualStyleBackColor = true;
            this.BUT_Start.MouseCaptureChanged += new System.EventHandler(this.BUT_Start_Click);
            // 
            // but_guided
            // 
            this.but_guided.Dock = System.Windows.Forms.DockStyle.Fill;
            this.but_guided.Location = new System.Drawing.Point(3, 38);
            this.but_guided.Name = "but_guided";
            this.but_guided.Size = new System.Drawing.Size(130, 27);
            this.but_guided.TabIndex = 23;
            this.but_guided.Text = "Guided Mode (exl leader)";
            this.but_guided.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.but_guided.UseVisualStyleBackColor = true;
            this.but_guided.Click += new System.EventHandler(this.but_guided_Click);
            // 
            // BUT_Arm
            // 
            this.BUT_Arm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BUT_Arm.Location = new System.Drawing.Point(3, 71);
            this.BUT_Arm.Name = "BUT_Arm";
            this.BUT_Arm.Size = new System.Drawing.Size(130, 25);
            this.BUT_Arm.TabIndex = 14;
            this.BUT_Arm.Text = "Arm (exl leader)";
            this.BUT_Arm.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_Arm.UseVisualStyleBackColor = true;
            this.BUT_Arm.Click += new System.EventHandler(this.BUT_Arm_Click);
            // 
            // BUT_leader
            // 
            this.BUT_leader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BUT_leader.Location = new System.Drawing.Point(139, 3);
            this.BUT_leader.Name = "BUT_leader";
            this.BUT_leader.Size = new System.Drawing.Size(80, 29);
            this.BUT_leader.TabIndex = 19;
            this.BUT_leader.Text = "Set Leader";
            this.BUT_leader.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_leader.UseVisualStyleBackColor = true;
            this.BUT_leader.Click += new System.EventHandler(this.BUT_leader_Click);
            // 
            // BUT_Disarm
            // 
            this.BUT_Disarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BUT_Disarm.Location = new System.Drawing.Point(3, 102);
            this.BUT_Disarm.Name = "BUT_Disarm";
            this.BUT_Disarm.Size = new System.Drawing.Size(130, 28);
            this.BUT_Disarm.TabIndex = 15;
            this.BUT_Disarm.Text = "Disarm (exl leader)";
            this.BUT_Disarm.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_Disarm.UseVisualStyleBackColor = true;
            this.BUT_Disarm.Click += new System.EventHandler(this.BUT_Disarm_Click);
            // 
            // CMB_mavs
            // 
            this.CMB_mavs.FormattingEnabled = true;
            this.CMB_mavs.Location = new System.Drawing.Point(3, 3);
            this.CMB_mavs.Name = "CMB_mavs";
            this.CMB_mavs.Size = new System.Drawing.Size(130, 24);
            this.CMB_mavs.TabIndex = 18;
            this.CMB_mavs.DropDown += new System.EventHandler(this.CMB_mavs_DropDown);
            this.CMB_mavs.SelectedIndexChanged += new System.EventHandler(this.CMB_mavs_SelectedIndexChanged);
            // 
            // BUT_Takeoff
            // 
            this.BUT_Takeoff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BUT_Takeoff.Location = new System.Drawing.Point(139, 38);
            this.BUT_Takeoff.MinimumSize = new System.Drawing.Size(0, 28);
            this.BUT_Takeoff.Name = "BUT_Takeoff";
            this.BUT_Takeoff.Size = new System.Drawing.Size(80, 28);
            this.BUT_Takeoff.TabIndex = 16;
            this.BUT_Takeoff.Text = "Takeoff";
            this.BUT_Takeoff.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_Takeoff.UseVisualStyleBackColor = true;
            this.BUT_Takeoff.Click += new System.EventHandler(this.BUT_Takeoff_Click);
            // 
            // BUT_Land
            // 
            this.BUT_Land.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BUT_Land.Location = new System.Drawing.Point(139, 71);
            this.BUT_Land.Name = "BUT_Land";
            this.BUT_Land.Size = new System.Drawing.Size(80, 25);
            this.BUT_Land.TabIndex = 17;
            this.BUT_Land.Text = "Land (all)";
            this.BUT_Land.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_Land.UseVisualStyleBackColor = true;
            this.BUT_Land.Click += new System.EventHandler(this.BUT_Land_Click);
            // 
            // flowLayoutPanelSwarm
            // 
            this.flowLayoutPanelSwarm.AutoScroll = true;
            this.flowLayoutPanelSwarm.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelSwarm.Controls.Add(this.grid1);
            this.flowLayoutPanelSwarm.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanelSwarm.Controls.Add(this.PNL_status);
            this.flowLayoutPanelSwarm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelSwarm.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelSwarm.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanelSwarm.MinimumSize = new System.Drawing.Size(0, 285);
            this.flowLayoutPanelSwarm.Name = "flowLayoutPanelSwarm";
            this.flowLayoutPanelSwarm.Size = new System.Drawing.Size(1000, 285);
            this.flowLayoutPanelSwarm.TabIndex = 25;
            this.flowLayoutPanelSwarm.WrapContents = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.64384F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.35616F));
            this.tableLayoutPanel1.Controls.Add(this.BUT_leader, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.myButton1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.but_guided, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Arm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Disarm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.but_auto, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.CMB_mavs, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.But_ArmAll, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Updatepos, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Start, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Land, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Takeoff, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(319, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.84746F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.15254F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 207);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // myButton1
            // 
            this.myButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myButton1.Location = new System.Drawing.Point(3, 171);
            this.myButton1.Name = "myButton1";
            this.myButton1.Size = new System.Drawing.Size(130, 33);
            this.myButton1.TabIndex = 26;
            this.myButton1.Text = "Loiter All (exl leader)";
            this.myButton1.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.myButton1.UseVisualStyleBackColor = true;
            // 
            // But_ArmAll
            // 
            this.But_ArmAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.But_ArmAll.Location = new System.Drawing.Point(139, 171);
            this.But_ArmAll.Name = "But_ArmAll";
            this.But_ArmAll.Size = new System.Drawing.Size(80, 33);
            this.But_ArmAll.TabIndex = 25;
            this.But_ArmAll.Text = "Arm All";
            this.But_ArmAll.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.But_ArmAll.UseVisualStyleBackColor = true;
            this.But_ArmAll.Click += new System.EventHandler(this.But_ArmAll_Click);
            // 
            // grid1
            // 
            this.grid1.Location = new System.Drawing.Point(0, 0);
            this.grid1.Margin = new System.Windows.Forms.Padding(0);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(316, 225);
            this.grid1.TabIndex = 21;
            this.grid1.Vertical = false;
            this.grid1.UpdateOffsets += new MissionPlanner.Swarm.Grid.UpdateOffsetsEvent(this.grid1_UpdateOffsets);
            // 
            // FormationControl
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanelSwarm);
            this.Name = "FormationControl";
            this.Size = new System.Drawing.Size(1000, 278);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.flowLayoutPanelSwarm.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.FlowLayoutPanel PNL_status;
        private System.Windows.Forms.Timer timer_status;
        private Controls.MyButton but_auto;
        private Controls.MyButton BUT_Updatepos;
        private Grid grid1;
        private Controls.MyButton BUT_Start;
        private Controls.MyButton but_guided;
        private Controls.MyButton BUT_Arm;
        private Controls.MyButton BUT_leader;
        private Controls.MyButton BUT_Disarm;
        private System.Windows.Forms.ComboBox CMB_mavs;
        private Controls.MyButton BUT_Takeoff;
        private Controls.MyButton BUT_Land;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSwarm;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private Controls.MyButton But_ArmAll;
        private Controls.MyButton myButton1;
    }
}