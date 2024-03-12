using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Windows.Controls;
using WpfKovalev.Model;

namespace WpfKovalev.Pages
{
    public partial class ProfilePage : Page
    {
        public ObservableCollection<Order> Orders { get; set; }

        public ProfilePage()
        {
            InitializeComponent();
            if (App.enteredUser != null)
            {
                LoginTb.Text = App.enteredUser.Login;
                NumberPhoneTb.Text = App.enteredUser.PhoneNumber;
                EmailTb.Text = App.enteredUser.Email;
                AdressTb.Text = App.enteredUser.DeliveryAddress;

                // Получение заказов только для текущего пользователя и инициализация DataGrid
                Orders = new ObservableCollection<Order>(GetUserOrders(App.enteredUser.UserID));
                OrdersDataGrid.ItemsSource = Orders;
            }
        }
        

        // Метод для получения заказов пользователя из базы данных
        // Метод для получения заказов пользователя из базы данных
        private List<Order> GetUserOrders(int userId)
        {
            using (var context = new RestartKovalevEntities())
            {
                return context.Order.Where(o => o.UserId == userId).ToList();
            }
        }

    }
}
