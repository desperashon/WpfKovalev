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

namespace WpfKovalev.Pages
{
    /// <summary>
    /// Логика взаимодействия для ProfilePage.xaml
    /// </summary>
    public partial class ProfilePage : Page
    {
        public ProfilePage()
        {
            InitializeComponent();
            if (App.enteredUser != null)
            {
                
                LoginTb.Text = App.enteredUser.Login;
                NumberPhoneTb.Text = App.enteredUser.PhoneNumber;
                EmailTb.Text = App.enteredUser.Email;
                AdressTb.Text = App.enteredUser.DeliveryAddress;
            }
        }
    }
}
