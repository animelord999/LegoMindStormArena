using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;
using Library;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Made in Bailey Gatherum

namespace Library
{
    public class Colour : Sensor
    {
        Brick brick;

        public double blue { get; private set; }
        public double black { get; private set; }
        public double yellow { get; private set; }
        public double red { get; private set; }

        /*
public int sumAverage(params int[] avgDistance)
{
int result = 0;

for (int i = 0; i < avgDistance.Length; i++)
{
result += avgDistance[i];
}

return result;
}*/
        /*
        public int black = 1;
        public int blue = 2;
        public int yellow = 4;
        public int red = 5;
        */
        //public int result { get; private set; }

        public double Seekcolour(object sender, BrickChangedEventArgs e)
        {

            getColour(brick);
            float colourv = getColour(brick);

            if (colourv == 0)
            {
                return black;
            }
            else if (colourv == 3)
            {
                return blue;
            }
            else if (colourv == 1)
            {
                return yellow;
            }
            else if (colourv == 5)
            {
                return red;
            }
            else
            {
                return -1;
            }

            /*
            switch (result)
            {
                case 1:
                    return black;

                case 2:
                    return blue;

                case 4:
                    return yellow;

                case 5:
                    return red;

                default:
                    return -1;
            }
            */
        }
    }
}