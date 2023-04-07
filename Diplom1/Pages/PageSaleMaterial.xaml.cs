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
    /// Логика взаимодействия для PageSaleMaterial.xaml
    /// </summary>
    public partial class PageSaleMaterial : Page
    {
        private Diplom1Entities _context = new Diplom1Entities();
        public PageSaleMaterial()
        {
            InitializeComponent();
            DateG.ItemsSource = Diplom1Entities.GetContext().Material.ToList();
        }

        private void CmbS_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            AppFrrame.frameMain.GoBack();
        }

        private void DelkBtn_Click(object sender, RoutedEventArgs e)
        {
            if (DateG.SelectedItems.Count > 0)
            {
                Material UserObj = DateG.SelectedItem as Material;
                Diplom1Entities.GetContext().Material.Remove(UserObj);//
                Diplom1Entities.GetContext().SaveChanges();
                DateG.ItemsSource = Diplom1Entities.GetContext().Material.ToList();
                MessageBox.Show("Данные успешно удалены!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("В таблице нет данных!", "Уведомление", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BtnD_Click(object sender, RoutedEventArgs e)
        {
            AddSaleMaterial addEditVTD = new AddSaleMaterial(null);
            addEditVTD.ShowDialog();
        }

        private void Obn_Click(object sender, RoutedEventArgs e)
        {
            DateG.ItemsSource = Diplom1Entities.GetContext().Material.ToList();
        }

        private void BtnR_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DateG_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Txb_TextChanged(object sender, TextChangedEventArgs e)
        {
            var cur = Diplom1Entities.GetContext().Material.ToList();
            if (Txb.Text != "")
            {
                DateG.ItemsSource = Diplom1Entities.GetContext().Material.Where(z => z.NameMaterial.ToLower().Contains(Txb.Text.ToLower())).ToList();
            }
            else
            {
                DateG.ItemsSource = Diplom1Entities.GetContext().Material.ToList();
            }
        }

        private void BtnR_Click_1(object sender, RoutedEventArgs e)
        {
            AddSaleMaterial addEditVTD = new AddSaleMaterial((sender as Button).DataContext as Material);
            addEditVTD.ShowDialog();
        }
    }
}
