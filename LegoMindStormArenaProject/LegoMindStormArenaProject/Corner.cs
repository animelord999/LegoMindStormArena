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
    class Corner : Sensors
    {
        public int corner;
        public int motor;

        Sensors UltraSonic  = new Sensors();
        Brick _Brick;    
        public int BlackRed(object sender, BrickChangedEventArgs e)
        {
            if (UltraSonic.getUltraSonic(sender, e) >= 5)
            {
                _Brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 50);
            }
            else if (UltraSonic.getUltraSonic(sender, e) < 5)
            {
                _Brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, -10);
            }

           
            
        }

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
