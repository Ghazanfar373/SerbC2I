using log4net;
using MissionPlanner.Comms;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MissionPlanner.Controls.ConnectionControl;

namespace MissionPlanner.Controls
{
    public partial class ConnectionOptionsNew : Form
    {

            private static readonly ILog log = LogManager.GetLogger(typeof(ConnectionOptions));

            private Dictionary<MAVLinkInterface, string> _interfaceToConnectionId =
                new Dictionary<MAVLinkInterface, string>();
       // public static List<MAVLinkInterface> Comports = new List<MAVLinkInterface>();

        private System.Windows.Forms.Timer _refreshTimer;
            private const int REFRESH_INTERVAL_MS = 1000;

            #region FORM LIFECYCLE

       

            private void ConnectionOptions_Load(object sender, EventArgs e)
            {
                try
                {
                    log.Info("ConnectionOptions loaded");

                    InitializeDropdowns();
                    btn_Refresh_Click(null, null);

                    lbl_StatusIndicator.BackColor = System.Drawing.Color.Gray;
                    lbl_StatusText.Text = "Monitoring connections...";

                    _refreshTimer = new System.Windows.Forms.Timer();
                    _refreshTimer.Interval = REFRESH_INTERVAL_MS;
                    _refreshTimer.Tick += (s, args) => RefreshConnectionsList();
                    _refreshTimer.Start();

                    RefreshConnectionsList();

                    log.Info("ConnectionOptions initialized");
                }
                catch (Exception ex)
                {
                    log.Error($"Error loading ConnectionOptions: {ex.Message}", ex);
                }
            }
        private void PopulateSerialportList()
        {
            cmb_SerialPort.Items.Clear();
            cmb_SerialPort.Items.Add("AUTO");
            cmb_SerialPort.Items.AddRange(SerialPort.GetPortNames());
            cmb_SerialPort.Items.Add("TCP");
            cmb_SerialPort.Items.Add("UDP");
            cmb_SerialPort.Items.Add("UDPCl");
            cmb_SerialPort.Items.Add("WS");
            cmb_SerialPort.SelectedIndex = 0;
        }
        private void ConnectionOptions_FormClosing(object sender, FormClosingEventArgs e)
            {
                try
                {
                    if (_refreshTimer != null)
                    {
                        _refreshTimer.Stop();
                        _refreshTimer.Dispose();
                    }

                    _interfaceToConnectionId.Clear();
                    log.Info("ConnectionOptions closed");
                }
                catch (Exception ex)
                {
                    log.Error($"Error closing: {ex.Message}");
                }
            }

            #endregion

            #region CONNECTION MONITORING - FIXED PORT/BAUD EXTRACTION

            private void RefreshConnectionsList()
            {
                try
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(RefreshConnectionsList));
                        return;
                    }

                    if (MainSerb.Comports == null)
                    {
                        ClearListView();
                        UpdateStatus(0, "No connections");
                        return;
                    }

                    List<MAVLinkInterface> currentConnections = MainSerb.Comports.ToList();

                    bool needsUpdate = NeedsUpdate(currentConnections);

                    if (needsUpdate)
                    {
                        log.Debug($"ListView needs update. Current: {lvw_ActiveConnections.Items.Count}, MainSerb: {currentConnections.Count}");
                        UpdateListView(currentConnections);
                    }

                    UpdateConnectionCount(currentConnections.Count);

