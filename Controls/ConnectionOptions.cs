using System;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using MissionPlanner.Comms;
using MissionPlanner.Utilities;
using static MissionPlanner.Controls.ConnectionControl;

namespace MissionPlanner.Controls
{
    public partial class ConnectionOptions : Form
    {
        // Thread signal. 
        public static ManualResetEvent tcpClientConnected = new ManualResetEvent(false);
        public static string comPortName = "";

        public static int comPortBaud = 57600;
        public ConnectionOptions()
        {
            InitializeComponent();

            CMB_serialport.Items.AddRange(SerialPort.GetPortNames());
            CMB_serialport.Items.Add("TCP");
            CMB_serialport.Items.Add("UDP");
            CMB_serialport.Items.Add("UDPCl");
            CMB_serialport.Items.Add("WS");


            rjComboBoxPorts.Items.AddRange(SerialPort.GetPortNames());
            rjComboBoxPorts.Items.Add("TCP");
            rjComboBoxPorts.Items.Add("UDP");
            rjComboBoxPorts.Items.Add("UDPCl");
            rjComboBoxPorts.Items.Add("WS");



            _connectionControl.CMB_baudrate.TextChanged += this.CMB_baudrate_TextChanged;
            _connectionControl.CMB_serialport.SelectedIndexChanged += this.CMB_serialport_SelectedIndexChanged;
            _connectionControl.CMB_serialport.Click += this.CMB_serialport_Click;
            // _connectionControl.cmb_sysid.Click += cmb_sysid_Click;
            cmb_sysid.Click += cmb_sysid_Click;

            ThemeManager.ApplyThemeTo(this);

            MissionPlanner.Utilities.Tracking.AddPage(this.GetType().ToString(), this.Text);
        }

        void cmb_sysid_Click(object sender, EventArgs e)
        {
            //_connectionControl.UpdateSysIDS();
            UpdateSysIDS();
        }
        public void UpdateSysIDS()
        {
            cmb_sysid.SelectedIndexChanged -= CMB_sysid_SelectedIndexChanged;

            var oldidx = cmb_sysid.SelectedIndex;

            cmb_sysid.Items.Clear();
            listView_sysid.Items.Clear();

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
                    // Create a ListViewItem for the ListView
                    var lvi = new ListViewItem($"{port.BaseStream.PortName}-{temp.sysid}-{temp.compid}");
                   // var lvi2 = new ListViewItem($"{port.BaseStream.PortName}-{temp.sysid}-{temp.compid}");
                    lvi.Tag = temp; // Store the port_sysid object for later use if needed
                    listView_sysid.Items.Add(lvi);

                    if (temp.port == MainSerb.comPort && temp.sysid == MainSerb.comPort.sysidcurrent && temp.compid == MainSerb.comPort.compidcurrent)
                    {
                        selectidx = idx;
                    }
                }
            }

            if (/*oldidx == -1 && */ selectidx != -1)
            {
                cmb_sysid.SelectedIndex = selectidx;
                listView_sysid.Items[selectidx].Selected = true;
                
            }

            cmb_sysid.SelectedIndexChanged += CMB_sysid_SelectedIndexChanged;
            listView_sysid.Select();
        }

        private void CMB_baudrate_TextChanged(object sender, EventArgs e)
        {
            if (!int.TryParse(_connectionControl.CMB_baudrate.Text, out comPortBaud))
            {
                CustomMessageBox.Show(Strings.InvalidBaudRate, Strings.ERROR);
                return;
            }

            var sb = new StringBuilder();
            int baud = 0;
            for (int i = 0; i < _connectionControl.CMB_baudrate.Text.Length; i++)
                if (char.IsDigit(_connectionControl.CMB_baudrate.Text[i]))
                {
                    sb.Append(_connectionControl.CMB_baudrate.Text[i]);
                    baud = baud * 10 + _connectionControl.CMB_baudrate.Text[i] - '0';
                }

            if (_connectionControl.CMB_baudrate.Text != sb.ToString())
            {
                _connectionControl.CMB_baudrate.Text = sb.ToString();
            }

            try
            {
                if (baud > 0 && MainSerb.comPort.BaseStream.BaudRate != baud)
                    MainSerb.comPort.BaseStream.BaudRate = baud;
            }
            catch (Exception)
            {
            }
        }
        private void CMB_serialport_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_connectionControl.CMB_serialport.SelectedItem == _connectionControl.CMB_serialport.Text)
                return;

            comPortName = _connectionControl.CMB_serialport.Text;
            if (comPortName == "UDP" || comPortName == "UDPCl" || comPortName == "TCP" || comPortName == "AUTO")
            {
                _connectionControl.CMB_baudrate.Enabled = false;
            }
            else
            {
                _connectionControl.CMB_baudrate.Enabled = true;
            }

            try
            {
                // check for saved baud rate and restore
                if (Settings.Instance[_connectionControl.CMB_serialport.Text.Replace(" ", "_") + "_BAUD"] != null)
                {
                    _connectionControl.CMB_baudrate.Text =
                        Settings.Instance[_connectionControl.CMB_serialport.Text.Replace(" ", "_") + "_BAUD"];
                }
            }
            catch
            {
            }
        }
        private void CMB_serialport_Click(object sender, EventArgs e)
        {
            string oldport = _connectionControl.CMB_serialport.Text;
            PopulateSerialportList();
            if (_connectionControl.CMB_serialport.Items.Contains(oldport))
                _connectionControl.CMB_serialport.Text = oldport;
        }
        private void PopulateSerialportList()
        {
            _connectionControl.CMB_serialport.Items.Clear();
            _connectionControl.CMB_serialport.Items.Add("AUTO");
            _connectionControl.CMB_serialport.Items.AddRange(SerialPort.GetPortNames());
            _connectionControl.CMB_serialport.Items.Add("TCP");
            _connectionControl.CMB_serialport.Items.Add("UDP");
            _connectionControl.CMB_serialport.Items.Add("UDPCl");
            _connectionControl.CMB_serialport.Items.Add("WS");
        }
        private void BUT_connect_Click(object sender, EventArgs e)
        {
            var mav = new MAVLinkInterface();
            try
            {
                MainSerb.instance.doConnect(mav, CMB_serialport.Text, CMB_baudrate.Text);
                MainSerb.Comports.Add(mav);
                MainSerb._connectionControl.UpdateSysIDS();
            }
            catch (Exception)
            {
            }
        }

        private void klcButtonConnect_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(rjComboBoxPorts.Texts, rjComboBoxBaudRate.Texts);
            var mav = new MAVLinkInterface();

            try
            {
                MainSerb.instance.doConnect(mav, rjComboBoxPorts.Texts, rjComboBoxBaudRate.Texts);

                MainSerb.Comports.Add(mav);

                MainSerb._connectionControl.UpdateSysIDS();

                this.Close();
            }
            catch (Exception)
            {
            }
        }


        private void klcButtonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ConnectionOptions_Load(object sender, EventArgs e)
        {

        }

        private void klcButtonCancel_Click_1(object sender, EventArgs e)
        {
            this.Close();
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
                    e.Value = temp.port.BaseStream.PortName + "-" + ((int)temp.sysid);// + "-" + mavComponentString.Replace("_", " ");
                }
            }

        }

        private void listView_sysid_DrawItem(object sender, DrawListViewItemEventArgs e)
        {

        }
    }
}