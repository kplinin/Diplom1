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
    /// Логика взаимодействия для ListSale.xaml
    /// </summary>
    public partial class ListSale : Page
    {
        private Diplom1Entities _context = new Diplom1Entities();
        public ListSale()
        {
            InitializeComponent();
            DateG.ItemsSource = Diplom1Entities.GetContext().Sale.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AppFrrame.frameMain.GoBack();
        }

        private void DelBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnR_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DateG_Selected(object sender, RoutedEventArgs e)
        {

        }

        private void DateG_Selected_1(object sender, RoutedEventArgs e)
        {

        }

        private void DateG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void DelkBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DateG.SelectedItems.Count > 0)
            {
                Sale UserObj = DateG.SelectedItem as Sale;
                Diplom1Entities.GetContext().Sale.Remove(UserObj);//
                Diplom1Entities.GetContext().SaveChanges();
                DateG.ItemsSource = Diplom1Entities.GetContext().Sale.ToList();
                MessageBox.Show("Данные успешно удалены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("В таблице нет данных!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }


        private void Obn_Click(object sender, RoutedEventArgs e)
        {
            DateG.ItemsSource = Diplom1Entities.GetContext().Sale.ToList();
            //DateG.ItemsSource = Diplom1Entities.GetContext().Client.ToList();
        }

        private void Txb_TextChanged(object sender, TextChangedEventArgs e)
        {
            var cur = Diplom1Entities.GetContext().Sale.ToList();
            if (Txb.Text != "")
            {
                DateG.ItemsSource = Diplom1Entities.GetContext().Sale.Where(z => z.Product.Name.ToLower().Contains(Txb.Text.ToLower())).ToList();
               // DateG.ItemsSource = Diplom1Entities.GetContext().Product.Where(z => z.Name.ToLower().Contains(Txb.Text.ToLower())).ToList();
            }
            else
            {
                DateG.ItemsSource = Diplom1Entities.GetContext().Sale.ToList();
            }
        }

        private void BtnD_Click(object sender, RoutedEventArgs e)
        {
            SaleAdd addEditVTD = new SaleAdd(null);
            addEditVTD.ShowDialog();
        }

        private void BtnR_Click_1(object sender, RoutedEventArgs e)
        {
            SaleAdd addEditVTD = new SaleAdd((sender as Button).DataContext as Sale);
            addEditVTD.ShowDialog();
           
        }

       /* private void CmbN_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var n = Diplom1Entities.GetContext().Sale.ToList().Distinct();
            switch (CmbS.SelectedIndex)
            {
                case 0:
                    n = n.Where(x => x.IdProduct == 1).ToList();
                    break;
                case 1:
                    n = n.Where(x => x.IdProduct == 2).ToList();
                    break;
                case 2:
                    n = n.Where(x => x.IdProduct == 3).ToList();
                    break;
                //case 3:
                //    n = n.Where(x => x.IdProduct == 4).ToList();
                //    break;
                //case 4:
                //    n = n.Where(x => x.IdProduct == 5).ToList();
                //    break;
                //case 5:
                //    n = n.Where(x => x.IdProduct == 6).ToList();
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
            DateG.ItemsSource = n.ToList();
        }*/
    }
    }
   