                    if (currentConnections.Count > 0)
                    {
                        lbl_StatusIndicator.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
                        lbl_StatusText.Text = $"{currentConnections.Count} connection(s) active";
                    }
                    else
                    {
                        lbl_StatusIndicator.BackColor = System.Drawing.Color.Gray;
                        lbl_StatusText.Text = "No connections";
                    }
                }
                catch (Exception ex)
                {
                    log.Error($"Error refreshing connections: {ex.Message}", ex);
                }
            }

            private bool NeedsUpdate(List<MAVLinkInterface> currentConnections)
            {
                if (lvw_ActiveConnections.Items.Count != currentConnections.Count)
                    return true;

                foreach (var mav in currentConnections)
                {
                    if (!_interfaceToConnectionId.ContainsKey(mav))
                        return true;
                }

                return false;
            }

            private void UpdateListView(List<MAVLinkInterface> currentConnections)
            {
                try
                {
                    log.Debug($"Updating ListView with {currentConnections.Count} connections");

                    lvw_ActiveConnections.Items.Clear();
                    _interfaceToConnectionId.Clear();
                int selectidx = -1;

                foreach (var portt in MainSerb.Comports.ToArray())
                {
                    var list = portt.MAVlist.GetRawIDS();

                foreach (int itemm in list)
                {
                    var temp = new port_sysid() { compid = (itemm % 256), sysid = (itemm / 256), port = portt };

                    // exclude GCS's from the list
                    if (temp.compid == (int)MAVLink.MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER)
                        continue;

                    //var idx = cmb_sysid.Items.Add(temp);
                    // Create a ListViewItem for the ListView
                    //var lvi = new ListViewItem($"{portt.BaseStream.PortName}-{temp.sysid}-{temp.compid}");
                    // var lvi2 = new ListViewItem($"{port.BaseStream.PortName}-{temp.sysid}-{temp.compid}");
                    //lvi.Tag = temp; // Store the port_sysid object for later use if needed
                    //listView_sysid.Items.Add(lvi);
                    //foreach (var mav in currentConnections)
                    //{
                    //    try
                    //    {
                    //        if (mav == null)
                    //            continue;

                            // ✅ FIXED: Properly extract port name and baud rate
                            string port = portt.BaseStream.PortName;
                            string baudRate = portt.BaseStream.BaudRate.ToString();
                            string systemId = temp.sysid.ToString();
                            string compId   = temp.compid.ToString();

                            log.Debug($"Adding connection: Port={port}, Baud={baudRate}, SysID={systemId}");

                        ConnectionEntry entry = new ConnectionEntry
                        {
                            Port = port,
                            BaudRate = baudRate,
                            SystemID = systemId,
                            CompID = compId,
                                Status = ConnectionStatus.Connected,
                                ConnectedTime = DateTime.Now
                            };

                            ListViewItem item = lvw_ActiveConnections.AddConnection(entry);

                           _interfaceToConnectionId[portt] = entry.ConnectionId;

                        if (!HasMavChangedHandler(portt))
                        {
                            portt.MavChanged += (s, e) => OnMavChanged(portt, entry.ConnectionId);
                        }

                        //    log.Debug($"Successfully added connection: {port}@{baudRate}");
                        //}
                        //    catch (Exception ex)
                        //    {
                        //        log.Error($"Error adding connection: {ex.Message}");
                    }
                    }
                }
                catch (Exception ex)
                {
                    log.Error($"Error updating ListView: {ex.Message}");
                }
            }

            private void ClearListView()
            {
                try
                {
                    lvw_ActiveConnections.Items.Clear();
                    _interfaceToConnectionId.Clear();
                }
                catch (Exception ex)
                {
                    log.Error($"Error clearing ListView: {ex.Message}");
                }
            }

            #endregion

            #region EXTRACT CONNECTION INFO - FIXED IMPLEMENTATION

            /// <summary>
            /// ✅ FIXED: Properly extract port name from MAVLinkInterface
            /// Checks: BaseStream → SerialPort → PortName property
            /// </summary>
            private string ExtractPortName(MAVLinkInterface mav)
            {
                try
                {
                    if (mav == null)
                    {
                        log.Debug("MAVLinkInterface is null");
                        return "Unknown";
                    }

                    // Try to access BaseStream
                    if (mav.BaseStream == null)
                    {
                        log.Debug("BaseStream is null");
                        return "Unknown";
                    }

                    // BaseStream should be a SerialPort object
                    SerialPort serialPort = mav.BaseStream as SerialPort;

                    if (serialPort == null)
                    {
                        log.Debug($"BaseStream is not SerialPort, it's {mav.BaseStream.GetType().Name}");
                        // Try to get PortName property anyway
                        var portNameProp = mav.BaseStream.GetType().GetProperty("PortName");
                        if (portNameProp != null)
                        {
                            var portName = portNameProp.GetValue(mav.BaseStream);
                            if (portName != null)
                            {
                                log.Debug($"Got PortName from property: {portName}");
                                return portName.ToString();
                            }
                        }
                        return "Unknown";
                    }

                    // Got the SerialPort, extract PortName
                    string port = serialPort.PortName;

                    if (string.IsNullOrEmpty(port))
                    {
                        log.Debug("PortName is empty or null");
                        return "Unknown";
                    }

                    log.Debug($"Successfully extracted port: {port}");
                    return port;
                }
                catch (Exception ex)
                {
                    log.Error($"Error extracting port name: {ex.Message}");
                    return "Unknown";
                }
            }

            /// <summary>
            /// ✅ FIXED: Properly extract baud rate from MAVLinkInterface
            /// Checks: BaseStream → SerialPort → BaudRate property
            /// </summary>
            private string ExtractBaudRate(MAVLinkInterface mav)
            {
            //var baud=115200;
                try
                {
                    if (mav == null)
                    {
                        log.Debug("MAVLinkInterface is null");
                        return "Unknown";
                    }

                    // Try to access BaseStream
                    if (mav.BaseStream == null)
                    {
                        log.Debug("BaseStream is null");
                        return "Unknown";
                    }

                    // BaseStream should be a SerialPort object
                    SerialPort serialPort = mav.BaseStream as SerialPort;

                    if (serialPort == null)
                    {
                        log.Debug($"BaseStream is not SerialPort, it's {mav.BaseStream.GetType().Name}");
                        // Try to get BaudRate property anyway
                        var baudProp = mav.BaseStream.GetType().GetProperty("BaudRate");
                        if (baudProp != null)
                        {
                            
                            if (baudProp.GetValue(mav.BaseStream) != null)
                            {
                                //log.Debug($"Got BaudRate from property: {baud}");
                                return baudProp.GetValue(mav.BaseStream).ToString();
                            }
                        }
                        return "Unknown";
                    }

                    // Got the SerialPort, extract BaudRate
                    int baud = serialPort.BaudRate;

                    if (baud <= 0)
                    {
                        log.Debug("BaudRate is invalid (0 or negative)");
                        return "Unknown";
                    }

                    log.Debug($"Successfully extracted baud rate: {baud}");
                    return baud.ToString();
                }
                catch (Exception ex)
                {
                    log.Error($"Error extracting baud rate: {ex.Message}");
                    return "Unknown";
                }
            }

            /// <summary>
            /// ✅ FIXED: Properly extract system ID from MAVLinkInterface
            /// Checks: MAV → sysid property
            /// </summary>
            private string ExtractSystemId(MAVLinkInterface mav)
            {
                try
                {
                    if (mav == null)
                    {
                        log.Debug("MAVLinkInterface is null");
                        return "Unknown";
                    }

                    // Try to get MAV object
                    if (mav.MAV == null)
                    {
                        log.Debug("MAV object is null, returning default");
                        return "1";
                    }

                    // Get system ID
                    int sysId = mav.MAV.sysid;

                    if (sysId <= 0 || sysId > 255)
                    {
                        log.Debug($"Invalid system ID: {sysId}, returning Unknown");
                        return "Unknown";
                    }

                    log.Debug($"Successfully extracted system ID: {sysId}");
                    return sysId.ToString();
                }
                catch (Exception ex)
                {
                    log.Error($"Error extracting system ID: {ex.Message}");
                    return "Unknown";
                }
            }

            #endregion

            #region CONNECT/DISCONNECT

            private void btn_Connect_Click(object sender, EventArgs e)
            {
                try
                {
                    string port = cmb_SerialPort.SelectedItem?.ToString();
                    string baudRate = cmb_BaudRate.SelectedItem?.ToString();
                    string systemId = cmb_SystemID.SelectedItem?.ToString() ?? "1";

                    if (string.IsNullOrEmpty(port) || string.IsNullOrEmpty(baudRate))
                    {
                        MessageBox.Show("Please select port and baud rate");
                        return;
                    }

                    //if (MainSerb.Comports.Any(m =>
                    //    ExtractPortName(m) == port &&
                    //    ExtractBaudRate(m) == baudRate))
                    //{
                    //    MessageBox.Show("Already connected to this port");
                    //    return;
                    //}

                    log.Info($"Connecting to {port} @ {baudRate}");

                    var mav = new MAVLinkInterface();
                    MainSerb.instance.doConnect(mav, port, baudRate);
                    MainSerb.Comports.Add(mav);

                    log.Info($"Connected to {port}");
                    //MessageBox.Show($"Connected to {port} @ {baudRate}");
                }
                catch (Exception ex)
                {
                    log.Error($"Connection failed: {ex.Message}");
                    MessageBox.Show($"Connection failed: {ex.Message}");
                }
            }

            private void btn_Disconnect_Click(object sender, EventArgs e)
            {
                try
                {
                    if (lvw_ActiveConnections.SelectedItems.Count == 0)
                    {
                        MessageBox.Show("Please select a connection to disconnect");
                        return;
                    }

                    ListViewItem selectedItem = lvw_ActiveConnections.SelectedItems[0];
                    ConnectionEntry selectedConnection = selectedItem.Tag as ConnectionEntry;

                    if (selectedConnection == null)
                        return;

                    var mav = _interfaceToConnectionId
                        .FirstOrDefault(x => x.Value == selectedConnection.ConnectionId)
                        .Key;

                    if (mav == null)
                    {
                        MessageBox.Show("Connection interface not found");
                        return;
                    }

                    log.Info($"Disconnecting {selectedConnection.Port}");
                    MainSerb.instance.doDisconnect(mav);

                    if (MainSerb.Comports.Contains(mav))
                    {
                        MainSerb.Comports.Remove(mav);
                    }

                    log.Info($"Disconnected from {selectedConnection.Port}");
                    MessageBox.Show($"Disconnected from {selectedConnection.Port}");
                }
                catch (Exception ex)
                {
                    log.Error($"Disconnect failed: {ex.Message}");
                    MessageBox.Show($"Disconnect failed: {ex.Message}");
                }
            }

            #endregion

            #region EVENT HANDLERS

            private void lvw_ActiveConnections_SelectedIndexChanged(object sender, EventArgs e)
            {
                btn_Disconnect.Enabled = (lvw_ActiveConnections.SelectedItems.Count > 0);
            }

            private void lvw_ActiveConnections_DoubleClick(object sender, EventArgs e)
            {
                if (lvw_ActiveConnections.SelectedItems.Count == 0)
                    return;

                ListViewItem item = lvw_ActiveConnections.SelectedItems[0];
                ConnectionEntry conn = item.Tag as ConnectionEntry;

                if (conn != null)
                {
                    string details = $"Connection Details:\n\n" +
                        $"Port: {conn.Port}\n" +
                        $"Baud Rate: {conn.BaudRate}\n" +
                        $"System ID: {conn.SystemID}\n" +
                        $"Status: {conn.Status}\n" +
                        $"Connected: {conn.ConnectedTime:G}";

                    MessageBox.Show(details, "Connection Details");
                }
            }

            private void OnMavChanged(MAVLinkInterface mav, string connectionId)
            {
                try
                {
                    if (InvokeRequired)
                    {
                        Invoke(new Action(() => OnMavChanged(mav, connectionId)));
                        return;
                    }

                    foreach (ListViewItem item in lvw_ActiveConnections.Items)
                    {
                        ConnectionEntry entry = item.Tag as ConnectionEntry;
                        if (entry?.ConnectionId == connectionId)
                        {
                            string newSysId = ExtractSystemId(mav);
                            entry.SystemID = newSysId;
                        
                            item.SubItems[2].Text = newSysId;
                            break;
                        }
                    }
                }
                catch (Exception ex)
                {
                    log.Error($"Error in OnMavChanged: {ex.Message}");
                }
            }
        
        private void btn_Refresh_Click(object sender, EventArgs e)
            {
                try
                {
                   
                    PopulateSerialportList();
                    
                }
                catch (Exception ex)
                {
                    log.Error($"Error refreshing ports: {ex.Message}");
                }
            }

            private void btn_Close_Click(object sender, EventArgs e)
            {
                this.Close();
            }

            #endregion

            #region HELPERS

            private void InitializeDropdowns()
            {
            PopulateSerialportList();
            cmb_BaudRate.Items.Clear();
            cmb_BaudRate.Items.AddRange(new object[] {
                "9600", "38400", "57600", "115200"
            });
                cmb_BaudRate.SelectedIndex = 3;

                cmb_SystemID.Items.AddRange(new object[] {
                "1", "2", "3", "4", "5", "255"
            });
                cmb_SystemID.SelectedIndex = 0;
            
        }
        


            private bool HasMavChangedHandler(MAVLinkInterface mav)
            {
                return mav != null;
            }

            private void UpdateConnectionCount(int count)
            {
                lbl_ConnectionCount.Text = $"({count})";
            }

            private void UpdateStatus(int count, string message)
            {
                if (count > 0)
                {
                    lbl_StatusIndicator.BackColor = System.Drawing.Color.FromArgb(76, 175, 80);
                }
                else
                {
                    lbl_StatusIndicator.BackColor = System.Drawing.Color.Gray;
                }
                lbl_StatusText.Text = message;
            }

        #endregion
        private string GetAllPortsInfo()
        {
            string result = "";
            foreach (var port in MainSerb.Comports.ToArray())
            {
                var list = port.MAVlist.GetRawIDS();

                foreach (int item in list)
                {
                    var temp = new port_sysid() { compid = (item % 256), sysid = (item / 256), port = port };

                    // exclude GCS's from the list
                    if (temp.compid == (int)MAVLink.MAV_COMPONENT.MAV_COMP_ID_MISSIONPLANNER)
                        continue;

                    //var idx = cmb_sysid.Items.Add(temp);
                    // Create a ListViewItem for the ListView
                    result = result + $"{port.BaseStream.PortName}-{temp.sysid}-{temp.compid}\n";
                    var lvi = new ListViewItem($"{port.BaseStream.PortName}-{temp.sysid}-{temp.compid}");
                    // var lvi2 = new ListViewItem($"{port.BaseStream.PortName}-{temp.sysid}-{temp.compid}");
                    lvi.Tag = temp; // Store the port_sysid object for later use if needed
                    //MessageBox.Show(result);
                }
            }
            return result;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            

            // Usage:
            MessageBox.Show(GetAllPortsInfo());
            //cmb_sysid_Format(sender, null);
            //try
            //{
            //    if (MainSerb.Comports == null)
            //    {
            //        // ClearListView();
            //        //  UpdateStatus(0, "No connections");
            //        // return;

            //        MessageBox.Show("No comports detected");

            //    }
            //    else
            //    {
            //        String str = "TOtal Count: " + MainSerb.Comports.Count + "\n\r";
            //        foreach (MAVLinkInterface mav in MainSerb.Comports)
            //        {

            //            str += mav.ToString();
            //            // +"Firmware \n"+ MainSerb.comPort.MAV.cs.firmware.ToString());
            //        }
            //        MessageBox.Show(str);
            //    }
            //}
            //catch (Exception)
            //{

            //    throw;
            //}
        }

        private void buttonAutoConnect_Click(object sender, EventArgs e)
        {
            AutoConnect.Start();
        }
    }
    }
