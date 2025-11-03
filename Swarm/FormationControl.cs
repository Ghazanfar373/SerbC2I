using MissionPlanner.Utilities;
using ProjNet.CoordinateSystems;
using ProjNet.CoordinateSystems.Transformations;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using GeoAPI.CoordinateSystems;
using GeoAPI.CoordinateSystems.Transformations;
using HUD_Claude;
using Xamarin.Forms.PlatformConfiguration.TizenSpecific;
using Dowding.Model;
using static MAVLink;

namespace MissionPlanner.Swarm
{
    public partial class FormationControl : UserControl
    {
        Formation SwarmInterface = null;
        bool threadrun = false;
        bool isInit = false;
        Dictionary<String, MAVState> mavStates;
        public FormationControl()
        {
            InitializeComponent();
            SwarmInterface = new Formation();
            init(); 
        }
        public void init() {
           
           
            
                updateicons();
                //swarmHud1.ArmButtonClick += buttonARM_Click;
                grid1.MouseWheel += new MouseEventHandler(FollowLeaderControl_MouseWheel);
                //MessageBox.Show("this is beta, use at own risk");
                MissionPlanner.Utilities.Tracking.AddPage(this.GetType().ToString(), this.Text);
            
        }
    private void updateCMBPorts()
    {
        mavStates = new Dictionary<string, MAVState>();
        foreach (var port in MainSerb.Comports)
        {
            foreach (var mav in port.MAVlist)
            {
                mavStates.Add(port.BaseStream.PortName + " " + mav.sysid + " " + mav.compid, mav);
            }
        }
        if (mavStates.Count != 0)
        {
            //  return;
            //CMB_mavs.SuspendLayout();
            bindingSource1.DataSource = mavStates;
            CMB_mavs.DataSource = bindingSource1;
            //CMB_mavs.Items.Add(mavStates);
            CMB_mavs.ValueMember = "Value";
            CMB_mavs.DisplayMember = "Key";
            //updateicons();

            //MessageBox.Show("After Update Icons");
           // CMB_mavs.ResumeLayout();
            //this.Invalidate();
        }
    
        }
        private void SwarmHud1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void FollowLeaderControl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta < 0)
            {
                grid1.setScale(grid1.getScale() + 2);
            }
            else
            {
                grid1.setScale(grid1.getScale() - 2);
            }
        }

        void updateicons()
        {
           updateCMBPorts();

            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                    if (mav == SwarmInterface.getLeader())
                    {
                        ((Formation)SwarmInterface).setOffsets(mav, 0, 0, 0);
                        var vector = SwarmInterface.getOffsets(mav);
                        grid1.UpdateIcon(mav, (float)vector.x, (float)vector.y, (float)vector.z, false);
                    }
                    else
                    {
                        var vector = SwarmInterface.getOffsets(mav);
                        grid1.UpdateIcon(mav, (float)vector.x, (float)vector.y, (float)vector.z, true);
                    }
                }
            }
            grid1.Invalidate();
        }

        private void CMB_mavs_SelectedIndexChanged(object sender, EventArgs e)
        {
            //init();
            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                    if (mav == CMB_mavs.SelectedValue)
                    {
                        MainSerb.comPort = port;
                        port.sysidcurrent = mav.sysid;
                        port.compidcurrent = mav.compid;
                    }
                }
            }
        }

        private void BUT_Start_Click(object sender, EventArgs e)
        {
            if (threadrun == true)
            {
                threadrun = false;
                BUT_Start.Text = Strings.Start;
                return;
            }

            if (SwarmInterface != null)
            {
                new System.Threading.Thread(mainloop) { IsBackground = true }.Start();
                BUT_Start.Text = Strings.Stop;
            }
        }

        void mainloop()
        {
            threadrun = true;

            // make sure leader is high freq updates
            SwarmInterface.Leader.parent.requestDatastream(MAVLink.MAV_DATA_STREAM.POSITION, 10, SwarmInterface.Leader.sysid, SwarmInterface.Leader.compid);
            SwarmInterface.Leader.cs.rateposition = 10;
            SwarmInterface.Leader.cs.rateattitude = 10;

            while (threadrun && !this.IsDisposed)
            {
                // update leader pos
                SwarmInterface.Update();

                // update other mavs
                SwarmInterface.SendCommand();

                // 10 hz
                System.Threading.Thread.Sleep(100);
            }
        }

        private void BUT_Arm_Click(object sender, EventArgs e)
        {

        }

        private void BUT_Disarm_Click(object sender, EventArgs e)
        {
            if (SwarmInterface != null)
            {
                SwarmInterface.Disarm();
            }
        }

        private void BUT_Takeoff_Click(object sender, EventArgs e)
        {
            if (SwarmInterface != null)
            {
                SwarmInterface.Takeoff();
            }
        }

        private void BUT_Land_Click(object sender, EventArgs e)
        {
            if (SwarmInterface != null)
            {
                SwarmInterface.Land();
            }
        }

        private void BUT_leader_Click(object sender, EventArgs e)
        {
            if (SwarmInterface != null)
            {
                var vectorlead = SwarmInterface.getOffsets(MainSerb.comPort.MAV);

                foreach (var port in MainSerb.Comports)
                {
                    foreach (var mav in port.MAVlist)
                    {
                        var vector = SwarmInterface.getOffsets(mav);

                        SwarmInterface.setOffsets(mav, (float)(vector.x - vectorlead.x),
                            (float)(vector.y - vectorlead.y),
                            (float)(vector.z - vectorlead.z));
                    }
                }

                SwarmInterface.setLeader(MainSerb.comPort.MAV);
                updateicons();
                BUT_Start.Enabled = true;
                BUT_Updatepos.Enabled = true;
            }
        }

        private void BUT_connect_Click(object sender, EventArgs e)
        {
            Comms.CommsSerialScan.Scan(true);

            DateTime deadline = DateTime.Now.AddSeconds(50);

            while (Comms.CommsSerialScan.foundport == false)
            {
                System.Threading.Thread.Sleep(100);

                if (DateTime.Now > deadline)
                {
                    CustomMessageBox.Show("Timeout waiting for autoscan/no mavlink device connected");
                    return;
                }
            }

            bindingSource1.ResetBindings(false);
        }

        public Vector3 getOffsetFromLeader(MAVState leader, MAVState mav)
        {
            //convert Wgs84ConversionInfo to utm
            CoordinateTransformationFactory ctfac = new CoordinateTransformationFactory();

            IGeographicCoordinateSystem wgs84 = GeographicCoordinateSystem.WGS84;

            int utmzone = (int)((leader.cs.lng - -186.0) / 6.0);

            IProjectedCoordinateSystem utm = ProjectedCoordinateSystem.WGS84_UTM(utmzone,
                leader.cs.lat < 0 ? false : true);

            ICoordinateTransformation trans = ctfac.CreateFromCoordinateSystems(wgs84, utm);
            double[] masterpll = { leader.cs.lng, leader.cs.lat };
            // get leader utm coords
            double[] masterutm = trans.MathTransform.Transform(masterpll);
            double[] mavpll = { mav.cs.lng, mav.cs.lat };
            //getLeader follower utm coords
            double[] mavutm = trans.MathTransform.Transform(mavpll);
            var heading = -leader.cs.yaw;
            var norotation = new Vector3(masterutm[1] - mavutm[1], masterutm[0] - mavutm[0], 0);
            norotation.x *= -1;
            norotation.y *= -1;
            return new Vector3(norotation.x * Math.Cos(heading * MathHelper.deg2rad) - norotation.y * Math.Sin(heading * MathHelper.deg2rad), norotation.x * Math.Sin(heading * MathHelper.deg2rad) + norotation.y * Math.Cos(heading * MathHelper.deg2rad), 0);
        }
        private void grid1_UpdateOffsets(MAVState mav, float x, float y, float z, Grid.icon ico)
        {
            if (mav == SwarmInterface.Leader)
            {
                CustomMessageBox.Show("Can not move Leader");
                ico.z = 0;
            }
            else
            {
                ((Formation)SwarmInterface).setOffsets(mav, x, y, z);
            }
        }
        private void Control_FormClosing(object sender, FormClosingEventArgs e)
        {
            threadrun = false;
        }

        private void BUT_Updatepos_Click(object sender, EventArgs e)
        {
            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                    mav.cs.UpdateCurrentSettings(null, true, port, mav);

                    if (mav == SwarmInterface.Leader)
                        continue;

                    Vector3 offset = getOffsetFromLeader(((Formation)SwarmInterface).getLeader(), mav);
                    if (Math.Abs(offset.x) < 200 && Math.Abs(offset.y) < 200)
                    {
                        grid1.UpdateIcon(mav, (float)offset.y, (float)offset.x, (float)offset.z, true);
                        ((Formation)SwarmInterface).setOffsets(mav, offset.y, offset.x, offset.z);
                    }
                }
            }
        }
        private void timer_status_Tick(object sender, EventArgs e)
        {
            //if (!isInit) init();
            // clean up old
            //CMB_mavs.Items.Clear();
            //updateCMBPorts();
            //bindingSource1.DataSource = mavStates;
            //CMB_mavs.DataSource = bindingSource1;
            
            foreach (Control ctl in PNL_status.Controls)
            {
                bool match = false;
                foreach (var port in MainSerb.Comports)
                {
                    foreach (var mav in port.MAVlist)
                    {
                        if (mav == (MAVState)ctl.Tag)
                        {
                            match = true;

                        }
                    }
                }
                if (match == false)
                    ctl.Dispose();
            }
            // setup new
            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                    bool exists = false;
                    //foreach (Control ctl in PNL_status.Controls)
                    //{
                    //    if (ctl is Status && ctl.Tag == mav)
                    //    {
                    //        exists = true;
                    //        ((Status)ctl).GPS.Text = mav.cs.gpsstatus >= 3 ? "OK" : "Bad";
                    //        ((Status)ctl).Armed.Text = mav.cs.armed.ToString();
                    //        ((Status)ctl).Mode.Text = mav.cs.mode;
                    //        ((Status)ctl).MAV.Text = mav.ToString();
                    //        ((Status)ctl).Guided.Text = mav.GuidedMode.x / 1e7 + "," + mav.GuidedMode.y / 1e7 + "," +
                    //                                     mav.GuidedMode.z;
                    //        ((Status)ctl).Location1.Text = mav.cs.lat + "," + mav.cs.lng + "," +
                    //                                        mav.cs.alt;
                    //        if (mav == SwarmInterface.Leader)
                    //        {
                    //            ((Status)ctl).ForeColor = Color.Red;
                    //        }
                    //        else
                    //        {
                    //            ((Status)ctl).ForeColor = Color.Black;
                    //        }
                    //    }
                    //}

                    //if (!exists)
                    //{
                    //    Status newstatus = new Status();
                    //    newstatus.Tag = mav;
                    //    PNL_status.Controls.Add(newstatus);
                    //}
                    foreach (Control ctl in flowLayoutPanelSwarm.Controls)
                    {
                        if (ctl is SwarmHud && ctl.Tag == mav)
                        {
                            exists = true;
                            // ((SwarmHud)ctl).GPS = mav.cs.gpsstatus >= 3 ? "OK" : "Bad";
                            ((SwarmHud)ctl).Roll = mav.cs.roll;
                            ((SwarmHud)ctl).Pitch = mav.cs.pitch;
                            ((SwarmHud)ctl).Heading = mav.cs.yaw;
                            ((SwarmHud)ctl).isArm = mav.cs.armed;
                            ((SwarmHud)ctl).ApMode = mav.cs.mode;
                            ((SwarmHud)ctl).VehicleInfo=mav.ToString();
                            ((SwarmHud)ctl).GPS=mav.cs.gpsstatus >=3 ? true : false;
                            //((SwarmHud)ctl).MAV.Text = mav.ToString();
                            //((SwarmHud)ctl).Guided.Text = mav.GuidedMode.x / 1e7 + "," + mav.GuidedMode.y / 1e7 + "," +
                            //                             mav.GuidedMode.z;
                            //((Status)ctl).Location1.Text = mav.cs.lat + "," + mav.cs.lng + "," +
                            //                                mav.cs.alt;
                            if (mav == SwarmInterface.Leader)
                            {
                                ((SwarmHud)ctl).ForeColor = Color.Red;
                            }
                            else
                            {
                                ((SwarmHud)ctl).ForeColor = Color.Black;
                            }
                        }
                    }

                    if (!exists)
                    {
                        SwarmHud newstatus = new SwarmHud();
                        newstatus.Tag = mav;
                        newstatus.GetArmButton().Click += (s, ee) =>
                        {
                        ArmformPanel(mav.ToString());
                        };
                        newstatus.GetLoiterButton().Click += (s, ee) =>
                        {
                        LoiterformPanel(mav.ToString());
                        };
                        flowLayoutPanelSwarm.Controls.Add(newstatus);
                    }
                }
            }
        }

        public void ArmformPanel(string sysId) {
            if (SwarmInterface != null)
            {
                SwarmInterface.ArmSelected(sysId);
            }
        }
        public void LoiterformPanel(string sysId)
        {
            if (SwarmInterface != null)
            {
                SwarmInterface.LoiterSelected(sysId);
            }
        }


        private void but_guided_Click(object sender, EventArgs e)
        {
            if (SwarmInterface != null)
            {
                SwarmInterface.GuidedMode();
            }
        }

        private void but_auto_Click(object sender, EventArgs e)
        {
            if (SwarmInterface != null)
            {
                SwarmInterface.AutoMode();
            }
        }
        int counter = 0;
        private void buttonARM_Click(object sender, EventArgs e)
        {
            counter++;
            
            //switch (counter)
            //{
            //    case 1:
            //        swarmHud1.isArm = true;
            //        swarmHud1.ApMode = "STABILIZE";
            //        break;
            //    case 2:
            //        swarmHud1.isArm = true;
            //        swarmHud1.ApMode = "Manual";
            //        break;
            //    case 3:

            //        swarmHud1.isArm = true;
            //        swarmHud1.ApMode = "Guided";
            //        break;
            //    case 4:
            //        swarmHud1.isArm = true;
            //        swarmHud1.ApMode = "lOITER";
            //        counter = 0;
            //        break;
            //    case 5:
            //        swarmHud1.isArm = true;
            //        swarmHud1.ApMode = "ALT_HOLD";
            //        counter = 0;
            //        break;     
            //}
        }

        private void But_ArmAll_Click(object sender, EventArgs e)
        {
            if (SwarmInterface != null)
            {
                SwarmInterface.ArmAll();
            }
        }

        private void CMB_mavs_DropDown(object sender, EventArgs e)
        {
            updateCMBPorts();
        }
    }
}