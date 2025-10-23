using log4net;
using MissionPlanner.ArduPilot;
using System.Reflection;
using System.Windows;
using Xamarin.Essentials;

namespace MissionPlanner.Swarm
{
    abstract class Swarm
    {
        internal static readonly ILog log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        internal MAVState Leader = null;

        public void setLeader(MAVState lead)
        {
            Leader = lead;
        }

        public MAVState getLeader()
        {
            return Leader;
        }

        public void Arm()
        {
            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                    if (mav == Leader)
                        continue;

                    port.doARM(mav.sysid, mav.compid, true);
                }
            }
        }
        //Arm All
        public void ArmAll()
        {
            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                    //if (mav == Leader)
                    //    continue;

                    port.doARM(mav.sysid, mav.compid, true);
                }
            }
        }
        //Arm Selected One
         public void ArmSelected(string mavid)
        {
           // int counter = 0;
            //string list="";
            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                   
                   
                    if(mavid==mav.sysid.ToString())    //compare with SysId always 
                    port.doARM(mav.sysid, mav.compid, true);
                   
                   // list += "Mav SysID: " + mav.sysid + " MavCompId: " + mav.compid + " Counter "+counter+"\r\n";
                }
                //counter++;
            }
           // MessageBox.Show(list);
        }


        public void LoiterSelected(string sysID) {
            try
            {
                foreach (var port in MainSerb.Comports)
                {
                    foreach (var mav in port.MAVlist)
                    {


                        if (sysID == mav.sysid.ToString())    //compare with SysId always 
                            port.setMode(mav.sysid, mav.compid, "Loiter");

                        // list += "Mav SysID: " + mav.sysid + " MavCompId: " + mav.compid + " Counter "+counter+"\r\n";
                    }
                    //counter++;
                }
            }
            catch
            {
                MessageBox.Show(Strings.CommandFailed, Strings.ERROR);
            }

            //((Control)sender).Enabled = true;


        } 

        public void Disarm()
        {
            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                    if (mav == Leader)
                        continue;

                    port.doARM(mav.sysid, mav.compid, false);
                }
            }
        }

        public void Takeoff()
        {
            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                    if (mav == Leader)
                        continue;

                    port.setMode(mav.sysid, mav.compid, "GUIDED");

                    port.doCommand(mav.sysid, mav.compid, MAVLink.MAV_CMD.TAKEOFF, 0, 0, 0, 0, 0, 0, 5);
                }
            }
        }

        public void Land()
        {
            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                    port.setMode(mav.sysid, mav.compid, "Land");
                }
            }
        }

        public void Stop()
        {
        }

        public void GuidedMode()
        {
            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                    if (mav == Leader)
                        continue;

                    port.setMode(mav.sysid, mav.compid, "GUIDED");
                }
            }
        }

        public void AutoMode()
        {
            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                    if (mav == Leader)
                        continue;

                    port.setMode(mav.sysid, mav.compid, "AUTO");
                }
            }
        }

        public abstract void Update();

        public abstract void SendCommand();
    }
}