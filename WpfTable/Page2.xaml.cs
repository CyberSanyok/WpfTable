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
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void Close_Click(object sender, RoutedEventArgs e)
        {
            Uri pageFunctionUri = new Uri("MainPage.xaml", UriKind.Relative);
            this.NavigationService.Navigate(pageFunctionUri);
        }

        private void buttonUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var db = new BookContext())
                {

                    int id = Convert.ToInt32(textBoxIDBookUp.Text);
                    var upBook = db.Books.SingleOrDefault(b => b.IDBook==id);
                    upBook.BookName = textBoxBookNameUp.Text.ToString();
                    upBook.Count = Convert.ToInt32(textBoxBookCountUp.Text);
                    upBook.Author = textBoxAuthorUp.Text.ToString();
                    db.SaveChanges();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
         
        }

        private void buttonUpdate_MouseEnter(object sender, MouseEventArgs e)
        {
            buttonUpdate.Width = 90;
            buttonUpdate.Height = 30;
        }

        private void buttonUpdate_MouseLeave(object sender, MouseEventArgs e)
        {
            buttonUpdate.Width = 95;
            buttonUpdate.Height = 35;
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
