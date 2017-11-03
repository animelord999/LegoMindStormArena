using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lego.Ev3.Core;
using Lego.Ev3.Desktop;

namespace Lego.Ev3
{
    
    public class Create_Brick
    {
        public float buttonstate = 0;
        public Brick brick;
        

        public async Task DoStuff()
        {
            brick = new Brick(new UsbCommunication());

            //brick.BrickChanged += Brick_BrickChanged;
            Console.WriteLine("Connecting...");
            await brick.ConnectAsync();
            Console.WriteLine("Connected.");
        }
        
    }
}
