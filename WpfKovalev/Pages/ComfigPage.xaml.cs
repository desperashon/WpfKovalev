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
        public ComfigPage()
        {
            InitializeComponent();
            BlockPitCmb.SelectedValuePath = "PowerSupplyID";
            BlockPitCmb.DisplayMemberPath = "ComponentName";
            BlockPitCmb.ItemsSource = App.context.PowerSupply.ToList();

            MouseCmb.SelectedValuePath = "MouseID";
            MouseCmb.DisplayMemberPath = "ComponentName";
            MouseCmb.ItemsSource = App.context.Mouse.ToList();

            BlockCmb.SelectedValuePath = "SystemUnitID";
            BlockCmb.DisplayMemberPath = "ComponentName";
            BlockCmb.ItemsSource = App.context.SystemUnit.ToList();

            MaterinCmd.SelectedValuePath = "MotherboardID";
            MaterinCmd.DisplayMemberPath = "ComponentName";
            MaterinCmd.ItemsSource = App.context.Motherboard.ToList();

            OhladCmb.SelectedValuePath = "CPUCoolingID";
            OhladCmb.DisplayMemberPath = "ComponentName";
            OhladCmb.ItemsSource = App.context.CPUCooling.ToList();

            OperativCmd.SelectedValuePath = "RAMID";
            OperativCmd.DisplayMemberPath = "ComponentName";
            OperativCmd.ItemsSource = App.context.RAM.ToList();

            DannCmb.SelectedValuePath = "StorageID";
            DannCmb.DisplayMemberPath = "ComponentName";
            DannCmb.ItemsSource = App.context.Storage.ToList();

            VidCatdCmb.SelectedValuePath = "GraphicsCardID";
            VidCatdCmb.DisplayMemberPath = "ComponentName";
            VidCatdCmb.ItemsSource = App.context.GraphicsCard.ToList();

            KeyBordCmb.SelectedValuePath = "KeyboardID";
            KeyBordCmb.DisplayMemberPath = "ComponentName";
            KeyBordCmb.ItemsSource = App.context.Keyboard.ToList();


            ProcKmb.SelectedValuePath = "ProcessorID";
            ProcKmb.DisplayMemberPath = "ComponentName";
            ProcKmb.ItemsSource = App.context.Processor.ToList();

        
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

            Computer computer = new Computer()
            {
                SystemUnit = BlockCmb.SelectedItem as SystemUnit,
                Processor = ProcKmb.SelectedItem as Processor,
                Motherboard = MaterinCmd.SelectedItem as Motherboard,
                CPUCooling = OhladCmb.SelectedItem as CPUCooling,
                RAM = OperativCmd.SelectedItem as RAM,
                Storage = DannCmb.SelectedItem as Storage,
                PowerSupply = BlockPitCmb.SelectedItem as PowerSupply,
                GraphicsCard = VidCatdCmb.SelectedItem as GraphicsCard,
                Keyboard = KeyBordCmb.SelectedItem as Model.Keyboard,
                Mouse = MouseCmb.SelectedItem as Model.Mouse,
                IdUser = App.enteredUser.UserID,
            };
            App.context.Computer.Add(computer);
            App.context.SaveChanges();
            MessageBox.Show("Товар добавлен к корзину");


        }
    }     
}

