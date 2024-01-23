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
            Datagr.ItemsSource = App.context.Processor.ToList();
        }

        private void BasketBtn_Click(object sender, RoutedEventArgs e)
        {
            // Получаем товар, соответствующий нажатой кнопке
            var button = sender as Button;
            if (button != null)
            {
                var item = button.DataContext as Processor; // Замените YourItemType на тип элемента в вашем DataGrid

                if (item != null)
                {
                    // Добавляем товар в заказ
                    AddItemToOrder(item);

                    // Здесь можно добавить логику обновления отображения заказа или других действий
                }
            }
        }

        private void AddItemToOrder(Processor item)
        {
            // Здесь должен быть ваш код для добавления товара в заказ
            // Например, вы можете иметь класс заказа и вызвать его метод для добавления товара
            // order.AddItem(item);
            App.context.Computer.Add(item);
        }
    }
}
