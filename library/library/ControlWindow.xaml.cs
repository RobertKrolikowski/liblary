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
    /// Interaction logic for ControlWindow.xaml
    /// </summary>
    public partial class ControlWindow : Window
    {
        User user;
        public ControlWindow()
        {
            InitializeComponent();
        }
        public ControlWindow(User user)
        {
            this.user = user;
            InitializeComponent();
            if (this.user.isAdmin)
            {
                bookLendedButton.Visibility = Visibility.Hidden;               
            }
            else
            {
                bookAddButton.Visibility = Visibility.Hidden;
                personAddButton.Visibility = Visibility.Hidden;
                personSearchButton.Visibility = Visibility.Hidden;
            }
        }
        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }

        private void bookAddButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddBookWindow addBookWindow = new AddBookWindow();
            addBookWindow.Owner = this;
            addBookWindow.Show();
        }

        private void bookSearchButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchBookWindow searchBookWindow = new SearchBookWindow(user);
            searchBookWindow.Owner = this;
            searchBookWindow.Show();
        }

        private void personAddButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddPersonWindow addPersonWindow = new AddPersonWindow();
            addPersonWindow.Owner = this;
            addPersonWindow.Show();
        }

        private void logoutButton_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void personSearchButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            SearchPersonWindow searchPersonWindow = new SearchPersonWindow();
            searchPersonWindow.Owner = this;
            searchPersonWindow.Show();
        }

        private void bookLendedButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            LendedWindow lendedWindow = new LendedWindow();
            lendedWindow.Owner = this;
            lendedWindow.Show();
        }
    }
}
