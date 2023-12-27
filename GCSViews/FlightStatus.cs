///اللَّهُمَّ صَلِّ عَلَى سَيِّدِنَا مُحَمَّدٍ وَعَلَى آلِهِ وَصَحْبِهِ وَسَلَّم
using System;
using System.Collections.Generic;
using System.ComponentModel;
using GMap.NET.WindowsForms.Markers;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DroneCAN;
using GMap.NET;
using GMap.NET.WindowsForms;
using log4net;
using MissionPlanner.Controls;
using MissionPlanner.Maps;
using MissionPlanner.Utilities;
using MissionPlanner.Warnings;
using Org.BouncyCastle.Utilities;
using RJCodeAdvance.RJControls;
using SharpAdbClient;
using ZedGraph;
using static Community.CsharpSqlite.Sqlite3;
using static MissionPlanner.GCSViews.FlightData;
using DateTime = System.DateTime;
using MissionPlanner.ArduPilot;
using System.Net;
using System.Drawing.Drawing2D;
using Nevron.Nov.DataStructures;
using GMap.NET.MapProviders;
using System.Windows.Controls.Primitives;
using OpenTK.Audio.OpenAL;
using static MissionPlanner.Utilities.LTM;
using MissionPlanner.Swarm;

namespace MissionPlanner.GCSViews
{
    public partial class FlightStatus : MyUserControl, IActivate, IDeactivate
    {
        public static GMapOverlay kmlpolygons;
        public static HUD myhud;
        public static myGMAP mymap;
        public static bool threadrun;
        //public SplitContainer MainHcopy;
        public static FlightStatus instance;
        internal static GMapOverlay geofence;
        internal static GMapOverlay photosoverlay;
        internal static GMapOverlay poioverlay = new GMapOverlay("POI");
        internal static GMapOverlay rallypointoverlay;
        internal static GMapOverlay tfrpolygons;
        internal GMapMarker CurrentGMapMarker;
        internal PointLatLng MouseDownStart;
        bool flagBindingSource = false;
        private bool CameraOverlap;
        GMapMarker center = new GMarkerGoogle(new PointLatLng(0.0, 0.0), GMarkerGoogleType.none);
        bool huddropout;
        Thread thisthreadSerb;
        Random rnd = new Random();
        bool isGraphInitialized = false;
        private static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        DateTime lastmapposchange = DateTime.MinValue;
        RollingPointPairList list1 = new RollingPointPairList(1200);
        CurveItem list1curve;
        PropertyInfo list1item;
        RollingPointPairList list2 = new RollingPointPairList(1200);
        CurveItem list2curve;
        PropertyInfo list2item;
        RollingPointPairList list3 = new RollingPointPairList(1200);
        CurveItem list3curve;
        PropertyInfo list3item;
        RollingPointPairList list4 = new RollingPointPairList(1200);
        CurveItem list4curve;
        PropertyInfo list4item;
        RollingPointPairList list5 = new RollingPointPairList(1200);
        CurveItem list5curve;
        PropertyInfo list5item;
        RollingPointPairList list6 = new RollingPointPairList(1200);
        CurveItem list6curve;
        PropertyInfo list6item;
        RollingPointPairList list7 = new RollingPointPairList(1200);
        CurveItem list7curve;
        PropertyInfo list7item;
        RollingPointPairList list8 = new RollingPointPairList(1200);
        CurveItem list8curve;
        PropertyInfo list8item;
        RollingPointPairList list9 = new RollingPointPairList(1200);
        CurveItem list9curve;
        PropertyInfo list9item;
        RollingPointPairList list10 = new RollingPointPairList(1200);
        CurveItem list10curve;
        PropertyInfo list10item;
        RollingPointPairList list11 = new RollingPointPairList(1200);
        CurveItem list11curve;
        PropertyInfo list11item;
        RollingPointPairList list12 = new RollingPointPairList(1200);
        CurveItem list12curve;
        PropertyInfo list12item;
        RollingPointPairList list13 = new RollingPointPairList(1200);
        CurveItem list13curve;
        PropertyInfo list13item;
        RollingPointPairList list14 = new RollingPointPairList(1200);
        CurveItem list14curve;
        PropertyInfo list14item;
        RollingPointPairList list15 = new RollingPointPairList(1200);
        CurveItem list15curve;
        PropertyInfo list15item;
        RollingPointPairList list16 = new RollingPointPairList(1200);
        CurveItem list16curve;
        PropertyInfo list16item;
        RollingPointPairList list17 = new RollingPointPairList(1200);
        CurveItem list17curve;
        PropertyInfo list17item;
        RollingPointPairList list18 = new RollingPointPairList(1200);
        CurveItem list18curve;
        PropertyInfo list18item;
        RollingPointPairList list19 = new RollingPointPairList(1200);
        CurveItem list19curve;
        PropertyInfo list19item;
        RollingPointPairList list20 = new RollingPointPairList(1200);
        CurveItem list20curve;
        PropertyInfo list20item;
        double LogPlayBackSpeed = 1.0;
        GMapMarker marker;
        int messagecount;
        //whether or not the output console has already started
        bool outputwindowstarted;

        bool playingLog;
        GMapOverlay polygons;
        private Propagation prop;

        GMapRoute route;
        GMapOverlay routes;
        GMapOverlay adsbais;
        int tickStart;
        //private DockStateSerializer _serializer = null;

        List<PointLatLng> trackPoints = new List<PointLatLng>();
        DateTime lastscreenupdate = DateTime.Now;
        volatile int updateBindingSourcecount;
        object updateBindingSourcelock = new object();
        string updateBindingSourceThreadName = "";
        int counterArmed = 0;
        //RJCircularPictureBox

        Script script;

        //whether or not a script is running
        bool scriptrunning;

        //the thread the script is running on
        Thread scriptthread;

        public readonly List<TabPage> TabListOriginal = new List<TabPage>();


        //private DockStateSerializer _serializer = null;



