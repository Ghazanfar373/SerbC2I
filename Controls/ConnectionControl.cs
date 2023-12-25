using MissionPlanner.Comms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class ConnectionControl : UserControl
    {
        public ConnectionControl()
        {
            InitializeComponent();
            this.linkLabel1.Click += (sender, e) =>
            {
                ShowLinkStats?.Invoke(this, EventArgs.Empty);
            };
        }

        public event EventHandler ShowLinkStats;

        public ComboBox CMB_baudrate
        {
            get { return this.cmb_Baud; }
        }

        public ComboBox CMB_serialport
        {
            get { return this.cmb_Connection; }
        }


        /// <summary>
        /// Called from the main form - set whether we are connected or not currently.
        /// UI will be updated accordingly
        /// </summary>
        /// <param name="isConnected">Whether we are connected</param>
        public void IsConnected(bool isConnected)
        {
            //this.linkLabel1.Visible = isConnected;
            //cmb_Baud.Enabled = !isConnected;
            //cmb_Connection.Enabled = !isConnected;

            UpdateSysIDS();
        }

        private void ConnectionControl_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void cmb_Connection_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0)
                return;

            ComboBox combo = sender as ComboBox;
            if ((e.State & DrawItemState.Selected) == DrawItemState.Selected)
                e.Graphics.FillRectangle(new SolidBrush(SystemColors.Highlight),
                    e.Bounds);
            else
                e.Graphics.FillRectangle(new SolidBrush(combo.BackColor),
                    e.Bounds);

            string text = combo.Items[e.Index].ToString();
            if (!MainSerb.MONO)
            {
                text = text + " " + SerialPort.GetNiceName(text);
            }

            e.Graphics.DrawString(text, e.Font,
                new SolidBrush(combo.ForeColor),
                new Point(e.Bounds.X, e.Bounds.Y));

            e.DrawFocusRectangle();
        }

        public void UpdateSysIDS()
        {
            cmb_sysid.SelectedIndexChanged -= CMB_sysid_SelectedIndexChanged;

            var oldidx = cmb_sysid.SelectedIndex;

            cmb_sysid.Items.Clear();

            int selectidx = -1;

            foreach (var port in MainSerb.Comports.ToArray())
            {
                var list = port.MAVlist.GetRawIDS();

                foreach (int item in list)
                {
                    var temp = new port_sysid() { compid = (item % 256), sysid = (item / 256), port = port };

                    // exclude GCS's from the list
                    if (temp.compid == (int)MAVLink.MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER)
                        continue;

                    var idx = cmb_sysid.Items.Add(temp);

                    if (temp.port == MainSerb.comPort && temp.sysid == MainSerb.comPort.sysidcurrent && temp.compid == MainSerb.comPort.compidcurrent)
                    {
                        selectidx = idx;
                    }
                }
            }

            if (/*oldidx == -1 && */ selectidx != -1)
            {
                cmb_sysid.SelectedIndex = selectidx;
            }

            cmb_sysid.SelectedIndexChanged += CMB_sysid_SelectedIndexChanged;
        }

        internal struct port_sysid
        {
            internal MAVLinkInterface port;
            internal int sysid;
            internal int compid;
        }

        private void CMB_sysid_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmb_sysid.SelectedItem == null)
                return;

            var temp = (port_sysid)cmb_sysid.SelectedItem;

            foreach (var port in MainSerb.Comports)
            {
                if (port == temp.port)
                {
                    MainSerb.comPort = port;
                    MainSerb.comPort.sysidcurrent = temp.sysid;
                    MainSerb.comPort.compidcurrent = temp.compid;

                    if (MainSerb.comPort.MAV.param.TotalReceived < MainSerb.comPort.MAV.param.TotalReported && 
                        /*MainSerb.comPort.MAV.compid == (byte)MAVLink.MAV_COMPONENT.MAV_COMP_ID_AUTOPILOT1 && */
                        !(Control.ModifierKeys == Keys.Control))
                        MainSerb.comPort.getParamList();

                    MainSerb.View.Reload();
                }
            }
        }

        private void cmb_sysid_Format(object sender, ListControlConvertEventArgs e)
        {
            var temp = (port_sysid)e.Value;
            MAVLink.MAV_COMPONENT compid = (MAVLink.MAV_COMPONENT)temp.compid;
            string mavComponentHeader = "MAV_COMP_ID_";
            string mavComponentString = null;

            foreach (var port in MainSerb.Comports)
            {
                if (port == temp.port)
                {
                    if (compid == (MAVLink.MAV_COMPONENT)1)
                    {
                        //use Autopilot type as displaystring instead of "FCS1"
                        mavComponentString = port.MAVlist[temp.sysid, temp.compid].aptype.ToString();
                    }
                    else
                    {
                        //use name from enum if it exists, use the component ID otherwise
                        mavComponentString = compid.ToString();
                        if (mavComponentString.Length > mavComponentHeader.Length)
                        {
                            //remove "MAV_COMP_ID_" header
                            mavComponentString = mavComponentString.Remove(0, mavComponentHeader.Length);
                        }

                        if (temp.port.MAVlist[temp.sysid, temp.compid].CANNode)
                            mavComponentString =
                                temp.compid + " " + temp.port.MAVlist[temp.sysid, temp.compid].VersionString;
                    }
                    e.Value = temp.port.BaseStream.PortName + "-" + ((int)temp.sysid) + "-" + mavComponentString.Replace("_", " ");
                }
            }
        }
    }
}