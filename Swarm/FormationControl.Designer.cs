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
            this.grid1 = new MissionPlanner.Swarm.Grid();
            this.BUT_Start = new MissionPlanner.Controls.MyButton();
            this.but_guided = new MissionPlanner.Controls.MyButton();
            this.BUT_Arm = new MissionPlanner.Controls.MyButton();
            this.BUT_leader = new MissionPlanner.Controls.MyButton();
            this.BUT_Disarm = new MissionPlanner.Controls.MyButton();
            this.CMB_mavs = new System.Windows.Forms.ComboBox();
            this.BUT_Takeoff = new MissionPlanner.Controls.MyButton();
            this.BUT_Land = new MissionPlanner.Controls.MyButton();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.swarmHud3 = new HUD_Claude.SwarmHud();
            this.swarmHud2 = new HUD_Claude.SwarmHud();
            this.swarmHud1 = new HUD_Claude.SwarmHud();
            this.swarmHud4 = new HUD_Claude.SwarmHud();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_status
            // 
            this.PNL_status.AutoScroll = true;
            this.PNL_status.Location = new System.Drawing.Point(547, 3);
            this.PNL_status.Name = "PNL_status";
            this.PNL_status.Size = new System.Drawing.Size(92, 271);
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
            this.but_auto.Location = new System.Drawing.Point(3, 3);
            this.but_auto.Name = "but_auto";
            this.but_auto.Size = new System.Drawing.Size(130, 30);
            this.but_auto.TabIndex = 24;
            this.but_auto.Text = "Auto Mode  (exl leader)";
            this.but_auto.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.but_auto.UseVisualStyleBackColor = true;
            // 
            // BUT_Updatepos
            // 
            this.BUT_Updatepos.Enabled = false;
            this.BUT_Updatepos.Location = new System.Drawing.Point(139, 111);
            this.BUT_Updatepos.Name = "BUT_Updatepos";
            this.BUT_Updatepos.Size = new System.Drawing.Size(80, 30);
            this.BUT_Updatepos.TabIndex = 22;
            this.BUT_Updatepos.Text = "Update Pos";
            this.BUT_Updatepos.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_Updatepos.UseVisualStyleBackColor = true;
            // 
            // grid1
            // 
            this.grid1.Location = new System.Drawing.Point(0, 0);
            this.grid1.Margin = new System.Windows.Forms.Padding(0);
            this.grid1.Name = "grid1";
            this.grid1.Size = new System.Drawing.Size(316, 216);
            this.grid1.TabIndex = 21;
            this.grid1.Vertical = false;
            // 
            // BUT_Start
            // 
            this.BUT_Start.Enabled = false;
            this.BUT_Start.Location = new System.Drawing.Point(139, 76);
            this.BUT_Start.Name = "BUT_Start";
            this.BUT_Start.Size = new System.Drawing.Size(80, 29);
            this.BUT_Start.TabIndex = 20;
            this.BUT_Start.Text = "Start";
            this.BUT_Start.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_Start.UseVisualStyleBackColor = true;
            // 
            // but_guided
            // 
            this.but_guided.Location = new System.Drawing.Point(3, 40);
            this.but_guided.Name = "but_guided";
            this.but_guided.Size = new System.Drawing.Size(130, 30);
            this.but_guided.TabIndex = 23;
            this.but_guided.Text = "Guided Mode (exl leader)";
            this.but_guided.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.but_guided.UseVisualStyleBackColor = true;
            // 
            // BUT_Arm
            // 
            this.BUT_Arm.Location = new System.Drawing.Point(3, 76);
            this.BUT_Arm.Name = "BUT_Arm";
            this.BUT_Arm.Size = new System.Drawing.Size(129, 29);
            this.BUT_Arm.TabIndex = 14;
            this.BUT_Arm.Text = "Arm (exl leader)";
            this.BUT_Arm.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_Arm.UseVisualStyleBackColor = true;
            // 
            // BUT_leader
            // 
            this.BUT_leader.Location = new System.Drawing.Point(139, 149);
            this.BUT_leader.Name = "BUT_leader";
            this.BUT_leader.Size = new System.Drawing.Size(80, 23);
            this.BUT_leader.TabIndex = 19;
            this.BUT_leader.Text = "Set Leader";
            this.BUT_leader.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_leader.UseVisualStyleBackColor = true;
            this.BUT_leader.Click += new System.EventHandler(this.BUT_leader_Click_1);
            // 
            // BUT_Disarm
            // 
            this.BUT_Disarm.Location = new System.Drawing.Point(3, 111);
            this.BUT_Disarm.Name = "BUT_Disarm";
            this.BUT_Disarm.Size = new System.Drawing.Size(129, 30);
            this.BUT_Disarm.TabIndex = 15;
            this.BUT_Disarm.Text = "Disarm (exl leader)";
            this.BUT_Disarm.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_Disarm.UseVisualStyleBackColor = true;
            // 
            // CMB_mavs
            // 
            this.CMB_mavs.DataSource = this.bindingSource1;
            this.CMB_mavs.FormattingEnabled = true;
            this.CMB_mavs.Location = new System.Drawing.Point(3, 149);
            this.CMB_mavs.Name = "CMB_mavs";
            this.CMB_mavs.Size = new System.Drawing.Size(121, 24);
            this.CMB_mavs.TabIndex = 18;
            this.CMB_mavs.SelectedIndexChanged += new System.EventHandler(this.CMB_mavs_SelectedIndexChanged_1);
            // 
            // BUT_Takeoff
            // 
            this.BUT_Takeoff.Location = new System.Drawing.Point(139, 3);
            this.BUT_Takeoff.Name = "BUT_Takeoff";
            this.BUT_Takeoff.Size = new System.Drawing.Size(80, 30);
            this.BUT_Takeoff.TabIndex = 16;
            this.BUT_Takeoff.Text = "Takeoff";
            this.BUT_Takeoff.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_Takeoff.UseVisualStyleBackColor = true;
            // 
            // BUT_Land
            // 
            this.BUT_Land.Location = new System.Drawing.Point(139, 40);
            this.BUT_Land.Name = "BUT_Land";
            this.BUT_Land.Size = new System.Drawing.Size(80, 30);
            this.BUT_Land.TabIndex = 17;
            this.BUT_Land.Text = "Land (all)";
            this.BUT_Land.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_Land.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.grid1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Controls.Add(this.PNL_status);
            this.flowLayoutPanel1.Controls.Add(this.swarmHud3);
            this.flowLayoutPanel1.Controls.Add(this.swarmHud2);
            this.flowLayoutPanel1.Controls.Add(this.swarmHud1);
            this.flowLayoutPanel1.Controls.Add(this.swarmHud4);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1000, 278);
            this.flowLayoutPanel1.TabIndex = 25;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // swarmHud3
            // 
            this.swarmHud3.ArmButtonEnabled = true;
            this.swarmHud3.ArmButtonText = "Arm";
            this.swarmHud3.Dock = System.Windows.Forms.DockStyle.Right;
            this.swarmHud3.Heading = 0F;
            this.swarmHud3.Location = new System.Drawing.Point(642, 0);
            this.swarmHud3.LoiterButtonEnabled = true;
            this.swarmHud3.LoiterButtonText = "Loiter";
            this.swarmHud3.Margin = new System.Windows.Forms.Padding(0);
            this.swarmHud3.Name = "swarmHud3";
            this.swarmHud3.Pitch = 0F;
            this.swarmHud3.Roll = 0F;
            this.swarmHud3.Size = new System.Drawing.Size(132, 277);
            this.swarmHud3.TabIndex = 30;
            this.swarmHud3.VehicleName = "Vehicle 1";
            // 
            // swarmHud2
            // 
            this.swarmHud2.ArmButtonEnabled = true;
            this.swarmHud2.ArmButtonText = "Arm";
            this.swarmHud2.Dock = System.Windows.Forms.DockStyle.Right;
            this.swarmHud2.Heading = 0F;
            this.swarmHud2.Location = new System.Drawing.Point(774, 0);
            this.swarmHud2.LoiterButtonEnabled = true;
            this.swarmHud2.LoiterButtonText = "Loiter";
            this.swarmHud2.Margin = new System.Windows.Forms.Padding(0);
            this.swarmHud2.Name = "swarmHud2";
            this.swarmHud2.Pitch = 0F;
            this.swarmHud2.Roll = 0F;
            this.swarmHud2.Size = new System.Drawing.Size(132, 277);
            this.swarmHud2.TabIndex = 29;
            this.swarmHud2.VehicleName = "Vehicle 1";
            // 
            // swarmHud1
            // 
            this.swarmHud1.ArmButtonEnabled = true;
            this.swarmHud1.ArmButtonText = "Arm";
            this.swarmHud1.Dock = System.Windows.Forms.DockStyle.Right;
            this.swarmHud1.Heading = 0F;
            this.swarmHud1.Location = new System.Drawing.Point(906, 0);
            this.swarmHud1.LoiterButtonEnabled = true;
            this.swarmHud1.LoiterButtonText = "Loiter";
            this.swarmHud1.Margin = new System.Windows.Forms.Padding(0);
            this.swarmHud1.Name = "swarmHud1";
            this.swarmHud1.Pitch = 0F;
            this.swarmHud1.Roll = 0F;
            this.swarmHud1.Size = new System.Drawing.Size(132, 277);
            this.swarmHud1.TabIndex = 28;
            this.swarmHud1.VehicleName = "Vehicle 1";
            // 
            // swarmHud4
            // 
            this.swarmHud4.ArmButtonEnabled = true;
            this.swarmHud4.ArmButtonText = "Arm";
            this.swarmHud4.Heading = 0F;
            this.swarmHud4.Location = new System.Drawing.Point(1038, 0);
            this.swarmHud4.LoiterButtonEnabled = true;
            this.swarmHud4.LoiterButtonText = "Loiter";
            this.swarmHud4.Margin = new System.Windows.Forms.Padding(0);
            this.swarmHud4.Name = "swarmHud4";
            this.swarmHud4.Pitch = 0F;
            this.swarmHud4.Roll = 0F;
            this.swarmHud4.Size = new System.Drawing.Size(133, 274);
            this.swarmHud4.TabIndex = 31;
            this.swarmHud4.VehicleName = "Vehicle 1";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.64384F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.35616F));
            this.tableLayoutPanel1.Controls.Add(this.but_auto, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.but_guided, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Arm, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Disarm, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Takeoff, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Land, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.BUT_leader, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Updatepos, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.CMB_mavs, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.BUT_Start, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(319, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.70422F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.29578F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(222, 177);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // FormationControl
            // 
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FormationControl";
            this.Size = new System.Drawing.Size(1000, 278);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private HUD_Claude.SwarmHud swarmHud3;
        private HUD_Claude.SwarmHud swarmHud2;
        private HUD_Claude.SwarmHud swarmHud1;
        private HUD_Claude.SwarmHud swarmHud4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}