using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

// Done by Nadeem Abu Shanab.

namespace LegoMindStormArenaProject
{ 
    class Connection
    {
        public Brick _Brick;
        public async Task Connecting()
        { 
         _Brick = new Brick(new BluetoothCommunication("COM7"));
        // _Brick = new Brick(new UsbCommunication());
            _Brick.BrickChanged += _Brick_BrickChanged;

            await _Brick.ConnectAsync();
        }

        private void _Brick_BrickChanged(object sender, BrickChangedEventArgs e)
        {

        }
    }
}
