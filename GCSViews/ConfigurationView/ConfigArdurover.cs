using MissionPlanner.ArduPilot;
using MissionPlanner.Controls;
using MissionPlanner.Utilities;
using System;
using System.Collections;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MissionPlanner.GCSViews.ConfigurationView
{
    public partial class ConfigArdurover : MyUserControl, IActivate
    {
        // from http://stackoverflow.com/questions/2512781/winforms-big-paragraph-tooltip/2512895#2512895
        private const int maximumSingleLineTooltipLength = 50;
        private static readonly Hashtable tooltips = new Hashtable();
        private readonly Hashtable changes = new Hashtable();
        internal bool startup = true;

        public ConfigArdurover()
        {
            InitializeComponent();
        }

        public void Activate()
        {
            if (!MainSerb.comPort.BaseStream.IsOpen)
            {
                Enabled = false;
                return;
            }
            if (MainSerb.comPort.MAV.cs.firmware == Firmwares.ArduRover)
            {
                Enabled = true;
            }
            else
            {
                Enabled = false;
                return;
            }

            startup = true;

            CH7_OPTION.setup(new[] { "CH7_OPTION", "RC7_OPTION" }, MainSerb.comPort.MAV.param);
            CH8_OPTION.setup(new[] { "CH8_OPTION", "RC8_OPTION" }, MainSerb.comPort.MAV.param);
            CH9_OPTION.setup(new[] { "CH9_OPTION", "RC9_OPTION" }, MainSerb.comPort.MAV.param);
            CH10_OPTION.setup(new[] { "CH10_OPTION", "RC10_OPTION" }, MainSerb.comPort.MAV.param);

            ATC_BRAKE.setup(new[] { "ATC_BRAKE" }, MainSerb.comPort.MAV.param);
            MOT_PWM_TYPE.setup(new[] { "MOT_PWM_TYPE" }, MainSerb.comPort.MAV.param);

            STEER2SRV_P.setup(0, 0, 1, 0.1f, new[] { "STEER2SRV_P", "ATC_STR_RAT_P" }, MainSerb.comPort.MAV.param);
            STEER2SRV_I.setup(0, 0, 1, 0.1f, new[] { "STEER2SRV_I", "ATC_STR_RAT_I" }, MainSerb.comPort.MAV.param);
            STEER2SRV_D.setup(0, 0, 1, 0.1f, new[] { "STEER2SRV_D", "ATC_STR_RAT_D" }, MainSerb.comPort.MAV.param);
            STEER2SRV_IMAX.setup(0, 0, 1, 0.1f, new[] { "STEER2SRV_IMAX", "ATC_STR_RAT_IMAX" }, MainSerb.comPort.MAV.param);
            ATC_STR_RAT_FF.setup(0, 100, 1, 0.1f, "ATC_STR_RAT_FF", MainSerb.comPort.MAV.param);

            TURN_RADIUS.setup(0, 0, 1, 0.1f, "TURN_RADIUS", MainSerb.comPort.MAV.param);

            SPEED2THR_P.setup(0, 0, 1, 0.1f, new[] { "SPEED2THR_P", "ATC_SPEED_P" }, MainSerb.comPort.MAV.param);
            SPEED2THR_I.setup(0, 0, 1, 0.1f, new[] { "SPEED2THR_I", "ATC_SPEED_I" }, MainSerb.comPort.MAV.param);
            SPEED2THR_D.setup(0, 0, 1, 0.1f, new[] { "SPEED2THR_D", "ATC_SPEED_D" }, MainSerb.comPort.MAV.param);
            SPEED2THR_IMAX.setup(0, 0, 1, 0.1f, new[] { "SPEED2THR_IMAX", "ATC_SPEED_IMAX" }, MainSerb.comPort.MAV.param);
            ATC_ACCEL_MAX.setup(0, 0, 1, 0.1f, "ATC_ACCEL_MAX", MainSerb.comPort.MAV.param);
            WP_SPEED.setup(0, 100, 1, 0.1f, "WP_SPEED", MainSerb.comPort.MAV.param);

            CRUISE_SPEED.setup(0, 0, 1, 0.1f, "CRUISE_SPEED", MainSerb.comPort.MAV.param);
            CRUISE_THROTTLE.setup(0, 0, 1, 1, "CRUISE_THROTTLE", MainSerb.comPort.MAV.param);
            THR_MIN.setup(0, 0, 1, 1, new[] { "THR_MIN", "MOT_THR_MIN" }, MainSerb.comPort.MAV.param);
            THR_MAX.setup(0, 0, 1, 1, new[] { "THR_MAX", "MOT_THR_MAX" }, MainSerb.comPort.MAV.param);

            WP_RADIUS.setup(0, 0, 1, 0.1f, "WP_RADIUS", MainSerb.comPort.MAV.param);
            WP_OVERSHOOT.setup(0, 0, 1, 0.1f, "WP_OVERSHOOT", MainSerb.comPort.MAV.param);
            TURN_G_MAX.setup(0, 0, 1, 0.1f, new[] { "TURN_MAX_G", "ATC_TURN_MAX_G" }, MainSerb.comPort.MAV.param);
            NAVL1_PERIOD.setup(0, 0, 1, 1, "NAVL1_PERIOD", MainSerb.comPort.MAV.param);
            NAVL1_DAMPING.setup(0, 0, 1, 0.05f, "NAVL1_DAMPING", MainSerb.comPort.MAV.param);

            if (MainSerb.comPort.MAV.param["SONAR_TRIGGER_CM"] == null && MainSerb.comPort.MAV.param["RNGFND_TRIGGR_CM"] == null)
            {
                groupBox1.Visible = false;
            }
            
            SONAR_TRIGGER_CM.setup(0, 0, 1, 1, new[] { "SONAR_TRIGGER_CM", "RNGFND_TRIGGR_CM" }, MainSerb.comPort.MAV.param);
            SONAR_TURN_ANGLE.setup(0, 0, 1, 1, new[] { "SONAR_TURN_ANGLE", "RNGFND_TURN_ANGL" }, MainSerb.comPort.MAV.param);
            SONAR_TURN_TIME.setup(0, 0, 1, 1, new[] { "SONAR_TURN_TIME", "RNGFND_TURN_TIME" }, MainSerb.comPort.MAV.param);
            SONAR_DEBOUNCE.setup(0, 0, 1, 1, new[] { "SONAR_DEBOUNCE", "RNGFND_DEBOUNCE" }, MainSerb.comPort.MAV.param);

            changes.Clear();

            // add tooltips to all controls
            foreach (Control control1 in Controls)
            {
                foreach (Control control2 in control1.Controls)
                {
                    if (control2 is MavlinkNumericUpDown)
                    {
                        var ParamName = ((MavlinkNumericUpDown)control2).ParamName;
                        toolTip1.SetToolTip(control2,
                            ParameterMetaDataRepository.GetParameterMetaData(ParamName,
                                ParameterMetaDataConstants.Description, MainSerb.comPort.MAV.cs.firmware.ToString()));
                    }
                    if (control2 is MavlinkComboBox)
                    {
                        var ParamName = ((MavlinkComboBox)control2).ParamName;
                        toolTip1.SetToolTip(control2,
                            ParameterMetaDataRepository.GetParameterMetaData(ParamName,
                                ParameterMetaDataConstants.Description, MainSerb.comPort.MAV.cs.firmware.ToString()));
                    }
                }
            }

            startup = false;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.S))
            {
                BUT_writePIDS_Click(null, null);
                return true;
            }

            return false;
        }

        private static string AddNewLinesForTooltip(string text)
        {
            if (text.Length < maximumSingleLineTooltipLength)
                return text;
            var lineLength = (int)Math.Sqrt(text.Length) * 2;
            var sb = new StringBuilder();
            var currentLinePosition = 0;
            for (var textIndex = 0; textIndex < text.Length; textIndex++)
            {
                // If we have reached the target line length and the next      
                // character is whitespace then begin a new line.   
                if (currentLinePosition >= lineLength &&
                    char.IsWhiteSpace(text[textIndex]))
                {
                    sb.Append(Environment.NewLine);
                    currentLinePosition = 0;
                }
                // If we have just started a new line, skip all the whitespace.    
                if (currentLinePosition == 0)
                    while (textIndex < text.Length && char.IsWhiteSpace(text[textIndex]))
                        textIndex++;
                // Append the next character.     
                if (textIndex < text.Length) sb.Append(text[textIndex]);
                currentLinePosition++;
            }
            return sb.ToString();
        }

        private void BUT_writePIDS_Click(object sender, EventArgs e)
        {
            var temp = (Hashtable)changes.Clone();

            foreach (string value in temp.Keys)
            {
                try
                {
                    if ((float)changes[value] > (float)MainSerb.comPort.MAV.param[value] * 2.0f)
                        if (
                            CustomMessageBox.Show(value + " has more than doubled the last input. Are you sure?",
                                "Large Value", MessageBoxButtons.YesNo) == (int)DialogResult.No)
                            return;

                    if (MainSerb.comPort.BaseStream == null || !MainSerb.comPort.BaseStream.IsOpen)
                    {
                        CustomMessageBox.Show("Your are not connected", Strings.ERROR);
                        return;
                    }

                    MainSerb.comPort.setParam(value, (float)changes[value]);

                    try
                    {
                        // set control as well
                        var textControls = Controls.Find(value, true);
                        if (textControls.Length > 0)
                        {
                            textControls[0].BackColor = Color.FromArgb(0x43, 0x44, 0x45);
                        }
                    }
                    catch
                    {
                    }
                }
                catch
                {
                    CustomMessageBox.Show(string.Format(Strings.ErrorSetValueFailed, value), Strings.ERROR);
                }
            }
        }

        /// <summary>
        ///     Handles the Click event of the BUT_rerequestparams control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        protected void BUT_rerequestparams_Click(object sender, EventArgs e)
        {
            if (!MainSerb.comPort.BaseStream.IsOpen)
                return;

            ((Control)sender).Enabled = false;

            try
            {
                MainSerb.comPort.getParamList();
            }
            catch (Exception ex)
            {
                CustomMessageBox.Show(Strings.ErrorReceivingParams + ex, Strings.ERROR);
            }


            ((Control)sender).Enabled = true;

            Activate();
        }

        private void BUT_refreshpart_Click(object sender, EventArgs e)
        {
            if (!MainSerb.comPort.BaseStream.IsOpen)
                return;

            ((Control)sender).Enabled = false;


            updateparam(this);

            ((Control)sender).Enabled = true;


            Activate();
        }

        private void updateparam(Control parentctl)
        {
            foreach (Control ctl in parentctl.Controls)
            {
                if (typeof(NumericUpDown) == ctl.GetType() || typeof(ComboBox) == ctl.GetType())
                {
                    try
                    {
                        MainSerb.comPort.GetParam(ctl.Name);
                    }
                    catch
                    {
                    }
                }

                if (ctl.Controls.Count > 0)
                {
                    updateparam(ctl);
                }
            }
        }

        public struct paramsettings // hk's
        {
            public string desc;
            public float maxvalue;
            public float minvalue;
            public string name;
            public float normalvalue;
            public float scale;
        }
    }
}