        public enum actions
        {
            Loiter_Unlim,
            Return_To_Launch,
            Preflight_Calibration,
            Mission_Start,
            Preflight_Reboot_Shutdown,
            Trigger_Camera,
            System_Time,
            Battery_Reset,
            ADSB_Out_Ident,
            Scripting_cmd_stop_and_restart,
            Scripting_cmd_stop,
            HighLatency_Enable,
            HighLatency_Disable
        }
        public FlightStatus()
        {
            instance = this;
            InitializeComponent();
            // panelFlowLayoutHud.BackColor = Color.FromArgb(25, Color.Black);
            if (status == false) // not armed
            {
                //klcButArm.Text = "DisArmed";
            }
            if (status == false)
            {
                //rjButtonStatus.Text = MissionPlanner.Controls.HUDT.FAILSAFE;
                //rjButtonStatus.BackgroundColor = Color.Red;
                //rjButtonStatus.Visible = true;
                // rjTextBox.PlaceholderText = MissionPlanner.Controls.HUDT.FAILSAFE;
            }
            myhud = hudSerb;
            mymap = gMapControlSerb;
            //MainHcopy = MainH;
            mymap.Paint += gMapControlSerb_Paint;
            //myhud.groundColor1 = ThemeManager.HudGroundTop;
            //myhud.groundColor2 = ThemeManager.HudGroundBot;
            //myhud.skyColor1 = ThemeManager.HudSkyTop;
            //myhud.skyColor2 = ThemeManager.HudSkyBot;
            //myhud.hudcolor = ThemeManager.HudText;
            hudSerb.displayicons = Settings.Instance.GetBoolean("HUD_showicons", false);
            CMB_mountmode.DataSource = Enum.GetNames(typeof(actions));
            CMB_modes.DataSource = ArduPilot.Common.getModesList(MainSerb.comPort.MAV.cs.firmware);
            CMB_modes.ValueMember = "Key";
            CMB_modes.DisplayMember = "Value";
            //default to auto

            CMB_action.DataSource = Enum.GetNames(typeof(actions));
            CMB_modes.Text = "Auto";
            var item1 = ParameterMetaDataRepository.GetParameterOptionsInt("MNT_MODE",
               MainSerb.comPort.MAV.cs.firmware.ToString());
            var item2 = ParameterMetaDataRepository.GetParameterOptionsInt("MNT_DEFLT_MODE",
                MainSerb.comPort.MAV.cs.firmware.ToString());
            if (item1.Count > 0)
                CMB_mountmode.DataSource = item1;

            if (item2.Count > 0)
                CMB_mountmode.DataSource = item2;
            //CMB_mountmode.DisplayMember = "Value";
            //CMB_mountmode.ValueMember = "Key";
            //panel2.Width = panelRightWrapper.Width;
            // config map      
            log.Info("Map Setup");
            //CustomMessageBox.Show(Settings.GetDataDirectory() +
            //                             "gmapcache" + Path.DirectorySeparatorChar + gMapControlSerb.MapProvider);
            gMapControlSerb.CacheLocation = Settings.GetDataDirectory() +
                                         "gmapcache" + Path.DirectorySeparatorChar;
            gMapControlSerb.MinZoom = 0;
            gMapControlSerb.MaxZoom = 24;
            gMapControlSerb.Zoom = 13;

            gMapControlSerb.OnMapZoomChanged += gMapControlSerb_OnMapZoomChanged;

            gMapControlSerb.DisableFocusOnMouseEnter = true;

            gMapControlSerb.OnMarkerEnter += gMapControlSerb_OnMarkerEnter;
            gMapControlSerb.OnMarkerLeave += gMapControlSerb_OnMarkerLeave;

            gMapControlSerb.RoutesEnabled = true;
            gMapControlSerb.PolygonsEnabled = true;

            tfrpolygons = new GMapOverlay("tfrpolygons");
            gMapControlSerb.Overlays.Add(tfrpolygons);

            kmlpolygons = new GMapOverlay("kmlpolygons");
            gMapControlSerb.Overlays.Add(kmlpolygons);

            geofence = new GMapOverlay("geofence");
            gMapControlSerb.Overlays.Add(geofence);

            polygons = new GMapOverlay("polygons");
            gMapControlSerb.Overlays.Add(polygons);

            photosoverlay = new GMapOverlay("photos overlay");
            gMapControlSerb.Overlays.Add(photosoverlay);

            routes = new GMapOverlay("routes");
            gMapControlSerb.Overlays.Add(routes);

            adsbais = new GMapOverlay("adsb/ais");
            gMapControlSerb.Overlays.Add(adsbais);

            rallypointoverlay = new GMapOverlay("rally points");
            gMapControlSerb.Overlays.Add(rallypointoverlay);

            gMapControlSerb.Overlays.Add(poioverlay);
           
            log.Info("Tunning Graph Settings");
            // setup default tuning graph
            if (Settings.Instance["Tuning_Graph_Selected"] != null)
            {
                string line = Settings.Instance["Tuning_Graph_Selected"].ToString();
                string[] lines = line.Split(new[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
                foreach (string option in lines)
                {
                    string name = option;
                    if (option.StartsWith("customfield"))
                    {
                        // add empty custom felids so the are un-tickable
                        if (option.Length <= 12)
                        {
                            // string only contains key
                            CurrentState.custom_field_names.Add(option, "Unknown");
                        }
                        else
                        {
                            // both key and name
                            name = option.Substring(0, 12);
                            CurrentState.custom_field_names.Add(name, option.Substring(12));
                        }
                    }
                    string desc = MainSerb.comPort.MAV.cs.GetNameandUnit(name);
                    using (var cb = new CheckBox { Name = name, Checked = true, Text = desc })
                    {
                        chk_box_tunningCheckedChanged(cb, EventArgs.Empty);
                    }
                }
            }
            else
            {
                using (var cb = new CheckBox { Name = "roll", Checked = true })
                {
                    chk_box_tunningCheckedChanged(cb, EventArgs.Empty);
                }

                using (var cb = new CheckBox { Name = "pitch", Checked = true })
                {
                    chk_box_tunningCheckedChanged(cb, EventArgs.Empty);
                }

                using (var cb = new CheckBox { Name = "nav_roll", Checked = true })
                {
                    chk_box_tunningCheckedChanged(cb, EventArgs.Empty);
                }

                using (var cb = new CheckBox { Name = "nav_pitch", Checked = true })
                {
                    chk_box_tunningCheckedChanged(cb, EventArgs.Empty);
                }
            }
            CreateChart(zedGraph);
        }
        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public bool failsafe { get; set; }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public bool lowvoltagealert { get; set; }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public bool criticalvoltagealert { get; set; }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public bool connected { get; set; }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float groundalt { get; set; }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public bool status { get; set; }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public string message { get; set; } = "";

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public MAVLink.MAV_SEVERITY messageSeverity { get; set; } = MAVLink.MAV_SEVERITY.EMERGENCY;

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float vibex { get; set; }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float vibey { get; set; }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float vibez { get; set; }

        [System.ComponentModel.Browsable(true), System.ComponentModel.Category("Values")]
        public float ekfstatus { get; set; }

        private void hsi1_Load(object sender, EventArgs e)
        {

        }

        private void klcButArm_Click(object sender, EventArgs e)
        {
            timerTest.Start();
        }
        private void timerTest_Tick(object sender, EventArgs e)
        {
            //statusLabel.State = CodeArtEng.Controls.StatusLabelState.Grey;
            hsiHeading.Heading = rnd.Next(-30, 50);
            hudSerb.roll = rnd.Next(-20, 20);
            hudSerb.pitch = rnd.Next(-10, 20);
            //statusLabel.State = CodeArtEng.Controls.StatusLabelState.Red;
        }

        private void rjButtonStatus_Click(object sender, EventArgs e)
        {
            if (flagBindingSource) flagBindingSource = false;
            else flagBindingSource = true;
        }

        private void FlightStatus_Load(object sender, EventArgs e)
        {
            POI.POIModified += POI_POIModified;

            gMapControlSerb.EmptyTileColor = Color.Gray;
            prop = new Propagation(gMapControlSerb);
            try
            {
                thisthreadSerb = new Thread(statusloop);
                thisthreadSerb.Name = "FS Statusloop";
                thisthreadSerb.IsBackground = true;
                thisthreadSerb.Start();
                System.Diagnostics.Debug.WriteLine("######################################### Loop Started");
            }
            catch (NotSupportedException)
            {
                statusloop();
            }
        }
        void POI_POIModified(object sender, EventArgs e)
        {
            POI.UpdateOverlay(poioverlay);
        }
        //private void hud1_Resize(object sender, EventArgs e)
        //{
        //    Console.WriteLine("HUD resize " + hud1.Width + " " + hud1.Height); // +"\n"+ System.Environment.StackTrace);

        //    if (hud1.Parent == this.SubMainLeft.Panel1)
        //    {
        //        var ht = SubMainLeft.SplitterDistance;
        //        if (ht >= hud1.Height + 5 || ht <= hud1.Height - 5)
        //            SubMainLeft.SplitterDistance = hud1.Height;
        //    }
        //}
        private void statusloop()
        {
            threadrun = true;

            EndPoint Remote = new IPEndPoint(IPAddress.Any, 0);

            DateTime tracklast = DateTime.Now.AddSeconds(0);

            DateTime tunning = DateTime.Now.AddSeconds(0);

            DateTime mapupdate = DateTime.Now.AddSeconds(0);

            DateTime vidrec = DateTime.Now.AddSeconds(0);

            DateTime waypoints = DateTime.Now.AddSeconds(0);

            DateTime updatescreen = DateTime.Now;
            //pilotHUD.hudControl hud = new pilotHUD.hudControl();


            DateTime tsreal = DateTime.Now;
            double taketime = 0;
            double timeerror = 0;
            
            System.Diagnostics.Debug.WriteLine("##################################### loop method");
            while (!IsHandleCreated)
            {
                //await Task.Delay(1000);
                Thread.Sleep(1000);
            }
            while (threadrun)
            {
                try
                {
                    if (MainSerb.comPort.giveComport)
                    {
                        //await Task.Delay(50);
                        Thread.Sleep(50);
                        updateBindingSource();
                        continue;
                    }
                    if (!MainSerb.comPort.logreadmode)
                    {
                        //await Task.Delay(50); // max is only ever 10 hz but we go a little faster to empty the serial queue
                        Thread.Sleep(50);
                    }
                    if (this.IsDisposed)
                    {
                        threadrun = false;
                        break;
                    }
                    try
                    {

                    }
                    catch (Exception ex)
                    {
                        //log.Error(ex);
                        Tracking.AddException(ex);
                        Console.WriteLine("FD Main loop exception " + ex);
                    }
                    double warnvolt = 0;
                    double warnpercent = 0;
                    double critvolt = 0;
                    double critpercent = 0;
                    //hud.RollAngle = 10;
                    updateBindingSource();
                    if (MainSerb.comPort.MAV.param.ContainsKey("BATT_LOW_VOLT")) warnvolt = MainSerb.comPort.MAV.param["BATT_LOW_VOLT"].Value;
                    if (MainSerb.comPort.MAV.param.ContainsKey("BATT_LOW_MAH") && MainSerb.comPort.MAV.param.ContainsKey("BATT_CAPACITY"))
                    {
                        if (MainSerb.comPort.MAV.param["BATT_LOW_MAH"].Value > 0)
                        {
                            warnpercent = MainSerb.comPort.MAV.param["BATT_LOW_MAH"].Value / MainSerb.comPort.MAV.param["BATT_CAPACITY"].Value * 100;
                        }
                    }
                    if (MainSerb.comPort.MAV.param.ContainsKey("BATT_CRT_VOLT")) critvolt = MainSerb.comPort.MAV.param["BATT_CRT_VOLT"].Value;
                    if (MainSerb.comPort.MAV.param.ContainsKey("BATT_CRT_MAH") && MainSerb.comPort.MAV.param.ContainsKey("BATT_CAPACITY"))
                    {
                        if (MainSerb.comPort.MAV.param["BATT_CRT_MAH"].Value > 0)
                        {
                            critpercent = MainSerb.comPort.MAV.param["BATT_CRT_MAH"].Value / MainSerb.comPort.MAV.param["BATT_CAPACITY"].Value * 100;
                        }
                    }

                    if (warnvolt == 0)
                    {
                        warnvolt = Settings.Instance.GetDouble("speechbatteryvolt");
                    }
                    if (warnpercent == 0)
                    {
                        warnpercent = Settings.Instance.GetDouble("speechbatterypercent");
                    }

                    if (critvolt == 0) critvolt = warnvolt;
                    if (critpercent == 0) critpercent = warnpercent;

                    if (MainSerb.comPort.MAV.cs.battery_voltage <= warnvolt)
                    {
                        hudSerb.lowvoltagealert = true;
                    }
                    else if ((MainSerb.comPort.MAV.cs.battery_remaining) < warnpercent)
                    {
                        hudSerb.lowvoltagealert = true;
                    }
                    else
                    {
                        hudSerb.lowvoltagealert = false;
                    }

                    if (MainSerb.comPort.MAV.cs.battery_voltage <= critvolt)
                    {
                        hudSerb.criticalvoltagealert = true;
                    }
                    else if ((MainSerb.comPort.MAV.cs.battery_remaining) < critpercent)
                    {
                        hudSerb.criticalvoltagealert = true;
                    }
                    else
                    {
                        hudSerb.criticalvoltagealert = false;
                    }

                    if (OpenGLtest.instance != null)
                    {
                        OpenGLtest.instance.rpy = new Vector3(MainSerb.comPort.MAV.cs.roll,
                            MainSerb.comPort.MAV.cs.pitch,
                            MainSerb.comPort.MAV.cs.yaw);
                        OpenGLtest.instance.LocationCenter = new PointLatLngAlt(MainSerb.comPort.MAV.cs.lat,
                            MainSerb.comPort.MAV.cs.lng, MainSerb.comPort.MAV.cs.altasl / CurrentState.multiplieralt,
                            "here");
                    }

                    // update opengltest2
                    if (OpenGLtest2.instance != null)
                    {
                        OpenGLtest2.instance.rpy = new Vector3(MainSerb.comPort.MAV.cs.roll,
                            MainSerb.comPort.MAV.cs.pitch,
                            MainSerb.comPort.MAV.cs.yaw);
                        OpenGLtest2.instance.LocationCenter = new PointLatLngAlt(MainSerb.comPort.MAV.cs.lat,
                            MainSerb.comPort.MAV.cs.lng, MainSerb.comPort.MAV.cs.altasl / CurrentState.multiplieralt,
                            "here");
                        OpenGLtest2.instance.Velocity = new Vector3(MainSerb.comPort.MAV.cs.vx, MainSerb.comPort.MAV.cs.vy,
                            MainSerb.comPort.MAV.cs.vz);
                        OpenGLtest2.instance.WPs = MainSerb.comPort.MAV.wps.Values.Select(a => (Locationwp)a).ToList();
                    }
                    //labelValGS.Text = rnd.Next(1000, 9000).ToString();
                    // update vario info
                    Vario.SetValue(MainSerb.comPort.MAV.cs.climbrate);
                    // udpate tunning tab
                    //calculateAndFill(true);
                    if (tunning.AddMilliseconds(75) < DateTime.Now && isGraphInitialized )
                    {
                        double time = (Environment.TickCount - tickStart) / 100.0;
                        if (list1item != null)
                            list1.Add(time, (list1item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list2item != null)
                            list2.Add(time, (list2item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list3item != null)
                            list3.Add(time, (list3item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list4item != null)
                            list4.Add(time, (list4item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list5item != null)
                            list5.Add(time, (list5item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list6item != null)
                            list6.Add(time, (list6item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list7item != null)
                            list7.Add(time, (list7item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list8item != null)
                            list8.Add(time, (list8item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list9item != null)
                            list9.Add(time, (list9item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list10item != null)
                            list10.Add(time, (list10item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list11item != null)
                            list11.Add(time, (list11item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list12item != null)
                            list12.Add(time, (list12item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list13item != null)
                            list13.Add(time, (list13item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list14item != null)
                            list14.Add(time, (list14item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list15item != null)
                            list15.Add(time, (list15item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list16item != null)
                            list16.Add(time, (list16item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list17item != null)
                            list17.Add(time, (list17item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list18item != null)
                            list18.Add(time, (list18item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list19item != null)
                            list19.Add(time, (list19item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                        if (list20item != null)
                            list20.Add(time, (list20item.GetValue(MainSerb.comPort.MAV.cs, null).ConvertToDouble()));
                    }



                    if (((MainSerb.comPort.BaseStream.IsOpen || MainSerb.comPort.logreadmode) &&
                             tracklast.AddSeconds(Settings.Instance.GetDouble("FD_MapUpdateDelay", 0.3)) < DateTime.Now) ||
                             tracklast.AddSeconds(2) < DateTime.Now)
                    {
                        //if (MainSerb.joystick != null && MainSerb.joystick.enabled)
                        //{
                        //    this.BeginInvoke((MethodInvoker)delegate { but_disablejoystick.Visible = true; });
                        //}

                        adsb.CurrentPosition = MainSerb.comPort.MAV.cs.HomeLocation;

                        // show proximity screen
                        if (MainSerb.comPort.MAV?.Proximity != null && MainSerb.comPort.MAV.Proximity.DataAvailable)
                        {
                            //this.BeginInvoke((MethodInvoker)delegate { new ProximityControl(MainSerb.comPort.MAV).Show(); });
                        }

                        // maintain route history length
                        if (Settings.Instance.GetBoolean("CHK_maprotation"))
                        {
                            // dont holdinvalidation here
                            setMapBearing();
                        }
                        if (route == null)
                        {
                            route = new GMapRoute(trackPoints, "track");
                            routes.Routes.Add(route);
                        }

                        PointLatLng currentloc = new PointLatLng(MainSerb.comPort.MAV.cs.lat, MainSerb.comPort.MAV.cs.lng);
                        gMapControlSerb.HoldInvalidation = true;
                        int numTrackLength = Settings.Instance.GetInt32("NUM_tracklength", 200);
                        // maintain route history length
                        if (route.Points.Count > numTrackLength)
                        {
                            route.Points.RemoveRange(0,
                                route.Points.Count - numTrackLength);
                        }
                        // add new route point
                        if (MainSerb.comPort.MAV.cs.lat != 0 && MainSerb.comPort.MAV.cs.lng != 0)
                        {
                            route.Points.Add(currentloc);
                        }

                        if (!this.IsHandleCreated)
                            continue;

                        updateRoutePosition();
                        // update programed wp course
                        if (waypoints.AddSeconds(5) < DateTime.Now)
                        {
                            //Console.WriteLine("Doing FD WP's");
                            updateClearMissionRouteMarkers();

                            var wps = MainSerb.comPort.MAV.wps.Values.ToList();
                            if (wps.Count >= 1)
                            {
                                var homeplla = new PointLatLngAlt(MainSerb.comPort.MAV.cs.HomeLocation.Lat,
                                    MainSerb.comPort.MAV.cs.HomeLocation.Lng,
                                    MainSerb.comPort.MAV.cs.HomeLocation.Alt / CurrentState.multiplieralt, "H");

                                if (homeplla.Lat == 0 && homeplla.Lng == 0)
                                {
                                    homeplla = new PointLatLngAlt(MainSerb.comPort.MAV.cs.PlannedHomeLocation.Lat,
                                        MainSerb.comPort.MAV.cs.PlannedHomeLocation.Lng,
                                        MainSerb.comPort.MAV.cs.PlannedHomeLocation.Alt / CurrentState.multiplieralt, "H");
                                }

                                var wpOverlay = new WPOverlay();

                                {
                                    List<Locationwp> mission_items;
                                    mission_items = MainSerb.comPort.MAV.wps.Values.Select(a => (Locationwp)a).ToList();
                                    mission_items.RemoveAt(0);

                                    if (wps.Count == 1)
                                    {
                                        wpOverlay.CreateOverlay(homeplla,
                                            mission_items,
                                            0 / CurrentState.multiplieralt, 0 / CurrentState.multiplieralt,
                                            CurrentState.multiplieralt);
                                    }
                                    else
                                    {
                                        wpOverlay.CreateOverlay(homeplla,
                                            mission_items,
                                            0 / CurrentState.multiplieralt, 0 / CurrentState.multiplieralt,
                                            CurrentState.multiplieralt);

                                    }
                                }

                                var existing = gMapControlSerb.Overlays.Where(a => a.Id == wpOverlay.overlay.Id).ToList();
                                foreach (var b in existing)
                                {
                                    gMapControlSerb.Overlays.Remove(b);
                                }
                                gMapControlSerb.Overlays.Insert(1, wpOverlay.overlay);

                                wpOverlay.overlay.ForceUpdate();

                                try
                                {
                                    //distanceBar.ClearWPDist();

                                    var i = -1;
                                    var travdist = 0.0;
                                    if (wpOverlay.pointlist.Count > 0)
                                    {
                                        var lastplla = wpOverlay.pointlist.Where(a => a != null).FirstOrDefault();
                                        foreach (var plla in wpOverlay.pointlist)
                                        {
                                            i++;
                                            if (plla == null)
                                                continue;

                                            var dist = lastplla.GetDistance(plla);

                                            //distanceBar1.AddWPDist((float)dist);

                                            if (i <= MainSerb.comPort.MAV.cs.wpno)
                                            {
                                                travdist += dist;
                                            }
                                        }
                                    }

                                    travdist -= MainSerb.comPort.MAV.cs.wp_dist;

                                    //if (MainSerb.comPort.MAV.cs.mode.ToUpper() == "AUTO")
                                    //distanceBar1.traveleddist = (float)travdist;

                                }
                                catch (Exception ex)
                                {
                                    log.Error(ex);
                                }
                            }

                            RegeneratePolygon();

                            // update rally points

                            rallypointoverlay.Markers.Clear();

                            foreach (var mark in MainSerb.comPort.MAV.rallypoints.Values)
                            {
                                rallypointoverlay.Markers.Add(new GMapMarkerRallyPt(new PointLatLngAlt(mark)));
                            }

                            geofence.Clear();

                            var fenceoverlay = new WPOverlay();
                            fenceoverlay.overlay.Id = "fence";

                            fenceoverlay.CreateOverlay(PointLatLngAlt.Zero,
                                MainSerb.comPort.MAV.fencepoints.Values.Select(a => (Locationwp)a).ToList(), 0, 0,
                                CurrentState.multiplieralt);

                            var fence = mymap.Overlays.Where(a => a.Id == "fence");
                            if (fence.Count() > 0)
                                mymap.Overlays.Remove(fence.First());
                            mymap.Overlays.Add(fenceoverlay.overlay);

                            fenceoverlay.overlay.ForceUpdate();

                            // optional on Flight data
                            if (MainSerb.ShowAirports)
                            {
                                // airports
                                foreach (var item in Airports.getAirports(gMapControlSerb.Position).ToArray())
                                {
                                    try
                                    {
                                        rallypointoverlay.Markers.Add(new GMapMarkerAirport(item)
                                        {
                                            ToolTipText = item.Tag,
                                            ToolTipMode = MarkerTooltipMode.OnMouseOver
                                        });
                                    }
                                    catch (Exception e)
                                    {
                                        log.Error(e);
                                    }
                                }
                            }
                            //nofly
                            NoFly.NoFly.UpdateNoFlyZone(this, gMapControlSerb.Position);

                            waypoints = DateTime.Now;

                        }

                        // add this after the mav icons are drawn
                        if (MainSerb.comPort.MAV.cs.MovingBase != null &&
                            MainSerb.comPort.MAV.cs.MovingBase != PointLatLngAlt.Zero)
                        {
                            addMissionRouteMarker(new GMarkerGoogle(currentloc, GMarkerGoogleType.blue_dot)
                            {
                                Position = MainSerb.comPort.MAV.cs.MovingBase,
                                ToolTipText = "Moving Base",
                                ToolTipMode = MarkerTooltipMode.OnMouseOver
                            });
                        }
                        // add gimbal point center
                        try
                        {
                            if (MainSerb.comPort.MAV.param.ContainsKey("MNT_STAB_TILT")
                                && MainSerb.comPort.MAV.param.ContainsKey("MNT_STAB_ROLL")
                                && MainSerb.comPort.MAV.param.ContainsKey("MNT_TYPE"))
                            {
                                float temp1 = (float)MainSerb.comPort.MAV.param["MNT_STAB_TILT"];
                                float temp2 = (float)MainSerb.comPort.MAV.param["MNT_STAB_ROLL"];

                                float temp3 = (float)MainSerb.comPort.MAV.param["MNT_TYPE"];

                                if (MainSerb.comPort.MAV.param.ContainsKey("MNT_STAB_PAN") &&
                                    // (float)MainSerb.comPort.MAV.param["MNT_STAB_PAN"] == 1 &&
                                    ((float)MainSerb.comPort.MAV.param["MNT_STAB_TILT"] == 1 &&
                                     (float)MainSerb.comPort.MAV.param["MNT_STAB_ROLL"] == 0) ||
                                    (float)MainSerb.comPort.MAV.param["MNT_TYPE"] == 4) // storm driver
                                {
                                    var marker = GimbalPoint.ProjectPoint(MainSerb.comPort);

                                    if (marker != PointLatLngAlt.Zero)
                                    {
                                        MainSerb.comPort.MAV.cs.GimbalPoint = marker;

                                        addMissionRouteMarker(new GMarkerGoogle(marker, GMarkerGoogleType.blue_dot)
                                        {
                                            ToolTipText = "Camera Target\n" + marker,
                                            ToolTipMode = MarkerTooltipMode.OnMouseOver
                                        });
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            log.Error(ex);
                        }
                        try
                        {

                            // cleanup old - no markers where added, so remove all old 
                            if (MainSerb.comPort.MAV.camerapoints.Count < photosoverlay.Markers.Count)
                                photosoverlay.Markers.Clear();
                            var min_interval = 0.0;
                            if (MainSerb.comPort.MAV.param.ContainsKey("CAM_MIN_INTERVAL"))
                                min_interval = MainSerb.comPort.MAV.param["CAM_MIN_INTERVAL"].Value / 1000.0;

                            // set fov's based on last grid calc
                            if (Settings.Instance["camera_fovh"] != null)
                            {
                                GMapMarkerPhoto.hfov = Settings.Instance.GetDouble("camera_fovh");
                                GMapMarkerPhoto.vfov = Settings.Instance.GetDouble("camera_fovv");
                            }
                            // add new - populate camera_feedback to map
                            double oldtime = double.MinValue;
                            foreach (var mark in MainSerb.comPort.MAV.camerapoints.ToArray())
                            {
                                var timesincelastshot = (mark.time_usec / 1000.0) / 1000.0 - oldtime;
                                MainSerb.comPort.MAV.cs.timesincelastshot = timesincelastshot;
                                bool contains = photosoverlay.Markers.Any(p => p.Tag.Equals(mark.time_usec));
                                if (!contains)
                                {
                                    if (timesincelastshot < min_interval)
                                        addMissionPhotoMarker(new GMapMarkerPhoto(mark, true));
                                    else
                                        addMissionPhotoMarker(new GMapMarkerPhoto(mark, false));
                                }
                                oldtime = (mark.time_usec / 1000.0) / 1000.0;
                            }
                            var GMapMarkerOverlapCount = new GMapMarkerOverlapCount(PointLatLng.Empty);
                            // age current
                            int camcount = MainSerb.comPort.MAV.camerapoints.Count;
                            int a = 0;
                            foreach (var mark in photosoverlay.Markers)
                            {
                                if (mark is GMapMarkerPhoto)
                                {
                                    if (CameraOverlap)
                                    {
                                        var marker = ((GMapMarkerPhoto)mark);
                                        // abandon roll higher than 25 degrees
                                        if (Math.Abs(marker.Roll) < 25)
                                        {
                                            GMapMarkerOverlapCount.Add(
                                                ((GMapMarkerPhoto)mark).footprintpoly);
                                        }
                                    }
                                    if (a < (camcount - 4))
                                        ((GMapMarkerPhoto)mark).drawfootprint = false;
                                    else
                                        ((GMapMarkerPhoto)mark).drawfootprint = true;
                                }

                                a++;
                            }

                            if (CameraOverlap)
                            {
                                if (!kmlpolygons.Markers.Contains(GMapMarkerOverlapCount) &&
                                    camcount > 0)
                                {
                                    kmlpolygons.Markers.Clear();
                                    kmlpolygons.Markers.Add(GMapMarkerOverlapCount);
                                }
                            }
                            else if (kmlpolygons.Markers.Contains(GMapMarkerOverlapCount))
                            {
                                kmlpolygons.Markers.OfType<GMapMarkerOverlapCount>().ToArray()
                                    .ForEach(c => kmlpolygons.Markers.Remove(c));
                            }
                        }
                        catch (Exception ex)
                        {
                            log.Error(ex);
                        }
                        // draw AIS
                        updateMarkersAsNeeded<MAVLink.mavlink_ais_vessel_t, GMapMarkerAISBoat>(AIS.Vessels, adsbais,
                            (item) => { return item.MMSI.ToString(); },
                            (marker) => { return ((MAVLink.mavlink_ais_vessel_t)marker.Tag).MMSI.ToString(); },
                            (item) =>
                            {
                                return new GMapMarkerAISBoat(new PointLatLngAlt(item.lat / 1e7, item.lon / 1e7, 0),
                                    item.heading / 100.0f)
                                {
                                    Tag = item
                                };
                            }, (item, markerin) =>
                            {
                                var marker = markerin as GMapMarkerAISBoat;
                                marker.Position = new PointLatLngAlt(item.lat / 1e7, item.lon / 1e7, 0);
                                marker.heading = item.heading / 100.0f;
                                marker.ToolTipText = "MMSI: " + item.MMSI + "\n" +
                                                     "Speed: " + (item.velocity / 100).ToString("0 m/s") + "\n" +
                                                     "TurnRate: " + (item.turn_rate / 100).ToString("0");
                                marker.ToolTipMode = MarkerTooltipMode.OnMouseOver;
                                marker.Tag = item;
                            });


                        if (route.Points.Count > 0)
                        {
                            // add primary route icon

                            // draw guide mode point for only main mav
                            if (MainSerb.comPort.MAV.cs.mode.ToLower() == "guided" &&
                                MainSerb.comPort.MAV.GuidedMode.x != 0)
                            {
                                FlightPlanner.addpolygonmarker(this, "Guided Mode", MainSerb.comPort.MAV.GuidedMode.y / 1e7,
                                    MainSerb.comPort.MAV.GuidedMode.x / 1e7, (int)MainSerb.comPort.MAV.GuidedMode.z,
                                    Color.Blue,
                                    routes);
                            }

                            // draw all icons for all connected mavs
                            foreach (var port in MainSerb.Comports.ToArray())
                            {
                                // draw the mavs seen on this port
                                foreach (var MAV in port.MAVlist)
                                {
                                    this.BeginInvokeIfRequired(() =>
                                    {
                                        var marker = Common.getMAVMarker(MAV, routes);

                                        if (marker == null || marker.Position.Lat == 0 && marker.Position.Lng == 0)
                                            return;

                                        addMissionRouteMarker(marker);
                                    });
                                }
                            }

                            if (route.Points.Count == 0 || route.Points[route.Points.Count - 1].Lat != 0 &&
                                (mapupdate.AddSeconds(3) < DateTime.Now)) //&& CHK_autopan.Checked)
                            {
                                updateMapPosition(currentloc);
                                mapupdate = DateTime.Now;
                            }

                            if (route.Points.Count == 1 && gMapControlSerb.Zoom == 3) // 3 is the default load zoom
                            {
                                updateMapPosition(currentloc);
                                updateMapZoom(17);
                            }
                        }
                        prop.Update(MainSerb.comPort.MAV.cs.HomeLocation, MainSerb.comPort.MAV.cs.Location,
                                MainSerb.comPort.MAV.cs.battery_kmleft);

                        prop.alt = MainSerb.comPort.MAV.cs.alt;
                        prop.altasl = MainSerb.comPort.MAV.cs.altasl;
                        prop.center = gMapControlSerb.Position;

                        gMapControlSerb.HoldInvalidation = false;

                        if (gMapControlSerb.Visible)
                        {
                            this.BeginInvokeIfRequired(() =>
                            {
                                gMapControlSerb.Invalidate();
                            });
                        }

                        tracklast = DateTime.Now;
                    }
                }
                catch (Exception ex)
                {
                    log.Error(ex);
                    Tracking.AddException(ex);
                    Console.WriteLine("FD Main loop exception " + ex);
                }

                //if (MainSerb.comPort.MAV.cs.xpdr_status_pending)
                //{
                //    BeginInvoke((Action)updateTransponder);
                //}
            }
            void RegeneratePolygon()
            {
                List<PointLatLng> polygonPoints = new List<PointLatLng>();

                if (routes == null)
                    return;

                foreach (GMapMarker m in polygons.Markers)
                {
                    if (m is GMapMarkerRect)
                    {
                        m.Tag = polygonPoints.Count;
                        polygonPoints.Add(m.Position);
                    }
                }

                if (polygonPoints.Count < 2)
                    return;

                GMapRoute homeroute = new GMapRoute("homepath");
                homeroute.Stroke = new Pen(Color.Yellow, 2);
                homeroute.Stroke.DashStyle = DashStyle.Dash;
                // add first point past home
                homeroute.Points.Add(polygonPoints[1]);
                // add home location
                homeroute.Points.Add(polygonPoints[0]);
                // add last point
                homeroute.Points.Add(polygonPoints[polygonPoints.Count - 1]);

                GMapRoute wppath = new GMapRoute("wp path");
                wppath.Stroke = new Pen(Color.Yellow, 4);
                wppath.Stroke.DashStyle = DashStyle.Custom;

                for (int a = 1; a < polygonPoints.Count; a++)
                {
                    wppath.Points.Add(polygonPoints[a]);
                }

                BeginInvoke((Action)delegate
                {
                    polygons.Routes.Add(homeroute);
                    polygons.Routes.Add(wppath);
                });
            }
        }
        private void setMapBearing()
        {
            BeginInvoke((Action)delegate { gMapControlSerb.Bearing = (int)((MainSerb.comPort.MAV.cs.yaw + 360) % 360); });
        }
        private void updateRoutePosition()
        {
            // not async
            BeginInvoke((Action)delegate
            {
                gMapControlSerb.UpdateRouteLocalPosition(route);


            });
        }
        private void updateBindingSource()
        {
            //  run at 20 hz.
            if (lastscreenupdate.AddMilliseconds(50) < DateTime.Now)
            {
                lock (updateBindingSourcelock)
                {
                    //if (MainSerb.comPort.MAV.cs.armed)
                    //{
                    //    if (counterArmed < 5) { mavlinkMsgViewControl1.status = "Armed"; counterArmed++; }
                    //    mavlinkMsgViewControl1.status = MainSerb.comPort.MAV.cs.mode;
                    //    mavlinkMsgViewControl1.message = MainSerb.comPort.MAV.cs.message;
                    //}
                    //else
                    //{
                    //    mavlinkMsgViewControl1.status = "DisArmed";
                    //    mavlinkMsgViewControl1.message = "Warning";
                    //}

                        //mavlinkMsgViewControl1.message = MainSerb.comPort.MAV.cs.messageHigh;
                        //string msg = MainSerb.comPort.MAV.cs.failsafe.ToString();
                        System.Diagnostics.Debug.WriteLine("##################################### Inside loop ");
                    //his is an attempt to prevent an invoke queue on the binding update on slow machines
                    if (updateBindingSourcecount > 0)
                    {
                        if (lastscreenupdate < DateTime.Now.AddSeconds(-5))
                        {
                            updateBindingSourcecount = 0;
                        }

                        return;
                    }

                    updateBindingSourcecount++;
                    //System.Diagnostics.Debug.WriteLine("#####################################  "+ Thread.CurrentThread.Name);
                    updateBindingSourceThreadName = Thread.CurrentThread.Name;
                }

                if (Disposing)
                    return;

                this.BeginInvokeIfRequired(delegate
                {
                    updateBindingSourceWork();

                    lock (updateBindingSourcelock)
                    {
                        updateBindingSourcecount--;
                    }
                });
            }
        }

        private void updateBindingSourceWork()
        {
            try
            {
                if (this.Visible)
                {
                    //Console.Write("bindingSource1 ");
                    //MainSerb.comPort.MAV.cs.UpdateCurrentSettings(bindingSource1.UpdateDataSource(MainSerb.comPort.MAV.cs));
                    //Console.Write("bindingSourceHud ");
                    
                    MainSerb.comPort.MAV.cs.UpdateCurrentSettings(
                        bindingSourceHUD.UpdateDataSource(MainSerb.comPort.MAV.cs));
                    //Console.WriteLine("DONE ");

                    //if (tabControlactions.SelectedTab == tabStatus)
                    //{
                    //    MainSerb.comPort.MAV.cs.UpdateCurrentSettings(
                    //        bindingSourceStatusTab.UpdateDataSource(MainSerb.comPort.MAV.cs));
                    //    this.tabStatus.Invalidate();
                    //}
                    //else if (tabControlactions.SelectedTab == tabQuick)
                    //{
                    //    MainSerb.comPort.MAV.cs.UpdateCurrentSettings(
                    //        bindingSourceQuickTab.UpdateDataSource(MainSerb.comPort.MAV.cs));
                    //}
                    //else if (tabControlactions.SelectedTab == tabGauges)
                    //{
                    //    MainSerb.comPort.MAV.cs.UpdateCurrentSettings(
                    //        bindingSourceGaugesTab.UpdateDataSource(MainSerb.comPort.MAV.cs));
                    //}
                    //else if (tabControlactions.SelectedTab == tabPagePreFlight)
                    //{
                    //    MainSerb.comPort.MAV.cs.UpdateCurrentSettings(
                    //        bindingSourceGaugesTab.UpdateDataSource(MainSerb.comPort.MAV.cs));
                    //}
                    //else if (tabControlactions.SelectedTab == tabPayload)
                    //{
                    //    MainSerb.comPort.MAV.cs.UpdateCurrentSettings(
                    //        bindingSourcePayloadTab.UpdateDataSource(MainSerb.comPort.MAV.cs));
                    //}
                }
                else
                {
                    //Console.WriteLine("Null Binding");
                    // MainSerb.comPort.MAV.cs.UpdateCurrentSettings(
                    //     bindingSourceHUD.UpdateDataSource(MainSerb.comPort.MAV.cs));
                }
                //if the tab detached wi have to update it 
                // if (tabQuickDetached) MainSerb.comPort.MAV.cs.UpdateCurrentSettings(bindingSourceQuickTab.UpdateDataSource(MainSerb.comPort.MAV.cs));

                lastscreenupdate = DateTime.Now;
            }
            catch (Exception ex)
            {
                // log.Error(ex);
                Tracking.AddException(ex);
            }
        }
        private void updateMapPosition(PointLatLng currentloc)
        {
            BeginInvoke((Action)delegate
            {
                try
                {
                    if (lastmapposchange.Second != DateTime.Now.Second)
                    {
                        if (Math.Abs(currentloc.Lat - gMapControlSerb.Position.Lat) > 0.0001 ||
                            Math.Abs(currentloc.Lng - gMapControlSerb.Position.Lng) > 0.0001)
                        {
                            gMapControlSerb.Position = currentloc;
                        }

                        lastmapposchange = DateTime.Now;
                    }

                    //hud1.Refresh();
                }
                catch
                {
                }
            });
        }

        private void updateMapZoom(int zoom)
        {
            BeginInvoke((Action)delegate
            {
                try
                {
                    gMapControlSerb.Zoom = zoom;
                }
                catch
                {
                }
            });
        }
        private void FlightStatus_FormClosing(object sender, FormClosingEventArgs e)
        {
            threadrun = false;

            DateTime end = DateTime.Now.AddSeconds(5);

            if (thisthreadSerb == null)
                return;

            while (thisthreadSerb.IsAlive && DateTime.Now < end)
            {
                Application.DoEvents();
            }
        }

        private void hud1_Validated(object sender, EventArgs e)
        {

        }

        private void FlightStatus_Validated(object sender, EventArgs e)
        {

        }
        protected override void OnInvalidated(InvalidateEventArgs e)
        {
            base.OnInvalidated(e);
            updateBindingSourceWork();
        }

        public void Activate()
        {
            //log.Info("Activate Called");
            OnResize(EventArgs.Empty);
            //if (CB_tuning.Checked)
            //    ZedGraphTimer.Start();
            hudSerb.altunit = CurrentState.AltUnit;
            hudSerb.speedunit = CurrentState.SpeedUnit;
            hudSerb.distunit = CurrentState.DistanceUnit;
            //coords1.AltUnit = CurrentState.AltUnit;
            // make sure the hud user items/warnings/checklist are using the current state
            HUD.Custom.src = MainSerb.comPort.MAV.cs;
            CustomWarning.defaultsrc = MainSerb.comPort.MAV.cs;
            MissionPlanner.Controls.PreFlight.CheckListItem.defaultsrc = MainSerb.comPort.MAV.cs;
            //hudSerb.doResize();


            int spliterDistance = splitMainPanel.Width - tableLayoutPanelHUD.Width;
            splitMainPanel.SplitterDistance = (spliterDistance - 28);
            //splitMainPanel.Panel2.Width = spliterDistance;
            //rjTextBox.Texts=spliterDistance.ToString();
            //splitMainPanel.IsSplitterFixed = true;
            gMapControlSerb.MapProvider = GMapProviders.BingSatelliteMap;
            if (Settings.Instance["maplast_lat"] != "")
            {
                try
                {
                    gMapControlSerb.Position = new PointLatLng(Settings.Instance.GetDouble("maplast_lat"),
                        Settings.Instance.GetDouble("maplast_lng"));
                    if (Math.Round(Settings.Instance.GetDouble("maplast_lat"), 1) == 0)
                    {
                        // no zoom in
                        //Zoomlevel.Value = 3;
                        //TRK_zoom.Value = 3;
                    }
                    else
                    {
                        var zoom = Settings.Instance.GetFloat("maplast_zoom");
                        // if (Zoomlevel.Maximum < (decimal)zoom)
                        //     zoom = (float)Zoomlevel.Maximum;
                        // Zoomlevel.Value = (decimal)zoom;
                        // TRK_zoom.Value = (float)Zoomlevel.Value;
                    }
                }
                catch
                {
                }
            }

        }
        public void Deactivate()
        {
            //if (MainSerb.MONO)
            //{
            //    hudSerb.Dock = DockStyle.None;
            //    hudSerb.Size = new Size(5, 5);
            //    hudSerb.Enabled = false;
            //    hudSerb.Visible = false;
            //}
            //throw new NotImplementedException();

            Settings.Instance["maplast_lat"] = gMapControlSerb.Position.Lat.ToString();
            Settings.Instance["maplast_lng"] = gMapControlSerb.Position.Lng.ToString();
            Settings.Instance["maplast_zoom"] = gMapControlSerb.Zoom.ToString();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void hudSerb_Resize(object sender, EventArgs e)
        {
            //Console.WriteLine("HUD resize " + hudSerb.Width + " " + hudSerb.Height); // +"\n"+ System.Environment.StackTrace);

            //if (hudSerb.Parent == this.splitMainPanel.Panel1)
            //{
            //    var ht = splitMainPanel.SplitterDistance;
            //    if (ht >= hudSerb.Height + 5 || ht <= hudSerb.Height - 5)
            //        splitMainPanel.SplitterDistance = hudSerb.Height;
            //}
        }

        private void panelRightWrapper_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitMainPanel_SplitterMoved(object sender, SplitterEventArgs e)
        {
            //rjTextBox.Texts= splitMainPanel.Panel1.Width.ToString()+" / "+splitMainPanel.Panel2.Width.ToString();

        }

        private void groupBoxModeSelection_Enter(object sender, EventArgs e)
        {

        }

        private void CMB_setwp_Click(object sender, EventArgs e)
        {

        }

        private void rjTextBox__TextChanged(object sender, EventArgs e)
        {

        }

        private void gMapControlSerb_Paint(object sender, PaintEventArgs e)
        {
            // distanceBar1.DoPaintRemote(e);
        }

        private void gMapControlSerb_OnMapZoomChanged()
        {
            lblMapZoom.Text = gMapControlSerb.Zoom.ToString();
            //try
            //{
            //    // Exception System.Runtime.InteropServices.SEHException: External component has thrown an exception.
            //    TRK_zoom.Value = (float)gMapControl1.Zoom;
            //    Zoomlevel.Value = Convert.ToDecimal(gMapControl1.Zoom);
            //}
            //catch
            //{
            //}

            //center.Position = gMapControl1.Position;
        }
        public void updateMarkersAsNeeded<TBuilder, TMarker>(IEnumerable<TBuilder> list, GMapOverlay gMapOverlay,
           Func<TBuilder, string> GetTagSource, Func<GMapMarker, string> GetTagMarker,
           Func<TBuilder, GMapMarker> create, Action<TBuilder, GMapMarker> update)
        {
            if (list == null || gMapOverlay == null || GetTagSource == null
                || GetTagMarker == null || create == null || update == null)
                return;

            var markers = gMapOverlay.Markers.ToArray();

            foreach (var item in list)
            {
                if (item == null)
                    continue;

                if (markers.Any(a => a is TMarker && GetTagMarker(a) == GetTagSource(item)))
                {
                    update(item, markers.First(a => a is TMarker && GetTagMarker(a) == GetTagSource(item)));
                }
                else
                {
                    // skip invalid tags
                    if (GetTagSource(item) == null)
                        continue;
                    // new marker
                    var marker = create(item);
                    if (marker == null)
                        continue;
                    update(item, marker);
                    BeginInvoke((Action)delegate { gMapOverlay.Markers.Add(marker); });
                }
            }
        }
        private void updateClearMissionRouteMarkers()
        {
            // not async
            BeginInvoke((Action)delegate
            {
                polygons.Routes.Clear();
                polygons.Markers.Clear();
                routes.Markers.Clear();
            });
        }
        private void gMapControlSerb_OnMarkerEnter(GMapMarker item)
        {
            CurrentGMapMarker = item;
        }

        private void gMapControlSerb_OnMarkerLeave(GMapMarker item)
        {
            CurrentGMapMarker = null;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CMB_modes1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void klcButton9_Click(object sender, EventArgs e)
        {

        }

        private void klcButton10_Click(object sender, EventArgs e)
        {

        }

        private void rjButtonStatus_Click_1(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void addMissionPhotoMarker(GMapMarker marker)
        {
            BeginInvoke((Action)delegate { photosoverlay.Markers.Add(marker); });
        }

        private void addMissionRouteMarker(GMapMarker marker)
        {
            if (marker == null) return;

            this.BeginInvokeIfRequired((Action)delegate
            {
                routes.Markers.InsertSorted(marker, Comparer<GMapMarker>.Create((a, b) =>
                {
                    var bvalue = 0;
                    if (b is GMapMarkerBoat)
                        bvalue = 0;
                    else if (b is GMapMarkerRover)
                        bvalue = 1;
                    else if (b is GMapMarkerPlane)
                        bvalue = 2;
                    else if (b is GMapMarkerQuad)
                        bvalue = 3;

                    if (a is GMapMarkerBoat)
                        return 0.CompareTo(bvalue);
                    else if (a is GMapMarkerRover)
                        return 1.CompareTo(bvalue);
                    else if (a is GMapMarkerPlane)
                        return 2.CompareTo(bvalue);
                    else if (a is GMapMarkerQuad)
                        return 3.CompareTo(bvalue);

                    return a.GetType().Name.CompareTo(b.GetType().Name);
                }));
            });
        }

        private void gMapControlSerb_OnPositionChanged(PointLatLng point)
        {
            center.Position = point;

            UpdateOverlayVisibility();
        }
        void UpdateOverlayVisibility()
        {
            // change overlay visability
            if (gMapControlSerb.ViewArea != null)
            {
                var bounds = gMapControlSerb.ViewArea;
                bounds.Inflate(1, 1);

                foreach (var poly in kmlpolygons.Polygons)
                {
                    if (bounds.Contains(poly.Points[0]))
                        poly.IsVisible = true;
                    else
                        poly.IsVisible = false;
                }
            }
        }

        private void gMapControlSerb_MouseUp(object sender, MouseEventArgs e)
        {
            var posstart = gMapControlSerb.FromLatLngToLocal(MouseDownStart);
            var MouseDownEnd = gMapControlSerb.FromLocalToLatLng(e.X, e.Y);
            Console.WriteLine("gMapControl1_MouseUp " + MouseDownEnd);

            if (gMapControlSerb.Core.IsDragging)
                return;

            if (CurrentGMapMarker != null && CurrentGMapMarker.Tag is MAVState && MouseDownStart == MouseDownEnd && Settings.Instance.GetBoolean("ClickSwapMAV", false))
            {
                var mavstate = CurrentGMapMarker.Tag as MAVState;
                if (mavstate != null)
                {
                    MainSerb.comPort = mavstate.parent;
                    MainSerb.comPort.sysidcurrent = mavstate.sysid;
                    MainSerb.comPort.compidcurrent = mavstate.compid;
                }
            }

            if (Math.Abs(posstart.X - e.X) <= 2 && Math.Abs(posstart.Y - e.Y) <= 2 && e.Button == MouseButtons.Left)
            {
                // contextMenuStripMap.Show(gMapControl1, e.Location);
            }
        }
        private void flyToHereAltToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string alt = "100";

            if (MainSerb.comPort.MAV.cs.firmware == Firmwares.ArduCopter2)
            {
                alt = (10 * CurrentState.multiplieralt).ToString("0");
            }
            else
            {
                alt = (100 * CurrentState.multiplieralt).ToString("0");
            }

            if (Settings.Instance.ContainsKey("guided_alt"))
                alt = Settings.Instance["guided_alt"];

            if (DialogResult.Cancel == InputBox.Show("Enter Alt", "Enter Guided Mode Alt", ref alt))
                return;

            Settings.Instance["guided_alt"] = alt;

            int intalt = (int)(100 * CurrentState.multiplieralt);
            if (!int.TryParse(alt, out intalt))
            {
                CustomMessageBox.Show("Bad Alt");
                return;
            }

            MainSerb.comPort.MAV.GuidedMode.z = intalt / CurrentState.multiplieralt;

            if (MainSerb.comPort.MAV.cs.mode == "Guided")
            {
                MainSerb.comPort.setGuidedModeWP(new Locationwp
                {
                    alt = MainSerb.comPort.MAV.GuidedMode.z,
                    lat = MainSerb.comPort.MAV.GuidedMode.x / 1e7,
                    lng = MainSerb.comPort.MAV.GuidedMode.y / 1e7
                });
            }
        }
        private void goHereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!MainSerb.comPort.BaseStream.IsOpen)
            {
                CustomMessageBox.Show(Strings.PleaseConnect, Strings.ERROR);
                return;
            }

            if (MainSerb.comPort.MAV.GuidedMode.z == 0f)
            {
                flyToHereAltToolStripMenuItem_Click(null, null);

                if (MainSerb.comPort.MAV.GuidedMode.z == 0f)
                    return;
            }

            if (MouseDownStart.Lat == 0.0 || MouseDownStart.Lng == 0.0)
            {
                CustomMessageBox.Show(Strings.BadCoords, Strings.ERROR);
                return;
            }

            Locationwp gotohere = new Locationwp();

            gotohere.id = (ushort)MAVLink.MAV_CMD.WAYPOINT;
            gotohere.alt = MainSerb.comPort.MAV.GuidedMode.z; // back to m
            gotohere.lat = (MouseDownStart.Lat);
            gotohere.lng = (MouseDownStart.Lng);

            try
            {
                MainSerb.comPort.setGuidedModeWP(gotohere);
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(Strings.CommandFailed + ex.Message, Strings.ERROR);
            }
        }
        private void gMapControlSerb_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownStart = gMapControlSerb.FromLocalToLatLng(e.X, e.Y);
            Console.WriteLine("gMapControl1_MouseDown " + MouseDownStart);

            if (ModifierKeys == Keys.Control)
            {
                goHereToolStripMenuItem_Click(null, null);
                return;
            }

            if (CurrentGMapMarker is GMapMarkerADSBPlane)
            {
                var marker = CurrentGMapMarker as GMapMarkerADSBPlane;
                if (marker.Tag is adsb.PointLatLngAltHdg)
                {
                    var plla = marker.Tag as adsb.PointLatLngAltHdg;
                    plla.DisplayICAO = !plla.DisplayICAO;
                }
            }
        }

        private void gMapControlSerb_MouseLeave(object sender, EventArgs e)
        {

            if (marker != null)
            {
                try
                {
                    if (routes.Markers.Contains(marker))
                        routes.Markers.Remove(marker);
                }
                catch
                {
                }
            }

        }

        private void gMapControlSerb_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                PointLatLng point = gMapControlSerb.FromLocalToLatLng(e.X, e.Y);

                double latdif = MouseDownStart.Lat - point.Lat;
                double lngdif = MouseDownStart.Lng - point.Lng;

                gMapControlSerb.Position = new PointLatLng(center.Position.Lat + latdif,
                    center.Position.Lng + lngdif);
            }
            else
            {
                // setup a ballon with home distance
                if (marker != null)
                {
                    if (routes.Markers.Contains(marker))
                        routes.Markers.Remove(marker);
                }

                if (Settings.Instance.GetBoolean("CHK_disttohomeflightdata") != false)
                {
                    PointLatLng point = gMapControlSerb.FromLocalToLatLng(e.X, e.Y);

                    marker = new GMapMarkerRect(point);
                    marker.ToolTip = new GMapToolTip(marker);
                    marker.ToolTipMode = MarkerTooltipMode.Always;
                    marker.ToolTipText = "Dist to Home: " +
                                         ((gMapControlSerb.MapProvider.Projection.GetDistance(point,
                                              MainSerb.comPort.MAV.cs.HomeLocation.Point()) * 1000) *
                                          CurrentState.multiplierdist).ToString("0");

                    routes.Markers.Add(marker);
                }
            }
        }

        private void gMapControlSerb_Click(object sender, EventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (gMapControlSerb.Zoom >= 0)
                gMapControlSerb.Zoom++;
            lblMapZoom.Text = gMapControlSerb.Zoom.ToString();
            gMapControlSerb.OnMapZoomChanged += gMapControlSerb_OnMapZoomChanged;
        }

        private void btnMapMin_Click(object sender, EventArgs e)
        {

            if (gMapControlSerb.Zoom > 0)
                gMapControlSerb.Zoom--;
            lblMapZoom.Text = gMapControlSerb.Zoom.ToString();
            gMapControlSerb.OnMapZoomChanged += gMapControlSerb_OnMapZoomChanged;
        }

        private void CMB_setwp_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void rjToggleBtnArm_CheckedChanged(object sender, EventArgs e)
        {   bool isButtonChecked = false;
            if (!MainSerb.comPort.BaseStream.IsOpen)
                return;

            // arm the MAV
            try
            {
                counterArmed = 0;
                isButtonChecked = rjToggleBtnArm.Checked;
                var isitarmed = MainSerb.comPort.MAV.cs.armed;
                var action = MainSerb.comPort.MAV.cs.armed ? "Disarm" : "Arm";

                if (isitarmed)
                    if (CustomMessageBox.Show(isButtonChecked+" Are you sure you want to " + action, action,
                            CustomMessageBox.MessageBoxButtons.YesNo) !=
                        CustomMessageBox.DialogResult.Yes)
                        return;
                StringBuilder sb = new StringBuilder();
                var sub = MainSerb.comPort.SubscribeToPacketType(MAVLink.MAVLINK_MSG_ID.STATUSTEXT, message =>
                {
                    sb.AppendLine(Encoding.ASCII.GetString(((MAVLink.mavlink_statustext_t)message.data).text)
                        .TrimEnd('\0'));
                    return true;
                }, (byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent);
                bool ans = MainSerb.comPort.doARM(!isitarmed);
                MainSerb.comPort.UnSubscribeToPacketType(sub);
                if (ans == false)
                {
                    if (CustomMessageBox.Show(
                            action + " failed.\n" + sb.ToString() + "\nForce " + action +
                            " can bypass safety checks,\nwhich can lead to the vehicle crashing\nand causing serious injuries.\n\nDo you wish to Force " +
                            action + "?", Strings.ERROR, CustomMessageBox.MessageBoxButtons.YesNo,
                            CustomMessageBox.MessageBoxIcon.Exclamation, "Force " + action, "Cancel") ==
                        CustomMessageBox.DialogResult.Yes)
                    {
                        ans = MainSerb.comPort.doARM(!isitarmed, true);
                        if (ans == false)
                        {
                            CustomMessageBox.Show(Strings.ErrorRejectedByMAV, Strings.ERROR);
                        }
                    }
                }
            }
            catch
            {
                CustomMessageBox.Show(Strings.ErrorNoResponce, Strings.ERROR);
            }


            if (rjToggleBtnArm.Checked)
            {
                MainSerb.comPort.setMode("Guided");
                //rjButtonStatus.Text = "ARMED";
                //rjButtonStatus.BackColor = Color.DarkRed;
                //rjButtonStatus.TextColor = Color.DarkGoldenrod;
            }
            else
            {
                //rjButtonStatus.Text = "DISARMED";
                //rjButtonStatus.BackColor = Color.MediumSeaGreen;
                //rjButtonStatus.TextColor = Color.WhiteSmoke;
            }
        }

        private void klcButton20_Click(object sender, EventArgs e)
        {
            try
            {
                ((Control)sender).Enabled = false;

                MainSerb.comPort.setWPCurrent(MainSerb.comPort.MAV.sysid, MainSerb.comPort.MAV.compid, 0); // set nav to
            }
            catch
            {
                CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
            }

            ((Control)sender).Enabled = true;
        }

        private void klcButtonDoAction_Click(object sender, EventArgs e)
        {
            try
            {
                if (CMB_action.Text == actions.Trigger_Camera.ToString())
                {
                    MainSerb.comPort.setDigicamControl(true);
                    return;
                }
            }
            catch
            {
                CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                return;
            }

            if (CMB_action.Text == actions.Scripting_cmd_stop_and_restart.ToString())
            {
                try
                {
                    MainSerb.comPort.doCommandInt(MainSerb.comPort.MAV.sysid, MainSerb.comPort.MAV.compid, MAVLink.MAV_CMD.SCRIPTING, (int)MAVLink.SCRIPTING_CMD.STOP_AND_RESTART, 0, 0, 0, 0, 0, 0);
                    return;
                }
                catch
                {
                    CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    return;
                }
            }

            if (CMB_action.Text == actions.Scripting_cmd_stop.ToString())
            {
                try
                {
                    MainSerb.comPort.doCommandInt(MainSerb.comPort.MAV.sysid, MainSerb.comPort.MAV.compid, MAVLink.MAV_CMD.SCRIPTING, (int)MAVLink.SCRIPTING_CMD.STOP, 0, 0, 0, 0, 0, 0);
                    return;
                }
                catch
                {
                    CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                    return;
                }
            }

            if (CMB_action.Text == actions.System_Time.ToString())
            {
                var now = DateTime.UtcNow;
                var epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                ulong time_unix_us = Convert.ToUInt64((now - epoch).TotalMilliseconds * 1000);
                try
                {
                    MainSerb.comPort.sendPacket(
                        new MAVLink.mavlink_system_time_t() { time_unix_usec = time_unix_us, time_boot_ms = 0 },
                        MainSerb.comPort.sysidcurrent, MainSerb.comPort.compidcurrent);
                }
                catch
                {
                    CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                }

                return;
            }

            if (
                CustomMessageBox.Show("Are you sure you want to do " + CMB_action.Text + " ?", "Action",
                    MessageBoxButtons.YesNo) == (int)DialogResult.Yes)
            {
                try
                {
                    ((Control)sender).Enabled = false;

                    int param1 = 0;
                    int param2 = 0;
                    int param3 = 1;

                    // request gyro
                    if (CMB_action.Text == actions.Preflight_Calibration.ToString())
                    {
                        if (MainSerb.comPort.MAV.cs.firmware == Firmwares.ArduCopter2)
                            param1 = 1; // gyro
                        param3 = 1; // baro / airspeed
                    }

                    if (CMB_action.Text == actions.Preflight_Reboot_Shutdown.ToString())
                    {
                        MainSerb.comPort.doReboot();
                        ((Control)sender).Enabled = true;
                        return;
                    }
                    if (CMB_action.Text == actions.HighLatency_Enable.ToString())
                    {
                        MainSerb.comPort.doHighLatency(true);
                        ((Control)sender).Enabled = true;
                        return;
                    }
                    if (CMB_action.Text == actions.HighLatency_Disable.ToString())
                    {
                        MainSerb.comPort.doHighLatency(false);
                        ((Control)sender).Enabled = true;
                        return;
                    }

                    if (CMB_action.Text == actions.Battery_Reset.ToString())
                    {
                        param1 = 0xff; // batt 1
                        param2 = 100; // 100%
                        param3 = 0;
                    }

                    MAVLink.MAV_CMD cmd;
                    try
                    {
                        cmd = (MAVLink.MAV_CMD)Enum.Parse(typeof(MAVLink.MAV_CMD), CMB_action.Text.ToUpper());
                    }
                    catch (ArgumentException ex)
                    {
                        cmd = (MAVLink.MAV_CMD)Enum.Parse(typeof(MAVLink.MAV_CMD),
                            "DO_START_" + CMB_action.Text.ToUpper());
                    }

                    if (MainSerb.comPort.doCommand(cmd, param1, param2, param3, 0, 0, 0, 0))
                    {

                    }
                    else
                    {
                        CustomMessageBox.Show(Strings.CommandFailed + " " + cmd, Strings.ERROR);
                    }
                }
                catch
                {
                    CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
                }

                ((Control)sender).Enabled = true;
            }
        }

        private void klcButtonSetWP_Click(object sender, EventArgs e)
        {
            try
            {
                ((Control)sender).Enabled = false;
                MainSerb.comPort.setWPCurrent(MainSerb.comPort.MAV.sysid, MainSerb.comPort.MAV.compid,
                    (ushort)CMB_setwp.SelectedIndex); // set nav to
            }
            catch
            {
                CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
            }

            ((Control)sender).Enabled = true;
        }

        private void klcButtonSetMode_Click(object sender, EventArgs e)
        {
            if (MainSerb.comPort.MAV.cs.failsafe)
            {
                if (CustomMessageBox.Show("You are in failsafe, are you sure?", "Failsafe", MessageBoxButtons.YesNo) !=
                    (int)DialogResult.Yes)
                {
                    return;
                }
            }

            MainSerb.comPort.setMode(CMB_modes.Text);
        }

        private void klcButtonSetMount_Click(object sender, EventArgs e)
        {
            try
            {
                if (MainSerb.comPort.MAV.param.ContainsKey("MNT_MODE"))
                {
                    MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent,
                        "MNT_MODE", (int)CMB_mountmode.SelectedValue);
                }
                else
                {
                    // copter 3.3 acks with an error, but is ok
                    MainSerb.comPort.doCommand((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent,
                        MAVLink.MAV_CMD.DO_MOUNT_CONTROL, 0, 0, 0, 0, 0, 0,
                        (int)CMB_mountmode.SelectedValue);
                }
            }
            catch
            {
                CustomMessageBox.Show(Strings.ErrorNoResponce, Strings.ERROR);
            }
        }

        private void CMB_setwp_Click_1(object sender, EventArgs e)
        {
            CMB_setwp.Items.Clear();
            CMB_setwp.Items.Add("0 (Home)");
            if (MainSerb.comPort.MAV.param["CMD_TOTAL"] != null)
            {
                int wps = int.Parse(MainSerb.comPort.MAV.param["CMD_TOTAL"].ToString());
                for (int z = 1; z <= wps; z++)
                {
                    CMB_setwp.Items.Add(z.ToString());
                }
                return;
            }
            if (MainSerb.comPort.MAV.param["WP_TOTAL"] != null)
            {
                int wps = int.Parse(MainSerb.comPort.MAV.param["WP_TOTAL"].ToString());
                for (int z = 1; z <= wps; z++)
                {
                    CMB_setwp.Items.Add(z.ToString());
                }

                return;
            }
            if (MainSerb.comPort.MAV.param["MIS_TOTAL"] != null)
            {
                int wps = int.Parse(MainSerb.comPort.MAV.param["MIS_TOTAL"].ToString());
                for (int z = 1; z <= wps; z++)
                {
                    CMB_setwp.Items.Add(z.ToString());
                }
                return;
            }
            if (MainSerb.comPort.MAV.wps.Count > 0)
            {
                int wps = MainSerb.comPort.MAV.wps.Count;
                for (int z = 1; z <= wps; z++)
                {
                    CMB_setwp.Items.Add(z.ToString());
                }

                return;
            }
        }

        private void klcButtonAuto_Click(object sender, EventArgs e)
        {
            try
            {
                ((Control)sender).Enabled = false;
                MainSerb.comPort.setMode("Auto");
            }
            catch
            {
                CustomMessageBox.Show(Strings.CommandFailed, Strings.ERROR);
            }

            ((Control)sender).Enabled = true;
        }

        private void klcButton_Click(object sender, EventArgs e)
        {
            
        }

        private async void klcButtonSetAlt_ClickAsync(object sender, EventArgs e)
        {
            try
            {
                //CustomMessageBox.Show("Value: " + numericUpDownAlt.Value);
                await MainSerb.comPort.doCommandAsync(MainSerb.comPort.MAV.sysid, MainSerb.comPort.MAV.compid,
                        MAVLink.MAV_CMD.DO_CHANGE_ALTITUDE, 0, (int)numericUpDownAlt.Value, 0, 0, 0, 0, 0)
                    .ConfigureAwait(true);
            }
            catch
            {


                CustomMessageBox.Show(Strings.ErrorCommunicating, Strings.ERROR);
            }
        }

        private async void klcButtonSetSpeed_Click(object sender, EventArgs e)
        {
            try
            {
                await MainSerb.comPort.doCommandAsync(MainSerb.comPort.MAV.sysid, MainSerb.comPort.MAV.compid,
                    MAVLink.MAV_CMD.DO_CHANGE_SPEED,0,(float)numericUpDownSpeed.Value,0,0,0,0,0).ConfigureAwait(true);

            }
            catch {

                CustomMessageBox.Show(Strings.ErrorCommunicating, Strings.ERROR);
            }

            
        }

        private async void klcButtonSetLoiterRad_Click(object sender, EventArgs e)
        {
            int newrad = (int)numericUpDownLoiter.Value;

            try
            {
                MainSerb.comPort.setParam(new[] { "LOITER_RAD", "WP_LOITER_RAD" }, newrad / CurrentState.multiplierdist);
            }
            catch
            {
                CustomMessageBox.Show(Strings.ErrorCommunicating, Strings.ERROR);
            }
        }
        public void CreateChart(ZedGraphControl zgc)
        {
            if (zgc == null) throw new ArgumentNullException(nameof(zgc));

            GraphPane myPane = zgc.GraphPane;

            // Set the titles and axis labels
            myPane.Title.Text = "realtime tunning";
            myPane.XAxis.Title.Text = "Time (s)";
            myPane.YAxis.Title.Text = "Unit";
            myPane.YAxis.Title.FontSpec.Size += 2;

            // Show the x axis grid
            myPane.XAxis.MajorGrid.IsVisible = true;

            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 5;

            // Make the Y axis scale red
            myPane.YAxis.Scale.FontSpec.FontColor = Color.White;
            myPane.YAxis.Title.FontSpec.FontColor = Color.White;
            // turn off the opposite tics so the Y tics don't show up on the Y2 axis
            myPane.YAxis.MajorTic.IsOpposite = false;
            myPane.YAxis.MinorTic.IsOpposite = false;
            // Don't display the Y zero line
            myPane.YAxis.MajorGrid.IsZeroLine = true;
            // Align the Y axis labels so they are flush to the axis
            myPane.YAxis.Scale.Align = AlignP.Inside;
            // Manually set the axis range
            //myPane.YAxis.Scale.Min = -1;
            //myPane.YAxis.Scale.Max = 1;

            // Fill the axis background with a gradient
            myPane.Chart.Fill = new Fill(Color.White, Color.LightGray, 45.0f);

            // Sample at 50ms intervals
            timerZedGraph.Interval = 200;
            //timer1.Enabled = true;
            //timer1.Start();
           

            // Calculate the Axis Scale Ranges
            //zgc.AxisChange();

            tickStart = Environment.TickCount;
        }
        void updateGraph() { 
        
            zedGraph.AxisChange();
            zedGraph.Invalidate();
            zedGraph.Update();
            zedGraph.Refresh();
            //Data Enginner 
            

        }
        //Graph Test Cases
        private void calculateAndFill(bool flag) {

            double time = 0;
            float fstartDegree = 0;
           // while (flag) {
                float fscale = Convert.ToSingle(23);
                list1.Add(time, fscale * Math.Sin(Math.PI * fstartDegree / 100));
                fstartDegree++;
                time++;

                //you must update time graph
                updateGraph();
           // }

        }



        private void zedGraph_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            tuningwasrightclick = true;
            isGraphInitialized = true;
            

            if (!timerZedGraph.Enabled) { timerZedGraph.Enabled = true;
                timerZedGraph.Start();
            }
            
           var selectform = new Form
            {
                Name = "select",
                Width = 50,
                Height = 50,
                Text = "Display This",
                AutoSize = true,
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false,
                MinimizeBox = false,
                AutoScroll = true
            };

            ThemeManager.ApplyThemeTo(selectform);

            object thisBoxed = MainSerb.comPort.MAV.cs;
            Type test = thisBoxed.GetType();

            int max_length = 0;
            List<(string name, string desc)> fields = new List<(string, string)>();

            foreach (var field in test.GetProperties())
            {
                // field.Name has the field's name.
                object fieldValue = field.GetValue(thisBoxed, null); // Get value
                if (fieldValue == null)
                    continue;

                if (!fieldValue.IsNumber())
                    continue;

                if (field.Name.Contains("customfield"))
                {
                    if (CurrentState.custom_field_names.ContainsKey(field.Name))
                    {
                        string name = CurrentState.custom_field_names[field.Name];
                        max_length = Math.Max(max_length, TextRenderer.MeasureText(name, selectform.Font).Width);
                        fields.Add((field.Name, name));
                    }
                }
                else
                {
                    max_length = Math.Max(max_length, TextRenderer.MeasureText(field.Name, selectform.Font).Width);
                    fields.Add((field.Name, field.Name));
                }
            }

            max_length += 25;
            fields.Sort((a, b) =>
            {
                var ans = CurrentState.GetGroupText(a.name).CompareTo(CurrentState.GetGroupText(b.name));
                if (ans == 0) return a.Item2.CompareTo(b.Item2);
                return ans;
            });

            int col_count = (int)(Screen.FromControl(this).Bounds.Width * 0.8f) / max_length;
            int row_count = fields.Count / col_count + ((fields.Count % col_count == 0) ? 0 : 1);
            int row_height = 20;

            selectform.SuspendLayout();

            (string name, string desc) last = ("", "");

            int i = 1;
            foreach (var field in fields)
            {
                CheckBox chk_box = new CheckBox();

                ThemeManager.ApplyThemeTo(chk_box);

                if (list1item != null && list1item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list2item != null && list2item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list3item != null && list3item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list4item != null && list4item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list5item != null && list5item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list6item != null && list6item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list7item != null && list7item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list8item != null && list8item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list9item != null && list9item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list10item != null && list10item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }
                if (list11item != null && list11item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list12item != null && list12item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list13item != null && list13item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list14item != null && list14item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list15item != null && list15item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list16item != null && list16item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list17item != null && list17item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list18item != null && list18item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list19item != null && list19item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (list20item != null && list20item.Name == field.name)
                {
                    chk_box.Checked = true;
                    chk_box.BackColor = Color.Green;
                }

                if (CurrentState.GetGroupText(field.name) != CurrentState.GetGroupText(last.name))
                {
                    selectform.Controls.Add(new System.Windows.Forms.Label()
                    {
                        Text = CurrentState.GetGroupText(field.name),
                        Location = new Point(5 + (i / row_count) * (max_length + 5), 2 + (i % row_count) * row_height)
                    });
                    i++;
                }

                chk_box.Text = field.desc;
                chk_box.Name = field.name;
                chk_box.Tag = "custom";
                chk_box.Location = new Point(5 + (i / row_count) * (max_length + 5), 2 + (i % row_count) * row_height);
                chk_box.Size = new Size(120, 20);
                chk_box.CheckedChanged += chk_box_tunningCheckedChanged;
                chk_box.MouseDown += Chk_box_tunningMouseDown;
                chk_box.AutoSize = true;

                selectform.Controls.Add(chk_box);
                i++;

                last = field;
            }
            selectform.ResumeLayout();

            selectform.Shown += (o, args) =>
            {
                selectform.Controls.ForEach(a =>
                {
                    if (a is CheckBox && ((CheckBox)a).Checked)
                        ((CheckBox)a).BackColor = Color.IndianRed;
                });
            };

            selectform.Show();
        }
        private bool tuningwasrightclick=false;
        void chk_box_tunningCheckedChanged(object sender, EventArgs e)
        {
            //ThemeManager.ApplyThemeTo((Control)sender);

            if (((CheckBox)sender).Checked)
            {
                ((CheckBox)sender).BackColor = Color.IndianRed;

                if (list1item == null)
                {
                    if (setupPropertyInfo(ref list1item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list1.Clear();
                        list1curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list1, Color.Red,
                            SymbolType.HDash);
                        
                        list1curve.Tag = ((CheckBox)sender).Name;
                        if (true)
                        {
                            list1curve.Label.Text += " R";
                            list1curve.IsY2Axis = true;
                            list1curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                   
             
                else if (list2item == null)
                {
                    if (setupPropertyInfo(ref list2item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list2.Clear();
                        list2curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list2, Color.Blue,
                            SymbolType.HDash);
                        list2curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list2curve.Label.Text += " R";
                            list2curve.IsY2Axis = true;
                            list2curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list3item == null)
                {
                    if (setupPropertyInfo(ref list3item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list3.Clear();
                        list3curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list3, Color.Green,
                            SymbolType.HDash);
                        list3curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list3curve.Label.Text += " R";
                            list3curve.IsY2Axis = true;
                            list3curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list4item == null)
                {
                    if (setupPropertyInfo(ref list4item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list4.Clear();
                        list4curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list4, Color.Orange,
                            SymbolType.HDash);
                        list4curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list4curve.Label.Text += " R";
                            list4curve.IsY2Axis = true;
                            list4curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list5item == null)
                {
                    if (setupPropertyInfo(ref list5item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list5.Clear();
                        list5curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list5, Color.Yellow,
                            SymbolType.HDash);
                        list5curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list5curve.Label.Text += " R";
                            list5curve.IsY2Axis = true;
                            list5curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list6item == null)
                {
                    if (setupPropertyInfo(ref list6item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list6.Clear();
                        list6curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list6, Color.Magenta,
                            SymbolType.HDash);
                        list6curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list6curve.Label.Text += " R";
                            list6curve.IsY2Axis = true;
                            list6curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list7item == null)
                {
                    if (setupPropertyInfo(ref list7item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list7.Clear();
                        list7curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list7, Color.Purple,
                            SymbolType.None);
                        list7curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list7curve.Label.Text += " R";
                            list7curve.IsY2Axis = true;
                            list7curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list8item == null)
                {
                    if (setupPropertyInfo(ref list8item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list8.Clear();
                        list8curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list8, Color.LimeGreen,
                            SymbolType.None);
                        list8curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list8curve.Label.Text += " R";
                            list8curve.IsY2Axis = true;
                            list8curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list9item == null)
                {
                    if (setupPropertyInfo(ref list9item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list9.Clear();
                        list9curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list9, Color.Cyan,
                            SymbolType.None);
                        list9curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list9curve.Label.Text += " R";
                            list9curve.IsY2Axis = true;
                            list9curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list10item == null)
                {
                    if (setupPropertyInfo(ref list10item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list10.Clear();
                        list10curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list10, Color.Violet,
                            SymbolType.None);
                        list10curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list10curve.Label.Text += " R";
                            list10curve.IsY2Axis = true;
                            list10curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list11item == null)
                {
                    if (setupPropertyInfo(ref list11item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list11.Clear();
                        list11curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list11, Color.Violet,
                            SymbolType.None);
                        list11curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list11curve.Label.Text += " R";
                            list11curve.IsY2Axis = true;
                            list11curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list12item == null)
                {
                    if (setupPropertyInfo(ref list12item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list12.Clear();
                        list12curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list12, Color.Violet,
                            SymbolType.None);
                        list12curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list12curve.Label.Text += " R";
                            list12curve.IsY2Axis = true;
                            list12curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list13item == null)
                {
                    if (setupPropertyInfo(ref list13item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list13.Clear();
                        list13curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list13, Color.Violet,
                            SymbolType.None);
                        list13curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list13curve.Label.Text += " R";
                            list13curve.IsY2Axis = true;
                            list13curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }  
                }
                else if (list14item == null)
                {
                    if (setupPropertyInfo(ref list14item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list14.Clear();
                        list14curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list14, Color.Violet,
                            SymbolType.None);
                        list14curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list14curve.Label.Text += " R";
                            list14curve.IsY2Axis = true;
                            list14curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list15item == null)
                {
                    if (setupPropertyInfo(ref list15item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list15.Clear();
                        list15curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list15, Color.Violet,
                            SymbolType.None);
                        list15curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list15curve.Label.Text += " R";
                            list15curve.IsY2Axis = true;
                            list15curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list16item == null)
                {
                    if (setupPropertyInfo(ref list16item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list16.Clear();
                        list16curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list16, Color.Violet,
                            SymbolType.None);
                        list16curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list16curve.Label.Text += " R";
                            list16curve.IsY2Axis = true;
                            list16curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list17item == null)
                {
                    if (setupPropertyInfo(ref list17item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list17.Clear();
                        list17curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list17, Color.Violet,
                            SymbolType.None);
                        list17curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list17curve.Label.Text += " R";
                            list17curve.IsY2Axis = true;
                            list17curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list18item == null)
                {
                    if (setupPropertyInfo(ref list18item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list18.Clear();
                        list18curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list18, Color.Violet,
                            SymbolType.None);
                        list18curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list18curve.Label.Text += " R";
                            list18curve.IsY2Axis = true;
                            list18curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list19item == null)
                {
                    if (setupPropertyInfo(ref list19item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list19.Clear();
                        list19curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list19, Color.Violet,
                            SymbolType.None);
                        list19curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list19curve.Label.Text += " R";
                            list19curve.IsY2Axis = true;
                            list19curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else if (list20item == null)
                {
                    if (setupPropertyInfo(ref list20item, ((CheckBox)sender).Name, MainSerb.comPort.MAV.cs))
                    {
                        list20.Clear();
                        list20curve = zedGraph.GraphPane.AddCurve(((CheckBox)sender).Text, list20, Color.Violet,
                            SymbolType.None);
                        list20curve.Tag = ((CheckBox)sender).Name;
                        if (tuningwasrightclick)
                        {
                            list20curve.Label.Text += " R";
                            list20curve.IsY2Axis = true;
                            list20curve.YAxisIndex = 0;
                            zedGraph.GraphPane.Y2Axis.IsVisible = true;
                        }
                    }
                }
                else
                {
                    CustomMessageBox.Show("Max 20 at a time.");
                    ((CheckBox)sender).Checked = false;
                }
               
                string selected = "";
                try
                {
                    foreach (var curve in zedGraph.GraphPane.CurveList)
                    {
                        string curve_name = curve.Tag.ToString();
                        if (curve_name.Contains("customfield"))
                        {
                            curve_name += ((CheckBox)sender).Text;
                        }
                        selected = selected + curve_name + "|";
                    }
                }
                catch
                {
                }

                Settings.Instance["Tuning_Graph_Selected"] = selected;
            }
            else
            {
                ((CheckBox)sender).BackColor = Color.Transparent;

                // reset old stuff
                if (list1item != null && list1item.Name == ((CheckBox)sender).Name)
                {
                    list1item = null;
                    zedGraph.GraphPane.CurveList.Remove(list1curve);
                }

                if (list2item != null && list2item.Name == ((CheckBox)sender).Name)
                {
                    list2item = null;
                    zedGraph.GraphPane.CurveList.Remove(list2curve);
                }

                if (list3item != null && list3item.Name == ((CheckBox)sender).Name)
                {
                    list3item = null;
                    zedGraph.GraphPane.CurveList.Remove(list3curve);
                }

                if (list4item != null && list4item.Name == ((CheckBox)sender).Name)
                {
                    list4item = null;
                    zedGraph.GraphPane.CurveList.Remove(list4curve);
                }

                if (list5item != null && list5item.Name == ((CheckBox)sender).Name)
                {
                    list5item = null;
                    zedGraph.GraphPane.CurveList.Remove(list5curve);
                }

                if (list6item != null && list6item.Name == ((CheckBox)sender).Name)
                {
                    list6item = null;
                    zedGraph.GraphPane.CurveList.Remove(list6curve);
                }

                if (list7item != null && list7item.Name == ((CheckBox)sender).Name)
                {
                    list7item = null;
                    zedGraph.GraphPane.CurveList.Remove(list7curve);
                }

                if (list8item != null && list8item.Name == ((CheckBox)sender).Name)
                {
                    list8item = null;
                    zedGraph.GraphPane.CurveList.Remove(list8curve);
                }

                if (list9item != null && list9item.Name == ((CheckBox)sender).Name)
                {
                    list9item = null;
                    zedGraph.GraphPane.CurveList.Remove(list9curve);
                }

                if (list10item != null && list10item.Name == ((CheckBox)sender).Name)
                {
                    list10item = null;
                    zedGraph.GraphPane.CurveList.Remove(list10curve);
                }

                if (list11item != null && list11item.Name == ((CheckBox)sender).Name)
                {
                    list11item = null;
                    zedGraph.GraphPane.CurveList.Remove(list11curve);
                }

                if (list12item != null && list12item.Name == ((CheckBox)sender).Name)
                {
                    list12item = null;
                    zedGraph.GraphPane.CurveList.Remove(list12curve);
                }

                if (list13item != null && list13item.Name == ((CheckBox)sender).Name)
                {
                    list13item = null;
                    zedGraph.GraphPane.CurveList.Remove(list13curve);
                }

                if (list14item != null && list14item.Name == ((CheckBox)sender).Name)
                {
                    list14item = null;
                    zedGraph.GraphPane.CurveList.Remove(list14curve);
                }

                if (list15item != null && list15item.Name == ((CheckBox)sender).Name)
                {
                    list15item = null;
                    zedGraph.GraphPane.CurveList.Remove(list15curve);
                }

                if (list16item != null && list16item.Name == ((CheckBox)sender).Name)
                {
                    list16item = null;
                    zedGraph.GraphPane.CurveList.Remove(list16curve);
                }

                if (list17item != null && list17item.Name == ((CheckBox)sender).Name)
                {
                    list17item = null;
                    zedGraph.GraphPane.CurveList.Remove(list17curve);
                }

                if (list18item != null && list18item.Name == ((CheckBox)sender).Name)
                {
                    list18item = null;
                    zedGraph.GraphPane.CurveList.Remove(list18curve);
                }

                if (list19item != null && list19item.Name == ((CheckBox)sender).Name)
                {
                    list19item = null;
                    zedGraph.GraphPane.CurveList.Remove(list19curve);
                }

                if (list20item != null && list20item.Name == ((CheckBox)sender).Name)
                {
                    list20item = null;
                    zedGraph.GraphPane.CurveList.Remove(list20curve);
                }
            }
        }
        private void Chk_box_tunningMouseDown(object sender, MouseEventArgs e)
        {
            tuningwasrightclick = e.Button == MouseButtons.Right;
            if (tuningwasrightclick)
            {
                var chk = sender as CheckBox;
                if (chk != null)
                    chk.Checked = !chk.Checked;
            }
        }
        bool setupPropertyInfo(ref PropertyInfo input, string name, object source)
        {
            Type test = source.GetType();

            foreach (var field in test.GetProperties())
            {
                if (field.Name == name)
                {
                    input = field;
                    return true;
                }
            }

            return false;
        }

        private void timerZedGraph_Tick(object sender, EventArgs e)
        {
            try
            {
                // Make sure that the curvelist has at least one curve
                if (zedGraph.GraphPane.CurveList.Count <= 0)
                    return;

                // Get the first CurveItem in the graph
                LineItem curve = zedGraph.GraphPane.CurveList[0] as LineItem;
                if (curve == null)
                    return;

                // Get the PointPairList
                IPointListEdit list = curve.Points as IPointListEdit;
                // If this is null, it means the reference at curve.Points does not
                // support IPointListEdit, so we won't be able to modify it
                if (list == null)
                    return;

                // Time is measured in seconds
                double time = (Environment.TickCount - tickStart) / 100.0;

                // Keep the X scale at a rolling 30 second interval, with one
                // major step between the max X value and the end of the axis
                Scale xScale = zedGraph.GraphPane.XAxis.Scale;
                if (time > xScale.Max - xScale.MajorStep)
                {
                    xScale.Max = time + xScale.MajorStep;
                    xScale.Min = xScale.Max - 10.0;
                }

                // Make sure the Y axis is rescaled to accommodate actual data
                zedGraph.AxisChange();

                // Force a redraw
                zedGraph.Invalidate();
                zedGraph.Update();
                zedGraph.Refresh();
            }
            catch
            {
            }
        }
        int var = 20;
        bool flag = false;
        private void klcButtonZedGraph_Click(object sender, EventArgs e)
        {
            var action = MainSerb.comPort.MAV.cs.armed ? "Disarm" : "Arm";

            //flag = flag ? !false : flag;
            if (flag) flag = false;else flag= true;
            calculateAndFill(flag);
        }

        

        private void btnSwarm_Click(object sender, EventArgs e)
        {
            var form = new FormationControl();
            ThemeManager.ApplyThemeTo(form);
            form.Show();
        }

        private void btnTelem_Click(object sender, EventArgs e)
        {
            Form form = new MAVLinkInspector(MainSerb.comPort);
            ThemeManager.ApplyThemeTo(form);
            form.Show();
        }

        private void btnVideoVlc_Click(object sender, EventArgs e)
        {
            var render = new vlcrender();

            var url = render.playurl;
            if (InputBox.Show("enter url", "enter url", ref url) == DialogResult.OK)
            {
                render.playurl = url;
                try
                {
                    render.Start();
                }
                catch (Exception ex)
                {
                    CustomMessageBox.Show(ex.ToString(), Strings.ERROR);
                }
            }
        }
    }
    }
