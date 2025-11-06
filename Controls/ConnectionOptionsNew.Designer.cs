namespace MissionPlanner.Controls
{
    partial class ConnectionOptionsNew
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

        public ConnectionOptionsNew()
        {
            InitializeComponent();
        }
        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_Main = new System.Windows.Forms.Panel();
            this.pnl_ActiveConnections = new System.Windows.Forms.Panel();
            this.lvw_ActiveConnections = new System.Windows.Forms.ListView();
            this.col_Port = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_BaudRate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_SystemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_CompID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Status = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_Action = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_ConnectionCount = new System.Windows.Forms.Label();
            this.lbl_ActiveConnectionsTitle = new System.Windows.Forms.Label();
            this.pnl_ConnectionPanel = new System.Windows.Forms.Panel();
            this.buttonAutoConnect = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_StatusText = new System.Windows.Forms.Label();
            this.lbl_StatusIndicator = new System.Windows.Forms.Label();
            this.lbl_Port = new System.Windows.Forms.Label();
            this.cmb_SerialPort = new System.Windows.Forms.ComboBox();
            this.lbl_BaudRate = new System.Windows.Forms.Label();
            this.cmb_BaudRate = new System.Windows.Forms.ComboBox();
            this.lbl_SystemID = new System.Windows.Forms.Label();
            this.cmb_SystemID = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Connect = new System.Windows.Forms.Button();
            this.btn_Disconnect = new System.Windows.Forms.Button();
            this.pnl_Main.SuspendLayout();
            this.pnl_ActiveConnections.SuspendLayout();
            this.pnl_ConnectionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_Main
            // 
            this.pnl_Main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.pnl_Main.Controls.Add(this.pnl_ActiveConnections);
            this.pnl_Main.Controls.Add(this.pnl_ConnectionPanel);
            this.pnl_Main.Location = new System.Drawing.Point(0, 0);
            this.pnl_Main.Name = "pnl_Main";
            this.pnl_Main.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_Main.Size = new System.Drawing.Size(600, 522);
            this.pnl_Main.TabIndex = 0;
            // 
            // pnl_ActiveConnections
            // 
            this.pnl_ActiveConnections.BackColor = System.Drawing.Color.White;
            this.pnl_ActiveConnections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_ActiveConnections.Controls.Add(this.lvw_ActiveConnections);
            this.pnl_ActiveConnections.Controls.Add(this.lbl_ConnectionCount);
            this.pnl_ActiveConnections.Controls.Add(this.lbl_ActiveConnectionsTitle);
            this.pnl_ActiveConnections.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_ActiveConnections.Location = new System.Drawing.Point(15, 235);
            this.pnl_ActiveConnections.Margin = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.pnl_ActiveConnections.Name = "pnl_ActiveConnections";
            this.pnl_ActiveConnections.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_ActiveConnections.Size = new System.Drawing.Size(570, 272);
            this.pnl_ActiveConnections.TabIndex = 0;
            // 
            // lvw_ActiveConnections
            // 
            this.lvw_ActiveConnections.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lvw_ActiveConnections.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvw_ActiveConnections.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_Port,
            this.col_BaudRate,
            this.col_SystemID,
            this.col_CompID,
            this.col_Status,
            this.col_Action});
            this.lvw_ActiveConnections.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lvw_ActiveConnections.FullRowSelect = true;
            this.lvw_ActiveConnections.GridLines = true;
            this.lvw_ActiveConnections.HideSelection = false;
            this.lvw_ActiveConnections.Location = new System.Drawing.Point(15, 45);
            this.lvw_ActiveConnections.Name = "lvw_ActiveConnections";
            this.lvw_ActiveConnections.Size = new System.Drawing.Size(551, 220);
            this.lvw_ActiveConnections.TabIndex = 0;
            this.lvw_ActiveConnections.UseCompatibleStateImageBehavior = false;
            this.lvw_ActiveConnections.View = System.Windows.Forms.View.Details;
            this.lvw_ActiveConnections.DoubleClick += new System.EventHandler(this.lvw_ActiveConnections_DoubleClick);
            // 
            // col_Port
            // 
            this.col_Port.Text = "Port";
            this.col_Port.Width = 100;
            // 
            // col_BaudRate
            // 
            this.col_BaudRate.Text = "Baud Rate";
            this.col_BaudRate.Width = 90;
            // 
            // col_SystemID
            // 
            this.col_SystemID.Text = "System ID";
            this.col_SystemID.Width = 80;
            // 
            // col_CompID
            // 
            this.col_CompID.Text = "Comp ID";
            // 
            // col_Status
            // 
            this.col_Status.Text = "Status";
            this.col_Status.Width = 100;
            // 
            // col_Action
            // 
            this.col_Action.Text = "Action";
            this.col_Action.Width = 80;
            // 
            // lbl_ConnectionCount
            // 
            this.lbl_ConnectionCount.AutoSize = true;
            this.lbl_ConnectionCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_ConnectionCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_ConnectionCount.Location = new System.Drawing.Point(150, 18);
            this.lbl_ConnectionCount.Name = "lbl_ConnectionCount";
            this.lbl_ConnectionCount.Size = new System.Drawing.Size(27, 20);
            this.lbl_ConnectionCount.TabIndex = 1;
            this.lbl_ConnectionCount.Text = "(0)";
            // 
            // lbl_ActiveConnectionsTitle
            // 
            this.lbl_ActiveConnectionsTitle.AutoSize = true;
            this.lbl_ActiveConnectionsTitle.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_ActiveConnectionsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_ActiveConnectionsTitle.Location = new System.Drawing.Point(15, 15);
            this.lbl_ActiveConnectionsTitle.Name = "lbl_ActiveConnectionsTitle";
            this.lbl_ActiveConnectionsTitle.Size = new System.Drawing.Size(182, 25);
            this.lbl_ActiveConnectionsTitle.TabIndex = 2;
            this.lbl_ActiveConnectionsTitle.Text = "Active Connections";
            // 
            // pnl_ConnectionPanel
            // 
            this.pnl_ConnectionPanel.BackColor = System.Drawing.Color.White;
            this.pnl_ConnectionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_ConnectionPanel.Controls.Add(this.buttonAutoConnect);
            this.pnl_ConnectionPanel.Controls.Add(this.button1);
            this.pnl_ConnectionPanel.Controls.Add(this.lbl_StatusText);
            this.pnl_ConnectionPanel.Controls.Add(this.lbl_StatusIndicator);
            this.pnl_ConnectionPanel.Controls.Add(this.lbl_Port);
            this.pnl_ConnectionPanel.Controls.Add(this.cmb_SerialPort);
            this.pnl_ConnectionPanel.Controls.Add(this.lbl_BaudRate);
            this.pnl_ConnectionPanel.Controls.Add(this.cmb_BaudRate);
            this.pnl_ConnectionPanel.Controls.Add(this.lbl_SystemID);
            this.pnl_ConnectionPanel.Controls.Add(this.cmb_SystemID);
            this.pnl_ConnectionPanel.Controls.Add(this.btn_Refresh);
            this.pnl_ConnectionPanel.Controls.Add(this.btn_Connect);
            this.pnl_ConnectionPanel.Controls.Add(this.btn_Disconnect);
            this.pnl_ConnectionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnl_ConnectionPanel.Location = new System.Drawing.Point(15, 15);
            this.pnl_ConnectionPanel.Name = "pnl_ConnectionPanel";
            this.pnl_ConnectionPanel.Padding = new System.Windows.Forms.Padding(15);
            this.pnl_ConnectionPanel.Size = new System.Drawing.Size(570, 220);
            this.pnl_ConnectionPanel.TabIndex = 1;
            // 
            // buttonAutoConnect
            // 
            this.buttonAutoConnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.buttonAutoConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAutoConnect.FlatAppearance.BorderSize = 0;
            this.buttonAutoConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAutoConnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.buttonAutoConnect.ForeColor = System.Drawing.Color.White;
            this.buttonAutoConnect.Location = new System.Drawing.Point(259, 120);
            this.buttonAutoConnect.Name = "buttonAutoConnect";
            this.buttonAutoConnect.Size = new System.Drawing.Size(138, 36);
            this.buttonAutoConnect.TabIndex = 12;
            this.buttonAutoConnect.Text = "Auto Connect";
            this.buttonAutoConnect.UseVisualStyleBackColor = false;
            this.buttonAutoConnect.Click += new System.EventHandler(this.buttonAutoConnect_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(440, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Debug";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_StatusText
            // 
            this.lbl_StatusText.AutoSize = true;
            this.lbl_StatusText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_StatusText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.lbl_StatusText.Location = new System.Drawing.Point(32, 15);
            this.lbl_StatusText.Name = "lbl_StatusText";
            this.lbl_StatusText.Size = new System.Drawing.Size(124, 20);
            this.lbl_StatusText.TabIndex = 0;
            this.lbl_StatusText.Text = "Ready to connect";
            // 
            // lbl_StatusIndicator
            // 
            this.lbl_StatusIndicator.BackColor = System.Drawing.Color.Gray;
            this.lbl_StatusIndicator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_StatusIndicator.Location = new System.Drawing.Point(15, 15);
            this.lbl_StatusIndicator.Name = "lbl_StatusIndicator";
            this.lbl_StatusIndicator.Size = new System.Drawing.Size(12, 12);
            this.lbl_StatusIndicator.TabIndex = 1;
            // 
            // lbl_Port
            // 
            this.lbl_Port.AutoSize = true;
            this.lbl_Port.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_Port.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_Port.Location = new System.Drawing.Point(15, 46);
            this.lbl_Port.Name = "lbl_Port";
            this.lbl_Port.Size = new System.Drawing.Size(79, 20);
            this.lbl_Port.TabIndex = 2;
            this.lbl_Port.Text = "Serial Port:";
            // 
            // cmb_SerialPort
            // 
            this.cmb_SerialPort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SerialPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_SerialPort.Location = new System.Drawing.Point(15, 70);
            this.cmb_SerialPort.Name = "cmb_SerialPort";
            this.cmb_SerialPort.Size = new System.Drawing.Size(200, 28);
            this.cmb_SerialPort.TabIndex = 3;
            // 
            // lbl_BaudRate
            // 
            this.lbl_BaudRate.AutoSize = true;
            this.lbl_BaudRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_BaudRate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_BaudRate.Location = new System.Drawing.Point(230, 46);
            this.lbl_BaudRate.Name = "lbl_BaudRate";
            this.lbl_BaudRate.Size = new System.Drawing.Size(80, 20);
            this.lbl_BaudRate.TabIndex = 4;
            this.lbl_BaudRate.Text = "Baud Rate:";
            // 
            // cmb_BaudRate
            // 
            this.cmb_BaudRate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_BaudRate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_BaudRate.Items.AddRange(new object[] {
            "9600",
            "57600",
            "115200"});
            this.cmb_BaudRate.Location = new System.Drawing.Point(230, 70);
            this.cmb_BaudRate.Name = "cmb_BaudRate";
            this.cmb_BaudRate.Size = new System.Drawing.Size(120, 28);
            this.cmb_BaudRate.TabIndex = 5;
            // 
            // lbl_SystemID
            // 
            this.lbl_SystemID.AutoSize = true;
            this.lbl_SystemID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lbl_SystemID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_SystemID.Location = new System.Drawing.Point(365, 46);
            this.lbl_SystemID.Name = "lbl_SystemID";
            this.lbl_SystemID.Size = new System.Drawing.Size(78, 20);
            this.lbl_SystemID.TabIndex = 6;
            this.lbl_SystemID.Text = "System ID:";
            // 
            // cmb_SystemID
            // 
            this.cmb_SystemID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SystemID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmb_SystemID.Location = new System.Drawing.Point(365, 70);
            this.cmb_SystemID.Name = "cmb_SystemID";
            this.cmb_SystemID.Size = new System.Drawing.Size(100, 28);
            this.cmb_SystemID.TabIndex = 7;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.btn_Refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Refresh.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.btn_Refresh.Location = new System.Drawing.Point(480, 70);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(70, 24);
            this.btn_Refresh.TabIndex = 8;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Connect
            // 
            this.btn_Connect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btn_Connect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Connect.FlatAppearance.BorderSize = 0;
            this.btn_Connect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Connect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Connect.ForeColor = System.Drawing.Color.White;
            this.btn_Connect.Location = new System.Drawing.Point(15, 120);
            this.btn_Connect.Name = "btn_Connect";
            this.btn_Connect.Size = new System.Drawing.Size(110, 36);
            this.btn_Connect.TabIndex = 9;
            this.btn_Connect.Text = "Connect";
            this.btn_Connect.UseVisualStyleBackColor = false;
            this.btn_Connect.Click += new System.EventHandler(this.btn_Connect_Click);
            // 
            // btn_Disconnect
            // 
            this.btn_Disconnect.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btn_Disconnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Disconnect.FlatAppearance.BorderSize = 0;
            this.btn_Disconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Disconnect.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btn_Disconnect.ForeColor = System.Drawing.Color.White;
            this.btn_Disconnect.Location = new System.Drawing.Point(135, 120);
            this.btn_Disconnect.Name = "btn_Disconnect";
            this.btn_Disconnect.Size = new System.Drawing.Size(110, 36);
            this.btn_Disconnect.TabIndex = 10;
            this.btn_Disconnect.Text = "Disconnect";
            this.btn_Disconnect.UseVisualStyleBackColor = false;
            this.btn_Disconnect.Click += new System.EventHandler(this.btn_Disconnect_Click);
            // 
            // ConnectionOptionsNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(245)))));
            this.ClientSize = new System.Drawing.Size(600, 515);
            this.Controls.Add(this.pnl_Main);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConnectionOptionsNew";
            this.Text = "Datalink Connections Manager";
            this.Load += new System.EventHandler(this.ConnectionOptions_Load);
            this.pnl_Main.ResumeLayout(false);
            this.pnl_ActiveConnections.ResumeLayout(false);
            this.pnl_ActiveConnections.PerformLayout();
            this.pnl_ConnectionPanel.ResumeLayout(false);
            this.pnl_ConnectionPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        // Panels
        private System.Windows.Forms.Panel pnl_Main;
        private System.Windows.Forms.Panel pnl_ConnectionPanel;
        private System.Windows.Forms.Panel pnl_ActiveConnections;

        // Connection input controls
        private System.Windows.Forms.Label lbl_Port;
        private System.Windows.Forms.ComboBox cmb_SerialPort;
        private System.Windows.Forms.Label lbl_BaudRate;
        private System.Windows.Forms.ComboBox cmb_BaudRate;
        private System.Windows.Forms.Label lbl_SystemID;
        private System.Windows.Forms.ComboBox cmb_SystemID;

        // Connection list header
        private System.Windows.Forms.Label lbl_ActiveConnectionsTitle;
        private System.Windows.Forms.Label lbl_ConnectionCount;

        // Connection list
        private System.Windows.Forms.ListView lvw_ActiveConnections;
        private System.Windows.Forms.ColumnHeader col_Port;
        private System.Windows.Forms.ColumnHeader col_BaudRate;
        private System.Windows.Forms.ColumnHeader col_SystemID;
        private System.Windows.Forms.ColumnHeader col_Status;
        private System.Windows.Forms.ColumnHeader col_Action;

        // Buttons
        private System.Windows.Forms.Button btn_Connect;
        private System.Windows.Forms.Button btn_Disconnect;
        private System.Windows.Forms.Button btn_Refresh;

        // Status indicator
        private System.Windows.Forms.Label lbl_StatusIndicator;
        private System.Windows.Forms.Label lbl_StatusText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonAutoConnect;
        private System.Windows.Forms.ColumnHeader col_CompID;
    }
}