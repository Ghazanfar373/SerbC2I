using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{/// <summary>
 /// Represents a single MAVLink connection entry
 /// </summary>
    public class ConnectionEntry
    {
        public string Port { get; set; }
        public string BaudRate { get; set; }
        public string SystemID { get; set; }
        public ConnectionStatus Status { get; set; }
        public DateTime ConnectedTime { get; set; }
        public string ConnectionId { get; set; } // Unique identifier

        public ConnectionEntry()
        {
            ConnectionId = Guid.NewGuid().ToString();
            ConnectedTime = DateTime.Now;
            Status = ConnectionStatus.Disconnected;
        }

        public override string ToString()
        {
            return $"{Port}@{BaudRate} (SysID:{SystemID})";
        }
    }

    /// <summary>
    /// Connection status enumeration
    /// </summary>
    public enum ConnectionStatus
    {
        Connected,
        Disconnected,
        Connecting,
        Error,
        Idle
    }

    /// <summary>
    /// Extension class for ListView to manage connections
    /// </summary>
    public static class ListViewConnectionHelper
    {
        /// <summary>
        /// Adds a new connection entry to the ListView
        /// Column indices: 0=Port, 1=BaudRate, 2=SystemID, 3=Status, 4=Action
        /// </summary>
        public static ListViewItem AddConnection(this ListView listView, ConnectionEntry connection)
        {
            if (listView == null || connection == null)
                return null;

            // Create item with Port as the first column (index 0)
            ListViewItem item = new ListViewItem(connection.Port);
            item.Tag = connection;

            // Add subitems for remaining columns (indices 1-4)
            item.SubItems.Add(connection.BaudRate);      // Index 1
            item.SubItems.Add(connection.SystemID);      // Index 2
            item.SubItems.Add(GetStatusText(connection.Status));  // Index 3
            item.SubItems.Add("Disconnect");             // Index 4

            // Set styling based on status
            UpdateItemStyle(item, connection.Status);

            listView.Items.Add(item);
            return item;
        }

        /// <summary>
        /// Removes a connection by ConnectionId
        /// </summary>
        public static bool RemoveConnection(this ListView listView, string connectionId)
        {
            if (listView == null)
                return false;

            foreach (ListViewItem item in listView.Items)
            {
                ConnectionEntry conn = item.Tag as ConnectionEntry;
                if (conn != null && conn.ConnectionId == connectionId)
                {
                    listView.Items.Remove(item);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Removes a connection by index
        /// </summary>
        public static void RemoveConnectionAt(this ListView listView, int index)
        {
            if (listView != null && index >= 0 && index < listView.Items.Count)
            {
                listView.Items.RemoveAt(index);
            }
        }

        /// <summary>
        /// Updates connection status
        /// </summary>
        public static bool UpdateConnectionStatus(this ListView listView, string connectionId, ConnectionStatus newStatus)
        {
            if (listView == null)
                return false;

            foreach (ListViewItem item in listView.Items)
            {
                ConnectionEntry conn = item.Tag as ConnectionEntry;
                if (conn != null && conn.ConnectionId == connectionId)
                {
                    conn.Status = newStatus;
                    item.SubItems[3].Text = GetStatusText(newStatus);
                    UpdateItemStyle(item, newStatus);
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Gets a connection by ConnectionId
        /// </summary>
        public static ConnectionEntry GetConnection(this ListView listView, string connectionId)
        {
            if (listView == null)
                return null;

            foreach (ListViewItem item in listView.Items)
            {
                ConnectionEntry conn = item.Tag as ConnectionEntry;
                if (conn != null && conn.ConnectionId == connectionId)
                    return conn;
            }
            return null;
        }

        /// <summary>
        /// Gets all connections currently in the list
        /// </summary>
        public static List<ConnectionEntry> GetAllConnections(this ListView listView)
        {
            List<ConnectionEntry> connections = new List<ConnectionEntry>();

            if (listView != null)
            {
                foreach (ListViewItem item in listView.Items)
                {
                    ConnectionEntry conn = item.Tag as ConnectionEntry;
                    if (conn != null)
                        connections.Add(conn);
                }
            }

            return connections;
        }

        /// <summary>
        /// Clears all connections from the list
        /// </summary>
        public static void ClearConnections(this ListView listView)
        {
            if (listView != null)
                listView.Items.Clear();
        }

        /// <summary>
        /// Checks if a connection already exists
        /// </summary>
        public static bool ConnectionExists(this ListView listView, string port, string baudRate)
        {
            if (listView == null)
                return false;

            foreach (ListViewItem item in listView.Items)
            {
                ConnectionEntry conn = item.Tag as ConnectionEntry;
                if (conn != null && conn.Port == port && conn.BaudRate == baudRate)
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Gets connection count
        /// </summary>
        public static int GetConnectionCount(this ListView listView)
        {
            return listView != null ? listView.Items.Count : 0;
        }

        /// <summary>
        /// Gets count of connected devices
        /// </summary>
        public static int GetConnectedCount(this ListView listView)
        {
            int count = 0;
            if (listView != null)
            {
                foreach (ListViewItem item in listView.Items)
                {
                    ConnectionEntry conn = item.Tag as ConnectionEntry;
                    if (conn != null && conn.Status == ConnectionStatus.Connected)
                        count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Gets the selected connection
        /// </summary>
        public static ConnectionEntry GetSelectedConnection(this ListView listView)
        {
            if (listView != null && listView.SelectedItems.Count > 0)
            {
                return listView.SelectedItems[0].Tag as ConnectionEntry;
            }
            return null;
        }

        /// <summary>
        /// Selects a connection by ConnectionId
        /// </summary>
        public static void SelectConnection(this ListView listView, string connectionId)
        {
            if (listView == null)
                return;

            foreach (ListViewItem item in listView.Items)
            {
                ConnectionEntry conn = item.Tag as ConnectionEntry;
                if (conn != null && conn.ConnectionId == connectionId)
                {
                    item.Selected = true;
                    item.EnsureVisible();
                    return;
                }
            }
        }

        /// <summary>
        /// Gets the status text representation
        /// </summary>
        private static string GetStatusText(ConnectionStatus status)
        {
            switch (status)
            {
                case ConnectionStatus.Connected:
                    return "✓ Connected";
                case ConnectionStatus.Connecting:
                    return "⟳ Connecting...";
                case ConnectionStatus.Error:
                    return "✗ Error";
                case ConnectionStatus.Idle:
                    return "◆ Idle";
                default:
                    return "◯ Disconnected";
            }
        }

        /// <summary>
        /// Updates visual styling based on status
        /// Applies color to all columns in the row
        /// </summary>
        private static void UpdateItemStyle(ListViewItem item, ConnectionStatus status)
        {
            Color foreColor;
            Color backColor;

            switch (status)
            {
                case ConnectionStatus.Connected:
                    foreColor = Color.FromArgb(76, 175, 80);        // Green
                    backColor = Color.FromArgb(232, 245, 233);      // Light green
                    break;
                case ConnectionStatus.Connecting:
                    foreColor = Color.FromArgb(255, 193, 7);        // Amber
                    backColor = Color.FromArgb(255, 248, 225);      // Light amber
                    break;
                case ConnectionStatus.Error:
                    foreColor = Color.FromArgb(244, 67, 54);        // Red
                    backColor = Color.FromArgb(255, 235, 238);      // Light red
                    break;
                case ConnectionStatus.Idle:
                    foreColor = Color.FromArgb(158, 158, 158);      // Gray
                    backColor = Color.FromArgb(245, 245, 245);      // Light gray
                    break;
                default:
                    foreColor = Color.FromArgb(117, 117, 117);      // Dark gray
                    backColor = Color.White;
                    break;
            }

            // Apply to main item
            item.ForeColor = foreColor;
            item.BackColor = backColor;

            // Apply to all subitems
            for (int i = 0; i < item.SubItems.Count; i++)
            {
                item.SubItems[i].BackColor = backColor;
                item.SubItems[i].ForeColor = foreColor;
            }
        }
    }
}