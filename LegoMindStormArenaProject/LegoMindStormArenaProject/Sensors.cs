using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Done by Nadeem Abu Shanab.

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

        public int getGyro(object sender, BrickChangedEventArgs e)
        {
            var port2 = e.Ports[InputPort.Three];
            var press = port2.SIValue;

            return Gyro;
        }

        public int getUltraSonic(object sender, BrickChangedEventArgs e)
        {
            var port2 = e.Ports[InputPort.One];
            var press = port2.SIValue;

            return UltraSonic;
        }
    }
}
