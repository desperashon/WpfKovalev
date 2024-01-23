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
using WpfKovalev.Windows;

namespace WpfKovalev
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LogBtn_Click(object sender, RoutedEventArgs e)
        {
            User user = App.context.User
                        .FirstOrDefault(w => w.Password == PasswordPb.Password && w.Login == LoginTb.Text);
          
            if (user != null)
            {
                App.enteredUser = user;

                MidWindow midWindow = new MidWindow();
                midWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Неправильный код или не код а логин");
                PasswordPb.Clear();
                LoginTb.Clear();
            }

        }

        private void registrBtn_Click(object sender, RoutedEventArgs e)
        {
            RegistrWindow registrWindow = new RegistrWindow(); 
            registrWindow.Show();
            Close();
        }
    }
}
