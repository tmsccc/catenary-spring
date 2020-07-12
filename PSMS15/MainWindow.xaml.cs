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

namespace PSMS15
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SalaryEmployer page1 = new SalaryEmployer();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            CheckinEmployer page1 = new CheckinEmployer();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            InfoEmployer page1 = new InfoEmployer();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            CheckinInfoEmployer page1 = new CheckinInfoEmployer();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }
    }
}
