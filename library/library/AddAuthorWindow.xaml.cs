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
    /// Interaction logic for AddAuthor.xaml
    /// </summary>
    public partial class AddAuthorWindow : Window
    {
        public AddAuthorWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            Query query = new Query();
            if (firstNameBox.Text == "" || lastNameBox.Text == "" || countryBox.Text == "")
            {
                MessageBox.Show("Incomplite Data.");
            }
            else
            {
                query.SendQuery("INSERT INTO authors (id,first_name,last_name,country) VALUES (NULL,\'"
                    + firstNameBox.Text + "\',\'" + lastNameBox.Text + "\',\'" + countryBox.Text + "\')");
                this.Owner.Show();
                this.Close();
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }
    }
}
