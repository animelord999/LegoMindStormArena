using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Lego.Ev3.Desktop;

namespace LegoMindStormArenaProject
{ 
    class Connect
    {

        public Brick _Brick;
        public async Task Connecting()
        { 
        //_Brick = new Brick(new BluetoothCommunication("COM6"));
        _Brick = new Brick(new UsbCommunication());
            _Brick.BrickChanged += _Brick_BrickChanged;

            await _Brick.ConnectAsync();
        }
    }
}
