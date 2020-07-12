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

namespace PSMS15
{
    /// <summary>
    /// Info.xaml 的交互逻辑
    /// </summary>
    public partial class Info : Page
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            InfoChange page1 = new InfoChange();
            Content = new Frame()
            {
                Content = page1
            };
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            InfoAdd page1 = new InfoAdd();
            Content = new Frame()
            {
                Content = page1
            };
        }
    }
}
