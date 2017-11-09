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

        public string getColour()
        {
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
