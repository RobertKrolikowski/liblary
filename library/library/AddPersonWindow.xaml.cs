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

namespace library
{
    /// <summary>
    /// Interaction logic for AddPersonWindow.xaml
    /// </summary>
    public partial class AddPersonWindow : Window
    {
        public AddPersonWindow()
        {
            InitializeComponent();
        }

        private void addPerson_Click(object sender, RoutedEventArgs e)
        {
            Query query = new Query();
            if (firstNameBox.Text == "" || lastNameBox.Text == "" || phoneBox.Text == "" || emailBox.Text == "")
            {
                MessageBox.Show("Incomplite Data.");
            }
            else
            {
                query.SendQuery("INSERT INTO users (id, first_name,last_name,phone,email,password,is_admin)"
                    + "VALUES (NULL,\'" + firstNameBox.Text + "\',\'" + lastNameBox.Text + "\',\'" + phoneBox.Text + "\',\'"
                    + emailBox.Text + "\',\'\',\'0\'); ");

                this.Owner.Show();
                this.Close();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }
    }
}
