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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //  MyFrame.Content = new MainPage();

            MyFrame.Navigate(new MainPage());

        }

       

      

        private void Page2_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page2();
        }

        private void Page3_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page3();
        }

        private void Page1_Click_1(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new Page1();
        }

        private void MainPage_Click(object sender, RoutedEventArgs e)
        {
            MyFrame.Content = new MainPage();
        }
    }
}
