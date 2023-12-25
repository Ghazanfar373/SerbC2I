using MissionPlanner.Controls;
using System;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigHWOptFlow : MyUserControl, IActivate
    {
        private bool startup;

        public ConfigHWOptFlow()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            if (!MainSerb.comPort.BaseStream.IsOpen)
            {
                Enabled = false;
                return;
            }
            Enabled = true;

            startup = true;


            CHK_enableoptflow.setup(1, 0, "FLOW_ENABLE", MainSerb.comPort.MAV.param);

            startup = false;
        }

        private void CHK_enableoptflow_CheckedChanged(object sender, EventArgs e)
        {
            if (startup)
                return;
            try
            {
                if (MainSerb.comPort.MAV.param["FLOW_ENABLE"] == null)
                {
                    CustomMessageBox.Show("Not Available on " + MainSerb.comPort.MAV.cs.firmware);
                }
                else
                {
                    MainSerb.comPort.setParam((byte)MainSerb.comPort.sysidcurrent, (byte)MainSerb.comPort.compidcurrent, "FLOW_ENABLE", ((CheckBox)sender).Checked ? 1 : 0);
                }
            }
            catch
            {
                CustomMessageBox.Show("Set FLOW_ENABLE Failed");
            }
        }
    }
}