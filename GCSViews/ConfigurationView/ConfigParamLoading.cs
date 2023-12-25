using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MissionPlanner.Controls;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigParamLoading : UserControl, IActivate, IDeactivate
    {
        public bool gotAllParams
        {
            get
            {
                if (MainSerb.comPort.MAV.param.TotalReceived < MainSerb.comPort.MAV.param.TotalReported)
                {
                    return false;
                }

                return true;
            }
        }

        public ConfigParamLoading()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            timer1.Start();
        }

        public void Deactivate()
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (gotAllParams)
                MainSerb.View.Reload();
        }

        private void but_forceparams_Click(object sender, EventArgs e)
        {
            MainSerb.comPort.getParamList();
        }
    }
}
