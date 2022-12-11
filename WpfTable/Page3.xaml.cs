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

namespace WpfTable
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Uri pageFunctionUri = new Uri("MainPage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(pageFunctionUri);
        }

        private void buttonDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var db = new BookContext();
                

                    int id = Convert.ToInt32(textBoxIDBook.Text);
                   // var delBook = db.Books.SingleOrDefault(b => b.IDBook == id);
                    Book book = new Book { IDBook = id };
                    db.Books.Attach(book);
                    db.Books.Remove(book);
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonDelete_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonDelete.Width = 90;
            buttonDelete.Height = 30;
        }

        private void buttonDelete_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonDelete.Width = 95;
            buttonDelete.Height = 35;
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
