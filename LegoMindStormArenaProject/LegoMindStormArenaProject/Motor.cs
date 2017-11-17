using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMindStormArenaProject
{
    class Motor
    {
        public float leftMotor(object sender, BrickChangedEventArgs e)
        {
            var portA = e.Ports[InputPort.A];
            var LeftMotor = portA.SIValue;

            return LeftMotor;
        }

        public float rightMotor(object sender, BrickChangedEventArgs e)
        {
            var portD = e.Ports[InputPort.D];
            var RightMotor = portD.SIValue;

            return RightMotor;
        }

        internal static void TurnAround(Brick brick)
        {
            throw new NotImplementedException();
        }
    }
}
