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
        public float getGyro(Brick brick)
        {
            return brick.Ports[InputPort.Three].SIValue;
        }

        public float getColour(Brick brick)
        {
            return brick.Ports[InputPort.Four].SIValue;
        }

        public float getUltraSonic(Brick brick)
        {
            return brick.Ports[InputPort.Two].SIValue;
        }
    }
}
