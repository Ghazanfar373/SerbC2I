using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Configuration;
namespace MissionPlanner.Controls
{
    [System.ComponentModel.DefaultBindingProperty("status")]
    public partial class MavlinkMsgViewControl : UserControl
    {
       // private const string V = "hudStatus";

        public MavlinkMsgViewControl()
        {
            InitializeComponent();
        }
        [System.ComponentModel.Browsable(true), DefaultValue(true)]
        public new string status {
            get { return labelStatus.Text.ToString(); }
            set { labelStatus.Text = value;
                //this.Invalidate();
                }
            

            //get => labelStatus.Text;
            //set => labelStatus.Text = value;
        }
        [System.ComponentModel.Browsable(true), DefaultValue(true)]
        public new string message {
            get => labelMessage.Text.ToString();
            set  { labelMessage.Text = value;
                this.Invalidate();
            }
        }
        
        //[Browsable(true)]
        //public new string warning
        //{
        //    get => labelMessage.Text;
        //    set => labelMessage.Text = value;
        //}
        
    }
    
}
