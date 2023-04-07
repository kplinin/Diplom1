using Diplom1.Klasses;
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

namespace Diplom1.Pages
{
    /// <summary>
    /// Логика взаимодействия для Aftor.xaml
    /// </summary>
    public partial class Aftor : Page
    {
        public Aftor()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var userObj = Diplom1Entities.GetContext().User.FirstOrDefault(x => x.UserLogin == Login.Text && x.Password == Password.Text);               
                if (userObj == null)
                {
                    MessageBox.Show("Такого пользователя нет!", "Ошибка при авторизации!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                else
                {
                    switch (userObj.IdUser)
                    {
                        case 1:
                            MessageBox.Show("Здравствуйте, Менеджер " + userObj.Role.Role1 + "!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
                            AppFrrame.frameMain.Navigate(new List());

                            break;
                        default:
                            MessageBox.Show("Данные не обнаружены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
                            break;
                    }
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show("Ошибка" + Ex.Message.ToString() + "Критическая работа приложения!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }

    }
}

