using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library;

//Done By Zachary Verdon

namespace LegoMindStormArenaProject
{
    class Corner : Motor
    {
        public int corner;
        public int motor;

       
        
        Brick brick;

        Colour result = new Colour();
        Motor turn = new Motor();
        

         public void BlackRed(Brick brick)
         {
            var port3 = brick.Ports[InputPort.Three];
            var UltraS = port3.SIValue;
            
            while (UltraS != 5)
            {
                if (UltraS >= 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 15);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, 15);
                }
                else if (UltraS < 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, -10);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, -10);
                }
            }
            while (corner != result.red || corner != result.black)
            {
                if (corner == result.blue)
                {
                    Motor.TurnAround(brick);
                }
                else if (corner == result.yellow)
                {
                    Motor.TurnLeft(brick);
                }
            }
            if (corner == result.black)
            {
                Motor.TurnLeft(brick);
                
            }
            else if (corner == result.red)
            {
                Motor.TurnRight(brick);
            }
            while (UltraS != 5)
            {
                if (UltraS >= 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 15);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, 15);
                }
                else if (UltraS < 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, -10);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, -10);
                }
            }
        }  

        public void BlackYellow(Brick brick)
        {
            var port3 = brick.Ports[InputPort.Three];
            var UltraS = port3.SIValue;

            while (UltraS != 5)
            {
                if (UltraS >= 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 15);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, 15);
                }
                else if (UltraS < 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, -10);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, -10);
                }
            }
            while (corner != result.yellow || corner != result.black)
            {
                if (corner == result.blue)
                {
                    Motor.TurnAround(brick);
                }
                else if (corner == result.red)
                {
                    Motor.TurnRight(brick);
                }
            }
            if (corner == result.black)
            {
                Motor.TurnRight(brick);

            }
            else if (corner == result.yellow)
            {
                Motor.TurnLeft(brick);
            }
            while (UltraS != 5)
            {
                if (UltraS >= 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 15);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, 15);
                }
                else if (UltraS < 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, -10);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, -10);
                }
            }
        
    }
    
        public void BlueRed(Brick brick)
        {
            var port3 = brick.Ports[InputPort.Three];
            var UltraS = port3.SIValue;

            while (UltraS != 5)
            {
                if (UltraS >= 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 15);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, 15);
                }
                else if (UltraS < 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, -10);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, -10);
                }
            }
            while (corner != result.blue || corner != result.red)
            {
                if (corner == result.yellow)
                {
                    Motor.TurnAround(brick);
                }
                else if (corner == result.black)
                {
                    Motor.TurnLeft(brick);
                }
            }
            if (corner == result.red)
            {
                Motor.TurnLeft(brick);

            }
            else if (corner == result.blue)
            {
                Motor.TurnRight(brick);
            }
            while (UltraS != 5)
            {
                if (UltraS >= 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 15);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, 15);
                }
                else if (UltraS < 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, -10);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, -10);
                }
            }
        }


        public void BlueYellow(Brick brick)
        {
            var port3 = brick.Ports[InputPort.Three];
            var UltraS = port3.SIValue;

            while (UltraS != 5)
            {
                if (UltraS >= 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 15);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, 15);
                }
                else if (UltraS < 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, -10);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, -10);
                }
            }
            while (corner != result.blue || corner != result.yellow)
            {
                if (corner == result.red)
                {
                    Motor.TurnAround(brick);
                }
                else if (corner == result.black)
                {
                    Motor.TurnRight(brick);
                }
            }
            if (corner == result.blue)
            {
                Motor.TurnLeft(brick);

            }
            else if (corner == result.yellow)
            {
                Motor.TurnRight(brick);
            }
            while (UltraS != 5)
            {
                if (UltraS >= 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 15);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, 15);
                }
                else if (UltraS < 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, -10);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, -10);
                }
            }
        }


        

        


        


      

    }
}
