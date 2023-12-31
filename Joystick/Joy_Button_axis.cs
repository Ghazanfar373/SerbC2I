﻿using System;
using System.Windows.Forms;

namespace MissionPlanner.Joystick
{
    public partial class Joy_Button_axis : Form
    {
        public Joy_Button_axis(string name)
        {
            InitializeComponent();

            Utilities.ThemeManager.ApplyThemeTo(this);

            this.Tag = name;

            var config = MainSerb.joystick.getButton(int.Parse(name));

            numericUpDownpwmmin.Text = config.p1.ToString();
            numericUpDownpwmmax.Text = config.p2.ToString();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var config = MainSerb.joystick.getButton(int.Parse(this.Tag.ToString()));

            config.p1 = (float)numericUpDownpwmmin.Value;

            MainSerb.joystick.setButton(int.Parse(this.Tag.ToString()), config);
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            var config = MainSerb.joystick.getButton(int.Parse(this.Tag.ToString()));

            config.p2 = (float)numericUpDownpwmmax.Value;

            MainSerb.joystick.setButton(int.Parse(this.Tag.ToString()), config);
        }
    }
}