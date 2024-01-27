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
using WpfKovalev.Model;

namespace WpfKovalev.Pages
{
    /// <summary>
    /// Логика взаимодействия для BasketPage.xaml
    /// </summary>
    public partial class BasketPage : Page
    {
       
        public BasketPage()
        {
            InitializeComponent();

            basketLb.ItemsSource = App.enteredUser.Order.Where(computer => computer != null && computer.IsPaid == null);


        }

        private void PayBtn_Click(object sender, RoutedEventArgs e)
        {
      
            var selectedOrder = basketLb.SelectedItem as Order;

            if (selectedOrder != null)
            {
               
                selectedOrder.IsPaid = true;

    
                basketLb.ItemsSource = App.enteredUser?.Order.Where(order => order.IsPaid != true);

     
                App.context.SaveChanges();
                MessageBox.Show("Заказ передан!");
            }
            else
            {
          
                MessageBox.Show("Выберите заказ.");
            }
        }


    }
}
