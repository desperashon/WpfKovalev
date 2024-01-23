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
            //// Получаем выбранный элемент из ListBox
            //var selectedComputer = basketLb.SelectedItem as Order;

            //if (selectedComputer != null)
            //{
            //    // Устанавливаем статус оплаты в базе данных
            //    selectedComputer.IsPaid = true;

            //    // Обновляем источник данных ListBox
            //    basketLb.ItemsSource = App.enteredUser?.Order.Where(computer => computer.IsPaid != true);

            //    // Выводим MessageBox об успешной оплате
            //    App.context.SaveChanges();
            //    MessageBox.Show("Оплата прошла успешно!");
            //    basketLb.SelectedItem = null;
            //}
            //else
            //{
            //    // Если ничего не выбрано, выводим сообщение
            //    MessageBox.Show("Выберите компьютер для оплаты.");
            //}

            var selectedOrder = basketLb.SelectedItem as Order;

            if (selectedOrder != null)
            {
                // Устанавливаем статус оплаты в базе данных
                selectedOrder.IsPaid = true;

                // Обновляем источник данных ListBox
                basketLb.ItemsSource = App.enteredUser?.Order.Where(order => order.IsPaid != true);

                // Выводим MessageBox об успешной оплате
                App.context.SaveChanges();
                MessageBox.Show("Оплата прошла успешно!");
            }
            else
            {
                // Если ничего не выбрано, выводим сообщение
                MessageBox.Show("Выберите заказ для оплаты.");
            }
        }


    }
}
