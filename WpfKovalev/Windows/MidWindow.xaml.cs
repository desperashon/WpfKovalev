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
using WpfKovalev.Pages;

namespace WpfKovalev.Windows
{
    /// <summary>
    /// Логика взаимодействия для MidWindow.xaml
    /// </summary>
    public partial class MidWindow : Window
    {
        public MidWindow()
        {
            InitializeComponent();
            MainFrm.Navigate(new HomePage());
        }

        private void HomeBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new HomePage());
        }

        private void ConfigBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new ComfigPage());
        }

        private void CatalogBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new CatalogPage());
        }

        private void BasketBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new BasketPage());
        }

        private void FeedBackBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new FeedbackPage());
        }

        private void ProfileBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new ProfilePage());
        }
    }
}
