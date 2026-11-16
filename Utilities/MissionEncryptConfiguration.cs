using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using Org.BouncyCastle.Math.EC.Rfc7748;

namespace MissionPlanner.Utilities
{
    public partial class MissionEncryptConfiguration : Form
    {
        const int Aes256KeyBytes = 32;
        const int X25519KeyBytes = 32;

        const string ParamEncMode = "MIS_ENC_MODE";
        const string ParamScrubEn = "MIS_SCRUB_EN";

        bool dragging;
        Point dragCursor;
        Point dragForm;
        bool suppressParamWrite;
        int lastRamValue = -1;

        public MissionEncryptConfiguration()
        {
            InitializeComponent();
            EnableDrag(panelHeader);
            EnableDrag(lblBrand);
            EnableDrag(lblTitle);
            EnableDrag(lblTagline);
            LoadMissionParams();
        }

        /// <summary>
        /// AES-256 key as 64 uppercase hex characters, empty until one is generated or entered.
        /// </summary>
        public string KeyHex
        {
            get { return ReadBox(txtPassphrase); }
        }

        /// <summary>X25519 private key, 64 uppercase hex characters (32 bytes).</summary>
        public string PrivateKeyHex
        {
            get { return ReadBox(txtPrivate); }
        }

        /// <summary>X25519 public key, 64 uppercase hex characters (32 bytes).</summary>
        public string PublicKeyHex
        {
            get { return ReadBox(txtPublic); }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            byte[] aesKey = new byte[Aes256KeyBytes];
            byte[] privateKey = new byte[X25519KeyBytes];
            byte[] publicKey = new byte[X25519KeyBytes];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(aesKey);
                rng.GetBytes(privateKey);
            }

            // Same derivation as X25519PrivateKey.public_key(): clamp the scalar and multiply by the base point.
            X25519.ScalarMultBase(privateKey, 0, publicKey, 0);

            SetBox(txtPassphrase, ToHex(aesKey));
            SetBox(txtPrivate, ToHex(privateKey));
            SetBox(txtPublic, ToHex(publicKey));
            Array.Clear(aesKey, 0, aesKey.Length);
            Array.Clear(privateKey, 0, privateKey.Length);

            lblActiveCipher.Text = "AES-256-CBC";
            lblKeyBits.Text = "256-BIT";
            lblStrength.Text = "X25519";
            lblStrength.ForeColor = System.Drawing.Color.FromArgb(140, 230, 190);
            barStrength.Value = 100;
            lblFingerprint.Text = Fingerprint(PublicKeyHex);
        }

        void EnableDrag(Control control)
        {
            control.Cursor = Cursors.SizeAll;
            control.MouseDown += Header_MouseDown;
            control.MouseMove += Header_MouseMove;
            control.MouseUp += Header_MouseUp;
        }

