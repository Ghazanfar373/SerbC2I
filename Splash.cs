using System;
using System.Reflection;
using System.Windows.Forms;

namespace MissionPlanner
{
    public partial class Splash : Form
    {
        int progressval = 0;
        public Splash()
        {
            InitializeComponent();

            string strVersion = typeof(Splash).GetType().Assembly.GetName().Version.ToString();

            TXT_version.Text = "Version: " + Application.ProductVersion; // +" Build " + strVersion;

            Console.WriteLine(strVersion);

            timerSplash.Start();
            if (Program.Logo != null)
            {
                //pictureBox1.BackgroundImage = MissionPlanner.Properties.Resources.bgdark;
                //pictureBox1.Image = Program.Logo;
                //pictureBox1.Visible = true;
                //rjProgressBar.Value = 90;
            }

            Console.WriteLine("Splash .ctor");
        }

        private void labelHeader1_Click(object sender, EventArgs e)
        {

        }

        private void timerSplash_Tick(object sender, EventArgs e)
        {
            progressval += 33;

            if (progressval > 100) { progressval = 100; progressBarSplash.Value = progressval; timerSplash.Stop(); }
            progressBarSplash.Value = progressval;

        }
    }
}