using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Done by Nadeem Abu Shanab.

namespace LegoMindStormArenaProject
{
    class Turn : Sensors
    {
        Brick _Brick;

        public void Right(object sender, BrickChangedEventArgs e)
        {
            Sensors Gyro = new Sensors();
            int Direction =Convert.ToInt32(Gyro.getGyro(sender , e));

            if (Direction <= Direction + 90 )
            { 
                _Brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 50);
                _Brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, -50);
            }
            else
            {
                _Brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 0);
                _Brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, 0);
            }
            

            return;
        }

        public string Left()
        {
            return Left();
        }

        public string Around()
        {
            return Around();
        }
    }
}
