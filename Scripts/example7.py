import sys
import math
import clr
import time
clr.AddReference("MissionPlanner")
import MissionPlanner
clr.AddReference("MissionPlanner.Utilities") # includes the Utilities class

print 'Start Script'

MissionPlanner.MainSerb.instance.FlightPlanner.BUT_read_Click(MissionPlanner.MainSerb.instance.FlightPlanner,null)

