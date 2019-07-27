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

namespace library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            string name = nameBox.Text;
            string pass = passwordBox.Password;
            Query query = new Query();
            var result = query.SendQuery("SELECT * FROM users WHERE (last_name = \'" + name + "\' OR email = \'" 
                + name + "\') AND password = \'" + pass + "\'");
            
            if (result != null && result.Count != 0)
            {
                string[] buff = result[0];
                User user = new User(buff[1], buff[2], buff[3], buff[4], Boolean.Parse(buff[6]));
                nameBox.Text = "";
                passwordBox.Password = "";
                this.Hide();
                ControlWindow controlWindow = new ControlWindow(user);
                controlWindow.Owner = this;
                controlWindow.Show();
             
            }
            else
            {
                MessageBox.Show("User not exist.");
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Key.Enter == e.Key)
            {
                loginButton_Click(sender, e);
            }
        }
    }
}
