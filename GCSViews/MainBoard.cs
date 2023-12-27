using MissionPlanner.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace MissionPlanner.GCSViews
{
    public partial class MainBoard : MyUserControl,IActivate,IDeactivate
    {
        bool flagLed = false;
        WPDialog wPDialog;
        public MainBoard()
        {
            InitializeComponent();
           
        }

        public void Activate()
        {
            //throw new NotImplementedException();
            
        }

        public void Deactivate()
        {
          //  throw new NotImplementedException();
        }

        private void klcButton10_Click(object sender, EventArgs e)
        {

        }

        private void CMB_modes1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void klcButton9_Click(object sender, EventArgs e)
        {

        }

        private void CMB_setwp_Click(object sender, EventArgs e)
        {

        }

        private void btnLed_Click(object sender, EventArgs e)
        {
            timerLed.Start();
            timerLed.Interval = 100;
            
           
        }

        private void timerLed_Tick(object sender, EventArgs e)
        {
            if (flagLed)
            {
                ledBulb.On = true; flagLed = false;
            }
            else{ ledBulb.On = false;flagLed = true; }
            
        }

        private void btnledstop_Click(object sender, EventArgs e)
        {
            timerLed.Stop();
        }

        private void klcButton13_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel11_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void rjToggleBtnArm_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void labeledTextBox1_Load(object sender, EventArgs e)
        {

        }

        private void rjButtonStatus_Click(object sender, EventArgs e)
        {
           
        }
        bool flag = false;
        private void btnledstop_MouseEnter(object sender, EventArgs e)
        {
            wPDialog = new WPDialog();
            if (flag == false)
            {
                flag = true;
                wPDialog.ShowDialog();
            }
         
            Console.WriteLine("Mouse Entered!");
        }

        private void btnledstop_MouseLeave(object sender, EventArgs e)
        {
            if (flag == true)
            {
                flag = false;
                this.wPDialog.Close();
            }
            
            Console.WriteLine("Mouse Leaved!");

        }
    }
}
