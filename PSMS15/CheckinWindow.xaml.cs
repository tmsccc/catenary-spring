﻿using System;
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
using System.Windows.Shapes;

namespace PSMS15
{
    /// <summary>
    /// checkinwindow.xaml 的交互逻辑
    /// </summary>
    public partial class checkinwindow : Window
    {
        public checkinwindow()
        {
            InitializeComponent();
        }

        private void Image_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_MouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_MouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_MouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            infowindow ifw = new infowindow();
            ifw.Show ();


            //ifw.StartPosition = FormStartPosition.CenterParent;

            //mylogin.ShowDialog();
        }
    }
}
