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
    /// Логика взаимодействия для ListSupplier.xaml
    /// </summary>
    public partial class ListSupplier : Page
    {
        private Diplom1Entities _context = new Diplom1Entities();
        public ListSupplier()
        {
            InitializeComponent();
            DG.ItemsSource = Diplom1Entities.GetContext().Supplier.ToList();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AppFrrame.frameMain.GoBack();
        }

        private void DelkBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DG.SelectedItems.Count > 0)
            {
                Supplier UserObj = DG.SelectedItem as Supplier;
                Diplom1Entities.GetContext().Supplier.Remove(UserObj);//
                Diplom1Entities.GetContext().SaveChanges();
                DG.ItemsSource = Diplom1Entities.GetContext().Supplier.ToList();
                MessageBox.Show("Данные успешно удалены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("В таблице нет данных!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnD_Click(object sender, RoutedEventArgs e)
        {
            SupplierAdd addEditVTD = new SupplierAdd(null);
            addEditVTD.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = Diplom1Entities.GetContext().Supplier.ToList();
        }

        private void DG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BtnP_Click(object sender, RoutedEventArgs e)
        {
            AppFrrame.frameMain.Navigate(new PageSaleMaterial());
        }

        private void Txb_TextChanged(object sender, TextChangedEventArgs e)
        {
            var cur = Diplom1Entities.GetContext().Supplier.ToList();
            if (Txb.Text != "")
            {
                DG.ItemsSource = Diplom1Entities.GetContext().Supplier.Where(z => z.Name.ToLower().Contains(Txb.Text.ToLower())).ToList();
            }
            else
            {
                DG.ItemsSource = Diplom1Entities.GetContext().Supplier.ToList();
            }
        }

        private void BtnR_Click(object sender, RoutedEventArgs e)
        {
            SupplierAdd addEditVTD = new SupplierAdd((sender as Button).DataContext as Supplier);
            addEditVTD.ShowDialog();
        }
    }
    }
