using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
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
    /// Логика взаимодействия для ComfigPage.xaml
    /// </summary>
    public partial class ComfigPage : Page
    {
        public List<OrderProduct> OrderProducts { get; set; } = new List<OrderProduct>();
        public ComfigPage()
        {
            InitializeComponent();

            BlockPitCmb.SelectedValuePath = "ProductId";
            BlockPitCmb.DisplayMemberPath = "ComponentName";
            BlockPitCmb.ItemsSource = LoadProductsByType(1);

            MouseCmb.SelectedValuePath = "ProductId";
            MouseCmb.DisplayMemberPath = "ComponentName";
            MouseCmb.ItemsSource = LoadProductsByType(2);

            BlockCmb.SelectedValuePath = "ProductId";
            BlockCmb.DisplayMemberPath = "ComponentName";
            BlockCmb.ItemsSource = LoadProductsByType(3);

            MaterinCmd.SelectedValuePath = "ProductId";
            MaterinCmd.DisplayMemberPath = "ComponentName";
            MaterinCmd.ItemsSource = LoadProductsByType(4);

            OhladCmb.SelectedValuePath = "ProductId";
            OhladCmb.DisplayMemberPath = "ComponentName";
            OhladCmb.ItemsSource = LoadProductsByType(5);

            OperativCmd.SelectedValuePath = "ProductId";
            OperativCmd.DisplayMemberPath = "ComponentName";
            OperativCmd.ItemsSource = LoadProductsByType(6);

            DannCmb.SelectedValuePath = "ProductId";
            DannCmb.DisplayMemberPath = "ComponentName";
            DannCmb.ItemsSource = LoadProductsByType(7);

            VidCatdCmb.SelectedValuePath = "ProductId";
            VidCatdCmb.DisplayMemberPath = "ComponentName";
            VidCatdCmb.ItemsSource = LoadProductsByType(8);

            KeyBordCmb.SelectedValuePath = "ProductId";
            KeyBordCmb.DisplayMemberPath = "ComponentName";
            KeyBordCmb.ItemsSource = LoadProductsByType(9);

            ProcKmb.SelectedValuePath = "ProductId";
            ProcKmb.DisplayMemberPath = "ComponentName";
            ProcKmb.ItemsSource = LoadProductsByType(10);
        }

        private List<Product> LoadProductsByType(int typeId)
        {
            // Загрузите продукты из базы данных, отфильтрованные по типу
            return App.context.Product.Where(product => product.TypeProductId == typeId).ToList();
        }


        private void addNewPk_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(BlockPitCmb.Text))
            {
                mes += "Введите блок питания\n";
            }
            if (string.IsNullOrWhiteSpace(MouseCmb.Text))
            {
                mes += "Введите мышку\n";
            }
            if (string.IsNullOrWhiteSpace(BlockCmb.Text))
            {
                mes += "Введите кропус\n";
            }
            if (string.IsNullOrWhiteSpace(MaterinCmd.Text))
            {
                mes += "Введите мать\n";
            }
            if (string.IsNullOrWhiteSpace(OhladCmb.Text))
            {
                mes += "Введите охлажение\n";
            }
            if (string.IsNullOrWhiteSpace(OperativCmd.Text))
            {
                mes += "Введите оперативку\n";
            }
            if (string.IsNullOrWhiteSpace(DannCmb.Text))
            {
                mes += "Введите не помню\n";
            }
            if (string.IsNullOrWhiteSpace(VidCatdCmb.Text))
            {
                mes += "Введите видеокарту\n";
            }
            if (string.IsNullOrWhiteSpace(KeyBordCmb.Text))
            {
                mes += "Введите клавиатуру\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                return;
            }



            Order order = new Order()
            {
                UserId = App.enteredUser.UserID,
                OrderProduct = new List<OrderProduct>()
            };

            // Добавляем выбранные продукты в коллекцию OrderProducts
            order.OrderProduct.Add(new OrderProduct { ProductId = (BlockPitCmb.SelectedItem as Product)?.ProductId ?? 0 });
            order.OrderProduct.Add(new OrderProduct { ProductId = (MouseCmb.SelectedItem as Product)?.ProductId ?? 0 });
            order.OrderProduct.Add(new OrderProduct { ProductId = (BlockCmb.SelectedItem as Product)?.ProductId ?? 0 });
            order.OrderProduct.Add(new OrderProduct { ProductId = (MaterinCmd.SelectedItem as Product)?.ProductId ?? 0 });
            order.OrderProduct.Add(new OrderProduct { ProductId = (OhladCmb.SelectedItem as Product)?.ProductId ?? 0 });
            order.OrderProduct.Add(new OrderProduct { ProductId = (OperativCmd.SelectedItem as Product)?.ProductId ?? 0 });
            order.OrderProduct.Add(new OrderProduct { ProductId = (DannCmb.SelectedItem as Product)?.ProductId ?? 0 });
            order.OrderProduct.Add(new OrderProduct { ProductId = (VidCatdCmb.SelectedItem as Product)?.ProductId ?? 0 });
            order.OrderProduct.Add(new OrderProduct { ProductId = (KeyBordCmb.SelectedItem as Product)?.ProductId ?? 0 });
            order.OrderProduct.Add(new OrderProduct { ProductId = (ProcKmb.SelectedItem as Product)?.ProductId ?? 0 });

            // Добавляем order в контекст данных
            App.context.Order.Add(order);
            App.context.SaveChanges();

            MessageBox.Show("Товары добавлены в корзину");


        }
    }     
}

