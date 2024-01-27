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
    /// Логика взаимодействия для ProcPage.xaml
    /// </summary>
    public partial class ProcPage : Page
    {
        public ProcPage()
        {
            InitializeComponent();
            Datagr.ItemsSource = App.context.Product.ToList();
            LoadProductsByType(5);
        }

        private void BasketBtn_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                var item = button.DataContext as Product; 

                if (item != null)
                {
          
                    Order order = new Order
                    {
                        UserId = App.enteredUser.UserID,
                        OrderProduct = new List<OrderProduct>() 
                    };

             
                    OrderProduct orderProduct = new OrderProduct
                    {
                        ProductId = item.ProductId
                    };

                   
                    order.OrderProduct.Add(orderProduct);

                    App.context.Order.Add(order);

                
                    App.context.SaveChanges();

                    MessageBox.Show("Товар добавлен в корзину!");
                }
            }
        }
        private void LoadProductsByType(int typeId)
        {
            
            Datagr.ItemsSource = null;

           
            var products = App.context.Product.Where(p => p.TypeProductId == typeId).ToList();

    
            Datagr.ItemsSource = products;
        }




    }
}
