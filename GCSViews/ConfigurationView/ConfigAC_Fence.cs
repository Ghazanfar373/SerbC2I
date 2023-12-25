using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigAC_Fence : MyUserControl, IActivate
    {
        public ConfigAC_Fence()
        {
            InitializeComponent();

            label6maxalt.Text += "[" + CurrentState.DistanceUnit + "]";
            label8minalt.Text += "[" + CurrentState.DistanceUnit + "]";
            label7maxrad.Text += "[" + CurrentState.DistanceUnit + "]";
            label2rtlalt.Text += "[" + CurrentState.DistanceUnit + "]";
        }

        public void Activate()
        {
            mavlinkCheckBox1.setup(1, 0, "FENCE_ENABLE", MainSerb.comPort.MAV.param, null, () => { if (mavlinkCheckBox1.Checked) MainSerb.comPort.getParamList(); });

            mavlinkComboBox1.setup(
                ParameterMetaDataRepository.GetParameterOptionsInt("FENCE_TYPE",
                    MainSerb.comPort.MAV.cs.firmware.ToString()), "FENCE_TYPE", MainSerb.comPort.MAV.param);


            mavlinkComboBox2.setup(
                ParameterMetaDataRepository.GetParameterOptionsInt("FENCE_ACTION",
                    MainSerb.comPort.MAV.cs.firmware.ToString()), "FENCE_ACTION", MainSerb.comPort.MAV.param);


            // 3
            mavlinkNumericUpDown1.setup(10, 1000, (float)CurrentState.fromDistDisplayUnit(1), 1, "FENCE_ALT_MAX",
                MainSerb.comPort.MAV.param);

            mavlinkNumericUpDown4.setup(-100, 100, (float)CurrentState.fromDistDisplayUnit(1), 1, "FENCE_ALT_MIN",
                MainSerb.comPort.MAV.param);

            mavlinkNumericUpDown2.setup(30, 65536, (float)CurrentState.fromDistDisplayUnit(1), 1, "FENCE_RADIUS",
                MainSerb.comPort.MAV.param);

            mavlinkNumericUpDown3.setup(1, 500, (float)CurrentState.fromDistDisplayUnit(100), 1, "RTL_ALT",
                MainSerb.comPort.MAV.param);
        }
    }
}