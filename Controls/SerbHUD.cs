using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MissionPlanner.Controls
{
    [System.ComponentModel.DefaultBindingProperty("hudStatus")]
    public partial class SerbHUD : UserControl
    {
        public SerbHUD()
        {
            InitializeComponent();
        }

        //[System.ComponentModel.Browsable(true), DefaultValue(true)]
        //public new string message
        //{
        //    get => lblMessage.Text.ToString();
        //    set
        //    {
        //        lblMessage.Text = value;
        //        this.Invalidate();
        //    }
        //}

    }
}
