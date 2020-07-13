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
using PSMS.BLL;
using PSMS.Model;
using PSMS.DAL;
using PMSM.DAL;

namespace PSMS15
{
    /// <summary>
    /// InfoAdd.xaml 的交互逻辑
    /// </summary>
    public partial class InfoAdd : Page
    {
        public InfoAdd()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
            UserDAL  mb = new UserDAL();
          
            //int id = Convert.ToInt32(tbid.Text);
            //int salary = Convert.ToInt32(tbsalary.Text);
            //DateTime dt = Convert.ToDateTime(tbtime.Text);
            DateTime dt = DateTime.Now;
            User user = new User(1001, "haha", "haha", "haha", 50000, dt, "haha", "haha", 1);
            mb.AddUser(user);
            
            MessageBox.Show("添加成功");
            
            Info page1 = new Info();
            Content = new Frame()
            {
                Content = page1
            };
        }
    }
}
