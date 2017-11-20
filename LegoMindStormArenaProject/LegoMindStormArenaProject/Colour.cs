using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Made in Bailey Gatherum

namespace LegoMindStormArenaProject
{
    class Colour // : Sensors
    {
        public int sumAverage(params int[] avgDistance)
        {
            int result = 0;

            for (int i = 0; i < avgDistance.Length; i++)
            {
                result += avgDistance[i];
            }

            return result;
        }

        public int black = 1;
        public int blue = 2;
        public int yellow = 4;
        public int red = 5;

       /* public Seekcolour(object sender, BrickChangedEventArgs e)
        {
            if (result += 1)
            {
                return black;
            }

            else if (result += 2)
            {
                return blue;
            }

            else if (result += 4)
            {
                return yellow;
            }

            else
            {
                return red;
            }
            */
        }
    }


