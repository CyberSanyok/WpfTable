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
using System.Data.Entity;

namespace WpfTable
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Uri pageFunctionUri = new Uri("MainPage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(pageFunctionUri);
        }

        private void buttonAdd_Click(object sender, RoutedEventArgs e)
        {
            //Book newbook = new Book(Convert.ToInt32(textBoxIDBook.Text), textBoxBookName.Text.ToString(), Convert.ToInt32(textBoxBookCount.Text), textBoxAuthor.ToString());
            //BookContext bookContext = new BookContext();
            //bookContext.Book.Add(newbook);
            //bookContext.SaveChanges();

            try
            {
                int id = Convert.ToInt32(textBoxIDBook.Text);
                string name = textBoxBookName.Text.ToString();
                int count = Convert.ToInt32(textBoxBookCount.Text);
                string author = textBoxAuthor.Text.ToString();
                Book newbook = new Book { IDBook = id, BookName = name, Count = count, Author = author };
                using (BookContext db = new BookContext())
                {
                    db.Books.Add(newbook);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         

        }

        private void buttonAdd_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonAdd.Width = 90;
            buttonAdd.Height = 30;
        }

        private void buttonAdd_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonAdd.Width = 95;
            buttonAdd.Height = 35;
        }

        private void buttonClose_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonClose.Width = 90;
            buttonClose.Height = 30;
        }

        private void buttonClose_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonClose.Width = 95;
            buttonClose.Height = 35;
        }
    }
}
