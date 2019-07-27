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
    /// Interaction logic for AddBookWindow.xaml
    /// </summary>
    public partial class AddBookWindow : Window
    {
        public AddBookWindow()
        {
            InitializeComponent();
        }

        private void addBookButton_Click(object sender, RoutedEventArgs e)
        {
            Query query = new Query();
            
            string[] author = authorComboBox.Text.Split(' '); 
            var authorId = query.SendQuery("SELECT id FROM authors WHERE first_name = \'"+author[0] +
                "\' AND last_name = \'"+ author[1] +"\'");
            var buff = authorId;
            query.SendQuery("INSERT INTO books (id, name, idauthor) VALUES (NULL,\'"+titleBox.Text+"\',\'"+ buff[0] +"\' )");

            this.Owner.Show();
            this.Close();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            this.Owner.Show();
        }

        private void newCategoryButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddCategoryWindow addCategoryWindow = new AddCategoryWindow();
            addCategoryWindow.Owner = this;
            addCategoryWindow.Show();
        }

        private void newAuthorButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            AddAuthorWindow addAuthorWindow = new AddAuthorWindow();
            addAuthorWindow.Owner = this;
            addAuthorWindow.Show();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            Query query = new Query();

            var categories = query.SendQuery("SELECT name FROM categories");
            for (int i = 0; i < categories.Count; i++)
            {
                string[] buff = categories[i];
                categoryComboBox.Items.Add(buff[0]);
            }

            var authors = query.SendQuery("SELECT first_name, last_name FROM authors");
            for (int i = 0; i < authors.Count; i++)
            {
                string[] buff = authors[i];
                authorComboBox.Items.Add(buff[0]+" "+buff[1]);
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void addCategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            if (categoryComboBox.Text != "")
            {
                if (addedCategories.Text != "")
                    addedCategories.Text += ",";
                addedCategories.Text += categoryComboBox.Text;
            }
        }

        private void clearCategoriesButton_Click(object sender, RoutedEventArgs e)
        {
            addedCategories.Text = "";
        }
    }
}
