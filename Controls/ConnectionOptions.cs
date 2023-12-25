using System;
using System.Threading;
using System.Windows.Forms;
using MissionPlanner.Comms;
using MissionPlanner.Utilities;

namespace MissionPlanner.Controls
{
    public partial class ConnectionOptions : Form
    {
        // Thread signal. 
        public static ManualResetEvent tcpClientConnected = new ManualResetEvent(false);

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

            ThemeManager.ApplyThemeTo(this);

            MissionPlanner.Utilities.Tracking.AddPage(this.GetType().ToString(), this.Text);
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
    }
}