﻿using MissionPlanner.Controls;
using System;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigHWOSD : MyUserControl, IActivate
    {
        public ConfigHWOSD()
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
        }

        private void BUT_osdrates_Click(object sender, EventArgs e)
        {
            /*
SR0_EXT_STAT,0
SR0_EXTRA1,0
SR0_EXTRA2,0
SR0_EXTRA3,0
SR0_PARAMS,50
SR0_POSITION,0
SR0_RAW_CTRL,0
SR0_RAW_SENS,0
SR0_RC_CHAN,0
    */
            try
            {
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR0_EXT_STAT", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR0_EXTRA1", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR0_EXTRA2", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR0_EXTRA3", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR0_POSITION", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR0_RAW_CTRL", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR0_RAW_SENS", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR0_RC_CHAN", 2);

                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR1_EXT_STAT", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR1_EXTRA1", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR1_EXTRA2", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR1_EXTRA3", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR1_POSITION", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR1_RAW_CTRL", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR1_RAW_SENS", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR1_RC_CHAN", 2);

                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR3_EXT_STAT", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR3_EXTRA1", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR3_EXTRA2", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR3_EXTRA3", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR3_POSITION", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR3_RAW_CTRL", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR3_RAW_SENS", 2);
                MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "SR3_RC_CHAN", 2);
            }
            catch
            {
                CustomMessageBox.Show("Failed to set OSD rates.");
            }
        }
    }
}