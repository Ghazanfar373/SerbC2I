using System;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    public partial class Vibration : Form
    {
        public Vibration()
        {
            InitializeComponent();

            Utilities.ThemeManager.ApplyThemeTo(this);

            timer1.Start();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            VibBarX.Value = (int)MainSerb.comPort.MAV.cs.vibex;
            VibBarY.Value = (int)MainSerb.comPort.MAV.cs.vibey;
            VibBarZ.Value = (int)MainSerb.comPort.MAV.cs.vibez;

            txt_clip0.Text = MainSerb.comPort.MAV.cs.vibeclip0.ToString();
            txt_clip1.Text = MainSerb.comPort.MAV.cs.vibeclip1.ToString();
            txt_clip2.Text = MainSerb.comPort.MAV.cs.vibeclip2.ToString();
        }
    }
}