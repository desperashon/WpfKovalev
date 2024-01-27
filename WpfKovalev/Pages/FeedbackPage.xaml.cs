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
    /// Логика взаимодействия для FeedbackPage.xaml
    /// </summary>
    public partial class FeedbackPage : Page
    {
        public FeedbackPage()
        {
            InitializeComponent();
        }

        private void OtpBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(MeaasngeTb.Text))
            {
                mes += "Введите сообщение\n";
            }
           
            if (mes != "")
            {
                MessageBox.Show(mes);
                return;
            }

            Message message = new Message()
            {
                text = MeaasngeTb.Text,
                UserId = App.enteredUser.UserID,
            };
           

 
            App.context.Message.Add(message);
            App.context.SaveChanges();

            MessageBox.Show("Сообщение отправленно");
            MeaasngeTb.Text = "";

        }
    }
}

