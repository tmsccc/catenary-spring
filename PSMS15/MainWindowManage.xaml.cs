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
    /// MainWindowManage.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindowManage : Window
    {
        public MainWindowManage()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Info page1 = new Info();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Checkin page1 = new Checkin();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Salary page1 = new Salary();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            UserAccount page1 = new UserAccount();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            InfoChange page1 = new InfoChange();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            InfoAdd page1 = new InfoAdd();
            Page_Change.Content = new Frame()
            {
                Content = page1
            };
        }
    }
}
