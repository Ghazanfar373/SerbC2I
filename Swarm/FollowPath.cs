﻿using MissionPlanner.Utilities;
using System.Collections.Generic;

namespace MissionPlanner.Swarm
{
    /// <summary>
    /// Follow the trail of the leader
    /// </summary>
    class FollowPath : Swarm
    {
        // save the leaders trail
        List<PointLatLngAlt> trail = new List<PointLatLngAlt>();
        float FollowDistance = 2;

        public override void Update()
        {
            if (MainSerb.comPort.MAV.cs.lat == 0 || MainSerb.comPort.MAV.cs.lng == 0)
                return;

            if (Leader == null)
                Leader = MainSerb.comPort.MAV;

            trail.Add(new PointLatLngAlt(MainSerb.comPort.MAV.cs.lat, MainSerb.comPort.MAV.cs.lng, MainSerb.comPort.MAV.cs.alt,
                ""));
        }

        public override void SendCommand()
        {
            if (trail.Count == 0)
                return;

            // get the path
            List<PointLatLngAlt> newpositions = PlanMove();
            int a = 0;

            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                    if (mav == Leader)
                        continue;

                    // check we have a valid point for this mav
                    if (a < newpositions.Count)
                    {
                        // get the point for this sepecific mav
                        PointLatLngAlt target = newpositions[a];

                        // send it
                        port.setGuidedModeWP(mav.sysid, mav.compid, new Locationwp()
                        {
                            alt = (float)target.Alt,
                            lat = target.Lat,
                            lng = target.Lng,
                            id = (ushort)MAVLink.MAV_CMD.WAYPOINT
                        });
                    }
                }
            }
        }

        List<PointLatLngAlt> PlanMove()
        {
            List<PointLatLngAlt> currentpos = new List<PointLatLngAlt>();

            // get current pos
            foreach (var port in MainSerb.Comports)
            {
                foreach (var mav in port.MAVlist)
                {
                    currentpos.Add(new PointLatLngAlt(mav.cs.lat, mav.cs.lng, mav.cs.alt, ""));
                }
            }

            // check they are not to close already

            foreach (var lla in currentpos)
            {
                foreach (var lla2 in currentpos)
                {
                    double dist = lla.GetDistance(lla2);

                    if (dist < (FollowDistance / 2))
                    {
                        // do nothing yet
                        //Stop();
                        //return;
                    }
                }
            }

            // get planned pos.
            List<PointLatLngAlt> pathwithseperation = new List<PointLatLngAlt>();

            PointLatLngAlt current = trail[0];

            // generate path with distance gaps
            for (int a = 0; a < 20; a++)
            {
                PointLatLngAlt target = FindTrailPnt(current);
                if (target != null)
                {
                    pathwithseperation.Add(target);
                    current = target;
                }
            }

            return pathwithseperation;

            // find closest MAV


            // check intersect
        }

        PointLatLngAlt FindTrailPnt(PointLatLngAlt from)
        {
            // get the start point for the distance
            int start = trail.IndexOf(from);

            for (int i = start + 1; i < trail.Count; i++)
            {
                double dist = from.GetDistance(trail[i]); // 2d distance
                if (dist > FollowDistance)
                {
                    return trail[i];
                }
            }

            return null;
        }
    }
}