using Lego.Ev3.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class Sensor
    {


        public float getGyro(Brick brick)
        {

            var port1 = brick.Ports[InputPort.One];
            var Gyro = port1.SIValue;

            return Gyro;
        }

        public float getColour(Brick brick)
        {
            var port2 = brick.Ports[InputPort.Two];
            var Colour = port2.SIValue;

            return Colour;
        }

        public float getUltraSonic(Brick brick)
        {
            var port3 = brick.Ports[InputPort.Three];
            var UltraSonic = port3.SIValue;

            return UltraSonic;
        }
    }
}
