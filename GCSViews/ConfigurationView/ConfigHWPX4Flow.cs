﻿using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigHWPX4Flow : MyUserControl, IActivate, IDeactivate
    {
        bool focusmode = false;

        OpticalFlow _flow = null;

        public ConfigHWPX4Flow()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            if (!MainSerb.comPort.BaseStream.IsOpen && !MainSerb.comPort.logreadmode)
            {
                Enabled = false;
                return;
            }

            Enabled = true;

            _flow = new OpticalFlow(MainSerb.comPort, (byte)MainSerb.comPort.sysidcurrent,
                (byte)MainSerb.comPort.compidcurrent);

            // setup bitmap to screen
            _flow.newImage += (s, eh) =>
            {
                imagebox.Image = eh.Image.ToSKImage().ToBitmap();
            };
        }

        private void but_focusmode_Click(object sender, EventArgs e)
        {
            focusmode = !focusmode;
            _flow.CalibrationMode(focusmode);
        }

        public void Deactivate()
        {
            if (_flow != null)
            {
                _flow.CalibrationMode(false);
                _flow.Close();
            }
        }
    }
}