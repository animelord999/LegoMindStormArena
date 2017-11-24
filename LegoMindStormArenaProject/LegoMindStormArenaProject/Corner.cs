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
    public class Corner : Motor
    {
        public int corner;
        public int motor;

       
        
        Brick brick;

        Colour colourv = new Colour();
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
                else if (UltraS <= 5)
                {
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.A, 20);
                    brick.DirectCommand.TurnMotorAtPowerAsync(OutputPort.D, 20);
                }
            }
            while (corner != colourv.red || corner != colourv.black)
            {
                if (corner == colourv.blue)
                {
                    Motor.TurnAround(brick);
                }
                else if (corner == colourv.yellow)
                {
                    Motor.TurnLeft(brick);
                }
            }
            if (corner == colourv.black)
            {
                Motor.TurnLeft(brick);
                
            }
            else if (corner == colourv.red)
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
                else if (UltraS <= 5)
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
            while (corner != colourv.yellow || corner != colourv.black)
            {
                if (corner == colourv.blue)
                {
                    Motor.TurnAround(brick);
                }
                else if (corner == colourv.red)
                {
                    Motor.TurnRight(brick);
                }
            }
            if (corner == colourv.black)
            {
                Motor.TurnRight(brick);

            }
            else if (corner == colourv.yellow)
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
            while (corner != colourv.blue || corner != colourv.red)
            {
                if (corner == colourv.yellow)
                {
                    Motor.TurnAround(brick);
                }
                else if (corner == colourv.black)
                {
                    Motor.TurnLeft(brick);
                }
            }
            if (corner == colourv.red)
            {
                Motor.TurnLeft(brick);

            }
            else if (corner == colourv.blue)
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
            while (corner != colourv.blue || corner != colourv.yellow)
            {
                if (corner == colourv.red)
                {
                    Motor.TurnAround(brick);
                }
                else if (corner == colourv.black)
                {
                    Motor.TurnRight(brick);
                }
            }
            if (corner == colourv.blue)
            {
                Motor.TurnLeft(brick);

            }
            else if (corner == colourv.yellow)
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
