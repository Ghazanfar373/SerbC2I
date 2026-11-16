///اللَّهُمَّ صَلِّ عَلَى سَيِّدِنَا مُحَمَّدٍ وَعَلَى آلِهِ وَصَحْبِهِ وَسَلَّم
using System;
using System.Windows.Forms;
using Xamarin.Forms.PlatformConfiguration;

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
            this.btnTelem = new KLCToolbox.KLCControls.KLCButton();
            this.gMapControlSerb = new MissionPlanner.Controls.myGMAP();
            this.contextMenuStripMap = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.goHereToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flyToHereAltToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.takeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMap = new System.Windows.Forms.Panel();
            this.tabControlMain = new System.Windows.Forms.TabControl();
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
            this.whPanel5 = new SerbLabelControls.WhPanel();
            this.whPanel4 = new SerbLabelControls.WhPanel();
            this.whPanel3 = new SerbLabelControls.WhPanel();
            this.whPanel2 = new SerbLabelControls.WhPanel();
            this.whPanel1 = new SerbLabelControls.WhPanel();
            this.timerTest = new System.Windows.Forms.Timer(this.components);
            this.timerZedGraph = new System.Windows.Forms.Timer(this.components);
            this.betterFolderBrowser1 = new WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser(this.components);
            this.flightStatusView1 = new FlightHud.FlightStatusView();
            this.flightHudView1 = new FlightHud.FlightHudView();
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
            this.contextMenuStripMap.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanelQuickView.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitMainPanel
            // 
            this.splitMainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitMainPanel.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitMainPanel.IsSplitterFixed = true;
            this.splitMainPanel.Location = new System.Drawing.Point(0, 0);
            this.splitMainPanel.Margin = new System.Windows.Forms.Padding(0);
            this.splitMainPanel.MinimumSize = new System.Drawing.Size(629, 500);
            this.splitMainPanel.Name = "splitMainPanel";
            // 
            // splitMainPanel.Panel1
            // 
            this.splitMainPanel.Panel1.Controls.Add(this.splitContainerMap);
            this.splitMainPanel.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitMainPanel.Panel2
            // 
            this.splitMainPanel.Panel2.AutoScroll = true;
            this.splitMainPanel.Panel2.BackColor = System.Drawing.Color.Transparent;
            this.splitMainPanel.Panel2.Controls.Add(this.flightStatusView1);
            this.splitMainPanel.Panel2.Controls.Add(this.flightHudView1);
            this.splitMainPanel.Panel2.Padding = new System.Windows.Forms.Padding(2, 0, 8, 0);
            this.splitMainPanel.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitMainPanel.Size = new System.Drawing.Size(1003, 544);
            this.splitMainPanel.SplitterDistance = 690;
            this.splitMainPanel.SplitterWidth = 3;
            this.splitMainPanel.TabIndex = 0;
            this.splitMainPanel.TabStop = false;
            this.splitMainPanel.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitMainPanel_SplitterMoved);
            // 
            // splitContainerMap
            // 
            this.splitContainerMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerMap.Location = new System.Drawing.Point(0, 0);
            this.splitContainerMap.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainerMap.Name = "splitContainerMap";
            this.splitContainerMap.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainerMap.Panel1
            // 
            this.splitContainerMap.Panel1.Controls.Add(this.flowLayoutPanel4);
            this.splitContainerMap.Panel1.Controls.Add(this.gMapControlSerb);
            this.splitContainerMap.Panel1.Controls.Add(this.panelMap);
            this.splitContainerMap.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainerMap.Panel2
            // 
            this.splitContainerMap.Panel2.Controls.Add(this.tabControlMain);
            this.splitContainerMap.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainerMap.Panel2MinSize = 150;
            this.splitContainerMap.Size = new System.Drawing.Size(690, 544);
            this.splitContainerMap.SplitterDistance = 391;
            this.splitContainerMap.SplitterWidth = 3;
            this.splitContainerMap.TabIndex = 0;
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
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(0, 350);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(690, 41);
            this.flowLayoutPanel4.TabIndex = 4;
            this.flowLayoutPanel4.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel4_Paint);
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
            this.btnMapMax.Image = ((System.Drawing.Image)(resources.GetObject("btnMapMax.Image")));
            this.btnMapMax.Location = new System.Drawing.Point(660, 2);
            this.btnMapMax.Margin = new System.Windows.Forms.Padding(2);
            this.btnMapMax.Name = "btnMapMax";
            this.btnMapMax.Size = new System.Drawing.Size(26, 28);
            this.btnMapMax.TabIndex = 2;
            this.btnMapMax.TextColor = System.Drawing.Color.White;
            this.btnMapMax.UseVisualStyleBackColor = false;
            this.btnMapMax.Click += new System.EventHandler(this.rjButton1_Click);
            // 
            // lblMapZoom
            // 
            this.lblMapZoom.AutoSize = true;
            this.lblMapZoom.Location = new System.Drawing.Point(639, 0);
            this.lblMapZoom.Margin = new System.Windows.Forms.Padding(0);
            this.lblMapZoom.MaximumSize = new System.Drawing.Size(30, 0);
            this.lblMapZoom.MinimumSize = new System.Drawing.Size(19, 24);
            this.lblMapZoom.Name = "lblMapZoom";
            this.lblMapZoom.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.lblMapZoom.Size = new System.Drawing.Size(19, 24);
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
            this.btnMapMin.Image = ((System.Drawing.Image)(resources.GetObject("btnMapMin.Image")));
            this.btnMapMin.Location = new System.Drawing.Point(611, 2);
            this.btnMapMin.Margin = new System.Windows.Forms.Padding(2);
            this.btnMapMin.Name = "btnMapMin";
            this.btnMapMin.Size = new System.Drawing.Size(26, 28);
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
            this.lblMapAlt.Location = new System.Drawing.Point(582, 14);
            this.lblMapAlt.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMapAlt.MaximumSize = new System.Drawing.Size(0, 18);
            this.lblMapAlt.MinimumSize = new System.Drawing.Size(22, 0);
            this.lblMapAlt.Name = "lblMapAlt";
            this.lblMapAlt.Padding = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.lblMapAlt.Size = new System.Drawing.Size(22, 18);
            this.lblMapAlt.TabIndex = 2;
            this.lblMapAlt.Text = "700";
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
            this.lblMapLong.Location = new System.Drawing.Point(510, 14);
            this.lblMapLong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMapLong.MinimumSize = new System.Drawing.Size(68, 0);
            this.lblMapLong.Name = "lblMapLong";
            this.lblMapLong.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblMapLong.Size = new System.Drawing.Size(68, 18);
            this.lblMapLong.TabIndex = 1;
            this.lblMapLong.Text = "46.44512232";
            this.lblMapLong.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMapLat
            // 
            this.lblMapLat.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "lat", true));
            this.lblMapLat.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblMapLat.Location = new System.Drawing.Point(438, 14);
            this.lblMapLat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMapLat.MinimumSize = new System.Drawing.Size(68, 0);
            this.lblMapLat.Name = "lblMapLat";
            this.lblMapLat.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblMapLat.Size = new System.Drawing.Size(68, 18);
            this.lblMapLat.TabIndex = 0;
            this.lblMapLat.Text = "23.44512232";
            this.lblMapLat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblMapLat.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(415, 14);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label7.Size = new System.Drawing.Size(19, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "25";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelSats
            // 
            this.labelSats.AutoSize = true;
            this.labelSats.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelSats.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSats.Location = new System.Drawing.Point(385, 14);
            this.labelSats.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSats.Name = "labelSats";
            this.labelSats.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.labelSats.Size = new System.Drawing.Size(26, 18);
            this.labelSats.TabIndex = 11;
            this.labelSats.Text = "Sat:";
            this.labelSats.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblhdopVal
            // 
            this.lblhdopVal.AutoSize = true;
            this.lblhdopVal.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSourceHUD, "gpshdop", true));
            this.lblhdopVal.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblhdopVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhdopVal.Location = new System.Drawing.Point(381, 14);
            this.lblhdopVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblhdopVal.Name = "lblhdopVal";
            this.lblhdopVal.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.lblhdopVal.Size = new System.Drawing.Size(0, 18);
            this.lblhdopVal.TabIndex = 10;
            this.lblhdopVal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 14);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.label5.Size = new System.Drawing.Size(34, 18);
            this.label5.TabIndex = 9;
            this.label5.Text = "hdpo:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.btnTelem);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(283, 12);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(56, 18);
            this.flowLayoutPanel2.TabIndex = 13;
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
            this.btnTelem.Location = new System.Drawing.Point(2, 0);
            this.btnTelem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnTelem.Name = "btnTelem";
            this.btnTelem.Size = new System.Drawing.Size(57, 18);
            this.btnTelem.TabIndex = 23;
            this.btnTelem.Text = "Telem";
            this.btnTelem.UseCompatibleTextRendering = true;
            this.btnTelem.UseVisualStyleBackColor = false;
            this.btnTelem.Click += new System.EventHandler(this.btnTelem_Click);
            // 
            // gMapControlSerb
            // 
            this.gMapControlSerb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gMapControlSerb.BackColor = System.Drawing.Color.Black;
            this.gMapControlSerb.Bearing = 0F;
            this.gMapControlSerb.CanDragMap = true;
            this.gMapControlSerb.ContextMenuStrip = this.contextMenuStripMap;
            this.gMapControlSerb.EmptyTileColor = System.Drawing.Color.Gray;
            this.gMapControlSerb.GrayScaleMode = false;
            this.gMapControlSerb.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControlSerb.HoldInvalidation = false;
            this.gMapControlSerb.LevelsKeepInMemmory = 5;
            this.gMapControlSerb.Location = new System.Drawing.Point(0, 0);
            this.gMapControlSerb.Margin = new System.Windows.Forms.Padding(2);
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
            this.gMapControlSerb.Size = new System.Drawing.Size(690, 359);
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
            // contextMenuStripMap
            // 
            this.contextMenuStripMap.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripMap.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goHereToolStripMenuItem,
            this.flyToHereAltToolStripMenuItem,
            this.takeOffToolStripMenuItem});
            this.contextMenuStripMap.Name = "contextMenuStripMap";
            this.contextMenuStripMap.Size = new System.Drawing.Size(150, 70);
            // 
            // goHereToolStripMenuItem
            // 
            this.goHereToolStripMenuItem.Name = "goHereToolStripMenuItem";
            this.goHereToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.goHereToolStripMenuItem.Text = "Fly to Here";
            this.goHereToolStripMenuItem.Click += new System.EventHandler(this.goHereToolStripMenuItem_Click);
            // 
            // flyToHereAltToolStripMenuItem
            // 
            this.flyToHereAltToolStripMenuItem.Name = "flyToHereAltToolStripMenuItem";
            this.flyToHereAltToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.flyToHereAltToolStripMenuItem.Text = "Fly to Here Alt";
            this.flyToHereAltToolStripMenuItem.Click += new System.EventHandler(this.flyToHereAltToolStripMenuItem_Click);
            // 
            // takeOffToolStripMenuItem
            // 
            this.takeOffToolStripMenuItem.Name = "takeOffToolStripMenuItem";
            this.takeOffToolStripMenuItem.Size = new System.Drawing.Size(149, 22);
            this.takeOffToolStripMenuItem.Text = "TakeOff";
            this.takeOffToolStripMenuItem.Click += new System.EventHandler(this.takeOffToolStripMenuItem_Click);
            // 
            // panelMap
            // 
            this.panelMap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMap.Location = new System.Drawing.Point(0, 0);
            this.panelMap.Margin = new System.Windows.Forms.Padding(2);
            this.panelMap.Name = "panelMap";
            this.panelMap.Size = new System.Drawing.Size(690, 391);
            this.panelMap.TabIndex = 5;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Multiline = true;
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(690, 150);
            this.tabControlMain.TabIndex = 0;
            this.tabControlMain.SelectedIndexChanged += new System.EventHandler(this.tabControlMain_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.tabPage1.Size = new System.Drawing.Size(663, 142);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Data";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 61.2158F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.78419F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel1.Controls.Add(this.zedGraph, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanelQuickView, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(663, 140);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // zedGraph
            // 
            this.zedGraph.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zedGraph.Location = new System.Drawing.Point(2, 2);
            this.zedGraph.Margin = new System.Windows.Forms.Padding(2);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(401, 136);
            this.zedGraph.TabIndex = 26;
            this.zedGraph.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.zedGraph_MouseDoubleClick);
            // 
            // tableLayoutPanelQuickView
            // 
            this.tableLayoutPanelQuickView.AutoSize = true;
            this.tableLayoutPanelQuickView.BackColor = System.Drawing.SystemColors.Desktop;
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
            this.tableLayoutPanelQuickView.Location = new System.Drawing.Point(407, 2);
            this.tableLayoutPanelQuickView.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanelQuickView.Name = "tableLayoutPanelQuickView";
            this.tableLayoutPanelQuickView.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.tableLayoutPanelQuickView.RowCount = 6;
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanelQuickView.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 16F));
            this.tableLayoutPanelQuickView.Size = new System.Drawing.Size(254, 136);
            this.tableLayoutPanelQuickView.TabIndex = 25;
            // 
            // labelQV12
            // 
            this.labelQV12.AutoSize = true;
            this.labelQV12.BackColor = System.Drawing.Color.Transparent;
            this.labelQV12.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV12.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV12.Location = new System.Drawing.Point(191, 91);
            this.labelQV12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQV12.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelQV12.Name = "labelQV12";
            this.labelQV12.Size = new System.Drawing.Size(61, 16);
            this.labelQV12.TabIndex = 46;
            this.labelQV12.Text = "Time in Air(min)";
            this.labelQV12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV11
            // 
            this.labelQV11.AutoSize = true;
            this.labelQV11.BackColor = System.Drawing.Color.Transparent;
            this.labelQV11.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV11.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV11.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV11.Location = new System.Drawing.Point(128, 91);
            this.labelQV11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQV11.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelQV11.Name = "labelQV11";
            this.labelQV11.Size = new System.Drawing.Size(59, 16);
            this.labelQV11.TabIndex = 45;
            this.labelQV11.Text = "Yaw (deg)";
            this.labelQV11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV10
            // 
            this.labelQV10.AutoSize = true;
            this.labelQV10.BackColor = System.Drawing.Color.Transparent;
            this.labelQV10.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV10.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV10.Location = new System.Drawing.Point(65, 91);
            this.labelQV10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQV10.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelQV10.Name = "labelQV10";
            this.labelQV10.Size = new System.Drawing.Size(59, 16);
            this.labelQV10.TabIndex = 44;
            this.labelQV10.Text = "WindVelocity(kph)";
            this.labelQV10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV9
            // 
            this.labelQV9.AutoSize = true;
            this.labelQV9.BackColor = System.Drawing.Color.Transparent;
            this.labelQV9.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV9.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV9.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV9.Location = new System.Drawing.Point(2, 91);
            this.labelQV9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQV9.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelQV9.Name = "labelQV9";
            this.labelQV9.Size = new System.Drawing.Size(59, 16);
            this.labelQV9.TabIndex = 43;
            this.labelQV9.Text = "ch3percent";
            this.labelQV9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV6
            // 
            this.labelQV6.AutoSize = true;
            this.labelQV6.BackColor = System.Drawing.Color.Transparent;
            this.labelQV6.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV6.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV6.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV6.Location = new System.Drawing.Point(65, 47);
            this.labelQV6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQV6.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelQV6.Name = "labelQV6";
            this.labelQV6.Size = new System.Drawing.Size(59, 16);
            this.labelQV6.TabIndex = 42;
            this.labelQV6.Text = "WindDir (deg)";
            this.labelQV6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV7
            // 
            this.labelQV7.AutoSize = true;
            this.labelQV7.BackColor = System.Drawing.Color.Transparent;
            this.labelQV7.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV7.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV7.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV7.Location = new System.Drawing.Point(128, 47);
            this.labelQV7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQV7.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelQV7.Name = "labelQV7";
            this.labelQV7.Size = new System.Drawing.Size(59, 16);
            this.labelQV7.TabIndex = 41;
            this.labelQV7.Text = "Roll (deg)";
            this.labelQV7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV8
            // 
            this.labelQV8.AutoSize = true;
            this.labelQV8.BackColor = System.Drawing.Color.Transparent;
            this.labelQV8.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV8.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV8.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV8.Location = new System.Drawing.Point(191, 47);
            this.labelQV8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQV8.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelQV8.Name = "labelQV8";
            this.labelQV8.Size = new System.Drawing.Size(61, 16);
            this.labelQV8.TabIndex = 40;
            this.labelQV8.Text = "Distance Traveled(m)";
            this.labelQV8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV4
            // 
            this.labelQV4.AutoSize = true;
            this.labelQV4.BackColor = System.Drawing.Color.Transparent;
            this.labelQV4.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV4.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV4.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV4.Location = new System.Drawing.Point(191, 3);
            this.labelQV4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQV4.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelQV4.Name = "labelQV4";
            this.labelQV4.Size = new System.Drawing.Size(61, 16);
            this.labelQV4.TabIndex = 39;
            this.labelQV4.Text = "Dist to Home (m)";
            this.labelQV4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV3
            // 
            this.labelQV3.AutoSize = true;
            this.labelQV3.BackColor = System.Drawing.Color.Transparent;
            this.labelQV3.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV3.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV3.Location = new System.Drawing.Point(128, 3);
            this.labelQV3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQV3.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelQV3.Name = "labelQV3";
            this.labelQV3.Size = new System.Drawing.Size(59, 16);
            this.labelQV3.TabIndex = 38;
            this.labelQV3.Text = "Pitch (deg)";
            this.labelQV3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV2
            // 
            this.labelQV2.AutoSize = true;
            this.labelQV2.BackColor = System.Drawing.Color.Transparent;
            this.labelQV2.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV2.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV2.Location = new System.Drawing.Point(65, 3);
            this.labelQV2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQV2.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelQV2.Name = "labelQV2";
            this.labelQV2.Size = new System.Drawing.Size(59, 16);
            this.labelQV2.TabIndex = 37;
            this.labelQV2.Text = "Altitude(m)";
            this.labelQV2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV1
            // 
            this.labelQV1.AutoSize = true;
            this.labelQV1.BackColor = System.Drawing.Color.Transparent;
            this.labelQV1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV1.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV1.Location = new System.Drawing.Point(2, 3);
            this.labelQV1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQV1.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelQV1.Name = "labelQV1";
            this.labelQV1.Size = new System.Drawing.Size(59, 16);
            this.labelQV1.TabIndex = 36;
            this.labelQV1.Text = "Airspeed(kph)";
            this.labelQV1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelQV5
            // 
            this.labelQV5.AutoSize = true;
            this.labelQV5.BackColor = System.Drawing.Color.Transparent;
            this.labelQV5.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelQV5.Font = new System.Drawing.Font("Segoe UI Variable Text", 9F, System.Drawing.FontStyle.Bold);
            this.labelQV5.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelQV5.Location = new System.Drawing.Point(2, 47);
            this.labelQV5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelQV5.MaximumSize = new System.Drawing.Size(0, 16);
            this.labelQV5.Name = "labelQV5";
            this.labelQV5.Size = new System.Drawing.Size(59, 16);
            this.labelQV5.TabIndex = 28;
            this.labelQV5.Text = "GroundSpeed(kph)";
            this.labelQV5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quickView9
            // 
            this.quickView9.BackColor = System.Drawing.SystemColors.Desktop;
            this.quickView9.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "DistToHome", true));
            this.quickView9.desc = "";
            this.quickView9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView9.Location = new System.Drawing.Point(2, 111);
            this.quickView9.Margin = new System.Windows.Forms.Padding(2);
            this.quickView9.Name = "quickView9";
            this.quickView9.number = -99D;
            this.quickView9.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView9.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView9.numberformat = "0.00";
            this.quickView9.Size = new System.Drawing.Size(59, 23);
            this.quickView9.TabIndex = 12;
            this.quickView9.Text = "quickView24";
            // 
            // quickView3
            // 
            this.quickView3.BackColor = System.Drawing.SystemColors.Desktop;
            this.quickView3.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "pitch", true));
            this.quickView3.desc = "";
            this.quickView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView3.Location = new System.Drawing.Point(128, 23);
            this.quickView3.Margin = new System.Windows.Forms.Padding(2);
            this.quickView3.Name = "quickView3";
            this.quickView3.number = -9D;
            this.quickView3.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView3.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView3.numberformat = "0.00";
            this.quickView3.Size = new System.Drawing.Size(59, 22);
            this.quickView3.TabIndex = 2;
            this.quickView3.Text = "quickView14";
            // 
            // quickView7
            // 
            this.quickView7.BackColor = System.Drawing.SystemColors.Desktop;
            this.quickView7.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "roll", true));
            this.quickView7.desc = "";
            this.quickView7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView7.Location = new System.Drawing.Point(128, 67);
            this.quickView7.Margin = new System.Windows.Forms.Padding(2);
            this.quickView7.Name = "quickView7";
            this.quickView7.number = -99D;
            this.quickView7.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView7.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView7.numberformat = "0.00";
            this.quickView7.Size = new System.Drawing.Size(59, 22);
            this.quickView7.TabIndex = 4;
            this.quickView7.Text = "quickView16";
            // 
            // quickView11
            // 
            this.quickView11.BackColor = System.Drawing.SystemColors.Desktop;
            this.quickView11.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "yaw", true));
            this.quickView11.desc = "";
            this.quickView11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView11.Location = new System.Drawing.Point(128, 111);
            this.quickView11.Margin = new System.Windows.Forms.Padding(2);
            this.quickView11.Name = "quickView11";
            this.quickView11.number = 54D;
            this.quickView11.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView11.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView11.numberformat = "0.00";
            this.quickView11.Size = new System.Drawing.Size(59, 23);
            this.quickView11.TabIndex = 6;
            this.quickView11.Text = "quickView18";
            // 
            // quickView5
            // 
            this.quickView5.BackColor = System.Drawing.SystemColors.Desktop;
            this.quickView5.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "groundspeed", true));
            this.quickView5.desc = "";
            this.quickView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView5.Location = new System.Drawing.Point(2, 67);
            this.quickView5.Margin = new System.Windows.Forms.Padding(2);
            this.quickView5.Name = "quickView5";
            this.quickView5.number = -34D;
            this.quickView5.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView5.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView5.numberformat = "0.00";
            this.quickView5.Size = new System.Drawing.Size(59, 22);
            this.quickView5.TabIndex = 7;
            this.quickView5.Text = "quickView19";
            // 
            // quickView1
            // 
            this.quickView1.BackColor = System.Drawing.SystemColors.Desktop;
            this.quickView1.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "airspeed", true));
            this.quickView1.desc = "";
            this.quickView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView1.Location = new System.Drawing.Point(2, 23);
            this.quickView1.Margin = new System.Windows.Forms.Padding(2);
            this.quickView1.Name = "quickView1";
            this.quickView1.number = -56D;
            this.quickView1.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.quickView1.numberColorBackup = System.Drawing.Color.Lime;
            this.quickView1.numberformat = "0.0";
            this.quickView1.Size = new System.Drawing.Size(59, 22);
            this.quickView1.TabIndex = 10;
            // 
            // quickView4
            // 
            this.quickView4.BackColor = System.Drawing.SystemColors.Desktop;
            this.quickView4.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "DistToHome", true));
            this.quickView4.desc = "";
            this.quickView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView4.Location = new System.Drawing.Point(191, 23);
            this.quickView4.Margin = new System.Windows.Forms.Padding(2);
            this.quickView4.Name = "quickView4";
            this.quickView4.number = 20D;
            this.quickView4.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView4.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView4.numberformat = "0.00";
            this.quickView4.Size = new System.Drawing.Size(61, 22);
            this.quickView4.TabIndex = 1;
            this.quickView4.Text = "quickView13";
            // 
            // quickView2
            // 
            this.quickView2.BackColor = System.Drawing.SystemColors.Desktop;
            this.quickView2.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "alt", true));
            this.quickView2.desc = "";
            this.quickView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView2.Location = new System.Drawing.Point(65, 23);
            this.quickView2.Margin = new System.Windows.Forms.Padding(2);
            this.quickView2.Name = "quickView2";
            this.quickView2.number = -99D;
            this.quickView2.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView2.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView2.numberformat = "0.00";
            this.quickView2.Size = new System.Drawing.Size(59, 22);
            this.quickView2.TabIndex = 11;
            this.quickView2.Text = "quickView2";
            // 
            // quickView6
            // 
            this.quickView6.BackColor = System.Drawing.SystemColors.Desktop;
            this.quickView6.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "wind_dir", true));
            this.quickView6.desc = "";
            this.quickView6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView6.Location = new System.Drawing.Point(65, 67);
            this.quickView6.Margin = new System.Windows.Forms.Padding(2);
            this.quickView6.Name = "quickView6";
            this.quickView6.number = -300D;
            this.quickView6.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView6.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView6.numberformat = "0.00";
            this.quickView6.Size = new System.Drawing.Size(59, 22);
            this.quickView6.TabIndex = 9;
            this.quickView6.Text = "quickView21";
            // 
            // quickView8
            // 
            this.quickView8.BackColor = System.Drawing.SystemColors.Desktop;
            this.quickView8.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "distTraveled", true));
            this.quickView8.desc = "";
            this.quickView8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView8.Location = new System.Drawing.Point(191, 67);
            this.quickView8.Margin = new System.Windows.Forms.Padding(2);
            this.quickView8.Name = "quickView8";
            this.quickView8.number = 11D;
            this.quickView8.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView8.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView8.numberformat = "0.00";
            this.quickView8.Size = new System.Drawing.Size(61, 22);
            this.quickView8.TabIndex = 3;
            this.quickView8.Text = "quickView15";
            // 
            // quickView10
            // 
            this.quickView10.BackColor = System.Drawing.SystemColors.Desktop;
            this.quickView10.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "wind_vel", true));
            this.quickView10.desc = "";
            this.quickView10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView10.Location = new System.Drawing.Point(65, 111);
            this.quickView10.Margin = new System.Windows.Forms.Padding(2);
            this.quickView10.Name = "quickView10";
            this.quickView10.number = -43D;
            this.quickView10.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView10.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView10.numberformat = "0.00";
            this.quickView10.Size = new System.Drawing.Size(59, 23);
            this.quickView10.TabIndex = 8;
            this.quickView10.Text = "quickView20";
            // 
            // quickView12
            // 
            this.quickView12.BackColor = System.Drawing.SystemColors.Desktop;
            this.quickView12.DataBindings.Add(new System.Windows.Forms.Binding("number", this.bindingSourceHUD, "timeInAir", true));
            this.quickView12.desc = "";
            this.quickView12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quickView12.Location = new System.Drawing.Point(191, 111);
            this.quickView12.Margin = new System.Windows.Forms.Padding(2);
            this.quickView12.Name = "quickView12";
            this.quickView12.number = 23D;
            this.quickView12.numberColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.quickView12.numberColorBackup = System.Drawing.Color.Empty;
            this.quickView12.numberformat = "0.00";
            this.quickView12.Size = new System.Drawing.Size(61, 23);
            this.quickView12.TabIndex = 5;
            this.quickView12.Text = "quickView12";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.whPanel5);
            this.tabPage2.Controls.Add(this.whPanel4);
            this.tabPage2.Controls.Add(this.whPanel3);
            this.tabPage2.Controls.Add(this.whPanel2);
            this.tabPage2.Controls.Add(this.whPanel1);
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(663, 142);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tactical";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // whPanel5
            // 
            this.whPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.whPanel5.Location = new System.Drawing.Point(647, 7);
            this.whPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.whPanel5.MinimumSize = new System.Drawing.Size(75, 89);
            this.whPanel5.Name = "whPanel5";
            this.whPanel5.Size = new System.Drawing.Size(158, 197);
            this.whPanel5.SystemId = 5;
            this.whPanel5.TabIndex = 4;
            // 
            // whPanel4
            // 
            this.whPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.whPanel4.Location = new System.Drawing.Point(488, 7);
            this.whPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.whPanel4.MinimumSize = new System.Drawing.Size(75, 89);
            this.whPanel4.Name = "whPanel4";
            this.whPanel4.Size = new System.Drawing.Size(158, 197);
            this.whPanel4.SystemId = 4;
            this.whPanel4.TabIndex = 3;
            // 
            // whPanel3
            // 
            this.whPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.whPanel3.Location = new System.Drawing.Point(326, 7);
            this.whPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.whPanel3.MinimumSize = new System.Drawing.Size(75, 89);
            this.whPanel3.Name = "whPanel3";
            this.whPanel3.Size = new System.Drawing.Size(158, 197);
            this.whPanel3.SystemId = 3;
            this.whPanel3.TabIndex = 2;
            // 
            // whPanel2
            // 
            this.whPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.whPanel2.Location = new System.Drawing.Point(164, 7);
            this.whPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.whPanel2.MinimumSize = new System.Drawing.Size(75, 89);
            this.whPanel2.Name = "whPanel2";
            this.whPanel2.Size = new System.Drawing.Size(158, 197);
            this.whPanel2.SystemId = 2;
            this.whPanel2.TabIndex = 1;
            // 
            // whPanel1
            // 
            this.whPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(27)))), ((int)(((byte)(38)))));
            this.whPanel1.Location = new System.Drawing.Point(2, 7);
            this.whPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.whPanel1.MinimumSize = new System.Drawing.Size(75, 89);
            this.whPanel1.Name = "whPanel1";
            this.whPanel1.Size = new System.Drawing.Size(158, 197);
            this.whPanel1.TabIndex = 0;
            // 
            // timerZedGraph
            // 
            this.timerZedGraph.Tick += new System.EventHandler(this.timerZedGraph_Tick);
            // 
            // betterFolderBrowser1
            // 
            this.betterFolderBrowser1.Multiselect = false;
            this.betterFolderBrowser1.RootFolder = "C:\\Users\\pc\\Desktop";
            this.betterFolderBrowser1.Title = "Please select a folder...";
            // 
            // flightStatusView1
            // 
            this.flightStatusView1.BackColor = System.Drawing.Color.Black;
            this.flightStatusView1.DataBindings.Add(new System.Windows.Forms.Binding("Armed", this.bindingSourceHUD, "armed", true));
            this.flightStatusView1.DataBindings.Add(new System.Windows.Forms.Binding("MessageSeverity", this.bindingSourceHUD, "messageHighSeverity", true));
            this.flightStatusView1.DataBindings.Add(new System.Windows.Forms.Binding("Message", this.bindingSourceHUD, "messageHigh", true));
            this.flightStatusView1.DataBindings.Add(new System.Windows.Forms.Binding("Mode", this.bindingSourceHUD, "mode", true));
            this.flightStatusView1.DataBindings.Add(new System.Windows.Forms.Binding("TimeInAir", this.bindingSourceHUD, "timeInAir", true));
            this.flightStatusView1.DataBindings.Add(new System.Windows.Forms.Binding("NextWaypoint", this.bindingSourceHUD, "wpno", true));
            this.flightStatusView1.DataBindings.Add(new System.Windows.Forms.Binding("DistanceToWaypoint", this.bindingSourceHUD, "wp_dist", true));
            this.flightStatusView1.DataBindings.Add(new System.Windows.Forms.Binding("Battery1Percent", this.bindingSourceHUD, "battery_remaining", true));
            this.flightStatusView1.DataBindings.Add(new System.Windows.Forms.Binding("Battery1Voltage", this.bindingSourceHUD, "battery_voltage", true));
            this.flightStatusView1.DataBindings.Add(new System.Windows.Forms.Binding("Battery1Current", this.bindingSourceHUD, "current", true));
            this.flightStatusView1.DataBindings.Add(new System.Windows.Forms.Binding("Battery2Percent", this.bindingSourceHUD, "battery_remaining2", true));
            this.flightStatusView1.DataBindings.Add(new System.Windows.Forms.Binding("Battery2Voltage", this.bindingSourceHUD, "battery_voltage2", true));
            this.flightStatusView1.DataBindings.Add(new System.Windows.Forms.Binding("Battery2Current", this.bindingSourceHUD, "current2", true));
            this.flightStatusView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flightStatusView1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.flightStatusView1.ForeColor = System.Drawing.Color.White;
            this.flightStatusView1.Location = new System.Drawing.Point(2, 410);
            this.flightStatusView1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.flightStatusView1.Name = "flightStatusView1";
            this.flightStatusView1.Size = new System.Drawing.Size(283, 590);
            this.flightStatusView1.TabIndex = 1;
            this.flightStatusView1.AltitudeSend += new System.EventHandler(this.klcButtonSetAlt_ClickAsync);
            this.flightStatusView1.SpeedSend += new System.EventHandler(this.klcButtonSetSpeed_Click);
            this.flightStatusView1.LoiterRadiusSend += new System.EventHandler(this.klcButtonSetLoiterRad_Click);
            this.flightStatusView1.CMB_setwpClick += new System.EventHandler(this.CMB_setwp_Click_1);
            this.flightStatusView1.SetModeClick += new System.EventHandler(this.flightStatusView1_SetModeClick);
            this.flightStatusView1.DoActionClick += new System.EventHandler(this.klcButtonDoAction_Click);
            this.flightStatusView1.SetWaypointClick += new System.EventHandler(this.flightStatusView1_SetWaypointClick);
            this.flightStatusView1.AutoClick += new System.EventHandler(this.klcButtonAuto_Click);
            this.flightStatusView1.LoiterClick += new System.EventHandler(this.klcButtonLoiter_Click);
            this.flightStatusView1.ArmDisarmClick += new System.EventHandler(this.klcButtonARMD_Click);
            this.flightStatusView1.Load += new System.EventHandler(this.flightStatusView1_Load);
            // 
            // flightHudView1
            // 
            this.flightHudView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flightHudView1.DataBindings.Add(new System.Windows.Forms.Binding("Roll", this.bindingSourceHUD, "roll", true));
            this.flightHudView1.DataBindings.Add(new System.Windows.Forms.Binding("Pitch", this.bindingSourceHUD, "pitch", true));
            this.flightHudView1.DataBindings.Add(new System.Windows.Forms.Binding("Heading", this.bindingSourceHUD, "yaw", true));
            this.flightHudView1.DataBindings.Add(new System.Windows.Forms.Binding("AngleOfAttack", this.bindingSourceHUD, "AOA", true));
            this.flightHudView1.DataBindings.Add(new System.Windows.Forms.Binding("AirSpeed", this.bindingSourceHUD, "airspeed", true));
            this.flightHudView1.DataBindings.Add(new System.Windows.Forms.Binding("GroundSpeed", this.bindingSourceHUD, "groundspeed", true));
            this.flightHudView1.DataBindings.Add(new System.Windows.Forms.Binding("AltitudeSeaLevel", this.bindingSourceHUD, "alt", true));
            this.flightHudView1.DataBindings.Add(new System.Windows.Forms.Binding("AltitudeGroundLevel", this.bindingSourceHUD, "HomeAlt", true));
            this.flightHudView1.DataBindings.Add(new System.Windows.Forms.Binding("SignalPercent", this.bindingSourceHUD, "linkqualitygcs", true));
            this.flightHudView1.DataBindings.Add(new System.Windows.Forms.Binding("GpsStatus", this.bindingSourceHUD, "gpsstatus", true));
            this.flightHudView1.DataBindings.Add(new System.Windows.Forms.Binding("HeadingBug", this.bindingSourceHUD, "nav_bearing", true));
            this.flightHudView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flightHudView1.ForeColor = System.Drawing.Color.White;
            this.flightHudView1.Location = new System.Drawing.Point(2, 0);
            this.flightHudView1.Margin = new System.Windows.Forms.Padding(3, 3, 3, 0);
            this.flightHudView1.Name = "flightHudView1";
            this.flightHudView1.Size = new System.Drawing.Size(283, 410);
            this.flightHudView1.TabIndex = 0;
            this.flightHudView1.TabStop = false;
            this.flightHudView1.Text = "flightHudView1";
            // 
            // FlightStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.splitMainPanel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FlightStatus";
            this.Size = new System.Drawing.Size(1003, 544);
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
            this.contextMenuStripMap.ResumeLayout(false);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanelQuickView.ResumeLayout(false);
            this.tableLayoutPanelQuickView.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        
        #endregion
        private System.Windows.Forms.SplitContainer splitMainPanel;
        private System.Windows.Forms.Timer timerTest;
        private System.Windows.Forms.SplitContainer splitContainerMap;
        public Controls.myGMAP gMapControlSerb;
        private BindingSource bindingSourceHUD;
        private RJCodeAdvance.RJControls.RJButton btnMapMax;
        private RJCodeAdvance.RJControls.RJButton btnMapMin;
        private FlowLayoutPanel flowLayoutPanel4;
        private Panel panelMap;
        internal Label lblMapZoom;
        private Label lblMapLat;
        private Label lblMapLong;
       


        private Label lblMapAlt;
        private Label lblhdopVal;
        private Label label5;
        private Label label7;
        private Label labelSats;
        private TabControl tabControlMain;
        private TabPage tabPage1;
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
        private TableLayoutPanel tableLayoutPanel1;
        private Label labelQV12;
        private Label labelQV8;
        private Label labelQV4;
        private Controls.QuickView quickView4;
        private Controls.QuickView quickView8;
        private Controls.QuickView quickView12;
        private ZedGraph.ZedGraphControl zedGraph;
        private Timer timerZedGraph;
        private FlowLayoutPanel flowLayoutPanel2;
        private KLCToolbox.KLCControls.KLCButton btnTelem;
        private ContextMenuStrip contextMenuStripMap;
        private ToolStripMenuItem goHereToolStripMenuItem;
        private ToolStripMenuItem flyToHereAltToolStripMenuItem;
        private ToolStripMenuItem takeOffToolStripMenuItem;
        private TabPage tabPage2;
        private SerbLabelControls.WhPanel whPanel5;
        private SerbLabelControls.WhPanel whPanel4;
        private SerbLabelControls.WhPanel whPanel3;
        private SerbLabelControls.WhPanel whPanel2;
        private SerbLabelControls.WhPanel whPanel1;
        private FlightHud.FlightHudView flightHudView1;
        private FlightHud.FlightStatusView flightStatusView1;
        private WK.Libraries.BetterFolderBrowserNS.BetterFolderBrowser betterFolderBrowser1;


        // private AnimatedTextControl animatedTextControl1;
    }
}