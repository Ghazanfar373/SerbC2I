namespace MissionPlanner.Controls
{
    partial class ConnectionOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectionOptions));
            this.CMB_serialport = new System.Windows.Forms.ComboBox();
            this.CMB_baudrate = new System.Windows.Forms.ComboBox();
            this.klcButton1 = new KLCToolbox.KLCControls.KLCButton();
            this.klcButtonCancel = new KLCToolbox.KLCControls.KLCButton();
            this.myButton1 = new MissionPlanner.Controls.MyButton();
            this.BUT_connect = new MissionPlanner.Controls.MyButton();
            this.rjComboBoxPorts = new RJCodeAdvance.RJControls.RJComboBox();
            this.rjComboBoxBaudRate = new RJCodeAdvance.RJControls.RJComboBox();
            this.labelWithPseudoOpacity1 = new MissionPlanner.Controls.LabelWithPseudoOpacity();
            this.labelWithPseudoOpacity2 = new MissionPlanner.Controls.LabelWithPseudoOpacity();
            this.SuspendLayout();
            // 
            // CMB_serialport
            // 
            this.CMB_serialport.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_serialport.FormattingEnabled = true;
            resources.ApplyResources(this.CMB_serialport, "CMB_serialport");
            this.CMB_serialport.Name = "CMB_serialport";
            // 
            // CMB_baudrate
            // 
            this.CMB_baudrate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CMB_baudrate.FormattingEnabled = true;
            this.CMB_baudrate.Items.AddRange(new object[] {
            resources.GetString("CMB_baudrate.Items"),
            resources.GetString("CMB_baudrate.Items1"),
            resources.GetString("CMB_baudrate.Items2"),
            resources.GetString("CMB_baudrate.Items3"),
            resources.GetString("CMB_baudrate.Items4"),
            resources.GetString("CMB_baudrate.Items5"),
            resources.GetString("CMB_baudrate.Items6"),
            resources.GetString("CMB_baudrate.Items7")});
            resources.ApplyResources(this.CMB_baudrate, "CMB_baudrate");
            this.CMB_baudrate.Name = "CMB_baudrate";
            // 
            // klcButton1
            // 
            this.klcButton1.BackColor = System.Drawing.Color.LightGreen;
            this.klcButton1.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.klcButton1, "klcButton1");
            this.klcButton1.ForeColor = System.Drawing.Color.Black;
            this.klcButton1.KLCBackgroundColor = System.Drawing.Color.LightGreen;
            this.klcButton1.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButton1.KLCBorderRadius = 26;
            this.klcButton1.KLCBorderSize = 0;
            this.klcButton1.KLCTextColor = System.Drawing.Color.Black;
            this.klcButton1.Name = "klcButton1";
            this.klcButton1.UseVisualStyleBackColor = false;
            this.klcButton1.Click += new System.EventHandler(this.klcButtonConnect_Click);
            // 
            // klcButtonCancel
            // 
            this.klcButtonCancel.BackColor = System.Drawing.Color.Salmon;
            this.klcButtonCancel.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.klcButtonCancel, "klcButtonCancel");
            this.klcButtonCancel.ForeColor = System.Drawing.Color.Black;
            this.klcButtonCancel.KLCBackgroundColor = System.Drawing.Color.Salmon;
            this.klcButtonCancel.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButtonCancel.KLCBorderRadius = 26;
            this.klcButtonCancel.KLCBorderSize = 0;
            this.klcButtonCancel.KLCTextColor = System.Drawing.Color.Black;
            this.klcButtonCancel.Name = "klcButtonCancel";
            this.klcButtonCancel.UseVisualStyleBackColor = false;
            this.klcButtonCancel.Click += new System.EventHandler(this.klcButtonCancel_Click_1);
            // 
            // myButton1
            // 
            resources.ApplyResources(this.myButton1, "myButton1");
            this.myButton1.Name = "myButton1";
            this.myButton1.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.myButton1.UseVisualStyleBackColor = true;
            // 
            // BUT_connect
            // 
            resources.ApplyResources(this.BUT_connect, "BUT_connect");
            this.BUT_connect.Name = "BUT_connect";
            this.BUT_connect.TextColorNotEnabled = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(87)))), ((int)(((byte)(4)))));
            this.BUT_connect.UseVisualStyleBackColor = true;
            this.BUT_connect.Click += new System.EventHandler(this.BUT_connect_Click);
            // 
            // rjComboBoxPorts
            // 
            this.rjComboBoxPorts.BackColor = System.Drawing.Color.DimGray;
            this.rjComboBoxPorts.BorderColor = System.Drawing.Color.SpringGreen;
            this.rjComboBoxPorts.BorderSize = 1;
            this.rjComboBoxPorts.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            resources.ApplyResources(this.rjComboBoxPorts, "rjComboBoxPorts");
            this.rjComboBoxPorts.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBoxPorts.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxPorts.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBoxPorts.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBoxPorts.Name = "rjComboBoxPorts";
            this.rjComboBoxPorts.Texts = "";
            // 
            // rjComboBoxBaudRate
            // 
            this.rjComboBoxBaudRate.BackColor = System.Drawing.Color.DimGray;
            this.rjComboBoxBaudRate.BorderColor = System.Drawing.Color.SpringGreen;
            this.rjComboBoxBaudRate.BorderSize = 1;
            this.rjComboBoxBaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            resources.ApplyResources(this.rjComboBoxBaudRate, "rjComboBoxBaudRate");
            this.rjComboBoxBaudRate.ForeColor = System.Drawing.Color.Black;
            this.rjComboBoxBaudRate.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBoxBaudRate.Items.AddRange(new object[] {
            resources.GetString("rjComboBoxBaudRate.Items"),
            resources.GetString("rjComboBoxBaudRate.Items1"),
            resources.GetString("rjComboBoxBaudRate.Items2"),
            resources.GetString("rjComboBoxBaudRate.Items3"),
            resources.GetString("rjComboBoxBaudRate.Items4"),
            resources.GetString("rjComboBoxBaudRate.Items5"),
            resources.GetString("rjComboBoxBaudRate.Items6"),
            resources.GetString("rjComboBoxBaudRate.Items7")});
            this.rjComboBoxBaudRate.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rjComboBoxBaudRate.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBoxBaudRate.Name = "rjComboBoxBaudRate";
            this.rjComboBoxBaudRate.Texts = "";
            // 
            // labelWithPseudoOpacity1
            // 
            resources.ApplyResources(this.labelWithPseudoOpacity1, "labelWithPseudoOpacity1");
            this.labelWithPseudoOpacity1.DoubleBuffered = true;
            this.labelWithPseudoOpacity1.Name = "labelWithPseudoOpacity1";
            // 
            // labelWithPseudoOpacity2
            // 
            resources.ApplyResources(this.labelWithPseudoOpacity2, "labelWithPseudoOpacity2");
            this.labelWithPseudoOpacity2.DoubleBuffered = true;
            this.labelWithPseudoOpacity2.Name = "labelWithPseudoOpacity2";
            // 
            // ConnectionOptions
            // 
            resources.ApplyResources(this, "$this");
            this.ControlBox = false;
            this.Controls.Add(this.labelWithPseudoOpacity2);
            this.Controls.Add(this.labelWithPseudoOpacity1);
            this.Controls.Add(this.rjComboBoxBaudRate);
            this.Controls.Add(this.rjComboBoxPorts);
            this.Controls.Add(this.klcButtonCancel);
            this.Controls.Add(this.klcButton1);
            this.Controls.Add(this.myButton1);
            this.Controls.Add(this.CMB_baudrate);
            this.Controls.Add(this.BUT_connect);
            this.Controls.Add(this.CMB_serialport);
            this.Name = "ConnectionOptions";
            this.Load += new System.EventHandler(this.ConnectionOptions_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CMB_serialport;
        private System.Windows.Forms.ComboBox CMB_baudrate;
        private KLCToolbox.KLCControls.KLCButton klcButton1;
        private KLCToolbox.KLCControls.KLCButton klcButtonCancel;
        private MyButton myButton1;
        private MyButton BUT_connect;
        private RJCodeAdvance.RJControls.RJComboBox rjComboBoxPorts;
        private RJCodeAdvance.RJControls.RJComboBox rjComboBoxBaudRate;
        private LabelWithPseudoOpacity labelWithPseudoOpacity1;
        private LabelWithPseudoOpacity labelWithPseudoOpacity2;
    }
}