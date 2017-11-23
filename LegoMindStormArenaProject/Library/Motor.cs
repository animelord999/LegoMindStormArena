using Lego.Ev3.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Motor : Colour 
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
            brick.BatchCommand.TurnMotorAtSpeedForTime(OutputPort.A, -50, 900, false);
            brick.BatchCommand.TurnMotorAtPowerForTime(OutputPort.D, 50, 900, false);

            await brick.BatchCommand.SendCommandAsync();
        }
    }
}
