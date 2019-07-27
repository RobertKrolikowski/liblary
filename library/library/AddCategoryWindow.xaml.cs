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
    /// Interaction logic for addCategoryWindow.xaml
    /// </summary>
    public partial class AddCategoryWindow : Window
    {
        public AddCategoryWindow()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (categoryBox.Text == "")
            {
                MessageBox.Show("Incomplite Data");
            }
            else
            {
                Query query = new Query();
                var buff = query.SendQuery("SELECT name FROM categories WHERE name = \'"+categoryBox.Text+"\'");
                if(buff == null)
                {
                    query.SendQuery("INSERT INTO categories (id, name) VALUES (NULL, \'" + categoryBox.Text + "\')");
                }
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
