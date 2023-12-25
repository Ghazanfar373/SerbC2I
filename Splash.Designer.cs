namespace MissionPlanner
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.label1 = new System.Windows.Forms.Label();
            this.TXT_version = new System.Windows.Forms.Label();
            this.labelHeader1 = new System.Windows.Forms.Label();
            this.progressBarSplash = new RJCodeAdvance.RJControls.RJProgressBar();
            this.labelHeader2 = new System.Windows.Forms.Label();
            this.pictureBoxWithPseudoOpacity1 = new MissionPlanner.Controls.PictureBoxWithPseudoOpacity();
            this.timerSplash = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithPseudoOpacity1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OliveDrab;
            this.label1.Location = new System.Drawing.Point(472, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 17);
            this.label1.TabIndex = 0;
            this.label1.Tag = "Unmanned Systems Remote Command Post";
            this.label1.Text = "by Serb Software";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TXT_version
            // 
            this.TXT_version.BackColor = System.Drawing.Color.Transparent;
            this.TXT_version.ForeColor = System.Drawing.Color.White;
            this.TXT_version.Location = new System.Drawing.Point(409, 251);
            this.TXT_version.Name = "TXT_version";
            this.TXT_version.Size = new System.Drawing.Size(155, 25);
            this.TXT_version.TabIndex = 1;
            this.TXT_version.Text = "Version: ";
            this.TXT_version.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelHeader1
            // 
            this.labelHeader1.AutoSize = true;
            this.labelHeader1.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader1.Font = new System.Drawing.Font("Palatino Linotype", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader1.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHeader1.Location = new System.Drawing.Point(12, 214);
            this.labelHeader1.Name = "labelHeader1";
            this.labelHeader1.Size = new System.Drawing.Size(349, 46);
            this.labelHeader1.TabIndex = 2;
            this.labelHeader1.Text = "Unmanned Systems  ";
            this.labelHeader1.Click += new System.EventHandler(this.labelHeader1_Click);
            // 
            // progressBarSplash
            // 
            this.progressBarSplash.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.progressBarSplash.ChannelColor = System.Drawing.Color.DimGray;
            this.progressBarSplash.ChannelHeight = 12;
            this.progressBarSplash.ForeBackColor = System.Drawing.Color.Gold;
            this.progressBarSplash.ForeColor = System.Drawing.Color.Black;
            this.progressBarSplash.Location = new System.Drawing.Point(0, 298);
            this.progressBarSplash.Name = "progressBarSplash";
            this.progressBarSplash.ShowMaximun = false;
            this.progressBarSplash.ShowValue = RJCodeAdvance.RJControls.TextPosition.Right;
            this.progressBarSplash.Size = new System.Drawing.Size(580, 12);
            this.progressBarSplash.SliderColor = System.Drawing.Color.OliveDrab;
            this.progressBarSplash.SliderHeight = 12;
            this.progressBarSplash.SymbolAfter = "";
            this.progressBarSplash.SymbolBefore = "";
            this.progressBarSplash.TabIndex = 3;
            // 
            // labelHeader2
            // 
            this.labelHeader2.AutoSize = true;
            this.labelHeader2.BackColor = System.Drawing.Color.Transparent;
            this.labelHeader2.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHeader2.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHeader2.Location = new System.Drawing.Point(12, 254);
            this.labelHeader2.Name = "labelHeader2";
            this.labelHeader2.Size = new System.Drawing.Size(340, 41);
            this.labelHeader2.TabIndex = 4;
            this.labelHeader2.Text = "Remote Command Post";
            // 
            // pictureBoxWithPseudoOpacity1
            // 
            this.pictureBoxWithPseudoOpacity1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWithPseudoOpacity1.Image = global::MissionPlanner.Properties.Resources.logo_serb;
            this.pictureBoxWithPseudoOpacity1.Location = new System.Drawing.Point(78, 120);
            this.pictureBoxWithPseudoOpacity1.Name = "pictureBoxWithPseudoOpacity1";
            this.pictureBoxWithPseudoOpacity1.Size = new System.Drawing.Size(126, 98);
            this.pictureBoxWithPseudoOpacity1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWithPseudoOpacity1.TabIndex = 5;
            this.pictureBoxWithPseudoOpacity1.TabStop = false;
            // 
            // timerSplash
            // 
            this.timerSplash.Tick += new System.EventHandler(this.timerSplash_Tick);
            // 
            // Splash
            // 
            this.BackgroundImage = global::MissionPlanner.Properties.Resources.unmanned_aerial1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(582, 303);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBoxWithPseudoOpacity1);
            this.Controls.Add(this.labelHeader2);
            this.Controls.Add(this.progressBarSplash);
            this.Controls.Add(this.labelHeader1);
            this.Controls.Add(this.TXT_version);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 350);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(600, 350);
            this.Name = "Splash";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mission Planner";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWithPseudoOpacity1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TXT_version;
        private System.Windows.Forms.Label labelHeader1;
        private RJCodeAdvance.RJControls.RJProgressBar progressBarSplash;
        private System.Windows.Forms.Label labelHeader2;
        private Controls.PictureBoxWithPseudoOpacity pictureBoxWithPseudoOpacity1;
        private System.Windows.Forms.Timer timerSplash;
    }
}