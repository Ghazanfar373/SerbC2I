using log4net;
using MissionPlanner.ArduPilot;
using MissionPlanner.Controls;
using MissionPlanner.Controls.BackstageView;
using MissionPlanner.GCSViews.ConfigurationView;
using MissionPlanner.Radio;
using MissionPlanner.Utilities;
using System;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews
{
    public partial class InitialSetup : MyUserControl, IActivate
    {
        internal static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private static string lastpagename = "";

        public InitialSetup()
        {
            InitializeComponent();
        }

        public bool isConnected
        {
            get { return MainSerb.comPort.BaseStream.IsOpen; }
        }

        public bool isDisConnected
        {
            get { return !MainSerb.comPort.BaseStream.IsOpen; }
        }

        public bool isTracker
        {
            get { return isConnected && MainSerb.comPort.MAV.cs.firmware == Firmwares.ArduTracker; }
        }

        public bool isCopter
        {
            get { return isConnected && MainSerb.comPort.MAV.cs.firmware == Firmwares.ArduCopter2; }
        }

        public bool isCopter35plus
        {
            get { return MainSerb.comPort.MAV.cs.version >= Version.Parse("3.5"); }
        }

        public bool isHeli
        {
            get { return isConnected && MainSerb.comPort.MAV.aptype == MAVLink.MAV_TYPE.HELICOPTER; }
        }

        public bool isQuadPlane
        {
            get
            {
                return isConnected && isPlane &&
                       MainSerb.comPort.MAV.param.ContainsKey("Q_ENABLE") &&
                       (MainSerb.comPort.MAV.param["Q_ENABLE"].Value == 1.0);
            }
        }

        public bool isPlane
        {
            get
            {
                return isConnected &&
                       (MainSerb.comPort.MAV.cs.firmware == Firmwares.ArduPlane ||
                        MainSerb.comPort.MAV.cs.firmware == Firmwares.Ateryx);
            }
        }

        public bool isRover
        {
            get { return isConnected && MainSerb.comPort.MAV.cs.firmware == Firmwares.ArduRover; }
        }

        public bool gotAllParams
        {
            get
            {
                log.InfoFormat("TotalReceived {0} TotalReported {1}", MainSerb.comPort.MAV.param.TotalReceived,
                    MainSerb.comPort.MAV.param.TotalReported);
                if (MainSerb.comPort.MAV.param.TotalReceived < MainSerb.comPort.MAV.param.TotalReported)
                {
                    return false;
                }

                return true;
            }
        }

        private BackstageViewPage AddBackstageViewPage(Type userControl, string headerText, bool enabled = true,
    BackstageViewPage Parent = null, bool advanced = false)
        {
            try
            {
                if (enabled)
                    return backstageView.AddPage(userControl, headerText, Parent, advanced);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                return null;
            }

            return null;
        }

        public void Activate()
        {
        }

        private void HardwareConfig_Load(object sender, EventArgs e)
        {
            ResourceManager rm = new ResourceManager(this.GetType());

            if (!gotAllParams)
            {
                if (MainSerb.comPort.BaseStream.IsOpen)
                    AddBackstageViewPage(typeof(ConfigParamLoading), Strings.Loading);
            }

            if (MainSerb.DisplayConfiguration.displayInstallFirmware)
            {
                // if (!Program.WindowsStoreApp)
                {
                    AddBackstageViewPage(typeof(ConfigFirmwareDisabled), rm.GetString("backstageViewPagefw.Text"),
                        isConnected);
                    AddBackstageViewPage(typeof(ConfigFirmwareManifest), rm.GetString("backstageViewPagefw.Text"),
                        isDisConnected);
                    AddBackstageViewPage(typeof(ConfigFirmware), rm.GetString("backstageViewPagefw.Text") + " Legacy",
                        isDisConnected);
                }
            }

            AddBackstageViewPage(typeof(ConfigSecure), "Secure",
                isDisConnected);


            var mand = AddBackstageViewPage(typeof(ConfigMandatory), rm.GetString("backstageViewPagemand.Text"), isConnected && gotAllParams);

            if (MainSerb.DisplayConfiguration.displayFrameType)
            {
                //AddBackstageViewPage(typeof(ConfigTradHeli), rm.GetString("backstageViewPagetradheli.Text"), isHeli && gotAllParams, mand);
                AddBackstageViewPage(typeof(ConfigTradHeli4), rm.GetString("backstageViewPagetradheli.Text"), isHeli && gotAllParams, mand);
                AddBackstageViewPage(typeof(ConfigFrameType), rm.GetString("backstageViewPageframetype.Text"), isCopter && gotAllParams && !isCopter35plus, mand);
                AddBackstageViewPage(typeof(ConfigFrameClassType), rm.GetString("backstageViewPageframetype.Text"),
                    MainSerb.comPort.MAV.param.ContainsKey("FRAME_CLASS") || isCopter && gotAllParams && isCopter35plus,
                    mand);
            }

            if ((isCopter || isQuadPlane) && MainSerb.DisplayConfiguration.displayInitialParams)
            {
                AddBackstageViewPage(typeof(ConfigInitialParams), rm.GetString("backstageViewPageInitialParams.Text"), isConnected && gotAllParams, mand);
            }


            if (MainSerb.DisplayConfiguration.displayAccelCalibration)
            {
                AddBackstageViewPage(typeof(ConfigAccelerometerCalibration), rm.GetString("backstageViewPageaccel.Text"), isConnected && gotAllParams, mand);
            }


            if (MainSerb.DisplayConfiguration.displayCompassConfiguration)
            {
                if (MainSerb.comPort.MAV.param.ContainsKey("COMPASS_PRIO1_ID"))
                    AddBackstageViewPage(typeof(ConfigHWCompass2), rm.GetString("backstageViewPagecompass.Text"),
                        isConnected && gotAllParams, mand);
                else
                    AddBackstageViewPage(typeof(ConfigHWCompass), rm.GetString("backstageViewPagecompass.Text"),
                        isConnected && gotAllParams, mand);
            }

            if (MainSerb.DisplayConfiguration.displayRadioCalibration)
            {
                AddBackstageViewPage(typeof(ConfigRadioInput), rm.GetString("backstageViewPageradio.Text"), isConnected && gotAllParams, mand);
            }
            if (MainSerb.DisplayConfiguration.displayServoOutput)
            {
                AddBackstageViewPage(typeof(ConfigRadioOutput), "Servo Output", isConnected && gotAllParams, mand);

            }
            if (MainSerb.DisplayConfiguration.displayEscCalibration)
            {
                AddBackstageViewPage(typeof(ConfigESCCalibration), "ESC Calibration", isConnected && gotAllParams, mand);
            }
            if (MainSerb.DisplayConfiguration.displayFlightModes)
            {
                AddBackstageViewPage(typeof(ConfigFlightModes), rm.GetString("backstageViewPageflmode.Text"), isConnected && gotAllParams, mand);
            }
            if (MainSerb.DisplayConfiguration.displayFailSafe)
            {
                AddBackstageViewPage(typeof(ConfigFailSafe), rm.GetString("backstageViewPagefs.Text"), isConnected && gotAllParams, mand);
            }

            if (MainSerb.DisplayConfiguration.displayHWIDs)
                AddBackstageViewPage(typeof(ConfigHWIDs), "HW ID", isConnected && gotAllParams, mand);

            var opt = AddBackstageViewPage(typeof(ConfigOptional), rm.GetString("backstageViewPageopt.Text"));
            if (MainSerb.DisplayConfiguration.displayRTKInject)
            {
                AddBackstageViewPage(typeof(ConfigSerialInjectGPS), "RTK/GPS Inject", true, opt);
            }

            if (MainSerb.DisplayConfiguration.displaySikRadio)
            {
                AddBackstageViewPage(typeof(Sikradio), rm.GetString("backstageViewPageSikradio.Text"), true, opt);
            }

            if (MainSerb.DisplayConfiguration.displayADSB)
                AddBackstageViewPage(typeof(ConfigADSB), "ADSB", isConnected && gotAllParams, mand);

            if (MainSerb.DisplayConfiguration.displayGPSOrder)
                AddBackstageViewPage(typeof(ConfigGPSOrder), "CAN GPS Order", isConnected && gotAllParams, opt);

            if (MainSerb.DisplayConfiguration.displayBattMonitor)
            {
                AddBackstageViewPage(typeof(ConfigBatteryMonitoring), rm.GetString("backstageViewPagebatmon.Text"), isConnected && gotAllParams, opt);
                AddBackstageViewPage(typeof(ConfigBatteryMonitoring2), rm.GetString("backstageViewPageBatt2.Text"), isConnected && gotAllParams, opt);
            }
            if (MainSerb.DisplayConfiguration.displayCAN)
            {
                //AddBackstageViewPage(typeof(ConfigHWCAN), "CAN", isConnected, opt);
                AddBackstageViewPage(typeof(ConfigDroneCAN), "DroneCAN/UAVCAN", true, opt);
            }
            if (MainSerb.DisplayConfiguration.displayJoystick)
            {
                AddBackstageViewPage(typeof(Joystick.JoystickSetup), "Joystick", true, opt);
            }

            if (MainSerb.DisplayConfiguration.displayCompassMotorCalib)
            {
                AddBackstageViewPage(typeof(ConfigCompassMot), rm.GetString("backstageViewPagecompassmot.Text"), isConnected && gotAllParams, opt);
            }
            if (MainSerb.DisplayConfiguration.displayRangeFinder)
            {
                AddBackstageViewPage(typeof(ConfigHWRangeFinder), rm.GetString("backstageViewPagesonar.Text"), isConnected && gotAllParams, opt);
            }
            if (MainSerb.DisplayConfiguration.displayAirSpeed)
            {
                AddBackstageViewPage(typeof(ConfigHWAirspeed), rm.GetString("backstageViewPageairspeed.Text"), isConnected && gotAllParams, opt);
            }
            if (MainSerb.DisplayConfiguration.displayPx4Flow)
            {
                AddBackstageViewPage(typeof(ConfigHWPX4Flow), rm.GetString("backstageViewPagePX4Flow.Text"), true, opt);
            }
            if (MainSerb.DisplayConfiguration.displayOpticalFlow)
            {
                AddBackstageViewPage(typeof(ConfigHWOptFlow), rm.GetString("backstageViewPageoptflow.Text"), isConnected && gotAllParams, opt);
            }
            if (MainSerb.DisplayConfiguration.displayOsd)
            {
                AddBackstageViewPage(typeof(ConfigHWOSD), rm.GetString("backstageViewPageosd.Text"), isConnected && gotAllParams, opt);
            }
            if (MainSerb.DisplayConfiguration.displayCameraGimbal)
            {
                AddBackstageViewPage(typeof(ConfigMount), rm.GetString("backstageViewPagegimbal.Text"), isConnected && gotAllParams, opt);
            }
            if (MainSerb.DisplayConfiguration.displayAntennaTracker)
            {
                AddBackstageViewPage(typeof(ConfigAntennaTracker), rm.GetString("backstageViewPageAntTrack.Text"), isTracker, opt);
            }
            if (MainSerb.DisplayConfiguration.displayMotorTest)
            {
                AddBackstageViewPage(typeof(ConfigMotorTest), rm.GetString("backstageViewPageMotorTest.Text"), isConnected && gotAllParams, opt);
            }
            if (MainSerb.DisplayConfiguration.displayBluetooth)
            {
                AddBackstageViewPage(typeof(ConfigHWBT), rm.GetString("backstageViewPagehwbt.Text"), true, opt);
            }
            if (MainSerb.DisplayConfiguration.displayParachute)
            {
                AddBackstageViewPage(typeof(ConfigHWParachute), rm.GetString("backstageViewPageParachute.Text"), isConnected && gotAllParams, opt);
            }
            if (MainSerb.DisplayConfiguration.displayEsp)
            {
                AddBackstageViewPage(typeof(ConfigHWESP8266), rm.GetString("backstageViewPageESP.Text"), isConnected && gotAllParams, opt);
            }
            if (MainSerb.DisplayConfiguration.displayAntennaTracker)
            {
                AddBackstageViewPage(typeof(Antenna.TrackerUI), "Antenna Tracker", true, opt);
            }
            if (MainSerb.DisplayConfiguration.displayFFTSetup)
            {
                AddBackstageViewPage(typeof(ConfigFFT), "FFT Setup", isConnected && gotAllParams, opt);
            }

            if (MainSerb.DisplayConfiguration.isAdvancedMode)
            {
                var adv = AddBackstageViewPage(typeof(ConfigAdvanced), "Advanced");

                AddBackstageViewPage(typeof(ConfigTerminal), "Terminal", true, adv);

                AddBackstageViewPage(typeof(ConfigREPL), "Script REPL", isConnected, adv);
            }

            // remeber last page accessed
            foreach (BackstageViewPage page in backstageView.Pages)
            {
                if (page.LinkText == lastpagename && page.Show)
                {
                    backstageView.ActivatePage(page);
                    break;
                }
            }

            ThemeManager.ApplyThemeTo(this);
        }

        private void HardwareConfig_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (backstageView.SelectedPage != null)
                lastpagename = backstageView.SelectedPage.LinkText;

            backstageView.Close();
        }
    }
}