using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LegoMindStormArenaProject
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Brick _Brick;

        Turn turn = new Turn();

        Connection Connection;
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }
        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {

            Connection = new Connection();
            await Connection.Connecting();
            Connection._Brick.BrickChanged += _Brick_BrickColour;
            //connecting.TurnMotor();
            Connection._Brick.BrickChanged += _Brick_BrickGyro;
            Connection._Brick.BrickChanged += _Brick_BrickUltraSonic;
            Connection._Brick.BrickChanged += Right;

        }

        private void _Brick_BrickColour(object sender, BrickChangedEventArgs e)
        {
            Sensors Colour = new Sensors();
            lblColourSensor.Content = Colour.getColour(sender, e);
        }
        private void _Brick_BrickGyro(object sender, BrickChangedEventArgs e)
        {
            Sensors Gyro = new Sensors();
            lblGyroSensor.Content = Gyro.getGyro(sender, e);
        }
        private void _Brick_BrickUltraSonic(object sender, BrickChangedEventArgs e)
        {
            Sensors UltraSonic = new Sensors();
            lblUltraSonicSensor.Content = UltraSonic.getUltraSonic(sender, e);
        }

        private void cmbChoose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {
           // Right(sender, e);
        }

        private void Right(object sender, BrickChangedEventArgs e)
       {
            Turn turn = new Turn();
            turn.Right(sender, e);

        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }
    }
}
