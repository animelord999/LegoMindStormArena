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
    //public string black = 1;
    //public string blue = 2;
    //public string yellow = 4; 
    //public string red = 5;
    class Colour
    {
         
        // Background = Brushes.Red;

        public Seekcolour(object sender, BrickChangedEventArgs e)
        {
            if (SIValue)

            Background = Brushes.Red;
                Brush brush = new SolidColorBrush(System.Windows.Media.Color.FromRgb((byte)r.Next(1, 255), (byte)r.Next(1, 255), (byte)r.Next(1, 255)));
                Background = brush;
                Background = Brushes.White;
        }
        return colour;

    }
}
