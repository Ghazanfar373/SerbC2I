using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using MissionPlanner.GCSViews;
using MissionPlanner.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MissionPlanner
{
    public class Script
    {
        Microsoft.Scripting.Hosting.ScriptEngine engine;
        Microsoft.Scripting.Hosting.ScriptScope scope;

        // keeps history
        MAVLink.mavlink_rc_channels_override_t rc = new MAVLink.mavlink_rc_channels_override_t();

        public StringRedirectWriter OutputWriter { get; private set; }

        public Script(bool redirectOutput = false)
        {
            Dictionary<string, object> options = new Dictionary<string, object>();
            options["Debug"] = true;

            if (engine != null)
                engine.Runtime.Shutdown();

            engine = Python.CreateEngine(options);

            var paths = engine.GetSearchPaths();
            paths.Add(Settings.GetRunningDirectory() + "Lib.zip");
            paths.Add(Settings.GetRunningDirectory() + "lib");
            paths.Add(Settings.GetRunningDirectory());
            engine.SetSearchPaths(paths);

            scope = engine.CreateScope();

            var all = System.Reflection.Assembly.GetExecutingAssembly();
            var asss = AppDomain.CurrentDomain.GetAssemblies();
            foreach (var ass in asss)
            {
                engine.Runtime.LoadAssembly(ass);
            }
            scope.SetVariable("MainSerb", MainSerb.instance);
            scope.SetVariable("FlightPlanner", FlightPlanner.instance);
            scope.SetVariable("FlightData", FlightData.instance);
            scope.SetVariable("Ports", MainSerb.Comports);
            scope.SetVariable("MAV", MainSerb.comPort);
            scope.SetVariable("cs", MainSerb.comPort.MAV.cs);
            scope.SetVariable("Script", this);
            scope.SetVariable("mavutil", this);
            scope.SetVariable("Joystick", MainSerb.joystick);

            engine.CreateScriptSourceFromString("print 'hello world from python'").Execute(scope);
            engine.CreateScriptSourceFromString("print cs.roll").Execute(scope);

            if (redirectOutput)
            {
                //Redirect output through this writer
                //this writer will not actually write to the memorystreams
                OutputWriter = new Utilities.StringRedirectWriter();
                engine.Runtime.IO.SetErrorOutput(new MemoryStream(), OutputWriter);
                engine.Runtime.IO.SetOutput(new MemoryStream(), OutputWriter);
            }
            else
                OutputWriter = null;

            /*
            object thisBoxed = MainSerb.comPort.MAV.cs;
            Type test = thisBoxed.GetType();

            foreach (var field in test.GetProperties())
            {
                // field.Name has the field's name.
                object fieldValue;
                try
                {
                    fieldValue = field.GetValue(thisBoxed, null); // Get value
                }
                catch { continue; }

                // Get the TypeCode enumeration. Multiple types get mapped to a common typecode.
                TypeCode typeCode = Type.GetTypeCode(fieldValue.GetType());

                items.Add(field.Name);
            }
             */
        }

        public object mavlink_connection(string device, int baud = 115200, int source_system = 255,
            bool write = false, bool append = false,
            bool robust_parsing = true, bool notimestamps = false, bool input = true)
        {
            return null;
        }

        public object recv_match(string condition = null, string type = null, bool blocking = false)
        {
            return null;
        }

        public void Sleep(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }

        public void runScript(string filename)
        {
            try
            {
                Console.WriteLine("Run Script " + scope);
                engine.CreateScriptSourceFromFile(filename).Execute(scope);
                Console.WriteLine("Run Script Done");
            }
            catch (Exception e)
            {
                if (OutputWriter != null)
                    OutputWriter.Write(engine.GetService<ExceptionOperations>().FormatException(e));
                CustomMessageBox.Show("Error running script " + engine.GetService<ExceptionOperations>().FormatException(e));
            }
        }

        public enum Conditional
        {
            NONE = 0,
            LT,
            LTEQ,
            EQ,
            GT,
            GTEQ,
            NEQ
        }

        public bool ChangeParam(string param, float value)
        {
            return MainSerb.comPort.setParam(param, value);
        }

        public float GetParam(string param)
        {
            if (MainSerb.comPort.MAV.param[param] != null)
                return (float)MainSerb.comPort.MAV.param[param];

            return 0.0f;
        }

        public bool ChangeMode(string mode)
        {
            MainSerb.comPort.setMode(mode);
            return true;
        }

        public bool WaitFor(string message, int timeout)
        {
            int timein = 0;
            while (!MainSerb.comPort.MAV.cs.messages.Any(a => a.message.Contains(message)))
            {
                System.Threading.Thread.Sleep(5);
                timein += 5;
                if (timein > timeout)
                    return false;
            }

            return true;
        }

        public bool SendRC(int channel, short pwm, bool sendnow)
        {
            switch (channel)
            {
                case 1:
                    MainSerb.comPort.MAV.cs.rcoverridech1 = pwm;
                    rc.chan1_raw = (ushort)pwm;
                    break;
                case 2:
                    MainSerb.comPort.MAV.cs.rcoverridech2 = pwm;
                    rc.chan2_raw = (ushort)pwm;
                    break;
                case 3:
                    MainSerb.comPort.MAV.cs.rcoverridech3 = pwm;
                    rc.chan3_raw = (ushort)pwm;
                    break;
                case 4:
                    MainSerb.comPort.MAV.cs.rcoverridech4 = pwm;
                    rc.chan4_raw = (ushort)pwm;
                    break;
                case 5:
                    MainSerb.comPort.MAV.cs.rcoverridech5 = pwm;
                    rc.chan5_raw = (ushort)pwm;
                    break;
                case 6:
                    MainSerb.comPort.MAV.cs.rcoverridech6 = pwm;
                    rc.chan6_raw = (ushort)pwm;
                    break;
                case 7:
                    MainSerb.comPort.MAV.cs.rcoverridech7 = pwm;
                    rc.chan7_raw = (ushort)pwm;
                    break;
                case 8:
                    MainSerb.comPort.MAV.cs.rcoverridech8 = pwm;
                    rc.chan8_raw = (ushort)pwm;
                    break;
            }

            rc.target_component = MainSerb.comPort.MAV.compid;
            rc.target_system = MainSerb.comPort.MAV.sysid;

            if (sendnow)
            {
                MainSerb.comPort.sendPacket(rc, rc.target_system, rc.target_component);
                System.Threading.Thread.Sleep(20);
                MainSerb.comPort.sendPacket(rc, rc.target_system, rc.target_component);
            }

            return true;
        }
    }
}