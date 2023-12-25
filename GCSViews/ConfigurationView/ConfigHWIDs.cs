using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigHWIDs : MyUserControl, IActivate
    {
        public ConfigHWIDs()
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

            var list = MainSerb.comPort.MAV.param.Where(a => (a.Name.Contains("_ID") || a.Name.Contains("_DEVID")) && !a.Name.Contains("_IDX") && !a.Name.Contains("FRSKY"))
                .Select((a, b) => new DeviceInfo(b, a.Name, (uint) a.Value))
                .OrderBy((a) => a.ParamName).ToList();

            var bs = new BindingSource();
            bs.DataSource = list;
            myDataGridView1.DataSource = bs;
        }

    }
}