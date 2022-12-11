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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;



namespace WpfTable
{
    /// <summary>
    /// Логика взаимодействия для MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void dataGrid1_Loaded(object sender, RoutedEventArgs e)
        {
            using (BookContext db = new BookContext())
            {
                var books = db.Books.ToList();
                dataGrid1.ItemsSource = books;
            }
          
        }

        private void Page1_Click(object sender, RoutedEventArgs e)
        {
            Uri pageFunctionUri = new Uri("Page1.xaml", UriKind.Relative);
            this.NavigationService.Navigate(pageFunctionUri);
        }

        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            Uri pageFunctionUri = new Uri("Page2.xaml", UriKind.Relative);
            this.NavigationService.Navigate(pageFunctionUri);
        }

        private void Page3_Click(object sender, RoutedEventArgs e)
        {
            Uri pageFunctionUri = new Uri("Page3.xaml", UriKind.Relative);
            this.NavigationService.Navigate(pageFunctionUri);
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (BookContext db = new BookContext())
                {
                    var list = db.Books.ToList();
                    for (int i = 0; i < list.Count; i++)
                        if (list[i].BookName == textBoxSearch.Text)
                            (dataGrid1.ItemContainerGenerator.ContainerFromIndex(i) as DataGridRow).Background = Brushes.Gray;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
          
           

        }

        private void Search_MouseEnter(object sender, MouseEventArgs e)
        {

            Search.Width = 90;
            Search.Height = 30;
        }

        private void Search_MouseLeave(object sender, MouseEventArgs e)
        {

            Search.Width = 95;
            Search.Height = 35;
        }

        private void Page1_MouseEnter(object sender, MouseEventArgs e)
        {
            Page1.Width = 90;
            Page1.Height = 30;
        }

        private void Page1_MouseLeave(object sender, MouseEventArgs e)
        {
            Page1.Width = 95;
            Page1.Height = 35;
        }

        private void Page2_MouseEnter(object sender, MouseEventArgs e)
        {
            Page2.Width = 90;
            Page2.Height = 30;
        }

        private void Page2_MouseLeave(object sender, MouseEventArgs e)
        {
            Page2.Width = 95;
            Page2.Height = 35;
        }

        private void Page3_MouseEnter(object sender, MouseEventArgs e)
        {
            Page3.Width = 90;
            Page3.Height = 30;
        }

        private void Page3_MouseLeave(object sender, MouseEventArgs e)
        {
            Page3.Width = 95;
            Page3.Height = 35;
        }
    }
}
