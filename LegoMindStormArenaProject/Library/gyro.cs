using Lego.Ev3.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Gyro : Sensor
    {


        public float Gyros(Brick brick)
        {
            Sensor mGyro = new Sensor();
            var rGyro = mGyro.getGyro(brick);
            return rGyro;
        }
    }
}
