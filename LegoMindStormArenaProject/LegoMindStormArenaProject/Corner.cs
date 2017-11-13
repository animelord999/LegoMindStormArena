using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Done By Zachary Verdon

namespace LegoMindStormArenaProject
{
    class Corner : Colour
    {
        public int corner;
        public int motor;

       
        
        Brick _Brick;

        public float getUSS(object sender, BrickChangedEventArgs e)
        {
            var port3 = e.Ports[InputPort.Three];
            var UltraSonic = port3.SIValue;

            return UltraSonic;
        }

        /* public void BlackRed(object sender, BrickChangedEventArgs e)
         {
             if (getUSS.UltraSonic >= 5)
             {
                 _Brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 15);
             }
             else if (UltraSonic.getUltraSonic(sender, e) < 5)
             {
                 _Brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, -10);
             }
             if ()


       
    }  */

        public int BlackYellow()
        {
            throw new NotImplementedException();
        }

        public int BlueRed()
        {
            throw new NotImplementedException();
        }

        public int BlueYellow()
        {
            throw new NotImplementedException();
        }

        public int RedBlack()
        {
            throw new NotImplementedException();
        }

        public int RedBlue()
        {
            throw new NotImplementedException();
        }

        public int YellowBlack()
        {
            throw new NotImplementedException();
        }

        public int YellowBlue()
        {
            throw new NotImplementedException();
        }
    }
}
