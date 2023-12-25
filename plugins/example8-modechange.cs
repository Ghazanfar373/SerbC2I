using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MissionPlanner.Utilities;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using MissionPlanner;
using MissionPlanner.Controls;

namespace ModeChange
{
    public class Plugin : MissionPlanner.Plugin.Plugin
    {
        private int hashcode;
        private ToolStripComboBox modecmb;
        private string currentmode;
        private bool inchange;
        private bool setwithnosend;

        public override string Name
        {
            get { return "Mode Change Widget"; }
        }

        public override string Version
        {
            get { return "0.1"; }
        }

        public override string Author
        {
            get { return "Michael Oborne"; }
        }

        public override bool Init()
        {
            return false;
        }

        public override bool Loaded()
        {
            modecmb = new ToolStripComboBox();
            ThemeManager.ApplyThemeTo(modecmb);
            modecmb.SelectedIndexChanged += Modecmb_SelectedValueChanged;
            MainSerb.instance.MainMenu.Items.Add(modecmb);
            return true;
        }

        private void Modecmb_SelectedValueChanged(object sender, EventArgs e)
        {
            inchange = true;
            try
            {
                currentmode = modecmb.SelectedItem.ToString();
                if(setwithnosend)
                    return;
                MainSerb.comPort.setMode((byte) MainSerb.comPort.sysidcurrent, (byte) MainSerb.comPort.compidcurrent,
                    modecmb.SelectedItem?.ToString());
            }
            catch
            {
                CustomMessageBox.Show(Strings.ErrorNoResponce, Strings.ERROR);
            }
            finally
            {
                inchange = false;
                modecmb.BackColor = ThemeManager.BGColorTextBox;
                modecmb.ForeColor = ThemeManager.TextColor;
            }
        }

        public override bool Loop()
        {
            if (MainSerb.comPort.BaseStream != null && MainSerb.comPort.BaseStream.IsOpen)
            {
                if (MainSerb.comPort.GetHashCode() != hashcode)
                {
                    MainSerb.instance.BeginInvokeIfRequired(() =>
                    {
                        modecmb.Enabled = true;

                        hashcode = MainSerb.comPort.GetHashCode();
                        
                        MainSerb.comPort.MavChanged -= ComPort_MavChanged;
                        MainSerb.comPort.MavChanged += ComPort_MavChanged;

                        ComPort_MavChanged(null, null);
                    });
                }

                if (MainSerb.comPort.MAV.cs.mode != currentmode)
                {
                    if (!inchange)
                        MainSerb.instance.BeginInvokeIfRequired(() =>
                        {
                            setwithnosend = true;
                            modecmb.Enabled = true;
                            modecmb.Text = MainSerb.comPort.MAV.cs.mode;
                            setwithnosend = false;
                        });
                }
            }
            else
            {
                if (modecmb.Enabled)
                    MainSerb.instance.BeginInvokeIfRequired(() =>
                    {
                        modecmb.Enabled = false;
                    });
            }

            loopratehz = 0.3f;
            return true;
        }

        private void ComPort_MavChanged(object sender, EventArgs e)
        {
            MainSerb.instance.BeginInvokeIfRequired(() =>
            {
                modecmb.Items.Clear();

                ParameterMetaDataRepository
                    .GetParameterOptionsInt("FLTMODE1", MainSerb.comPort.MAV.cs.firmware.ToString())
                    .ForEach(a => modecmb.Items.Add(a.Value));

                ThemeManager.ApplyThemeTo(modecmb);
            });
        }

        public override bool Exit()
        {
            return true;
        }
    }
}