        void Header_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            dragging = true;
            dragCursor = Cursor.Position;
            dragForm = Location;
        }

        void Header_MouseMove(object sender, MouseEventArgs e)
        {
            if (!dragging)
                return;

            Point now = Cursor.Position;
            Location = new Point(dragForm.X + now.X - dragCursor.X, dragForm.Y + now.Y - dragCursor.Y);
        }

        void Header_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        void LoadMissionParams()
        {
            suppressParamWrite = true;

            MAVLink.MAVLinkParam ram = FindParam(ParamEncMode);
            int value = ram == null ? 0 : (int)Math.Round(ram.Value);
            ApplyRamValue(value);
            lastRamValue = value;

            MAVLink.MAVLinkParam scrub = FindParam(ParamScrubEn);
            toggleScrubOnly.Enabled = true;
            toggleScrubOnly.Checked = scrub != null && scrub.Value >= 0.5;
            toggleScrubOnly.BringToFront();

            suppressParamWrite = false;
        }

        void toggleArm_CheckedChanged(object sender, EventArgs e)
        {
            SetRamMode(toggleArm, 1);
        }

        void toggleMission_CheckedChanged(object sender, EventArgs e)
        {
            SetRamMode(toggleMission, 2);
        }

        void toggleUplink_CheckedChanged(object sender, EventArgs e)
        {
            SetRamMode(toggleUplink, 3);
        }

        void SetRamMode(CheckBox selected, int onValue)
        {
            if (suppressParamWrite)
                return;

            int value = selected.Checked ? onValue : 0;
            if (!WriteParamValue(ParamEncMode, value))
            {
                suppressParamWrite = true;
                ApplyRamValue(lastRamValue);
                suppressParamWrite = false;
                return;
            }

            lastRamValue = value;
            suppressParamWrite = true;
            ApplyRamValue(value);
            suppressParamWrite = false;
        }

        void ApplyRamValue(int value)
        {
            toggleArm.Checked = value == 1;
            toggleMission.Checked = value == 2;
            toggleUplink.Checked = value == 3;
        }

        void toggleScrubOnly_CheckedChanged(object sender, EventArgs e)
        {
            if (suppressParamWrite)
                return;

            if (!WriteParamValue(ParamScrubEn, toggleScrubOnly.Checked ? 1 : 0))
            {
                suppressParamWrite = true;
                toggleScrubOnly.Checked = !toggleScrubOnly.Checked;
                suppressParamWrite = false;
            }
        }

        void lblScrubOnly_Click(object sender, EventArgs e)
        {
            toggleScrubOnly.Checked = !toggleScrubOnly.Checked;
        }

        bool WriteParamValue(string name, double value)
        {
            MAVLinkInterface port = MainSerb.comPort;
            MAVLink.MAVLinkParam param = FindParam(name);
            if (port == null || port.BaseStream == null || !port.BaseStream.IsOpen || param == null)
            {
                ShowVehicleLines(new List<string>(), name + " is not on the connected vehicle");
                return false;
            }

            try
            {
                bool ok = port.setParam((byte)port.sysidcurrent, (byte)port.compidcurrent, param.Name, value);
                ShowVehicleLines(new List<string>(), ok
                    ? param.Name + " = " + value.ToString("0")
                    : param.Name + " was not accepted");
                return ok;
            }
            catch (Exception ex)
            {
                ShowVehicleLines(new List<string>(), name + " failed: " + ex.Message);
                return false;
            }
        }

        static MAVLink.MAVLinkParam FindParam(string name)
        {
            MAVLinkInterface port = MainSerb.comPort;
            if (port == null || port.MAV == null || port.MAV.param == null)
                return null;

            if (port.MAV.param.ContainsKey(name))
                return port.MAV.param[name];

            foreach (string key in port.MAV.param.Keys)
            {
                if (key != null && string.Equals(key.Trim(), name, StringComparison.OrdinalIgnoreCase))
                    return port.MAV.param[key];
            }

            return null;
        }

        void btnCopyPrivate_Click(object sender, EventArgs e)
        {
            CopyHex(PrivateKeyHex);
        }

        void btnCopyPublic_Click(object sender, EventArgs e)
        {
            CopyHex(PublicKeyHex);
        }

        void btnApply_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.None;

            MAVLinkInterface port = MainSerb.comPort;
            if (port == null || port.BaseStream == null || !port.BaseStream.IsOpen || port.sysidcurrent <= 0)
            {
                CustomMessageBox.Show("Connect to the vehicle before applying the key.");
                return;
            }

            byte[] aesKey = null;
            byte[] privateKey = null;
            byte[] publicKey = null;
            byte[] shared = null;
            byte[] wrapped = null;

            try
            {
                aesKey = HexToBytes(KeyHex);
                privateKey = HexToBytes(PrivateKeyHex);
                publicKey = HexToBytes(PublicKeyHex);
            }
            catch (Exception)
            {
                CustomMessageBox.Show("Generate a valid AES-256 key and X25519 key pair first.");
                return;
            }

            if (aesKey.Length != Aes256KeyBytes || privateKey.Length != X25519KeyBytes || publicKey.Length != X25519KeyBytes)
            {
                CustomMessageBox.Show("Generate a valid AES-256 key and X25519 key pair first.");
                return;
            }

            byte sysid = (byte)port.sysidcurrent;
            byte compid = (byte)port.compidcurrent;
            var vehicleLines = new List<string>();
            btnApply.Enabled = false;
            SetLinkState("SEND", true);
            ShowVehicleLines(vehicleLines, "Sending public key");

            try
            {
                // Same exclusive-link pattern as MAVLinkInterface.doCommand.
                port.giveComport = true;

                port.sendPacket(new MAVLink.mavlink_aes_pubkey_t(sysid, compid, publicKey), sysid, compid);

                SetLinkState("WAIT", true);
                byte[] vehiclePublic = RequestVehiclePublicKey(port, sysid, compid, publicKey, buffer =>
                    NoteVehicleStatus(buffer, sysid, vehicleLines));
                ShowVehicleLines(vehicleLines, "Vehicle X25519 public key received");

                shared = new byte[X25519KeyBytes];
                X25519.ScalarMult(privateKey, 0, vehiclePublic, 0, shared, 0);

                wrapped = new byte[Aes256KeyBytes];
                for (int i = 0; i < wrapped.Length; i++)
                    wrapped[i] = (byte)(aesKey[i] ^ shared[i]);

                port.sendPacket(new MAVLink.mavlink_aes_pubkey_t(sysid, compid, publicKey), sysid, compid);
                port.sendPacket(new MAVLink.mavlink_aes_key_wrapped_t(sysid, compid, wrapped), sysid, compid);

                SetLinkState("SENT", true);
                ShowVehicleLines(vehicleLines, "Wrapped key sent");
                DrainVehicleStatus(port, sysid, vehicleLines, 2500);

                bool derived = false;
                for (int i = 0; i < vehicleLines.Count; i++)
                {
                    if (vehicleLines[i].IndexOf("derived", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        derived = true;
                        break;
                    }
                }

                SetLinkState(derived ? "LINKED" : "SENT", true);
                ShowVehicleLines(vehicleLines, derived
                    ? "Vehicle derived the AES key"
                    : "Wrapped key sent — no AES status from vehicle yet");
            }
            catch (TimeoutException)
            {
                SetLinkState("FAIL", false);
                ShowVehicleLines(vehicleLines, "Vehicle did not return its AES public key");
            }
            catch (Exception ex)
            {
                SetLinkState("FAIL", false);
                ShowVehicleLines(vehicleLines, "Key share failed: " + ex.Message);
            }
            finally
            {
                port.giveComport = false;
                btnApply.Enabled = true;
                Clear(aesKey);
                Clear(privateKey);
                Clear(shared);
                Clear(wrapped);
            }
        }

        void NoteVehicleStatus(MAVLink.MAVLinkMessage buffer, byte sysid, List<string> vehicleLines)
        {
            if (buffer == null || buffer.Length <= 5 || buffer.sysid != sysid)
                return;
            if (buffer.msgid != (uint)MAVLink.MAVLINK_MSG_ID.STATUSTEXT)
                return;

            var msg = buffer.ToStructure<MAVLink.mavlink_statustext_t>();
            if (msg.text == null)
                return;

            string text = Encoding.ASCII.GetString(msg.text);
            int end = text.IndexOf('\0');
            if (end >= 0)
                text = text.Substring(0, end);
            text = text.Trim();
            if (text.Length == 0)
                return;
            if (text.IndexOf("AES", StringComparison.OrdinalIgnoreCase) < 0 &&
                text.IndexOf("X25519", StringComparison.OrdinalIgnoreCase) < 0 &&
                text.IndexOf("key", StringComparison.OrdinalIgnoreCase) < 0)
                return;

            vehicleLines.Add(text);
            ShowVehicleLines(vehicleLines, null);
        }

        void ShowVehicleLines(List<string> vehicleLines, string fallback)
        {
            if (vehicleLines.Count == 0)
            {
                lblFooter.Text = fallback ?? "";
            }
            else
            {
                int start = Math.Max(0, vehicleLines.Count - 3);
                var shown = new string[vehicleLines.Count - start];
                for (int i = start; i < vehicleLines.Count; i++)
                    shown[i - start] = "AP: " + vehicleLines[i];
                lblFooter.Text = string.Join(Environment.NewLine, shown);
            }

            lblFooter.ForeColor = Color.FromArgb(214, 228, 226);
            Refresh();
        }

        void SetLinkState(string text, bool ok)
        {
            lblLinkState.Text = text;
            lblLinkState.ForeColor = ok
                ? Color.FromArgb(140, 230, 190)
                : Color.FromArgb(232, 120, 96);
            Refresh();
        }

        void DrainVehicleStatus(MAVLinkInterface port, byte sysid, List<string> vehicleLines, int timeoutMs)
        {
            DateTime start = DateTime.Now;
            while (DateTime.Now < start.AddMilliseconds(timeoutMs))
            {
                MAVLink.MAVLinkMessage buffer = port.readPacket();
                NoteVehicleStatus(buffer, sysid, vehicleLines);
            }
        }

        /// <summary>
        /// Sends AES_PUBKEY_REQUEST and waits for AES_PUBKEY, with the same retry and timeout as doCommand.
        /// </summary>
        static byte[] RequestVehiclePublicKey(MAVLinkInterface port, byte sysid, byte compid, byte[] ourPublic,
            Action<MAVLink.MAVLinkMessage> onPacket)
        {
            var request = new MAVLink.mavlink_aes_pubkey_request_t(sysid, compid);
            port.sendPacket(request, sysid, compid);

            DateTime start = DateTime.Now;
            int retrys = 3;
            const int timeout = 2000;

            while (true)
            {
                if (!(start.AddMilliseconds(timeout) > DateTime.Now))
                {
                    if (retrys > 0)
                    {
                        port.sendPacket(request, sysid, compid);
                        start = DateTime.Now;
                        retrys--;
                        continue;
                    }

                    throw new TimeoutException("Timeout waiting for AES_PUBKEY");
                }

                MAVLink.MAVLinkMessage buffer = port.readPacket();
                if (onPacket != null)
                    onPacket(buffer);
                if (buffer == null || buffer.Length <= 5)
                    continue;
                if (buffer.msgid != (uint)MAVLink.MAVLINK_MSG_ID.AES_PUBKEY || buffer.sysid != sysid)
                    continue;

                var reply = buffer.ToStructure<MAVLink.mavlink_aes_pubkey_t>();
                if (reply.pubkey == null || reply.pubkey.Length != X25519KeyBytes)
                    continue;
                if (SameBytes(reply.pubkey, ourPublic) || AllZero(reply.pubkey))
                    continue;

                return reply.pubkey;
            }
        }

        static bool SameBytes(byte[] left, byte[] right)
        {
            if (left == null || right == null || left.Length != right.Length)
                return false;

            for (int i = 0; i < left.Length; i++)
            {
                if (left[i] != right[i])
                    return false;
            }

            return true;
        }

        static bool AllZero(byte[] bytes)
        {
            for (int i = 0; i < bytes.Length; i++)
            {
                if (bytes[i] != 0)
                    return false;
            }

            return true;
        }

        static void Clear(byte[] bytes)
        {
            if (bytes != null)
                Array.Clear(bytes, 0, bytes.Length);
        }

        static void CopyHex(string hex)
        {
            if (string.IsNullOrEmpty(hex))
                return;

            // Keep the text after this window loses clipboard ownership.
            Clipboard.SetDataObject(hex, true);
        }

        static void SetBox(Control box, string value)
        {
            TextBox inner = InnerTextBox(box);
            FieldInfo placeholderFlag = box.GetType().GetField("isPlaceholder", BindingFlags.Instance | BindingFlags.NonPublic);
            if (placeholderFlag != null)
                placeholderFlag.SetValue(box, false);

            if (inner == null)
                return;

            inner.ForeColor = box.ForeColor;
            inner.Text = value;
        }

        static string ReadBox(Control box)
        {
            TextBox inner = InnerTextBox(box);
            if (inner == null)
                return "";

            string text = inner.Text == null ? "" : inner.Text.Trim();
            string placeholder = box.GetType().GetProperty("PlaceholderText").GetValue(box, null) as string;
            if (!string.IsNullOrEmpty(placeholder) && text == placeholder)
                return "";

            return text;
        }

        static TextBox InnerTextBox(Control box)
        {
            FieldInfo field = box.GetType().GetField("textBox1", BindingFlags.Instance | BindingFlags.NonPublic);
            return field == null ? null : field.GetValue(box) as TextBox;
        }

        static string ToHex(byte[] bytes)
        {
            return BitConverter.ToString(bytes).Replace("-", "");
        }

        static string Fingerprint(string hexKey)
        {
            byte[] keyBytes = HexToBytes(hexKey);
            using (SHA256 sha = SHA256.Create())
            {
                byte[] hash = sha.ComputeHash(keyBytes);
                return BitConverter.ToString(hash, 0, 6).Replace("-", ":");
            }
        }

        static byte[] HexToBytes(string hex)
        {
            byte[] bytes = new byte[hex.Length / 2];
            for (int i = 0; i < bytes.Length; i++)
                bytes[i] = Convert.ToByte(hex.Substring(i * 2, 2), 16);
            return bytes;
        }
    }
}
