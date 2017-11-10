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

        public float getColour(object sender, BrickChangedEventArgs e)
        {
            var port2 = e.Ports[InputPort.Two];
            var Colour = port2.SIValue;

            return Colour;
        }

        public float getGyro(object sender, BrickChangedEventArgs e)
        {

            var port1 = e.Ports[InputPort.One];
            var Gyro = port1.SIValue;

            return Gyro;
        }

        public float getUltraSonic(object sender, BrickChangedEventArgs e)
        {
            var port3 = e.Ports[InputPort.Three];
            var UltraSonic = port3.SIValue;

            return UltraSonic;
        }
    }
}
