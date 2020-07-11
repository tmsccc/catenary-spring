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
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PSMS15
{
    /// <summary>
    /// loginwindow.xaml 的交互逻辑
    /// </summary>
    public partial class loginwindow : Window
    {
        public loginwindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        { if (userradiobutton .IsChecked==true )
            { 
                checkinwindow ckw=new checkinwindow ();
                ckw.Show();
            }
          if (userradiobutton.IsChecked == true)
            {
                checkinwindow ckw = new checkinwindow();
                ckw.Show();
            }
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void RadioButton_Checked_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
