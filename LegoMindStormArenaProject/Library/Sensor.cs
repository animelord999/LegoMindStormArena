using Lego.Ev3.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
   public class Sensor
    {


        public float getGyro(object sender, BrickChangedEventArgs e)
        {
            var port3 = e.Ports[InputPort.Three];
            var Gyro = port3.SIValue;

            return Gyro;
        }

        public float getColour(object sender, BrickChangedEventArgs e)
        {
            var port4 = e.Ports[InputPort.Four];
            var Colour = port4.SIValue;

            return Colour;
        }

        public float getUltraSonic(object sender, BrickChangedEventArgs e)
        {
            var port2 = e.Ports[InputPort.Two];
            var UltraSonic = port2.SIValue;

            return UltraSonic;
        }
    }
}
