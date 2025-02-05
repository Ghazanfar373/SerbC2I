namespace MissionPlanner.Controls
{
    partial class OpenTKClock
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
            this.glControl1 = new OpenTK.GLControl();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rjToggleButton1 = new RJCodeAdvance.RJControls.RJToggleButton();
            this.buttHUD = new RJCodeAdvance.RJControls.RJButton();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.updateHorizon = new RJCodeAdvance.RJControls.RJButton();
            this.glControlHUD = new OpenTK.GLControl();
            this.SuspendLayout();
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(640, 78);
            this.glControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(288, 267);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = false;
            this.glControl1.Load += new System.EventHandler(this.glControl1_Load);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.glControl1_Paint);
            this.glControl1.Resize += new System.EventHandler(this.glControl1_Resize);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rjToggleButton1
            // 
            this.rjToggleButton1.AutoSize = true;
            this.rjToggleButton1.Location = new System.Drawing.Point(883, 369);
            this.rjToggleButton1.MinimumSize = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.Name = "rjToggleButton1";
            this.rjToggleButton1.OffBackColor = System.Drawing.Color.Gray;
            this.rjToggleButton1.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleButton1.OnBackColor = System.Drawing.Color.MediumSlateBlue;
            this.rjToggleButton1.OnToggleColor = System.Drawing.Color.WhiteSmoke;
            this.rjToggleButton1.Size = new System.Drawing.Size(45, 22);
            this.rjToggleButton1.TabIndex = 1;
            this.rjToggleButton1.UseVisualStyleBackColor = true;
            this.rjToggleButton1.CheckedChanged += new System.EventHandler(this.rjToggleButton1_CheckedChanged);
            // 
            // buttHUD
            // 
            this.buttHUD.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.buttHUD.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.buttHUD.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttHUD.BorderRadius = 0;
            this.buttHUD.BorderSize = 0;
            this.buttHUD.FlatAppearance.BorderSize = 0;
            this.buttHUD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttHUD.ForeColor = System.Drawing.Color.White;
            this.buttHUD.Location = new System.Drawing.Point(700, 359);
            this.buttHUD.Name = "buttHUD";
            this.buttHUD.Size = new System.Drawing.Size(150, 40);
            this.buttHUD.TabIndex = 2;
            this.buttHUD.Text = "Ar Horizon";
            this.buttHUD.TextColor = System.Drawing.Color.White;
            this.buttHUD.UseVisualStyleBackColor = false;
            this.buttHUD.Click += new System.EventHandler(this.buttHUD_Click);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(43, 139);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 22);
            this.textBoxX.TabIndex = 3;
            this.textBoxX.Text = "-5";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(41, 166);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 22);
            this.textBoxY.TabIndex = 4;
            this.textBoxY.Text = "0";
            // 
            // updateHorizon
            // 
            this.updateHorizon.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.updateHorizon.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.updateHorizon.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.updateHorizon.BorderRadius = 0;
            this.updateHorizon.BorderSize = 0;
            this.updateHorizon.FlatAppearance.BorderSize = 0;
            this.updateHorizon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updateHorizon.ForeColor = System.Drawing.Color.White;
            this.updateHorizon.Location = new System.Drawing.Point(59, 207);
            this.updateHorizon.Name = "updateHorizon";
            this.updateHorizon.Size = new System.Drawing.Size(82, 24);
            this.updateHorizon.TabIndex = 5;
            this.updateHorizon.Text = "update";
            this.updateHorizon.TextColor = System.Drawing.Color.White;
            this.updateHorizon.UseVisualStyleBackColor = false;
            this.updateHorizon.Click += new System.EventHandler(this.updateHorizon_Click);
            // 
            // glControlHUD
            // 
            this.glControlHUD.BackColor = System.Drawing.Color.Black;
            this.glControlHUD.Location = new System.Drawing.Point(207, 78);
            this.glControlHUD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.glControlHUD.Name = "glControlHUD";
            this.glControlHUD.Size = new System.Drawing.Size(293, 267);
            this.glControlHUD.TabIndex = 6;
            this.glControlHUD.VSync = false;
            this.glControlHUD.Load += new System.EventHandler(this.glControlHUD_Load);
            this.glControlHUD.Paint += new System.Windows.Forms.PaintEventHandler(this.glControlHUD_Paint);
            // 
            // OpenTKClock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 444);
            this.Controls.Add(this.glControlHUD);
            this.Controls.Add(this.updateHorizon);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.buttHUD);
            this.Controls.Add(this.rjToggleButton1);
            this.Controls.Add(this.glControl1);
            this.Name = "OpenTKClock";
            this.Text = "OpenTKClock";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenTK.GLControl glControl1;
        private System.Windows.Forms.Timer timer1;
        private RJCodeAdvance.RJControls.RJToggleButton rjToggleButton1;
        private RJCodeAdvance.RJControls.RJButton buttHUD;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private RJCodeAdvance.RJControls.RJButton updateHorizon;
        private OpenTK.GLControl glControlHUD;
    }
}