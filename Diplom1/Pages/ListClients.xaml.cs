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
    /// Логика взаимодействия для ListClients.xaml
    /// </summary>
    public partial class ListClients : Page
    {
        private Diplom1Entities _context = new Diplom1Entities();
        public ListClients()
        {

            InitializeComponent();
            DG.ItemsSource = Diplom1Entities.GetContext().Client.ToList();
            CmbN.SelectedValuePath = "IdTypeClient";
            CmbN.DisplayMemberPath = "RoleClient";

            CmbN.ItemsSource = _context.TypeClient.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AppFrrame.frameMain.GoBack();
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItems.Count > 0)
            {
                Client UserObj = DG.SelectedItem as Client;
                Diplom1Entities.GetContext().Client.Remove(UserObj);//
                Diplom1Entities.GetContext().SaveChanges();
                DG.ItemsSource = Diplom1Entities.GetContext().Client.ToList();
                MessageBox.Show("Данные успешно удалены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("В таблице нет данных!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }

        private void BtnD_Click(object sender, RoutedEventArgs e)
        {
            ClientAdd addEditVTD = new ClientAdd(null);
            addEditVTD.ShowDialog();
        }


        private void Txb_TextChanged(object sender, TextChangedEventArgs e)
        {
            var cur = Diplom1Entities.GetContext().Client.ToList();
            if (Txb.Text != "")
            {
                DG.ItemsSource = Diplom1Entities.GetContext().Client.Where(z => z.Name.ToLower().Contains(Txb.Text.ToLower())).ToList();
            }
            else
            {
                DG.ItemsSource = Diplom1Entities.GetContext().Client.ToList();
            }
        }

        private void BtnR_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CmbN_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {
            var n = Diplom1Entities.GetContext().Client.ToList().Distinct();
            switch (CmbN.SelectedIndex)
            {
                case 0:
                    n = n.Where(x => x.IdTypeClient == 1).ToList();
                    break;
                case 1:
                    n = n.Where(x => x.IdTypeClient == 2).ToList();
                    break;
                //case 2:
                //    n = n.Where(x => x.IdМесяц == 3).ToList();
                //    break;
                //case 3:
                //    n = n.Where(x => x.IdМесяц == 4).ToList();
                //    break;
                //case 4:
                //    n = n.Where(x => x.IdМесяц == 5).ToList();
                //    break;
                //case 5:
                //    n = n.Where(x => x.IdМесяц == 6).ToList();
                //    break;
                //case 6:
                //    n = n.Where(x => x.IdМесяц == 7).ToList();
                //    break;
                //case 7:
                //    n = n.Where(x => x.IdМесяц == 8).ToList();
                //    break;
                //case 8:
                //    n = n.Where(x => x.IdМесяц == 9).ToList();
                //    break;
                //case 9:
                //    n = n.Where(x => x.IdМесяц == 10).ToList();
                //    break;
                //case 10:
                //    n = n.Where(x => x.IdМесяц == 11).ToList();
                //    break;
                //case 11:
                //    n = n.Where(x => x.Id_Месяц == 12).ToList();
                //    break;
                default:
                    break;
            }
            DG.ItemsSource = n.ToList();
        }

        private void DG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }



        private void BtnR_Click_2(object sender, RoutedEventArgs e)
        {
            ClientAdd addEditVTD = new ClientAdd((sender as Button).DataContext as Client);
            addEditVTD.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = Diplom1Entities.GetContext().Client.ToList();

        }

        private void BtnP_Click(object sender, RoutedEventArgs e)
        {
            AppFrrame.frameMain.Navigate(new ListSale());
        }
    }
}
