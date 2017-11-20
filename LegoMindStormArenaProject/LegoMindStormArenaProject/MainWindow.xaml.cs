﻿using Lego.Ev3.Core;
using Lego.Ev3.Desktop;
using Library;
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

        public float potato;
        
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }
        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Brick brick = new Brick(new UsbCommunication());
            await brick.ConnectAsync();

            brick.BrickChanged += _Brick_BrickUltraSonic;
            brick.BrickChanged += _Brick_BrickColour;
            brick.BrickChanged += _Brick_BrickGyro;

        }

        private void _Brick_BrickColour(object sender, BrickChangedEventArgs e)
        {
            Sensor Colour = new Sensor();
            lblColourSensor.Content = Colour.getColour(sender, e);
        }
        private void _Brick_BrickGyro(object sender, BrickChangedEventArgs e)
        {
            Sensor Gyro = new Sensor();
            lblGyroSensor.Content = Gyro.getGyro(sender, e);
        }

        private void _Brick_BrickUltraSonic(object sender, BrickChangedEventArgs e)
        {
            Sensor UltraSonic = new Sensor();          
            lblUltraSonicSensor.Content = UltraSonic.getUltraSonic(sender, e);
        }

        private void cmbChoose_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        
        }

        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Home_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
