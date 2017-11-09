using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMindStormArenaProject
{
    class Sensors
    {
        public string Colour;
        public int Gyro;
        public int UltraSonic;

        public string getColour(object sender, BrickChangedEventArgs e)
        {
            var port2 = e.Ports[InputPort.Two];
            var press = port2.SIValue;

            return Colour;
        }

        public int getGyro()
        {
            return Gyro;
        }

        public int getUltraSonic()
        {
            return UltraSonic;
        }
    }
}
