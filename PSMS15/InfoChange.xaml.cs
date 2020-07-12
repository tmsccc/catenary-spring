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
    /// InfoChange.xaml 的交互逻辑
    /// </summary>
    public partial class InfoChange : Page
    {
        public InfoChange()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Info page1 = new Info();
            Content = new Frame()
            {
                Content = page1
            };
        }
    }
}
