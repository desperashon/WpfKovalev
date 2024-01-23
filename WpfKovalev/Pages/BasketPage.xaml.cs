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

            baskedLb.ItemsSource = App.enteredUser.Computer.Where(computer => computer != null && computer.IsPaid == null);


        }

        private void PayBtn_Click(object sender, RoutedEventArgs e)
        {
            // Получаем выбранный элемент из ListBox
            var selectedComputer = baskedLb.SelectedItem as Computer;

            if (selectedComputer != null)
            {
                // Устанавливаем статус оплаты в базе данных
                selectedComputer.IsPaid = true;

                // Обновляем источник данных ListBox
                baskedLb.ItemsSource = App.enteredUser?.Computer.Where(computer => computer.IsPaid != true);

                // Выводим MessageBox об успешной оплате
                App.context.SaveChanges();
                MessageBox.Show("Оплата прошла успешно!");
                baskedLb.SelectedItem = null;
            }
            else
            {
                // Если ничего не выбрано, выводим сообщение
                MessageBox.Show("Выберите компьютер для оплаты.");
            }
        }


    }
}
