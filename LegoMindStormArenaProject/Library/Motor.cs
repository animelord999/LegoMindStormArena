using Lego.Ev3.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Motor
    {        
        public static async void TurnRight(Brick brick)
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.A, 50, 450, false);
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.D, -50, 450, false);

            await brick.BatchCommand.SendCommandAsync();
        }

        public static async void TurnLeft(Brick brick)
        {
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.A, -50, 450, false);
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.D, 50, 450, false);

            await brick.BatchCommand.SendCommandAsync();
        }

        public static async void TurnAround(Brick brick)
        {
            brick.BatchCommand.TurnMotorAtPower(OutputPort.A, -50);
            brick.BatchCommand.TurnMotorAtPower(OutputPort.D, 50);
   
            await brick.BatchCommand.SendCommandAsync();
        }
    }
}
