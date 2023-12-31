﻿using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using System;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigHWCAN : MyUserControl, IActivate
    {
        public ConfigHWCAN()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            if (!MainSerb.comPort.BaseStream.IsOpen)
            {
                Enabled = false;
            }
            Enabled = true;

            mavlinkComboBox_can.setup(ParameterMetaDataRepository.GetParameterOptionsInt("BRD_CAN_ENABLE",
                MainSerb.comPort.MAV.cs.firmware.ToString()), "BRD_CAN_ENABLE", MainSerb.comPort.MAV.param);
        }


        private void but_startenum_Click(object sender, EventArgs e)
        {
            MainSerb.comPort.doCommand((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, MAVLink.MAV_CMD.PREFLIGHT_UAVCAN, 1, 0, 0, 0, 0, 0, 0, false);
        }

        private void but_stopenum_Click(object sender, EventArgs e)
        {
            MainSerb.comPort.doCommand((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, MAVLink.MAV_CMD.PREFLIGHT_UAVCAN, 0, 0, 0, 0, 0, 0, 0, false);
        }

        private void but_saveconfig_Click(object sender, EventArgs e)
        {
            MainSerb.comPort.doCommand((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, MAVLink.MAV_CMD.PREFLIGHT_STORAGE, 1, 0, 0, 0, 0, 0, 0, false);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            but_factoryreset.Enabled = checkBox1.Checked;
        }

        private void but_factoryreset_Click(object sender, EventArgs e)
        {
            MainSerb.comPort.doCommand((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, MAVLink.MAV_CMD.PREFLIGHT_STORAGE, 2, 0, 0, 0, 0, 0, 0, false);
        }

        private void mavlinkComboBox_can_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}