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
    /// Interaction logic for SecondWindow.xaml
    /// </summary>
    public partial class SearchBookWindow : Window
    {
        public SearchBookWindow()
        {
            InitializeComponent();
        }
        public SearchBookWindow(User user)
        {
            InitializeComponent();
            if (!user.isAdmin)
            {
                removeButton.Visibility = Visibility.Hidden;
                editButton.Visibility = Visibility.Hidden;
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
            this.Owner.Show();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }

        private void searchBox_GotFocus(object sender, RoutedEventArgs e)
        {
            searchBox.Text = "";
        }

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
