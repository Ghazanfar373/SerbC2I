///اللَّهُمَّ صَلِّ عَلَى سَيِّدِنَا مُحَمَّدٍ وَعَلَى آلِهِ وَصَحْبِهِ وَسَلَّم
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    partial class FlightStatus:MyUserControl
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        //private System.Windows.Forms.BindingSource bindingSourceHUD;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightStatus));
            this.splitMainPanel = new System.Windows.Forms.SplitContainer();
            this.splitContainerMap = new System.Windows.Forms.SplitContainer();
            this.gMapControlSerb = new MissionPlanner.Controls.myGMAP();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnMapMax = new RJCodeAdvance.RJControls.RJButton();
            this.lblMapZoom = new System.Windows.Forms.Label();
            this.btnMapMin = new RJCodeAdvance.RJControls.RJButton();
            this.lblMapAlt = new System.Windows.Forms.Label();
            this.bindingSourceHUD = new System.Windows.Forms.BindingSource(this.components);
            this.lblMapLong = new System.Windows.Forms.Label();
            this.lblMapLat = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelSats = new System.Windows.Forms.Label();
            this.lblhdopVal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnVideoVlc = new KLCToolbox.KLCControls.KLCButton();
            this.btnTelem = new KLCToolbox.KLCControls.KLCButton();
            this.btnSwarm = new KLCToolbox.KLCControls.KLCButton();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.statusLabel2 = new CodeArtEng.Controls.StatusLabel();
            this.statusLabel3 = new CodeArtEng.Controls.StatusLabel();
            this.statusLabel4 = new CodeArtEng.Controls.StatusLabel();
            this.statusLabel1 = new CodeArtEng.Controls.StatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.gEOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uTMToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mGRSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.panelMap = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.tableLayoutPanelQuickView = new System.Windows.Forms.TableLayoutPanel();
            this.labelQV12 = new System.Windows.Forms.Label();
            this.labelQV11 = new System.Windows.Forms.Label();
            this.labelQV10 = new System.Windows.Forms.Label();
            this.labelQV9 = new System.Windows.Forms.Label();
            this.labelQV6 = new System.Windows.Forms.Label();
            this.labelQV7 = new System.Windows.Forms.Label();
            this.labelQV8 = new System.Windows.Forms.Label();
            this.labelQV4 = new System.Windows.Forms.Label();
            this.labelQV3 = new System.Windows.Forms.Label();
            this.labelQV2 = new System.Windows.Forms.Label();
            this.labelQV1 = new System.Windows.Forms.Label();
            this.labelQV5 = new System.Windows.Forms.Label();
            this.quickView9 = new MissionPlanner.Controls.QuickView();
            this.quickView3 = new MissionPlanner.Controls.QuickView();
            this.quickView7 = new MissionPlanner.Controls.QuickView();
            this.quickView11 = new MissionPlanner.Controls.QuickView();
            this.quickView5 = new MissionPlanner.Controls.QuickView();
            this.quickView1 = new MissionPlanner.Controls.QuickView();
            this.quickView4 = new MissionPlanner.Controls.QuickView();
            this.quickView2 = new MissionPlanner.Controls.QuickView();
            this.quickView6 = new MissionPlanner.Controls.QuickView();
            this.quickView8 = new MissionPlanner.Controls.QuickView();
            this.quickView10 = new MissionPlanner.Controls.QuickView();
            this.quickView12 = new MissionPlanner.Controls.QuickView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tableLayoutPanelHUD = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel9 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCapGS = new System.Windows.Forms.Label();
            this.labelHudGS = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.flowLayoutPanel10 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCapAS = new System.Windows.Forms.Label();
            this.labelHudAS = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.hsiHeading = new MissionPlanner.Controls.HSI();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel8 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelCapAOA = new System.Windows.Forms.Label();
            this.labelValAOA = new System.Windows.Forms.Label();
            this.labelUnitAOA = new System.Windows.Forms.Label();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelHg = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelUnitHdg = new System.Windows.Forms.Label();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelGPS = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panelClock = new System.Windows.Forms.Panel();
            this.labelClock = new System.Windows.Forms.Label();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanel6 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelAGL = new System.Windows.Forms.Label();
            this.labelValAgl = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelASL = new System.Windows.Forms.Label();
            this.labelValAsl = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.hudSerb = new MissionPlanner.Controls.HUD();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.flowLayoutPanelPitch = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTitleAS = new System.Windows.Forms.Label();
            this.labelValAS = new System.Windows.Forms.Label();
            this.labelSpeedUnit = new System.Windows.Forms.Label();
            this.flowLayoutPanelRoll = new System.Windows.Forms.FlowLayoutPanel();
            this.labelTitleGS = new System.Windows.Forms.Label();
            this.labelValGS = new System.Windows.Forms.Label();
            this.labelUnitRoll = new System.Windows.Forms.Label();
            this.mavlinkMsgViewControl1 = new MissionPlanner.Controls.MavlinkMsgViewControl();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label18 = new System.Windows.Forms.Label();
            this.rjToggleBtnArm = new RJCodeAdvance.RJControls.RJToggleButton();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.flowLayoutPanel16 = new System.Windows.Forms.FlowLayoutPanel();
            this.klcButtonSetSpeed = new KLCToolbox.KLCControls.KLCButton();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel17 = new System.Windows.Forms.FlowLayoutPanel();
            this.klcButtonSetAlt = new KLCToolbox.KLCControls.KLCButton();
            this.numericUpDownAlt = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.flowLayoutPanel18 = new System.Windows.Forms.FlowLayoutPanel();
            this.klcButtonSetLoiterRad = new KLCToolbox.KLCControls.KLCButton();
            this.numericUpDownLoiter = new System.Windows.Forms.NumericUpDown();
            this.flowLayoutPanel11 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.labelBatteryLevel = new System.Windows.Forms.Label();
            this.flowLayoutPanel15 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label19 = new System.Windows.Forms.Label();
            this.flowLayoutPanel14 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.labelBatteryVolateges = new System.Windows.Forms.Label();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.klcButton14 = new KLCToolbox.KLCControls.KLCButton();
            this.klcButtonAuto = new KLCToolbox.KLCControls.KLCButton();
            this.klcButtonDoAction = new KLCToolbox.KLCControls.KLCButton();
            this.klcButton15 = new KLCToolbox.KLCControls.KLCButton();
            this.klcButtonZedGraph = new KLCToolbox.KLCControls.KLCButton();
            this.CMB_setwp = new System.Windows.Forms.ComboBox();
            this.CMB_action = new System.Windows.Forms.ComboBox();
            this.CMB_modes = new System.Windows.Forms.ComboBox();
            this.CMB_mountmode = new System.Windows.Forms.ComboBox();
            this.klcButton21 = new KLCToolbox.KLCControls.KLCButton();
            this.klcButtonSetWP = new KLCToolbox.KLCControls.KLCButton();
            this.klcButtonSetMode = new KLCToolbox.KLCControls.KLCButton();
            this.klcButtonSetMount = new KLCToolbox.KLCControls.KLCButton();
            this.klcButton20 = new KLCToolbox.KLCControls.KLCButton();
            this.klcButton22 = new KLCToolbox.KLCControls.KLCButton();
            this.klcButton24 = new KLCToolbox.KLCControls.KLCButton();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.timerZedGraph = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitMainPanel)).BeginInit();
            this.splitMainPanel.Panel1.SuspendLayout();
            this.splitMainPanel.Panel2.SuspendLayout();
            this.splitMainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMap)).BeginInit();
            this.splitContainerMap.Panel1.SuspendLayout();
            this.splitContainerMap.Panel2.SuspendLayout();
            this.splitContainerMap.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHUD)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelQuickView.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanelHUD.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.flowLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel10.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.flowLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelClock.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.flowLayoutPanel6.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.flowLayoutPanelPitch.SuspendLayout();
            this.flowLayoutPanelRoll.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            this.flowLayoutPanel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlt)).BeginInit();
            this.flowLayoutPanel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoiter)).BeginInit();
            this.flowLayoutPanel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.flowLayoutPanel15.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.flowLayoutPanel14.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tableLayoutPanel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMainPanel
            // 
            this.splitMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMainPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitMainPanel.Location = new System.Drawing.Point(0, 0);
            this.splitMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.splitMainPanel.MinimumSize = new System.Drawing.Size(839, 615);
            this.splitMainPanel.Name = "splitMainPanel";
            // 
            // splitMainPanel.Panel1
            // 
            this.splitMainPanel.Panel1.Controls.Add(this.splitContainerMap);
            this.splitMainPanel.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitMainPanel.Panel2
            // 
            this.splitMainPanel.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitMainPanel.Panel2.Controls.Add(this.tableLayoutPanelHUD);
            this.splitMainPanel.Panel2.Controls.Add(this.tableLayoutPanel2);
            this.splitMainPanel.Panel2.Padding = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.splitMainPanel.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitMainPanel.Size = new System.Drawing.Size(1337, 670);
            this.splitMainPanel.SplitterDistance = 953;
            this.splitMainPanel.TabIndex = 0;
            this.splitMainPanel.TabStop = false;
            this.splitMainPanel.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitMainPanel_SplitterMoved);
            // 
            // splitContainerMap
            // 
            this.splitContainerMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMap.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.splitContainerMap.Name = "splitContainerMap";
            this.splitContainerMap.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMap.Panel1
            // 
            this.splitContainerMap.Panel1.Controls.Add(this.gMapControlSerb);
            this.splitContainerMap.Panel1.Controls.Add(this.flowLayoutPanel4);
            this.splitContainerMap.Panel1.Controls.Add(this.panelMap);
            this.splitContainerMap.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainerMap.Panel2
            // 
            this.splitContainerMap.Panel2.Controls.Add(this.tabControl1);
            this.splitContainerMap.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerMap.Panel2MinSize = 180;
            this.splitContainerMap.Size = new System.Drawing.Size(953, 670);
            this.splitContainerMap.SplitterDistance = 444;
            this.splitContainerMap.TabIndex = 0;
            // 
            // gMapControlSerb
            // 
            this.gMapControlSerb.BackColor = System.Drawing.Color.Black;
            this.gMapControlSerb.Bearing = 0F;
            this.gMapControlSerb.CanDragMap = true;
            this.gMapControlSerb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gMapControlSerb.EmptyTileColor = System.Drawing.Color.Gray;
            this.gMapControlSerb.GrayScaleMode = false;
            this.gMapControlSerb.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControlSerb.HoldInvalidation = false;
            this.gMapControlSerb.LevelsKeepInMemmory = 5;
            this.gMapControlSerb.Location = new System.Drawing.Point(0, 0);
            this.gMapControlSerb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gMapControlSerb.MarkersEnabled = true;
            this.gMapControlSerb.MaxZoom = 24;
            this.gMapControlSerb.MinZoom = 0;
            this.gMapControlSerb.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControlSerb.Name = "gMapControlSerb";
            this.gMapControlSerb.NegativeMode = false;
            this.gMapControlSerb.PolygonsEnabled = true;
            this.gMapControlSerb.RetryLoadTile = 0;
            this.gMapControlSerb.RoutesEnabled = true;
            this.gMapControlSerb.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Fractional;
            this.gMapControlSerb.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControlSerb.ShowTileGridLines = false;
            this.gMapControlSerb.Size = new System.Drawing.Size(953, 404);
            this.gMapControlSerb.TabIndex = 0;
            this.gMapControlSerb.Zoom = 5D;
            this.gMapControlSerb.OnMarkerEnter += new GMap.NET.WindowsForms.MarkerEnter(this.gMapControlSerb_OnMarkerEnter);
            this.gMapControlSerb.OnMarkerLeave += new GMap.NET.WindowsForms.MarkerLeave(this.gMapControlSerb_OnMarkerLeave);
            this.gMapControlSerb.OnPositionChanged += new GMap.NET.PositionChanged(this.gMapControlSerb_OnPositionChanged);
            this.gMapControlSerb.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMapControlSerb_OnMapZoomChanged);
            this.gMapControlSerb.Click += new System.EventHandler(this.gMapControlSerb_Click);
            this.gMapControlSerb.Paint += new System.Windows.Forms.PaintEventHandler(this.gMapControlSerb_Paint);
            this.gMapControlSerb.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gMapControlSerb_MouseDown);
            this.gMapControlSerb.MouseLeave += new System.EventHandler(this.gMapControlSerb_MouseLeave);
            this.gMapControlSerb.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControlSerb_MouseMove);
            this.gMapControlSerb.MouseUp += new System.Windows.Forms.MouseEventHandler(this.gMapControlSerb_MouseUp);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel4.Controls.Add(this.btnMapMax);
            this.flowLayoutPanel4.Controls.Add(this.lblMapZoom);
            this.flowLayoutPanel4.Controls.Add(this.btnMapMin);
            this.flowLayoutPanel4.Controls.Add(this.lblMapAlt);
            this.flowLayoutPanel4.Controls.Add(this.lblMapLong);
            this.flowLayoutPanel4.Controls.Add(this.lblMapLat);
            this.flowLayoutPanel4.Controls.Add(this.label7);
            this.flowLayoutPanel4.Controls.Add(this.labelSats);
            this.flowLayoutPanel4.Controls.Add(this.lblhdopVal);
            this.flowLayoutPanel4.Controls.Add(this.label5);
            this.flowLayoutPanel4.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel4.Controls.Add(this.tableLayoutPanel12);
            this.flowLayoutPanel4.Controls.Add(this.statusStrip1);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 404);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(953, 40);
            this.flowLayoutPanel4.TabIndex = 4;
            // 
            // btnMapMax
            // 
            this.btnMapMax.BackColor = System.Drawing.Color.Transparent;
            this.btnMapMax.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMapMax.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMapMax.BorderRadius = 0;
            this.btnMapMax.BorderSize = 0;
            this.btnMapMax.FlatAppearance.BorderSize = 0;
            this.btnMapMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapMax.ForeColor = System.Drawing.Color.White;
            this.btnMapMax.Image = global::MissionPlanner.Properties.Resources.icons8_plus_161;
            this.btnMapMax.Location = new System.Drawing.Point(913, 2);
            this.btnMapMax.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMapMax.Name = "btnMapMax";
            this.btnMapMax.Size = new System.Drawing.Size(35, 34);
            this.btnMapMax.TabIndex = 2;
            this.btnMapMax.TextColor = System.Drawing.Color.White;
            this.btnMapMax.UseVisualStyleBackColor = false;
            this.btnMapMax.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // lblMapZoom
            // 
            this.lblMapZoom.AutoSize = true;
            this.lblMapZoom.Location = new System.Drawing.Point(885, 0);
            this.lblMapZoom.Margin = new System.Windows.Forms.Padding(0);
            this.lblMapZoom.MaximumSize = new System.Drawing.Size(40, 0);
            this.lblMapZoom.MinimumSize = new System.Drawing.Size(25, 30);
            this.lblMapZoom.Name = "lblMapZoom";
            this.lblMapZoom.Padding = new System.Windows.Forms.Padding(0, 12, 0, 0);
            this.lblMapZoom.Size = new System.Drawing.Size(25, 30);
            this.lblMapZoom.TabIndex = 6;
            this.lblMapZoom.Text = "25";
            // 
            // btnMapMin
            // 
            this.btnMapMin.BackColor = System.Drawing.Color.Transparent;
            this.btnMapMin.BackgroundColor = System.Drawing.Color.Transparent;
            this.btnMapMin.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnMapMin.BorderRadius = 0;
            this.btnMapMin.BorderSize = 0;
            this.btnMapMin.FlatAppearance.BorderSize = 0;
            this.btnMapMin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapMin.ForeColor = System.Drawing.Color.White;
            this.btnMapMin.Image = global::MissionPlanner.Properties.Resources.icons8_minus_161;
            this.btnMapMin.Location = new System.Drawing.Point(847, 2);
            this.btnMapMin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMapMin.Name = "btnMapMin";
            this.btnMapMin.Size = new System.Drawing.Size(35, 34);
            this.btnMapMin.TabIndex = 3;
            this.btnMapMin.TextColor = System.Drawing.Color.White;
            this.btnMapMin.UseVisualStyleBackColor = false;
            this.btnMapMin.Click += new System.EventHandler(this.btnMapMin_Click);
            // 
            // lblMapAlt
            // 
            this.lblMapAlt.AutoSize = true;
            this.lblMapAlt.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "alt", true));
            this.lblMapAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMapAlt.Location = new System.Drawing.Point(812, 16);
            this.lblMapAlt.MaximumSize = new System.Drawing.Size(0, 22);
            this.lblMapAlt.MinimumSize = new System.Drawing.Size(29, 0);
            this.lblMapAlt.Name = "lblMapAlt";
            this.lblMapAlt.Padding = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblMapAlt.Size = new System.Drawing.Size(29, 22);
            this.lblMapAlt.TabIndex = 2;
            this.lblMapAlt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bindingSourceHUD
            // 
            this.bindingSourceHUD.DataSource = typeof(MissionPlanner.CurrentState);
            // 
            // lblMapLong
            // 
            this.lblMapLong.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "lng", true));
            this.lblMapLong.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMapLong.Location = new System.Drawing.Point(715, 16);
            this.lblMapLong.MinimumSize = new System.Drawing.Size(91, 0);
            this.lblMapLong.Name = "lblMapLong";
            this.lblMapLong.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblMapLong.Size = new System.Drawing.Size(91, 22);
            this.lblMapLong.TabIndex = 1;
            this.lblMapLong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMapLat
            // 
            this.lblMapLat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "lat", true));
            this.lblMapLat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMapLat.Location = new System.Drawing.Point(618, 16);
            this.lblMapLat.MinimumSize = new System.Drawing.Size(91, 0);
            this.lblMapLat.Name = "lblMapLat";
            this.lblMapLat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblMapLat.Size = new System.Drawing.Size(91, 22);
            this.lblMapLat.TabIndex = 0;
            this.lblMapLat.Text = "123.7436649723";
            this.lblMapLat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMapLat.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(591, 16);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label7.Size = new System.Drawing.Size(21, 22);
            this.label7.TabIndex = 12;
            this.label7.Text = "25";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSats
            // 
            this.labelSats.AutoSize = true;
            this.labelSats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSats.Location = new System.Drawing.Point(555, 16);
            this.labelSats.Name = "labelSats";
            this.labelSats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.labelSats.Size = new System.Drawing.Size(30, 22);
            this.labelSats.TabIndex = 11;
            this.labelSats.Text = "Sat:";
            this.labelSats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblhdopVal
            // 
            this.lblhdopVal.AutoSize = true;
            this.lblhdopVal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblhdopVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhdopVal.Location = new System.Drawing.Point(525, 16);
            this.lblhdopVal.Name = "lblhdopVal";
            this.lblhdopVal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblhdopVal.Size = new System.Drawing.Size(24, 22);
            this.lblhdopVal.TabIndex = 10;
            this.lblhdopVal.Text = "2.7";
            this.lblhdopVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(478, 16);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.label5.Size = new System.Drawing.Size(41, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "hdpo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnVideoVlc);
            this.flowLayoutPanel2.Controls.Add(this.btnTelem);
            this.flowLayoutPanel2.Controls.Add(this.btnSwarm);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(223, 14);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(249, 22);
            this.flowLayoutPanel2.TabIndex = 13;
            // 
            // btnVideoVlc
            // 
            this.btnVideoVlc.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnVideoVlc.FlatAppearance.BorderSize = 0;
            this.btnVideoVlc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVideoVlc.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnVideoVlc.ForeColor = System.Drawing.Color.DimGray;
            this.btnVideoVlc.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnVideoVlc.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnVideoVlc.KLCBorderRadius = 8;
            this.btnVideoVlc.KLCBorderSize = 0;
            this.btnVideoVlc.KLCTextColor = System.Drawing.Color.DimGray;
            this.btnVideoVlc.Location = new System.Drawing.Point(3, 0);
            this.btnVideoVlc.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnVideoVlc.Name = "btnVideoVlc";
            this.btnVideoVlc.Size = new System.Drawing.Size(76, 22);
            this.btnVideoVlc.TabIndex = 24;
            this.btnVideoVlc.Text = "Video";
            this.btnVideoVlc.UseCompatibleTextRendering = true;
            this.btnVideoVlc.UseVisualStyleBackColor = false;
            this.btnVideoVlc.Click += new System.EventHandler(this.btnVideoVlc_Click);
            // 
            // btnTelem
            // 
            this.btnTelem.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTelem.FlatAppearance.BorderSize = 0;
            this.btnTelem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTelem.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnTelem.ForeColor = System.Drawing.Color.DimGray;
            this.btnTelem.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnTelem.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTelem.KLCBorderRadius = 8;
            this.btnTelem.KLCBorderSize = 0;
            this.btnTelem.KLCTextColor = System.Drawing.Color.DimGray;
            this.btnTelem.Location = new System.Drawing.Point(85, 0);
            this.btnTelem.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnTelem.Name = "btnTelem";
            this.btnTelem.Size = new System.Drawing.Size(76, 22);
            this.btnTelem.TabIndex = 23;
            this.btnTelem.Text = "Telem";
            this.btnTelem.UseCompatibleTextRendering = true;
            this.btnTelem.UseVisualStyleBackColor = false;
            this.btnTelem.Click += new System.EventHandler(this.btnTelem_Click);
            // 
            // btnSwarm
            // 
            this.btnSwarm.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSwarm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSwarm.FlatAppearance.BorderSize = 0;
            this.btnSwarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwarm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.btnSwarm.ForeColor = System.Drawing.Color.DimGray;
            this.btnSwarm.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSwarm.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSwarm.KLCBorderRadius = 8;
            this.btnSwarm.KLCBorderSize = 0;
            this.btnSwarm.KLCTextColor = System.Drawing.Color.DimGray;
            this.btnSwarm.Location = new System.Drawing.Point(167, 0);
            this.btnSwarm.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.btnSwarm.Name = "btnSwarm";
            this.btnSwarm.Size = new System.Drawing.Size(76, 22);
            this.btnSwarm.TabIndex = 22;
            this.btnSwarm.Text = "Swarm";
            this.btnSwarm.UseCompatibleTextRendering = true;
            this.btnSwarm.UseVisualStyleBackColor = false;
            this.btnSwarm.Click += new System.EventHandler(this.btnSwarm_Click);
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 4;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.18182F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.20354F));
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.00885F));
            this.tableLayoutPanel12.Controls.Add(this.statusLabel2, 2, 0);
            this.tableLayoutPanel12.Controls.Add(this.statusLabel3, 0, 0);
            this.tableLayoutPanel12.Controls.Add(this.statusLabel4, 1, 0);
            this.tableLayoutPanel12.Controls.Add(this.statusLabel1, 3, 0);
            this.tableLayoutPanel12.Location = new System.Drawing.Point(503, 40);
            this.tableLayoutPanel12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 1;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(445, 33);
            this.tableLayoutPanel12.TabIndex = 8;
            // 
            // statusLabel2
            // 
            this.statusLabel2.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusLabel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel2.Font = new System.Drawing.Font("Calibri Light", 7.8F);
            this.statusLabel2.Location = new System.Drawing.Point(215, 11);
            this.statusLabel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusLabel2.MaximumSize = new System.Drawing.Size(999, 18);
            this.statusLabel2.MinimumSize = new System.Drawing.Size(0, 18);
            this.statusLabel2.Name = "statusLabel2";
            this.statusLabel2.Size = new System.Drawing.Size(123, 18);
            this.statusLabel2.State = CodeArtEng.Controls.StatusLabelState.Red;
            this.statusLabel2.TabIndex = 5;
            this.statusLabel2.Text = "Target Heading";
            // 
            // statusLabel3
            // 
            this.statusLabel3.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusLabel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel3.Font = new System.Drawing.Font("Calibri Light", 7.8F);
            this.statusLabel3.Location = new System.Drawing.Point(4, 13);
            this.statusLabel3.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.statusLabel3.MaximumSize = new System.Drawing.Size(1332, 18);
            this.statusLabel3.MinimumSize = new System.Drawing.Size(0, 18);
            this.statusLabel3.Name = "statusLabel3";
            this.statusLabel3.Size = new System.Drawing.Size(102, 18);
            this.statusLabel3.State = CodeArtEng.Controls.StatusLabelState.Green;
            this.statusLabel3.TabIndex = 4;
            this.statusLabel3.Text = "Target Heading";
            // 
            // statusLabel4
            // 
            this.statusLabel4.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusLabel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel4.Font = new System.Drawing.Font("Calibri Light", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel4.Location = new System.Drawing.Point(113, 9);
            this.statusLabel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusLabel4.MaximumSize = new System.Drawing.Size(1165, 20);
            this.statusLabel4.MinimumSize = new System.Drawing.Size(0, 20);
            this.statusLabel4.Name = "statusLabel4";
            this.statusLabel4.Size = new System.Drawing.Size(96, 20);
            this.statusLabel4.State = CodeArtEng.Controls.StatusLabelState.Yellow;
            this.statusLabel4.TabIndex = 3;
            this.statusLabel4.Text = "Current WP";
            // 
            // statusLabel1
            // 
            this.statusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.statusLabel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.statusLabel1.Font = new System.Drawing.Font("Calibri Light", 7.8F);
            this.statusLabel1.Location = new System.Drawing.Point(344, 11);
            this.statusLabel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.statusLabel1.MaximumSize = new System.Drawing.Size(999, 18);
            this.statusLabel1.MinimumSize = new System.Drawing.Size(0, 18);
            this.statusLabel1.Name = "statusLabel1";
            this.statusLabel1.Size = new System.Drawing.Size(98, 18);
            this.statusLabel1.TabIndex = 0;
            this.statusLabel1.Text = "Swarm";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Transparent;
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripDropDownButton1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(313, 38);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(187, 33);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(35, 27);
            this.toolStripStatusLabel1.Text = "GPS";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gEOToolStripMenuItem,
            this.uTMToolStripMenuItem,
            this.mGRSToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 31);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // gEOToolStripMenuItem
            // 
            this.gEOToolStripMenuItem.Name = "gEOToolStripMenuItem";
            this.gEOToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.gEOToolStripMenuItem.Text = "GEO";
            // 
            // uTMToolStripMenuItem
            // 
            this.uTMToolStripMenuItem.Name = "uTMToolStripMenuItem";
            this.uTMToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.uTMToolStripMenuItem.Text = "UTM";
            // 
            // mGRSToolStripMenuItem
            // 
            this.mGRSToolStripMenuItem.Name = "mGRSToolStripMenuItem";
            this.mGRSToolStripMenuItem.Size = new System.Drawing.Size(132, 26);
            this.mGRSToolStripMenuItem.Text = "MGRS";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 25);
            // 
            // panelMap
            // 
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 0);
            this.panelMap.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(953, 444);
            this.panelMap.TabIndex = 5;
            // 
            // tabControl1
            // 
            this.tabControl1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(953, 222);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(25, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tabPage1.Size = new System.Drawing.Size(924, 214);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.2158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.78419F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.zedGraph, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelQuickView, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 212);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // zedGraph
            // 
            this.zedGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraph.Location = new System.Drawing.Point(3, 2);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(559, 208);
            this.zedGraph.TabIndex = 26;
            this.zedGraph.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.zedGraph_MouseDoubleClick);
            // 
            // tableLayoutPanelQuickView
            // 
            this.tableLayoutPanelQuickView.ColumnCount = 4;
            this.tableLayoutPanelQuickView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelQuickView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelQuickView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelQuickView.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanelQuickView.Controls.Add(this.labelQV12, 3, 4);
            this.tableLayoutPanelQuickView.Controls.Add(this.labelQV11, 2, 4);
            this.tableLayoutPanelQuickView.Controls.Add(this.labelQV10, 1, 4);
            this.tableLayoutPanelQuickView.Controls.Add(this.labelQV9, 0, 4);
            this.tableLayoutPanelQuickView.Controls.Add(this.labelQV6, 1, 2);
            this.tableLayoutPanelQuickView.Controls.Add(this.labelQV7, 2, 2);
            this.tableLayoutPanelQuickView.Controls.Add(this.labelQV8, 3, 2);
            this.tableLayoutPanelQuickView.Controls.Add(this.labelQV4, 3, 0);
            this.tableLayoutPanelQuickView.Controls.Add(this.labelQV3, 2, 0);
            this.tableLayoutPanelQuickView.Controls.Add(this.labelQV2, 1, 0);
            this.tableLayoutPanelQuickView.Controls.Add(this.labelQV1, 0, 0);
            this.tableLayoutPanelQuickView.Controls.Add(this.labelQV5, 0, 2);
            this.tableLayoutPanelQuickView.Controls.Add(this.quickView9, 0, 5);
            this.tableLayoutPanelQuickView.Controls.Add(this.quickView3, 2, 1);
            this.tableLayoutPanelQuickView.Controls.Add(this.quickView7, 2, 3);
            this.tableLayoutPanelQuickView.Controls.Add(this.quickView11, 2, 5);
            this.tableLayoutPanelQuickView.Controls.Add(this.quickView5, 0, 3);
            this.tableLayoutPanelQuickView.Controls.Add(this.quickView1, 0, 1);
            this.tableLayoutPanelQuickView.Controls.Add(this.quickView4, 3, 1);
            this.tableLayoutPanelQuickView.Controls.Add(this.quickView2, 1, 1);
            this.tableLayoutPanelQuickView.Controls.Add(this.quickView6, 1, 3);
            this.tableLayoutPanelQuickView.Controls.Add(this.quickView8, 3, 3);
            this.tableLayoutPanelQuickView.Controls.Add(this.quickView10, 1, 5);
            this.tableLayoutPanelQuickView.Controls.Add(this.quickView12, 3, 5);
            this.tableLayoutPanelQuickView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanelQuickView.Location = new System.Drawing.Point(568, 2);
            this.tableLayoutPanelQuickView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanelQuickView.Name = "tableLayoutPanelQuickView";
            this.tableLayoutPanelQuickView.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tableLayoutPanelQuickView.RowCount = 6;
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 22F));
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanelQuickView.Size = new System.Drawing.Size(353, 208);
            this.tableLayoutPanelQuickView.TabIndex = 25;
            // 
            // labelQV12
            // 
            this.labelQV12.AutoSize = true;
            this.labelQV12.BackColor = System.Drawing.Color.Transparent;
            this.labelQV12.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV12.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV12.Location = new System.Drawing.Point(267, 140);
            this.labelQV12.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelQV12.Name = "labelQV12";
            this.labelQV12.Size = new System.Drawing.Size(83, 20);
            this.labelQV12.TabIndex = 46;
            this.labelQV12.Text = "Roll Over";
            this.labelQV12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV11
            // 
            this.labelQV11.AutoSize = true;
            this.labelQV11.BackColor = System.Drawing.Color.Transparent;
            this.labelQV11.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV11.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV11.Location = new System.Drawing.Point(179, 140);
            this.labelQV11.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelQV11.Name = "labelQV11";
            this.labelQV11.Size = new System.Drawing.Size(82, 20);
            this.labelQV11.TabIndex = 45;
            this.labelQV11.Text = "Yaw";
            this.labelQV11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV10
            // 
            this.labelQV10.AutoSize = true;
            this.labelQV10.BackColor = System.Drawing.Color.Transparent;
            this.labelQV10.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV10.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV10.Location = new System.Drawing.Point(91, 140);
            this.labelQV10.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelQV10.Name = "labelQV10";
            this.labelQV10.Size = new System.Drawing.Size(82, 20);
            this.labelQV10.TabIndex = 44;
            this.labelQV10.Text = "Roll";
            this.labelQV10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV9
            // 
            this.labelQV9.AutoSize = true;
            this.labelQV9.BackColor = System.Drawing.Color.Transparent;
            this.labelQV9.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV9.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV9.Location = new System.Drawing.Point(3, 140);
            this.labelQV9.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelQV9.Name = "labelQV9";
            this.labelQV9.Size = new System.Drawing.Size(82, 20);
            this.labelQV9.TabIndex = 43;
            this.labelQV9.Text = "Pitch";
            this.labelQV9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV6
            // 
            this.labelQV6.AutoSize = true;
            this.labelQV6.BackColor = System.Drawing.Color.Transparent;
            this.labelQV6.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV6.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV6.Location = new System.Drawing.Point(91, 72);
            this.labelQV6.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelQV6.Name = "labelQV6";
            this.labelQV6.Size = new System.Drawing.Size(82, 20);
            this.labelQV6.TabIndex = 42;
            this.labelQV6.Text = "Angle of Attack";
            this.labelQV6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV7
            // 
            this.labelQV7.AutoSize = true;
            this.labelQV7.BackColor = System.Drawing.Color.Transparent;
            this.labelQV7.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV7.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV7.Location = new System.Drawing.Point(179, 72);
            this.labelQV7.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelQV7.Name = "labelQV7";
            this.labelQV7.Size = new System.Drawing.Size(82, 20);
            this.labelQV7.TabIndex = 41;
            this.labelQV7.Text = "Heading";
            this.labelQV7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV8
            // 
            this.labelQV8.AutoSize = true;
            this.labelQV8.BackColor = System.Drawing.Color.Transparent;
            this.labelQV8.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV8.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV8.Location = new System.Drawing.Point(267, 72);
            this.labelQV8.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelQV8.Name = "labelQV8";
            this.labelQV8.Size = new System.Drawing.Size(83, 20);
            this.labelQV8.TabIndex = 40;
            this.labelQV8.Text = "Bearing";
            this.labelQV8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV4
            // 
            this.labelQV4.AutoSize = true;
            this.labelQV4.BackColor = System.Drawing.Color.Transparent;
            this.labelQV4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV4.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV4.Location = new System.Drawing.Point(267, 4);
            this.labelQV4.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelQV4.Name = "labelQV4";
            this.labelQV4.Size = new System.Drawing.Size(83, 20);
            this.labelQV4.TabIndex = 39;
            this.labelQV4.Text = "ارتفاع البحر";
            this.labelQV4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV3
            // 
            this.labelQV3.AutoSize = true;
            this.labelQV3.BackColor = System.Drawing.Color.Transparent;
            this.labelQV3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV3.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV3.Location = new System.Drawing.Point(179, 4);
            this.labelQV3.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelQV3.Name = "labelQV3";
            this.labelQV3.Size = new System.Drawing.Size(82, 20);
            this.labelQV3.TabIndex = 38;
            this.labelQV3.Text = "الارتفاع الأرضي";
            this.labelQV3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV2
            // 
            this.labelQV2.AutoSize = true;
            this.labelQV2.BackColor = System.Drawing.Color.Transparent;
            this.labelQV2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV2.Location = new System.Drawing.Point(91, 4);
            this.labelQV2.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelQV2.Name = "labelQV2";
            this.labelQV2.Size = new System.Drawing.Size(82, 20);
            this.labelQV2.TabIndex = 37;
            this.labelQV2.Text = "سرعة الهواء";
            this.labelQV2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV1
            // 
            this.labelQV1.AutoSize = true;
            this.labelQV1.BackColor = System.Drawing.Color.Transparent;
            this.labelQV1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV1.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV1.Location = new System.Drawing.Point(3, 4);
            this.labelQV1.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelQV1.Name = "labelQV1";
            this.labelQV1.Size = new System.Drawing.Size(82, 20);
            this.labelQV1.TabIndex = 36;
            this.labelQV1.Text = "زاوية الهجوم";
            this.labelQV1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV5
            // 
            this.labelQV5.AutoSize = true;
            this.labelQV5.BackColor = System.Drawing.Color.Transparent;
            this.labelQV5.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV5.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV5.Location = new System.Drawing.Point(3, 72);
            this.labelQV5.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelQV5.Name = "labelQV5";
            this.labelQV5.Size = new System.Drawing.Size(82, 20);
            this.labelQV5.TabIndex = 28;
            this.labelQV5.Text = "Air Speed";
            this.labelQV5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quickView9
            // 
            this.quickView9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.quickView9.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "DistToHome", true));
            this.quickView9.desc = "";
            this.quickView9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView9.Location = new System.Drawing.Point(3, 164);
            this.quickView9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickView9.Name = "quickView9";
            this.quickView9.number = -99D;
            this.quickView9.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView9.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView9.numberformat = "0.00";
            this.quickView9.Size = new System.Drawing.Size(82, 42);
            this.quickView9.TabIndex = 12;
            this.quickView9.Text = "quickView24";
            // 
            // quickView3
            // 
            this.quickView3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.quickView3.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "pitch", true));
            this.quickView3.desc = "";
            this.quickView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView3.Location = new System.Drawing.Point(179, 28);
            this.quickView3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickView3.Name = "quickView3";
            this.quickView3.number = -9D;
            this.quickView3.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView3.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView3.numberformat = "0.00";
            this.quickView3.Size = new System.Drawing.Size(82, 42);
            this.quickView3.TabIndex = 2;
            this.quickView3.Text = "quickView14";
            // 
            // quickView7
            // 
            this.quickView7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.quickView7.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "roll", true));
            this.quickView7.desc = "";
            this.quickView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView7.Location = new System.Drawing.Point(179, 96);
            this.quickView7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickView7.Name = "quickView7";
            this.quickView7.number = -99D;
            this.quickView7.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView7.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView7.numberformat = "0.00";
            this.quickView7.Size = new System.Drawing.Size(82, 42);
            this.quickView7.TabIndex = 4;
            this.quickView7.Text = "quickView16";
            // 
            // quickView11
            // 
            this.quickView11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.quickView11.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "wind_dir", true));
            this.quickView11.desc = "";
            this.quickView11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView11.Location = new System.Drawing.Point(179, 164);
            this.quickView11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickView11.Name = "quickView11";
            this.quickView11.number = 54D;
            this.quickView11.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView11.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView11.numberformat = "0.00";
            this.quickView11.Size = new System.Drawing.Size(82, 42);
            this.quickView11.TabIndex = 6;
            this.quickView11.Text = "quickView18";
            // 
            // quickView5
            // 
            this.quickView5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.quickView5.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "groundspeed", true));
            this.quickView5.desc = "";
            this.quickView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView5.Location = new System.Drawing.Point(3, 96);
            this.quickView5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickView5.Name = "quickView5";
            this.quickView5.number = -34D;
            this.quickView5.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView5.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView5.numberformat = "0.00";
            this.quickView5.Size = new System.Drawing.Size(82, 42);
            this.quickView5.TabIndex = 7;
            this.quickView5.Text = "quickView19";
            // 
            // quickView1
            // 
            this.quickView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.quickView1.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "airspeed", true));
            this.quickView1.desc = "";
            this.quickView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView1.Location = new System.Drawing.Point(3, 28);
            this.quickView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickView1.Name = "quickView1";
            this.quickView1.number = -56D;
            this.quickView1.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.quickView1.numberColorBackup = System.Drawing.Color.Lime;
            this.quickView1.numberformat = "0.0";
            this.quickView1.Size = new System.Drawing.Size(82, 42);
            this.quickView1.TabIndex = 10;
            // 
            // quickView4
            // 
            this.quickView4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.quickView4.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "DistToHome", true));
            this.quickView4.desc = "";
            this.quickView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView4.Location = new System.Drawing.Point(267, 28);
            this.quickView4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickView4.Name = "quickView4";
            this.quickView4.number = 20D;
            this.quickView4.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView4.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView4.numberformat = "0.00";
            this.quickView4.Size = new System.Drawing.Size(83, 42);
            this.quickView4.TabIndex = 1;
            this.quickView4.Text = "quickView13";
            // 
            // quickView2
            // 
            this.quickView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.quickView2.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "alt", true));
            this.quickView2.desc = "";
            this.quickView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView2.Location = new System.Drawing.Point(91, 28);
            this.quickView2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickView2.Name = "quickView2";
            this.quickView2.number = -99D;
            this.quickView2.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView2.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView2.numberformat = "0.00";
            this.quickView2.Size = new System.Drawing.Size(82, 42);
            this.quickView2.TabIndex = 11;
            this.quickView2.Text = "quickView2";
            // 
            // quickView6
            // 
            this.quickView6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.quickView6.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "wind_dir", true));
            this.quickView6.desc = "";
            this.quickView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView6.Location = new System.Drawing.Point(91, 96);
            this.quickView6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickView6.Name = "quickView6";
            this.quickView6.number = -300D;
            this.quickView6.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView6.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView6.numberformat = "0.00";
            this.quickView6.Size = new System.Drawing.Size(82, 42);
            this.quickView6.TabIndex = 9;
            this.quickView6.Text = "quickView21";
            // 
            // quickView8
            // 
            this.quickView8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.quickView8.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "DistToHome", true));
            this.quickView8.desc = "";
            this.quickView8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView8.Location = new System.Drawing.Point(267, 96);
            this.quickView8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickView8.Name = "quickView8";
            this.quickView8.number = 11D;
            this.quickView8.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView8.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView8.numberformat = "0.00";
            this.quickView8.Size = new System.Drawing.Size(83, 42);
            this.quickView8.TabIndex = 3;
            this.quickView8.Text = "quickView15";
            // 
            // quickView10
            // 
            this.quickView10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.quickView10.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "wind_vel", true));
            this.quickView10.desc = "";
            this.quickView10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView10.Location = new System.Drawing.Point(91, 164);
            this.quickView10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickView10.Name = "quickView10";
            this.quickView10.number = -43D;
            this.quickView10.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView10.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView10.numberformat = "0.00";
            this.quickView10.Size = new System.Drawing.Size(82, 42);
            this.quickView10.TabIndex = 8;
            this.quickView10.Text = "quickView20";
            // 
            // quickView12
            // 
            this.quickView12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.quickView12.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "AOA", true));
            this.quickView12.desc = "";
            this.quickView12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView12.Location = new System.Drawing.Point(267, 164);
            this.quickView12.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.quickView12.Name = "quickView12";
            this.quickView12.number = 23D;
            this.quickView12.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView12.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView12.numberformat = "0.00";
            this.quickView12.Size = new System.Drawing.Size(83, 42);
            this.quickView12.TabIndex = 5;
            this.quickView12.Text = "quickView12";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.zedGraphControl1);
            this.tabPage2.Location = new System.Drawing.Point(25, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(796, 214);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Graph";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 2);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(790, 210);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // tableLayoutPanelHUD
            // 
            this.tableLayoutPanelHUD.ColumnCount = 1;
            this.tableLayoutPanelHUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanelHUD.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanelHUD.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanelHUD.Controls.Add(this.tableLayoutPanel6, 0, 1);
            this.tableLayoutPanelHUD.Controls.Add(this.mavlinkMsgViewControl1, 0, 3);
            this.tableLayoutPanelHUD.Location = new System.Drawing.Point(11, 2);
            this.tableLayoutPanelHUD.Margin = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.tableLayoutPanelHUD.Name = "tableLayoutPanelHUD";
            this.tableLayoutPanelHUD.RowCount = 4;
            this.tableLayoutPanelHUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.014553F));
            this.tableLayoutPanelHUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.58929F));
            this.tableLayoutPanelHUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.3816F));
            this.tableLayoutPanelHUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.014553F));
            this.tableLayoutPanelHUD.Size = new System.Drawing.Size(373, 462);
            this.tableLayoutPanelHUD.TabIndex = 1;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel10, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.hsiHeading, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel9, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 253);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(367, 162);
            this.tableLayoutPanel4.TabIndex = 14;
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel10.Controls.Add(this.flowLayoutPanel9, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.flowLayoutPanel10, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(285, 2);
            this.tableLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(79, 158);
            this.tableLayoutPanel10.TabIndex = 2;
            // 
            // flowLayoutPanel9
            // 
            this.flowLayoutPanel9.Controls.Add(this.labelCapGS);
            this.flowLayoutPanel9.Controls.Add(this.labelHudGS);
            this.flowLayoutPanel9.Controls.Add(this.label14);
            this.flowLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel9.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel9.Location = new System.Drawing.Point(3, 81);
            this.flowLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel9.Name = "flowLayoutPanel9";
            this.flowLayoutPanel9.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanel9.Size = new System.Drawing.Size(73, 75);
            this.flowLayoutPanel9.TabIndex = 2;
            // 
            // labelCapGS
            // 
            this.labelCapGS.AutoSize = true;
            this.labelCapGS.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCapGS.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapGS.Location = new System.Drawing.Point(5, 5);
            this.labelCapGS.Margin = new System.Windows.Forms.Padding(0);
            this.labelCapGS.Name = "labelCapGS";
            this.labelCapGS.Padding = new System.Windows.Forms.Padding(7, 0, 0, 0);
            this.labelCapGS.Size = new System.Drawing.Size(35, 20);
            this.labelCapGS.TabIndex = 9;
            this.labelCapGS.Text = "GS";
            this.labelCapGS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHudGS
            // 
            this.labelHudGS.AutoSize = true;
            this.labelHudGS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "groundspeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "", "0.00"));
            this.labelHudGS.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelHudGS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelHudGS.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHudGS.Location = new System.Drawing.Point(5, 25);
            this.labelHudGS.Margin = new System.Windows.Forms.Padding(0);
            this.labelHudGS.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelHudGS.MinimumSize = new System.Drawing.Size(60, 0);
            this.labelHudGS.Name = "labelHudGS";
            this.labelHudGS.Size = new System.Drawing.Size(60, 20);
            this.labelHudGS.TabIndex = 10;
            this.labelHudGS.Text = "100";
            this.labelHudGS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(8, 45);
            this.label14.MaximumSize = new System.Drawing.Size(0, 14);
            this.label14.MinimumSize = new System.Drawing.Size(32, 0);
            this.label14.Name = "label14";
            this.label14.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label14.Size = new System.Drawing.Size(32, 14);
            this.label14.TabIndex = 11;
            this.label14.Text = "m/s";
            // 
            // flowLayoutPanel10
            // 
            this.flowLayoutPanel10.Controls.Add(this.labelCapAS);
            this.flowLayoutPanel10.Controls.Add(this.labelHudAS);
            this.flowLayoutPanel10.Controls.Add(this.label1);
            this.flowLayoutPanel10.Controls.Add(this.label17);
            this.flowLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel10.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel10.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel10.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel10.Name = "flowLayoutPanel10";
            this.flowLayoutPanel10.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanel10.Size = new System.Drawing.Size(73, 75);
            this.flowLayoutPanel10.TabIndex = 1;
            // 
            // labelCapAS
            // 
            this.labelCapAS.AutoSize = true;
            this.labelCapAS.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelCapAS.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapAS.Location = new System.Drawing.Point(5, 5);
            this.labelCapAS.Margin = new System.Windows.Forms.Padding(0);
            this.labelCapAS.MinimumSize = new System.Drawing.Size(36, 0);
            this.labelCapAS.Name = "labelCapAS";
            this.labelCapAS.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelCapAS.Size = new System.Drawing.Size(39, 20);
            this.labelCapAS.TabIndex = 4;
            this.labelCapAS.Text = "AS";
            this.labelCapAS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelHudAS
            // 
            this.labelHudAS.AutoSize = true;
            this.labelHudAS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "airspeed", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "", "0.00"));
            this.labelHudAS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelHudAS.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHudAS.Location = new System.Drawing.Point(5, 25);
            this.labelHudAS.Margin = new System.Windows.Forms.Padding(0);
            this.labelHudAS.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelHudAS.MinimumSize = new System.Drawing.Size(60, 0);
            this.labelHudAS.Name = "labelHudAS";
            this.labelHudAS.Size = new System.Drawing.Size(60, 20);
            this.labelHudAS.TabIndex = 5;
            this.labelHudAS.Text = "180";
            this.labelHudAS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 45);
            this.label1.MaximumSize = new System.Drawing.Size(0, 14);
            this.label1.MinimumSize = new System.Drawing.Size(32, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 1, 0, 0);
            this.label1.Size = new System.Drawing.Size(32, 14);
            this.label1.TabIndex = 12;
            this.label1.Text = "m/s";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(65, 5);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(0, 16);
            this.label17.TabIndex = 6;
            // 
            // hsiHeading
            // 
            this.hsiHeading.DataBindings.Add(new System.Windows.Forms.Binding("Heading", this.bindingSourceHUD, "yaw", true));
            this.hsiHeading.Heading = 0;
            this.hsiHeading.Location = new System.Drawing.Point(99, 5);
            this.hsiHeading.Margin = new System.Windows.Forms.Padding(15, 5, 15, 2);
            this.hsiHeading.Name = "hsiHeading";
            this.hsiHeading.NavHeading = 0;
            this.hsiHeading.Size = new System.Drawing.Size(155, 155);
            this.hsiHeading.TabIndex = 0;
            this.hsiHeading.Load += new System.EventHandler(this.hsi1_Load);
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 1;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Controls.Add(this.flowLayoutPanel8, 0, 1);
            this.tableLayoutPanel9.Controls.Add(this.flowLayoutPanel7, 0, 0);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 2;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(78, 158);
            this.tableLayoutPanel9.TabIndex = 1;
            // 
            // flowLayoutPanel8
            // 
            this.flowLayoutPanel8.Controls.Add(this.labelCapAOA);
            this.flowLayoutPanel8.Controls.Add(this.labelValAOA);
            this.flowLayoutPanel8.Controls.Add(this.labelUnitAOA);
            this.flowLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel8.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel8.Location = new System.Drawing.Point(3, 81);
            this.flowLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel8.Name = "flowLayoutPanel8";
            this.flowLayoutPanel8.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanel8.Size = new System.Drawing.Size(72, 75);
            this.flowLayoutPanel8.TabIndex = 2;
            // 
            // labelCapAOA
            // 
            this.labelCapAOA.AutoSize = true;
            this.labelCapAOA.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCapAOA.Location = new System.Drawing.Point(5, 5);
            this.labelCapAOA.Margin = new System.Windows.Forms.Padding(0);
            this.labelCapAOA.Name = "labelCapAOA";
            this.labelCapAOA.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelCapAOA.Size = new System.Drawing.Size(53, 20);
            this.labelCapAOA.TabIndex = 9;
            this.labelCapAOA.Text = "AOA";
            this.labelCapAOA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelValAOA
            // 
            this.labelValAOA.AutoSize = true;
            this.labelValAOA.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "pitch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "", "0.00"));
            this.labelValAOA.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelValAOA.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValAOA.Location = new System.Drawing.Point(5, 25);
            this.labelValAOA.Margin = new System.Windows.Forms.Padding(0);
            this.labelValAOA.MinimumSize = new System.Drawing.Size(60, 0);
            this.labelValAOA.Name = "labelValAOA";
            this.labelValAOA.Size = new System.Drawing.Size(60, 22);
            this.labelValAOA.TabIndex = 10;
            this.labelValAOA.Text = "7000";
            this.labelValAOA.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelUnitAOA
            // 
            this.labelUnitAOA.AutoSize = true;
            this.labelUnitAOA.Location = new System.Drawing.Point(8, 47);
            this.labelUnitAOA.Name = "labelUnitAOA";
            this.labelUnitAOA.Size = new System.Drawing.Size(16, 16);
            this.labelUnitAOA.TabIndex = 11;
            this.labelUnitAOA.Text = "...";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.Controls.Add(this.labelHg);
            this.flowLayoutPanel7.Controls.Add(this.label4);
            this.flowLayoutPanel7.Controls.Add(this.labelUnitHdg);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanel7.Size = new System.Drawing.Size(72, 75);
            this.flowLayoutPanel7.TabIndex = 1;
            // 
            // labelHg
            // 
            this.labelHg.AutoSize = true;
            this.labelHg.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHg.Location = new System.Drawing.Point(5, 5);
            this.labelHg.Margin = new System.Windows.Forms.Padding(0);
            this.labelHg.MinimumSize = new System.Drawing.Size(36, 0);
            this.labelHg.Name = "labelHg";
            this.labelHg.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelHg.Size = new System.Drawing.Size(53, 20);
            this.labelHg.TabIndex = 4;
            this.labelHg.Text = "HDG";
            this.labelHg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "roll", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "", "0.00"));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label4.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.MinimumSize = new System.Drawing.Size(60, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "180";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelUnitHdg
            // 
            this.labelUnitHdg.AutoSize = true;
            this.labelUnitHdg.Location = new System.Drawing.Point(5, 47);
            this.labelUnitHdg.Margin = new System.Windows.Forms.Padding(0);
            this.labelUnitHdg.Name = "labelUnitHdg";
            this.labelUnitHdg.Size = new System.Drawing.Size(0, 16);
            this.labelUnitHdg.TabIndex = 6;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 3;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.15265F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.69471F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.15265F));
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.flowLayoutPanel1, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.panelClock, 1, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(367, 34);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.labelGPS);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(108, 30);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MissionPlanner.Properties.Resources.satellite_icon;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(29, 25);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Variable Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(38, 0);
            this.label2.MinimumSize = new System.Drawing.Size(65, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "No GPS";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelGPS
            // 
            this.labelGPS.AutoSize = true;
            this.labelGPS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelGPS.Font = new System.Drawing.Font("Microsoft Tai Le", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGPS.ForeColor = System.Drawing.SystemColors.Control;
            this.labelGPS.Location = new System.Drawing.Point(3, 29);
            this.labelGPS.Name = "labelGPS";
            this.labelGPS.Size = new System.Drawing.Size(101, 16);
            this.labelGPS.TabIndex = 6;
            this.labelGPS.Text = "GPS: NO Signal";
            this.labelGPS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.label12);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(255, 2);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(109, 30);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MissionPlanner.Properties.Resources.radio_wav_icon;
            this.pictureBox2.Location = new System.Drawing.Point(3, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 25);
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.SystemColors.Control;
            this.label12.Location = new System.Drawing.Point(38, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 20);
            this.label12.TabIndex = 8;
            this.label12.Text = "100%";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelClock
            // 
            this.panelClock.Controls.Add(this.labelClock);
            this.panelClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelClock.Location = new System.Drawing.Point(117, 2);
            this.panelClock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelClock.Name = "panelClock";
            this.panelClock.Size = new System.Drawing.Size(132, 30);
            this.panelClock.TabIndex = 2;
            // 
            // labelClock
            // 
            this.labelClock.AutoSize = true;
            this.labelClock.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "datetime", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, ""));
            this.labelClock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelClock.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelClock.Location = new System.Drawing.Point(0, 0);
            this.labelClock.Margin = new System.Windows.Forms.Padding(0);
            this.labelClock.Name = "labelClock";
            this.labelClock.Size = new System.Drawing.Size(71, 20);
            this.labelClock.TabIndex = 2;
            this.labelClock.Text = "09:08:23";
            this.labelClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel6.ColumnCount = 3;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23F));
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel8, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.hudSerb, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.tableLayoutPanel7, 0, 0);
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 43);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(367, 204);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 1;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.Controls.Add(this.flowLayoutPanel6, 0, 1);
            this.tableLayoutPanel8.Controls.Add(this.flowLayoutPanel5, 0, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(285, 2);
            this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 2;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel8.Size = new System.Drawing.Size(79, 200);
            this.tableLayoutPanel8.TabIndex = 6;
            // 
            // flowLayoutPanel6
            // 
            this.flowLayoutPanel6.Controls.Add(this.labelAGL);
            this.flowLayoutPanel6.Controls.Add(this.labelValAgl);
            this.flowLayoutPanel6.Controls.Add(this.label13);
            this.flowLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel6.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel6.Location = new System.Drawing.Point(3, 109);
            this.flowLayoutPanel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel6.Name = "flowLayoutPanel6";
            this.flowLayoutPanel6.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanel6.Size = new System.Drawing.Size(73, 89);
            this.flowLayoutPanel6.TabIndex = 3;
            // 
            // labelAGL
            // 
            this.labelAGL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAGL.AutoSize = true;
            this.labelAGL.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAGL.Location = new System.Drawing.Point(5, 5);
            this.labelAGL.Margin = new System.Windows.Forms.Padding(0);
            this.labelAGL.Name = "labelAGL";
            this.labelAGL.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelAGL.Size = new System.Drawing.Size(60, 20);
            this.labelAGL.TabIndex = 9;
            this.labelAGL.Text = "AGL";
            this.labelAGL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelValAgl
            // 
            this.labelValAgl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValAgl.AutoSize = true;
            this.labelValAgl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "alt", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "", "0.00"));
            this.labelValAgl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelValAgl.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValAgl.Location = new System.Drawing.Point(5, 25);
            this.labelValAgl.Margin = new System.Windows.Forms.Padding(0);
            this.labelValAgl.MinimumSize = new System.Drawing.Size(60, 0);
            this.labelValAgl.Name = "labelValAgl";
            this.labelValAgl.Size = new System.Drawing.Size(60, 28);
            this.labelValAgl.TabIndex = 10;
            this.labelValAgl.Text = "N/D";
            this.labelValAgl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelValAgl.UseCompatibleTextRendering = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 53);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.label13.Size = new System.Drawing.Size(52, 16);
            this.label13.TabIndex = 11;
            this.label13.Text = "meter";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.labelASL);
            this.flowLayoutPanel5.Controls.Add(this.labelValAsl);
            this.flowLayoutPanel5.Controls.Add(this.label9);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(73, 103);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // labelASL
            // 
            this.labelASL.AutoSize = true;
            this.labelASL.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelASL.Location = new System.Drawing.Point(5, 5);
            this.labelASL.Margin = new System.Windows.Forms.Padding(0);
            this.labelASL.Name = "labelASL";
            this.labelASL.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelASL.Size = new System.Drawing.Size(47, 20);
            this.labelASL.TabIndex = 9;
            this.labelASL.Text = "ASL";
            this.labelASL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelValAsl
            // 
            this.labelValAsl.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "altasl", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "", "0.00"));
            this.labelValAsl.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelValAsl.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValAsl.Location = new System.Drawing.Point(5, 25);
            this.labelValAsl.Margin = new System.Windows.Forms.Padding(0);
            this.labelValAsl.MinimumSize = new System.Drawing.Size(45, 0);
            this.labelValAsl.Name = "labelValAsl";
            this.labelValAsl.Size = new System.Drawing.Size(60, 22);
            this.labelValAsl.TabIndex = 10;
            this.labelValAsl.Text = "N/D";
            this.labelValAsl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 47);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.label9.Size = new System.Drawing.Size(52, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "meter";
            // 
            // hudSerb
            // 
            this.hudSerb.airspeed = 0F;
            this.hudSerb.alt = 0F;
            this.hudSerb.altunit = null;
            this.hudSerb.AOA = 0F;
            this.hudSerb.BackColor = System.Drawing.Color.Black;
            this.hudSerb.batterycellcount = 4;
            this.hudSerb.batterylevel = 0F;
            this.hudSerb.batterylevel2 = 0F;
            this.hudSerb.batteryon = false;
            this.hudSerb.batteryremaining = 0F;
            this.hudSerb.batteryremaining2 = 0F;
            this.hudSerb.bgimage = null;
            this.hudSerb.connected = false;
            this.hudSerb.critAOA = 25F;
            this.hudSerb.criticalvoltagealert = false;
            this.hudSerb.critSSA = 30F;
            this.hudSerb.current = 0F;
            this.hudSerb.current2 = 0F;
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("airspeed", this.bindingSourceHUD, "airspeed", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("alt", this.bindingSourceHUD, "alt", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("load", this.bindingSourceHUD, "load", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("batterylevel", this.bindingSourceHUD, "battery_voltage", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("batteryremaining", this.bindingSourceHUD, "battery_remaining", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("connected", this.bindingSourceHUD, "connected", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("current", this.bindingSourceHUD, "current", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("batterylevel2", this.bindingSourceHUD, "battery_voltage2", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("batteryremaining2", this.bindingSourceHUD, "battery_remaining2", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("current2", this.bindingSourceHUD, "current2", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("disttowp", this.bindingSourceHUD, "wp_dist", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("ekfstatus", this.bindingSourceHUD, "ekfstatus", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("failsafe", this.bindingSourceHUD, "failsafe", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix", this.bindingSourceHUD, "gpsstatus", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("gpsfix2", this.bindingSourceHUD, "gpsstatus2", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop", this.bindingSourceHUD, "gpshdop", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("gpshdop2", this.bindingSourceHUD, "gpshdop2", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("groundalt", this.bindingSourceHUD, "HomeAlt", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("groundcourse", this.bindingSourceHUD, "groundcourse", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("groundspeed", this.bindingSourceHUD, "groundspeed", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("heading", this.bindingSourceHUD, "yaw", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("linkqualitygcs", this.bindingSourceHUD, "linkqualitygcs", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("message", this.bindingSourceHUD, "messageHigh", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("messageSeverity", this.bindingSourceHUD, "messageHighSeverity", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("mode", this.bindingSourceHUD, "mode", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("navpitch", this.bindingSourceHUD, "nav_pitch", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("navroll", this.bindingSourceHUD, "nav_roll", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("pitch", this.bindingSourceHUD, "pitch", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("roll", this.bindingSourceHUD, "roll", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("status", this.bindingSourceHUD, "armed", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("targetalt", this.bindingSourceHUD, "targetalt", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("targetheading", this.bindingSourceHUD, "nav_bearing", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("targetspeed", this.bindingSourceHUD, "targetairspeed", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("turnrate", this.bindingSourceHUD, "turnrate", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("verticalspeed", this.bindingSourceHUD, "verticalspeed", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("vibex", this.bindingSourceHUD, "vibex", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("vibey", this.bindingSourceHUD, "vibey", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("vibez", this.bindingSourceHUD, "vibez", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("wpno", this.bindingSourceHUD, "wpno", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("xtrack_error", this.bindingSourceHUD, "xtrack_error", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("AOA", this.bindingSourceHUD, "AOA", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("SSA", this.bindingSourceHUD, "SSA", true));
            this.hudSerb.DataBindings.Add(new System.Windows.Forms.Binding("critAOA", this.bindingSourceHUD, "crit_AOA", true));
            this.hudSerb.datetime = new System.DateTime(((long)(0)));
            this.hudSerb.displayalt = false;
            this.hudSerb.displayAOASSA = false;
            this.hudSerb.displayCellVoltage = false;
            this.hudSerb.displayconninfo = false;
            this.hudSerb.displayekf = false;
            this.hudSerb.displaygps = false;
            this.hudSerb.displayheading = false;
            this.hudSerb.displayicons = false;
            this.hudSerb.displayspeed = false;
            this.hudSerb.displayvibe = false;
            this.hudSerb.displayxtrack = false;
            this.hudSerb.disttowp = 0F;
            this.hudSerb.distunit = null;
            this.hudSerb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hudSerb.ekfstatus = 0F;
            this.hudSerb.failsafe = false;
            this.hudSerb.gpsfix = 0F;
            this.hudSerb.gpsfix2 = 0F;
            this.hudSerb.gpshdop = 0F;
            this.hudSerb.gpshdop2 = 0F;
            this.hudSerb.groundalt = 0F;
            this.hudSerb.groundColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(173)))), ((int)(((byte)(104)))), ((int)(((byte)(13)))));
            this.hudSerb.groundColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(147)))), ((int)(((byte)(17)))));
            this.hudSerb.groundcourse = 0F;
            this.hudSerb.groundspeed = 0F;
            this.hudSerb.heading = 0F;
            this.hudSerb.hudcolor = System.Drawing.Color.LightGray;
            this.hudSerb.linkqualitygcs = 0F;
            this.hudSerb.load = 0F;
            this.hudSerb.Location = new System.Drawing.Point(84, 4);
            this.hudSerb.lowairspeed = false;
            this.hudSerb.lowgroundspeed = false;
            this.hudSerb.lowvoltagealert = false;
            this.hudSerb.Margin = new System.Windows.Forms.Padding(0, 4, 0, 4);
            this.hudSerb.MaximumSize = new System.Drawing.Size(200, 199);
            this.hudSerb.message = "";
            this.hudSerb.messageSeverity = MAVLink.MAV_SEVERITY.EMERGENCY;
            this.hudSerb.MinimumSize = new System.Drawing.Size(200, 199);
            this.hudSerb.mode = "Unknown";
            this.hudSerb.Name = "hudSerb";
            this.hudSerb.navpitch = 0F;
            this.hudSerb.navroll = 0F;
            this.hudSerb.pitch = 0F;
            this.hudSerb.roll = 0F;
            this.hudSerb.Russian = false;
            this.hudSerb.Size = new System.Drawing.Size(200, 199);
            this.hudSerb.skyColor1 = System.Drawing.Color.Blue;
            this.hudSerb.skyColor2 = System.Drawing.Color.LightBlue;
            this.hudSerb.speedunit = null;
            this.hudSerb.SSA = 0F;
            this.hudSerb.status = false;
            this.hudSerb.TabIndex = 4;
            this.hudSerb.targetalt = 0F;
            this.hudSerb.targetheading = 0F;
            this.hudSerb.targetspeed = 0F;
            this.hudSerb.turnrate = 0F;
            this.hudSerb.verticalspeed = 0F;
            this.hudSerb.vibex = 0F;
            this.hudSerb.vibey = 0F;
            this.hudSerb.vibez = 0F;
            this.hudSerb.VSync = false;
            this.hudSerb.wpno = 0;
            this.hudSerb.xtrack_error = 0F;
            this.hudSerb.Resize += new System.EventHandler(this.hudSerb_Resize);
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 1;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Controls.Add(this.flowLayoutPanelPitch, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.flowLayoutPanelRoll, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 2;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel7.Size = new System.Drawing.Size(78, 200);
            this.tableLayoutPanel7.TabIndex = 5;
            // 
            // flowLayoutPanelPitch
            // 
            this.flowLayoutPanelPitch.Controls.Add(this.labelTitleAS);
            this.flowLayoutPanelPitch.Controls.Add(this.labelValAS);
            this.flowLayoutPanelPitch.Controls.Add(this.labelSpeedUnit);
            this.flowLayoutPanelPitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelPitch.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelPitch.Location = new System.Drawing.Point(3, 109);
            this.flowLayoutPanelPitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelPitch.Name = "flowLayoutPanelPitch";
            this.flowLayoutPanelPitch.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanelPitch.Size = new System.Drawing.Size(72, 89);
            this.flowLayoutPanelPitch.TabIndex = 1;
            // 
            // labelTitleAS
            // 
            this.labelTitleAS.AutoSize = true;
            this.labelTitleAS.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleAS.Location = new System.Drawing.Point(5, 5);
            this.labelTitleAS.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitleAS.Name = "labelTitleAS";
            this.labelTitleAS.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelTitleAS.Size = new System.Drawing.Size(55, 20);
            this.labelTitleAS.TabIndex = 9;
            this.labelTitleAS.Text = "Pitch";
            this.labelTitleAS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelValAS
            // 
            this.labelValAS.AutoSize = true;
            this.labelValAS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "pitch", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "", "0.00"));
            this.labelValAS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelValAS.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValAS.Location = new System.Drawing.Point(5, 25);
            this.labelValAS.Margin = new System.Windows.Forms.Padding(0);
            this.labelValAS.MinimumSize = new System.Drawing.Size(60, 0);
            this.labelValAS.Name = "labelValAS";
            this.labelValAS.Size = new System.Drawing.Size(60, 28);
            this.labelValAS.TabIndex = 10;
            this.labelValAS.Text = "7000";
            this.labelValAS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelValAS.UseCompatibleTextRendering = true;
            // 
            // labelSpeedUnit
            // 
            this.labelSpeedUnit.AutoSize = true;
            this.labelSpeedUnit.Location = new System.Drawing.Point(8, 53);
            this.labelSpeedUnit.Name = "labelSpeedUnit";
            this.labelSpeedUnit.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelSpeedUnit.Size = new System.Drawing.Size(51, 16);
            this.labelSpeedUnit.TabIndex = 11;
            this.labelSpeedUnit.Text = "Knots";
            // 
            // flowLayoutPanelRoll
            // 
            this.flowLayoutPanelRoll.Controls.Add(this.labelTitleGS);
            this.flowLayoutPanelRoll.Controls.Add(this.labelValGS);
            this.flowLayoutPanelRoll.Controls.Add(this.labelUnitRoll);
            this.flowLayoutPanelRoll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelRoll.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelRoll.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanelRoll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelRoll.Name = "flowLayoutPanelRoll";
            this.flowLayoutPanelRoll.Padding = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.flowLayoutPanelRoll.Size = new System.Drawing.Size(72, 103);
            this.flowLayoutPanelRoll.TabIndex = 0;
            // 
            // labelTitleGS
            // 
            this.labelTitleGS.AutoSize = true;
            this.labelTitleGS.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitleGS.Location = new System.Drawing.Point(5, 5);
            this.labelTitleGS.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitleGS.MinimumSize = new System.Drawing.Size(36, 0);
            this.labelTitleGS.Name = "labelTitleGS";
            this.labelTitleGS.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelTitleGS.Size = new System.Drawing.Size(47, 20);
            this.labelTitleGS.TabIndex = 4;
            this.labelTitleGS.Text = "Roll";
            this.labelTitleGS.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelValGS
            // 
            this.labelValGS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelValGS.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "roll", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "", "0.00"));
            this.labelValGS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.labelValGS.Font = new System.Drawing.Font("Segoe UI Variable Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValGS.Location = new System.Drawing.Point(5, 25);
            this.labelValGS.Margin = new System.Windows.Forms.Padding(0);
            this.labelValGS.MinimumSize = new System.Drawing.Size(60, 0);
            this.labelValGS.Name = "labelValGS";
            this.labelValGS.Size = new System.Drawing.Size(60, 22);
            this.labelValGS.TabIndex = 5;
            this.labelValGS.Text = "8000";
            this.labelValGS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelUnitRoll
            // 
            this.labelUnitRoll.AutoSize = true;
            this.labelUnitRoll.Location = new System.Drawing.Point(5, 47);
            this.labelUnitRoll.Margin = new System.Windows.Forms.Padding(0);
            this.labelUnitRoll.Name = "labelUnitRoll";
            this.labelUnitRoll.Padding = new System.Windows.Forms.Padding(11, 0, 0, 0);
            this.labelUnitRoll.Size = new System.Drawing.Size(42, 16);
            this.labelUnitRoll.TabIndex = 6;
            this.labelUnitRoll.Text = "deg";
            // 
            // mavlinkMsgViewControl1
            // 
            this.mavlinkMsgViewControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mavlinkMsgViewControl1.Location = new System.Drawing.Point(3, 421);
            this.mavlinkMsgViewControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mavlinkMsgViewControl1.message = "Warning";
            this.mavlinkMsgViewControl1.Name = "mavlinkMsgViewControl1";
            this.mavlinkMsgViewControl1.Size = new System.Drawing.Size(367, 39);
            this.mavlinkMsgViewControl1.status = "Armed";
            this.mavlinkMsgViewControl1.TabIndex = 15;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel13, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(11, 0);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(358, 670);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel13.Controls.Add(this.tableLayoutPanel11, 0, 1);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 337);
            this.tableLayoutPanel13.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 41.54663F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 58.45337F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(352, 331);
            this.tableLayoutPanel13.TabIndex = 23;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.04533F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.97734F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.97734F));
            this.tableLayoutPanel3.Controls.Add(this.label18, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.rjToggleBtnArm, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label15, 2, 2);
            this.tableLayoutPanel3.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel16, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel17, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.label16, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel18, 1, 2);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel11, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel15, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.flowLayoutPanel14, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(346, 133);
            this.tableLayoutPanel3.TabIndex = 23;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.label18.Location = new System.Drawing.Point(100, 99);
            this.label18.Name = "label18";
            this.label18.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label18.Size = new System.Drawing.Size(118, 25);
            this.label18.TabIndex = 26;
            this.label18.Text = "Arm/DisArm";
            // 
            // rjToggleBtnArm
            // 
            this.rjToggleBtnArm.AutoSize = true;
            this.rjToggleBtnArm.Dock = System.Windows.Forms.DockStyle.Top;
            this.rjToggleBtnArm.Location = new System.Drawing.Point(3, 101);
            this.rjToggleBtnArm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.rjToggleBtnArm.MaximumSize = new System.Drawing.Size(69, 90);
            this.rjToggleBtnArm.MinimumSize = new System.Drawing.Size(69, 25);
            this.rjToggleBtnArm.Name = "rjToggleBtnArm";
            this.rjToggleBtnArm.OffBackColor = System.Drawing.Color.MediumSeaGreen;
            this.rjToggleBtnArm.OffToggleColor = System.Drawing.Color.Gainsboro;
            this.rjToggleBtnArm.OnBackColor = System.Drawing.Color.DarkRed;
            this.rjToggleBtnArm.OnToggleColor = System.Drawing.Color.Goldenrod;
            this.rjToggleBtnArm.Size = new System.Drawing.Size(69, 25);
            this.rjToggleBtnArm.TabIndex = 25;
            this.rjToggleBtnArm.UseVisualStyleBackColor = true;
            this.rjToggleBtnArm.CheckedChanged += new System.EventHandler(this.rjToggleBtnArm_CheckedChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Dock = System.Windows.Forms.DockStyle.Left;
            this.label15.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.label15.Location = new System.Drawing.Point(224, 66);
            this.label15.MaximumSize = new System.Drawing.Size(0, 25);
            this.label15.Name = "label15";
            this.label15.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label15.Size = new System.Drawing.Size(107, 25);
            this.label15.TabIndex = 21;
            this.label15.Text = "Set Loiter Rad";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(224, 33);
            this.label10.MaximumSize = new System.Drawing.Size(0, 25);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label10.Size = new System.Drawing.Size(77, 25);
            this.label10.TabIndex = 20;
            this.label10.Text = "Set Speed";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel16
            // 
            this.flowLayoutPanel16.Controls.Add(this.klcButtonSetSpeed);
            this.flowLayoutPanel16.Controls.Add(this.numericUpDownSpeed);
            this.flowLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel16.Location = new System.Drawing.Point(100, 35);
            this.flowLayoutPanel16.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel16.Name = "flowLayoutPanel16";
            this.flowLayoutPanel16.Size = new System.Drawing.Size(118, 29);
            this.flowLayoutPanel16.TabIndex = 19;
            // 
            // klcButtonSetSpeed
            // 
            this.klcButtonSetSpeed.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButtonSetSpeed.FlatAppearance.BorderSize = 0;
            this.klcButtonSetSpeed.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButtonSetSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.klcButtonSetSpeed.ForeColor = System.Drawing.Color.DimGray;
            this.klcButtonSetSpeed.Image = global::MissionPlanner.Properties.Resources.icons8_up_16;
            this.klcButtonSetSpeed.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButtonSetSpeed.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButtonSetSpeed.KLCBorderRadius = 8;
            this.klcButtonSetSpeed.KLCBorderSize = 0;
            this.klcButtonSetSpeed.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButtonSetSpeed.Location = new System.Drawing.Point(3, 0);
            this.klcButtonSetSpeed.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.klcButtonSetSpeed.Name = "klcButtonSetSpeed";
            this.klcButtonSetSpeed.Size = new System.Drawing.Size(40, 25);
            this.klcButtonSetSpeed.TabIndex = 20;
            this.klcButtonSetSpeed.UseCompatibleTextRendering = true;
            this.klcButtonSetSpeed.UseVisualStyleBackColor = false;
            this.klcButtonSetSpeed.Click += new System.EventHandler(this.klcButtonSetSpeed_Click);
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(3, 27);
            this.numericUpDownSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownSpeed.TabIndex = 13;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // flowLayoutPanel17
            // 
            this.flowLayoutPanel17.Controls.Add(this.klcButtonSetAlt);
            this.flowLayoutPanel17.Controls.Add(this.numericUpDownAlt);
            this.flowLayoutPanel17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel17.Location = new System.Drawing.Point(100, 2);
            this.flowLayoutPanel17.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel17.Name = "flowLayoutPanel17";
            this.flowLayoutPanel17.Size = new System.Drawing.Size(118, 29);
            this.flowLayoutPanel17.TabIndex = 22;
            // 
            // klcButtonSetAlt
            // 
            this.klcButtonSetAlt.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButtonSetAlt.FlatAppearance.BorderSize = 0;
            this.klcButtonSetAlt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButtonSetAlt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.klcButtonSetAlt.ForeColor = System.Drawing.Color.DimGray;
            this.klcButtonSetAlt.Image = global::MissionPlanner.Properties.Resources.icons8_up_16;
            this.klcButtonSetAlt.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButtonSetAlt.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButtonSetAlt.KLCBorderRadius = 8;
            this.klcButtonSetAlt.KLCBorderSize = 0;
            this.klcButtonSetAlt.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButtonSetAlt.Location = new System.Drawing.Point(3, 0);
            this.klcButtonSetAlt.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.klcButtonSetAlt.Name = "klcButtonSetAlt";
            this.klcButtonSetAlt.Size = new System.Drawing.Size(40, 25);
            this.klcButtonSetAlt.TabIndex = 19;
            this.klcButtonSetAlt.UseCompatibleTextRendering = true;
            this.klcButtonSetAlt.UseVisualStyleBackColor = false;
            this.klcButtonSetAlt.Click += new System.EventHandler(this.klcButtonSetAlt_ClickAsync);
            // 
            // numericUpDownAlt
            // 
            this.numericUpDownAlt.Location = new System.Drawing.Point(3, 27);
            this.numericUpDownAlt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownAlt.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAlt.Name = "numericUpDownAlt";
            this.numericUpDownAlt.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownAlt.TabIndex = 13;
            this.numericUpDownAlt.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Dock = System.Windows.Forms.DockStyle.Left;
            this.label16.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.label16.Location = new System.Drawing.Point(224, 0);
            this.label16.MaximumSize = new System.Drawing.Size(0, 25);
            this.label16.Name = "label16";
            this.label16.Padding = new System.Windows.Forms.Padding(0, 7, 0, 0);
            this.label16.Size = new System.Drawing.Size(56, 25);
            this.label16.TabIndex = 24;
            this.label16.Text = "Set Alt";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel18
            // 
            this.flowLayoutPanel18.Controls.Add(this.klcButtonSetLoiterRad);
            this.flowLayoutPanel18.Controls.Add(this.numericUpDownLoiter);
            this.flowLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel18.Location = new System.Drawing.Point(100, 68);
            this.flowLayoutPanel18.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel18.Name = "flowLayoutPanel18";
            this.flowLayoutPanel18.Size = new System.Drawing.Size(118, 29);
            this.flowLayoutPanel18.TabIndex = 23;
            // 
            // klcButtonSetLoiterRad
            // 
            this.klcButtonSetLoiterRad.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButtonSetLoiterRad.FlatAppearance.BorderSize = 0;
            this.klcButtonSetLoiterRad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButtonSetLoiterRad.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.klcButtonSetLoiterRad.ForeColor = System.Drawing.Color.DimGray;
            this.klcButtonSetLoiterRad.Image = global::MissionPlanner.Properties.Resources.icons8_up_16;
            this.klcButtonSetLoiterRad.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButtonSetLoiterRad.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButtonSetLoiterRad.KLCBorderRadius = 8;
            this.klcButtonSetLoiterRad.KLCBorderSize = 0;
            this.klcButtonSetLoiterRad.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButtonSetLoiterRad.Location = new System.Drawing.Point(3, 0);
            this.klcButtonSetLoiterRad.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.klcButtonSetLoiterRad.Name = "klcButtonSetLoiterRad";
            this.klcButtonSetLoiterRad.Size = new System.Drawing.Size(40, 25);
            this.klcButtonSetLoiterRad.TabIndex = 20;
            this.klcButtonSetLoiterRad.UseCompatibleTextRendering = true;
            this.klcButtonSetLoiterRad.UseVisualStyleBackColor = false;
            this.klcButtonSetLoiterRad.Click += new System.EventHandler(this.klcButtonSetLoiterRad_Click);
            // 
            // numericUpDownLoiter
            // 
            this.numericUpDownLoiter.Location = new System.Drawing.Point(3, 27);
            this.numericUpDownLoiter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numericUpDownLoiter.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownLoiter.Minimum = new decimal(new int[] {
            10000,
            0,
            0,
            -2147483648});
            this.numericUpDownLoiter.Name = "numericUpDownLoiter";
            this.numericUpDownLoiter.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownLoiter.TabIndex = 13;
            this.numericUpDownLoiter.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // flowLayoutPanel11
            // 
            this.flowLayoutPanel11.Controls.Add(this.pictureBox6);
            this.flowLayoutPanel11.Controls.Add(this.labelBatteryLevel);
            this.flowLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel11.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel11.Name = "flowLayoutPanel11";
            this.flowLayoutPanel11.Size = new System.Drawing.Size(91, 29);
            this.flowLayoutPanel11.TabIndex = 16;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::MissionPlanner.Properties.Resources.icons8_battery_16;
            this.pictureBox6.Location = new System.Drawing.Point(3, 2);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(16, 16);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox6.TabIndex = 0;
            this.pictureBox6.TabStop = false;
            // 
            // labelBatteryLevel
            // 
            this.labelBatteryLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBatteryLevel.AutoSize = true;
            this.labelBatteryLevel.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "battery_remaining", true));
            this.labelBatteryLevel.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelBatteryLevel.Location = new System.Drawing.Point(25, 2);
            this.labelBatteryLevel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.labelBatteryLevel.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelBatteryLevel.Name = "labelBatteryLevel";
            this.labelBatteryLevel.Size = new System.Drawing.Size(44, 20);
            this.labelBatteryLevel.TabIndex = 1;
            this.labelBatteryLevel.Text = "87 %";
            this.labelBatteryLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel15
            // 
            this.flowLayoutPanel15.Controls.Add(this.pictureBox8);
            this.flowLayoutPanel15.Controls.Add(this.label19);
            this.flowLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel15.Location = new System.Drawing.Point(3, 68);
            this.flowLayoutPanel15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel15.Name = "flowLayoutPanel15";
            this.flowLayoutPanel15.Size = new System.Drawing.Size(91, 29);
            this.flowLayoutPanel15.TabIndex = 18;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::MissionPlanner.Properties.Resources.icons8_time_16;
            this.pictureBox8.Location = new System.Drawing.Point(3, 2);
            this.pictureBox8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(16, 16);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label19.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(3, 22);
            this.label19.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.label19.MaximumSize = new System.Drawing.Size(0, 20);
            this.label19.MinimumSize = new System.Drawing.Size(65, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(65, 17);
            this.label19.TabIndex = 1;
            this.label19.Text = "00:23:34";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel14
            // 
            this.flowLayoutPanel14.Controls.Add(this.pictureBox7);
            this.flowLayoutPanel14.Controls.Add(this.labelBatteryVolateges);
            this.flowLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel14.Location = new System.Drawing.Point(3, 35);
            this.flowLayoutPanel14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel14.Name = "flowLayoutPanel14";
            this.flowLayoutPanel14.Size = new System.Drawing.Size(91, 29);
            this.flowLayoutPanel14.TabIndex = 18;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MissionPlanner.Properties.Resources.icons8_plus_161;
            this.pictureBox7.Location = new System.Drawing.Point(3, 2);
            this.pictureBox7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(16, 16);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox7.TabIndex = 0;
            this.pictureBox7.TabStop = false;
            // 
            // labelBatteryVolateges
            // 
            this.labelBatteryVolateges.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelBatteryVolateges.AutoSize = true;
            this.labelBatteryVolateges.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "battery_voltage", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged, "", "0.00"));
            this.labelBatteryVolateges.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelBatteryVolateges.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelBatteryVolateges.Location = new System.Drawing.Point(25, 2);
            this.labelBatteryVolateges.Margin = new System.Windows.Forms.Padding(3, 2, 3, 0);
            this.labelBatteryVolateges.MaximumSize = new System.Drawing.Size(0, 20);
            this.labelBatteryVolateges.Name = "labelBatteryVolateges";
            this.labelBatteryVolateges.Size = new System.Drawing.Size(59, 20);
            this.labelBatteryVolateges.TabIndex = 1;
            this.labelBatteryVolateges.Text = "Test ok";
            this.labelBatteryVolateges.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.AutoSize = true;
            this.tableLayoutPanel11.ColumnCount = 4;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.Controls.Add(this.klcButton14, 1, 2);
            this.tableLayoutPanel11.Controls.Add(this.klcButtonAuto, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.klcButtonDoAction, 0, 1);
            this.tableLayoutPanel11.Controls.Add(this.klcButton15, 0, 3);
            this.tableLayoutPanel11.Controls.Add(this.klcButtonZedGraph, 1, 3);
            this.tableLayoutPanel11.Controls.Add(this.CMB_setwp, 1, 0);
            this.tableLayoutPanel11.Controls.Add(this.CMB_action, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.CMB_modes, 2, 0);
            this.tableLayoutPanel11.Controls.Add(this.CMB_mountmode, 3, 0);
            this.tableLayoutPanel11.Controls.Add(this.klcButton21, 2, 3);
            this.tableLayoutPanel11.Controls.Add(this.klcButtonSetWP, 1, 1);
            this.tableLayoutPanel11.Controls.Add(this.klcButtonSetMode, 2, 1);
            this.tableLayoutPanel11.Controls.Add(this.klcButtonSetMount, 3, 1);
            this.tableLayoutPanel11.Controls.Add(this.klcButton20, 3, 3);
            this.tableLayoutPanel11.Controls.Add(this.klcButton22, 2, 2);
            this.tableLayoutPanel11.Controls.Add(this.klcButton24, 3, 2);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 139);
            this.tableLayoutPanel11.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 4;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.71264F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.28736F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(346, 190);
            this.tableLayoutPanel11.TabIndex = 21;
            // 
            // klcButton14
            // 
            this.klcButton14.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButton14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klcButton14.FlatAppearance.BorderSize = 0;
            this.klcButton14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButton14.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.klcButton14.ForeColor = System.Drawing.Color.DimGray;
            this.klcButton14.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButton14.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButton14.KLCBorderRadius = 1;
            this.klcButton14.KLCBorderSize = 0;
            this.klcButton14.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButton14.Location = new System.Drawing.Point(89, 96);
            this.klcButton14.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klcButton14.Name = "klcButton14";
            this.klcButton14.Size = new System.Drawing.Size(80, 43);
            this.klcButton14.TabIndex = 15;
            this.klcButton14.Text = "Arm/DisArm";
            this.klcButton14.UseVisualStyleBackColor = false;
            // 
            // klcButtonAuto
            // 
            this.klcButtonAuto.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButtonAuto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klcButtonAuto.FlatAppearance.BorderSize = 0;
            this.klcButtonAuto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButtonAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.klcButtonAuto.ForeColor = System.Drawing.Color.DimGray;
            this.klcButtonAuto.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButtonAuto.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButtonAuto.KLCBorderRadius = 1;
            this.klcButtonAuto.KLCBorderSize = 0;
            this.klcButtonAuto.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButtonAuto.Location = new System.Drawing.Point(3, 96);
            this.klcButtonAuto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klcButtonAuto.Name = "klcButtonAuto";
            this.klcButtonAuto.Size = new System.Drawing.Size(80, 43);
            this.klcButtonAuto.TabIndex = 14;
            this.klcButtonAuto.Text = "Auto";
            this.klcButtonAuto.UseVisualStyleBackColor = false;
            this.klcButtonAuto.Click += new System.EventHandler(this.klcButtonAuto_Click);
            // 
            // klcButtonDoAction
            // 
            this.klcButtonDoAction.BackColor = System.Drawing.Color.OliveDrab;
            this.klcButtonDoAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klcButtonDoAction.FlatAppearance.BorderSize = 0;
            this.klcButtonDoAction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButtonDoAction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.klcButtonDoAction.ForeColor = System.Drawing.Color.DimGray;
            this.klcButtonDoAction.KLCBackgroundColor = System.Drawing.Color.OliveDrab;
            this.klcButtonDoAction.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButtonDoAction.KLCBorderRadius = 1;
            this.klcButtonDoAction.KLCBorderSize = 0;
            this.klcButtonDoAction.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButtonDoAction.Location = new System.Drawing.Point(3, 48);
            this.klcButtonDoAction.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klcButtonDoAction.Name = "klcButtonDoAction";
            this.klcButtonDoAction.Size = new System.Drawing.Size(80, 44);
            this.klcButtonDoAction.TabIndex = 13;
            this.klcButtonDoAction.Text = "Do Action";
            this.klcButtonDoAction.UseVisualStyleBackColor = false;
            this.klcButtonDoAction.Click += new System.EventHandler(this.klcButtonDoAction_Click);
            // 
            // klcButton15
            // 
            this.klcButton15.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButton15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klcButton15.FlatAppearance.BorderSize = 0;
            this.klcButton15.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButton15.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.klcButton15.ForeColor = System.Drawing.Color.DimGray;
            this.klcButton15.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButton15.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButton15.KLCBorderRadius = 1;
            this.klcButton15.KLCBorderSize = 0;
            this.klcButton15.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButton15.Location = new System.Drawing.Point(3, 143);
            this.klcButton15.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klcButton15.Name = "klcButton15";
            this.klcButton15.Size = new System.Drawing.Size(80, 45);
            this.klcButton15.TabIndex = 7;
            this.klcButton15.Text = "Abort Landing";
            this.klcButton15.UseVisualStyleBackColor = false;
            // 
            // klcButtonZedGraph
            // 
            this.klcButtonZedGraph.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButtonZedGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klcButtonZedGraph.FlatAppearance.BorderSize = 0;
            this.klcButtonZedGraph.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButtonZedGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.klcButtonZedGraph.ForeColor = System.Drawing.Color.DimGray;
            this.klcButtonZedGraph.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButtonZedGraph.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButtonZedGraph.KLCBorderRadius = 1;
            this.klcButtonZedGraph.KLCBorderSize = 0;
            this.klcButtonZedGraph.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButtonZedGraph.Location = new System.Drawing.Point(89, 143);
            this.klcButtonZedGraph.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klcButtonZedGraph.Name = "klcButtonZedGraph";
            this.klcButtonZedGraph.Size = new System.Drawing.Size(80, 45);
            this.klcButtonZedGraph.TabIndex = 6;
            this.klcButtonZedGraph.Text = "Clear Track";
            this.klcButtonZedGraph.UseVisualStyleBackColor = false;
            this.klcButtonZedGraph.Click += new System.EventHandler(this.klcButtonZedGraph_Click);
            // 
            // CMB_setwp
            // 
            this.CMB_setwp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CMB_setwp.DropDownWidth = 200;
            this.CMB_setwp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CMB_setwp.FormattingEnabled = true;
            this.CMB_setwp.Location = new System.Drawing.Point(89, 16);
            this.CMB_setwp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMB_setwp.Name = "CMB_setwp";
            this.CMB_setwp.Size = new System.Drawing.Size(80, 28);
            this.CMB_setwp.TabIndex = 11;
            this.CMB_setwp.Click += new System.EventHandler(this.CMB_setwp_Click_1);
            // 
            // CMB_action
            // 
            this.CMB_action.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CMB_action.DropDownWidth = 200;
            this.CMB_action.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CMB_action.FormattingEnabled = true;
            this.CMB_action.Location = new System.Drawing.Point(3, 16);
            this.CMB_action.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMB_action.Name = "CMB_action";
            this.CMB_action.Size = new System.Drawing.Size(80, 28);
            this.CMB_action.TabIndex = 9;
            // 
            // CMB_modes
            // 
            this.CMB_modes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CMB_modes.DropDownWidth = 200;
            this.CMB_modes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CMB_modes.FormattingEnabled = true;
            this.CMB_modes.Location = new System.Drawing.Point(175, 16);
            this.CMB_modes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMB_modes.Name = "CMB_modes";
            this.CMB_modes.Size = new System.Drawing.Size(80, 28);
            this.CMB_modes.TabIndex = 10;
            // 
            // CMB_mountmode
            // 
            this.CMB_mountmode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CMB_mountmode.DropDownWidth = 200;
            this.CMB_mountmode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.CMB_mountmode.FormattingEnabled = true;
            this.CMB_mountmode.Location = new System.Drawing.Point(261, 16);
            this.CMB_mountmode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CMB_mountmode.Name = "CMB_mountmode";
            this.CMB_mountmode.Size = new System.Drawing.Size(82, 28);
            this.CMB_mountmode.TabIndex = 12;
            // 
            // klcButton21
            // 
            this.klcButton21.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButton21.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klcButton21.FlatAppearance.BorderSize = 0;
            this.klcButton21.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klcButton21.ForeColor = System.Drawing.Color.DimGray;
            this.klcButton21.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButton21.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButton21.KLCBorderRadius = 1;
            this.klcButton21.KLCBorderSize = 0;
            this.klcButton21.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButton21.Location = new System.Drawing.Point(175, 143);
            this.klcButton21.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klcButton21.Name = "klcButton21";
            this.klcButton21.Size = new System.Drawing.Size(80, 45);
            this.klcButton21.TabIndex = 2;
            this.klcButton21.Text = "Loiter";
            this.klcButton21.UseVisualStyleBackColor = false;
            // 
            // klcButtonSetWP
            // 
            this.klcButtonSetWP.BackColor = System.Drawing.Color.OliveDrab;
            this.klcButtonSetWP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klcButtonSetWP.FlatAppearance.BorderSize = 0;
            this.klcButtonSetWP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButtonSetWP.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.klcButtonSetWP.ForeColor = System.Drawing.Color.DimGray;
            this.klcButtonSetWP.KLCBackgroundColor = System.Drawing.Color.OliveDrab;
            this.klcButtonSetWP.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButtonSetWP.KLCBorderRadius = 1;
            this.klcButtonSetWP.KLCBorderSize = 0;
            this.klcButtonSetWP.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButtonSetWP.Location = new System.Drawing.Point(89, 48);
            this.klcButtonSetWP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klcButtonSetWP.Name = "klcButtonSetWP";
            this.klcButtonSetWP.Size = new System.Drawing.Size(80, 44);
            this.klcButtonSetWP.TabIndex = 6;
            this.klcButtonSetWP.Text = "Set WP";
            this.klcButtonSetWP.UseVisualStyleBackColor = false;
            this.klcButtonSetWP.Click += new System.EventHandler(this.klcButtonSetWP_Click);
            // 
            // klcButtonSetMode
            // 
            this.klcButtonSetMode.BackColor = System.Drawing.Color.OliveDrab;
            this.klcButtonSetMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klcButtonSetMode.FlatAppearance.BorderSize = 0;
            this.klcButtonSetMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButtonSetMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klcButtonSetMode.ForeColor = System.Drawing.Color.DimGray;
            this.klcButtonSetMode.KLCBackgroundColor = System.Drawing.Color.OliveDrab;
            this.klcButtonSetMode.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButtonSetMode.KLCBorderRadius = 1;
            this.klcButtonSetMode.KLCBorderSize = 0;
            this.klcButtonSetMode.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButtonSetMode.Location = new System.Drawing.Point(175, 48);
            this.klcButtonSetMode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klcButtonSetMode.Name = "klcButtonSetMode";
            this.klcButtonSetMode.Size = new System.Drawing.Size(80, 44);
            this.klcButtonSetMode.TabIndex = 7;
            this.klcButtonSetMode.Text = "Set Mode";
            this.klcButtonSetMode.UseVisualStyleBackColor = false;
            this.klcButtonSetMode.Click += new System.EventHandler(this.klcButtonSetMode_Click);
            // 
            // klcButtonSetMount
            // 
            this.klcButtonSetMount.BackColor = System.Drawing.Color.OliveDrab;
            this.klcButtonSetMount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klcButtonSetMount.FlatAppearance.BorderSize = 0;
            this.klcButtonSetMount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButtonSetMount.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.klcButtonSetMount.ForeColor = System.Drawing.Color.DimGray;
            this.klcButtonSetMount.KLCBackgroundColor = System.Drawing.Color.OliveDrab;
            this.klcButtonSetMount.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButtonSetMount.KLCBorderRadius = 1;
            this.klcButtonSetMount.KLCBorderSize = 0;
            this.klcButtonSetMount.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButtonSetMount.Location = new System.Drawing.Point(261, 48);
            this.klcButtonSetMount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klcButtonSetMount.Name = "klcButtonSetMount";
            this.klcButtonSetMount.Size = new System.Drawing.Size(82, 44);
            this.klcButtonSetMount.TabIndex = 8;
            this.klcButtonSetMount.Text = "Set Mount";
            this.klcButtonSetMount.UseVisualStyleBackColor = false;
            this.klcButtonSetMount.Click += new System.EventHandler(this.klcButtonSetMount_Click);
            // 
            // klcButton20
            // 
            this.klcButton20.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButton20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klcButton20.FlatAppearance.BorderSize = 0;
            this.klcButton20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButton20.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.klcButton20.ForeColor = System.Drawing.Color.DimGray;
            this.klcButton20.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButton20.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButton20.KLCBorderRadius = 1;
            this.klcButton20.KLCBorderSize = 0;
            this.klcButton20.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButton20.Location = new System.Drawing.Point(261, 143);
            this.klcButton20.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klcButton20.Name = "klcButton20";
            this.klcButton20.Size = new System.Drawing.Size(82, 45);
            this.klcButton20.TabIndex = 3;
            this.klcButton20.Text = "Restart Mission";
            this.klcButton20.UseVisualStyleBackColor = false;
            this.klcButton20.Click += new System.EventHandler(this.klcButton20_Click);
            // 
            // klcButton22
            // 
            this.klcButton22.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButton22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klcButton22.FlatAppearance.BorderSize = 0;
            this.klcButton22.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.klcButton22.ForeColor = System.Drawing.Color.DimGray;
            this.klcButton22.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButton22.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButton22.KLCBorderRadius = 1;
            this.klcButton22.KLCBorderSize = 0;
            this.klcButton22.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButton22.Location = new System.Drawing.Point(175, 96);
            this.klcButton22.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klcButton22.Name = "klcButton22";
            this.klcButton22.Size = new System.Drawing.Size(80, 43);
            this.klcButton22.TabIndex = 4;
            this.klcButton22.Text = "RTL";
            this.klcButton22.UseVisualStyleBackColor = false;
            // 
            // klcButton24
            // 
            this.klcButton24.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButton24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.klcButton24.FlatAppearance.BorderSize = 0;
            this.klcButton24.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.klcButton24.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.klcButton24.ForeColor = System.Drawing.Color.DimGray;
            this.klcButton24.KLCBackgroundColor = System.Drawing.Color.MediumSeaGreen;
            this.klcButton24.KLCBorderColor = System.Drawing.Color.PaleVioletRed;
            this.klcButton24.KLCBorderRadius = 1;
            this.klcButton24.KLCBorderSize = 0;
            this.klcButton24.KLCTextColor = System.Drawing.Color.DimGray;
            this.klcButton24.Location = new System.Drawing.Point(261, 96);
            this.klcButton24.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.klcButton24.Name = "klcButton24";
            this.klcButton24.Size = new System.Drawing.Size(82, 43);
            this.klcButton24.TabIndex = 5;
            this.klcButton24.Text = "Resume Mission";
            this.klcButton24.UseVisualStyleBackColor = false;
            // 
            // timerTest
            // 
            this.timerTest.Interval = 500;
            this.timerTest.Tick += new System.EventHandler(this.timerTest_Tick);
            // 
            // timerZedGraph
            // 
            this.timerZedGraph.Tick += new System.EventHandler(this.timerZedGraph_Tick);
            // 
            // FlightStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitMainPanel);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FlightStatus";
            this.Size = new System.Drawing.Size(1337, 670);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FlightStatus_FormClosing);
            this.Load += new System.EventHandler(this.FlightStatus_Load);
            this.Validated += new System.EventHandler(this.FlightStatus_Validated);
            this.splitMainPanel.Panel1.ResumeLayout(false);
            this.splitMainPanel.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitMainPanel)).EndInit();
            this.splitMainPanel.ResumeLayout(false);
            this.splitContainerMap.Panel1.ResumeLayout(false);
            this.splitContainerMap.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerMap)).EndInit();
            this.splitContainerMap.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceHUD)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanelQuickView.ResumeLayout(false);
            this.tableLayoutPanelQuickView.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanelHUD.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel9.PerformLayout();
            this.flowLayoutPanel10.ResumeLayout(false);
            this.flowLayoutPanel10.PerformLayout();
            this.tableLayoutPanel9.ResumeLayout(false);
            this.flowLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel8.PerformLayout();
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelClock.ResumeLayout(false);
            this.panelClock.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.flowLayoutPanel6.ResumeLayout(false);
            this.flowLayoutPanel6.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanelPitch.ResumeLayout(false);
            this.flowLayoutPanelPitch.PerformLayout();
            this.flowLayoutPanelRoll.ResumeLayout(false);
            this.flowLayoutPanelRoll.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.flowLayoutPanel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            this.flowLayoutPanel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAlt)).EndInit();
            this.flowLayoutPanel18.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownLoiter)).EndInit();
            this.flowLayoutPanel11.ResumeLayout(false);
            this.flowLayoutPanel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.flowLayoutPanel15.ResumeLayout(false);
            this.flowLayoutPanel15.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.flowLayoutPanel14.ResumeLayout(false);
            this.flowLayoutPanel14.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tableLayoutPanel11.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitMainPanel;
        private Controls.HSI hsiHeading;
        private Controls.HUD hudSerb;
        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.SplitContainer splitContainerMap;
        public Controls.myGMAP gMapControlSerb;
        private System.Windows.Forms.Label labelTitleGS;
        private System.Windows.Forms.Label labelValGS;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private BindingSource bindingSourceHUD;
        private TableLayoutPanel tableLayoutPanelHUD;
        private TableLayoutPanel tableLayoutPanel5;
        private Label label12;
        private Label labelGPS;
        private FlowLayoutPanel flowLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel6;
        private TableLayoutPanel tableLayoutPanel8;
        private TableLayoutPanel tableLayoutPanel7;
        private FlowLayoutPanel flowLayoutPanelRoll;
        private Label labelUnitRoll;
        private FlowLayoutPanel flowLayoutPanelPitch;
        private Label labelTitleAS;
        private Label labelValAS;
        private Label labelSpeedUnit;
        private FlowLayoutPanel flowLayoutPanel6;
        private Label labelAGL;
        private Label labelValAgl;
        private Label label13;
        private FlowLayoutPanel flowLayoutPanel5;
        private Label labelASL;
        private Label labelValAsl;
        private Label label9;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel9;
        private FlowLayoutPanel flowLayoutPanel7;
        private Label labelHg;
        private Label label4;
        private Label labelUnitHdg;
        private FlowLayoutPanel flowLayoutPanel8;
        private Label labelCapAOA;
        private Label labelValAOA;
        private Label labelUnitAOA;
        private TableLayoutPanel tableLayoutPanel10;
        private FlowLayoutPanel flowLayoutPanel9;
        private Label labelCapGS;
        private Label labelHudGS;
        private Label label14;
        private FlowLayoutPanel flowLayoutPanel10;
        private Label labelCapAS;
        private Label labelHudAS;
        private Label label17;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label label2;
        private Label labelClock;
        private Panel panelClock;
        private RJCodeAdvance.RJControls.RJButton btnMapMax;
        private RJCodeAdvance.RJControls.RJButton btnMapMin;
        private FlowLayoutPanel flowLayoutPanel4;
        private Panel panelMap;
        private StatusStrip statusStrip1;
        internal Label lblMapZoom;
        private Label lblMapLat;
        private Label lblMapLong;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripProgressBar toolStripProgressBar1;
        private ToolStripMenuItem gEOToolStripMenuItem;
        private ToolStripMenuItem uTMToolStripMenuItem;
        private ToolStripMenuItem mGRSToolStripMenuItem;
        private TableLayoutPanel tableLayoutPanel12;
        private CodeArtEng.Controls.StatusLabel statusLabel4;
        private CodeArtEng.Controls.StatusLabel statusLabel1;
        private CodeArtEng.Controls.StatusLabel statusLabel3;
        private CodeArtEng.Controls.StatusLabel statusLabel2;
        private Label lblMapAlt;
        private Label lblhdopVal;
        private Label label5;
        private Label label7;
        private Label labelSats;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel13;
        private TableLayoutPanel tableLayoutPanel3;
        private Label label18;
        private RJCodeAdvance.RJControls.RJToggleButton rjToggleBtnArm;
        private Label label15;
        private Label label10;
        private FlowLayoutPanel flowLayoutPanel16;
        private KLCToolbox.KLCControls.KLCButton klcButtonSetSpeed;
        private NumericUpDown numericUpDownSpeed;
        private FlowLayoutPanel flowLayoutPanel17;
        private KLCToolbox.KLCControls.KLCButton klcButtonSetAlt;
        private NumericUpDown numericUpDownAlt;
        private Label label16;
        private FlowLayoutPanel flowLayoutPanel18;
        private KLCToolbox.KLCControls.KLCButton klcButtonSetLoiterRad;
        private NumericUpDown numericUpDownLoiter;
        private FlowLayoutPanel flowLayoutPanel11;
        private PictureBox pictureBox6;
        private Label labelBatteryLevel;
        private FlowLayoutPanel flowLayoutPanel15;
        private PictureBox pictureBox8;
        private Label label19;
        private FlowLayoutPanel flowLayoutPanel14;
        private PictureBox pictureBox7;
        private Label labelBatteryVolateges;
        private TableLayoutPanel tableLayoutPanel11;
        private KLCToolbox.KLCControls.KLCButton klcButton14;
        private KLCToolbox.KLCControls.KLCButton klcButtonAuto;
        private KLCToolbox.KLCControls.KLCButton klcButtonDoAction;
        private KLCToolbox.KLCControls.KLCButton klcButton15;
        private KLCToolbox.KLCControls.KLCButton klcButtonZedGraph;
        private ComboBox CMB_setwp;
        private ComboBox CMB_action;
        private ComboBox CMB_modes;
        private ComboBox CMB_mountmode;
        private KLCToolbox.KLCControls.KLCButton klcButton21;
        private KLCToolbox.KLCControls.KLCButton klcButtonSetWP;
        private KLCToolbox.KLCControls.KLCButton klcButtonSetMode;
        private KLCToolbox.KLCControls.KLCButton klcButtonSetMount;
        private KLCToolbox.KLCControls.KLCButton klcButton20;
        private KLCToolbox.KLCControls.KLCButton klcButton22;
        private KLCToolbox.KLCControls.KLCButton klcButton24;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private TableLayoutPanel tableLayoutPanelQuickView;
        private Label labelQV11;
        private Label labelQV10;
        private Label labelQV9;
        private Label labelQV6;
        private Label labelQV7;
        private Label labelQV3;
        private Label labelQV2;
        private Label labelQV1;
        private Label labelQV5;
        private Controls.QuickView quickView9;
        private Controls.QuickView quickView3;
        private Controls.QuickView quickView7;
        private Controls.QuickView quickView11;
        private Controls.QuickView quickView5;
        private Controls.QuickView quickView1;
        private Controls.QuickView quickView2;
        private Controls.QuickView quickView6;
        private Controls.QuickView quickView10;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelQV12;
        private Label labelQV8;
        private Label labelQV4;
        private Controls.QuickView quickView4;
        private Controls.QuickView quickView8;
        private Controls.QuickView quickView12;
        private ZedGraph.ZedGraphControl zedGraph;
        private Controls.MavlinkMsgViewControl mavlinkMsgViewControl1;
        private Timer timerZedGraph;
        private FlowLayoutPanel flowLayoutPanel2;
        private KLCToolbox.KLCControls.KLCButton btnSwarm;
        private KLCToolbox.KLCControls.KLCButton btnTelem;
        private KLCToolbox.KLCControls.KLCButton btnVideoVlc;
    }
}