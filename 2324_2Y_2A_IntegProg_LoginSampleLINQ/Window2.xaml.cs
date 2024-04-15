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

namespace _2324_2Y_2A_IntegProg_LoginSampleLINQ
{
    /// <summary>
    /// Interaction logic for Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        LoginSampleDataContext _lsdc = null;

        public Window2()
        {
            InitializeComponent();
            _lsdc = new LoginSampleDataContext(Properties.Settings.Default._2324_1A_LoginSampleConnectionString);
        }

        private void btRegister_Click(object sender, RoutedEventArgs e)
        {
            if (tbUserName.Text.Length > 0 && tbPassword.Text.Length > 0)
            {
                var registerQuery = from rQ in _lsdc.LoginUsers
                                    where
                                    rQ.LoginID == tbUserName.Text &&
                                    rQ.Password == tbPassword.Text
                                    select rQ;
            }
        }

        private void tbUserName_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbUserName.Text.Length > 0 && tbPassword.Text.Length > 0)
            {
                btRegister.IsEnabled = true;
            }
            else
            {
                btRegister.IsEnabled = false;
            }
        }

        private void tbPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (tbUserName.Text.Length > 0 && tbPassword.Text.Length > 0)
            {
                btRegister.IsEnabled = true;
            }
            else
            {
                btRegister.IsEnabled = false;
            }
        }
    }
}
