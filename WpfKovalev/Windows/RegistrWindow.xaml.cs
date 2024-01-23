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
using WpfKovalev.Model;

namespace WpfKovalev.Windows
{
    /// <summary>
    /// Логика взаимодействия для RegistrWindow.xaml
    /// </summary>
    public partial class RegistrWindow : Window
    {
        public RegistrWindow()
        {
            InitializeComponent();
        }

        private void registrBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(LoginTb.Text))
            {
                mes += "Введите логин\n";
            }
            if (string.IsNullOrWhiteSpace(NamberPhone.Text))
            {
                mes += "Введите номер телефона\n";
            }
            if (string.IsNullOrWhiteSpace(PasswordPb.Password))
            {
                mes += "Введите пароль\n";
            }
            if (string.IsNullOrWhiteSpace(PovtorPb.Password))
            {
                mes += "Введите повтор пароля\n";
            }
            if (mes != "")
            {
                MessageBox.Show(mes);
                return;
            }
            if (PasswordPb.Password == PovtorPb.Password)
            {

            User user = new User()
            {
                Login = LoginTb.Text,
                PhoneNumber = NamberPhone.Text,
                Password = PasswordPb.Password,
            };
                App.context.User.Add(user);
                App.context.SaveChanges();
                MessageBox.Show("Успешная регистрация!");
                MainWindow mainWindow  =  new MainWindow();
                mainWindow.Show();
                Close();
                
            }
            else
            {
                MessageBox.Show("Пароли не совпадают!");
            }
        }

        private void LogBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();  
            mainWindow.Show();
            Close();
        }
    }
}
