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

namespace WpfKovalev.Pages
{
    /// <summary>
    /// Логика взаимодействия для CatalogPage.xaml
    /// </summary>
    public partial class CatalogPage : Page
    {
        public CatalogPage()
        {
            InitializeComponent();
        }

        private void DiskiBtn_Click(object sender, RoutedEventArgs e)
        {
           NavigationService.Navigate(new Uri("Pages/DislPage.xaml", UriKind.Relative));
        }

        private void ProcBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/ProcPage.xaml", UriKind.Relative));
        }

        private void MatBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/MatPage.xaml", UriKind.Relative));
        }

        private void VideoBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/VidPage.xaml", UriKind.Relative));
        }

        private void OperativBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/OperatPage.xaml", UriKind.Relative));
        }

        private void KorpusBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/KorpusPage.xaml", UriKind.Relative));
        }

        private void PitBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/PitPage.xaml", UriKind.Relative));
        }

        private void OhladBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/OhladPage.xaml", UriKind.Relative));

        }

        private void NakopBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("Pages/TverdNakopPage.xaml", UriKind.Relative));
        }
    }
}
