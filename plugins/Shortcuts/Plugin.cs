using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MissionPlanner.Utilities;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using MissionPlanner;

namespace Shortcuts
{
    public class Plugin : MissionPlanner.Plugin.Plugin
    {
       
        public override string Name
        {
            get { return "Shortcuts"; }
        }

        public override string Version
        {
            get { return "0.1"; }
        }

        public override string Author
        {
            get { return "Michael Oborne"; }
        }

        //[DebuggerHidden]
        public override bool Init()
        {
            MainSerb.instance.ProcessCmdKeyCallback += this.Instance_ProcessCmdKeyCallback;

            return true;
        }

        private bool Instance_ProcessCmdKeyCallback(ref System.Windows.Forms.Message msg, System.Windows.Forms.Keys keyData)
        {
            if (keyData == (Keys.Alt | Keys.A))
            {
                MainSerb.comPort.setMode("Auto");
                return true;
            }
            if (keyData == (Keys.Alt | Keys.G))
            {
                MainSerb.comPort.setMode("Loiter");
                return true;
            }
            if (keyData == (Keys.Alt | Keys.U))
            {
                MainSerb.comPort.setMode("AltHold");
                return true;
            }
            if (keyData == (Keys.Alt | Keys.S))
            {
                MainSerb.comPort.setMode("Stabalize");
                return true;
            }
            if (keyData == (Keys.Alt | Keys.H))
            {
                MainSerb.comPort.setMode("RTL");
                return true;
            }

            if (keyData == (Keys.Alt | Keys.T))
            {
                MainSerb.comPort.doCommand((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, MAVLink.MAV_CMD.TAKEOFF, 0, 0, 0, 0, 0, 0, 2);
                return true;
            }
            if (keyData == (Keys.Alt | Keys.L))
            {
                MainSerb.comPort.doCommand((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, MAVLink.MAV_CMD.LAND, 0, 0, 0, 0, 0, 0, 0);
                return true;
            }

            if (keyData == (Keys.Alt | Keys.D0))
            {
                MainSerb.comPort.SendRCOverride(MainSerb.comPort.MAV.sysid, MainSerb.comPort.MAV.compid, 0, 0, 1000, 0, 0, 0,
                    0, 0);
                return true;
            }

            if (keyData == (Keys.Alt | Keys.F1))
            {
                //MainSerb.comPort.doCommand((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, MAVLink.MAV_CMD.DO_SET_SERVO, 1, MainSerb.comPort.MAV., 0, 0, 0, 0, 0, true);
                return true;
            }

            return false;
        }

        public override bool Loaded()
        {
            return true;
        }

        public override bool Loop()
        {
            return true;
        }

        public override bool Exit()
        {
            return true;
        }
    }
}
