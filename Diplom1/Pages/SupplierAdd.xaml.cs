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

namespace Diplom1.Pages
{
    /// <summary>
    /// Логика взаимодействия для SupplierAdd.xaml
    /// </summary>
    public partial class SupplierAdd : Window
    {
        private Supplier _currentPrakt = new Supplier();
        public SupplierAdd(Supplier supplier)
        {
            InitializeComponent();
            if (supplier != null)
                _currentPrakt = supplier;
            DataContext = _currentPrakt;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPrakt.IdSupplier == 0)
                Diplom1Entities.GetContext().Supplier.Add(_currentPrakt);
            try
            {
                Diplom1Entities.GetContext().SaveChanges();
                MessageBox.Show("Данные сохранены");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message.ToString());
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged_3(object sender, TextChangedEventArgs e)
        {

        }
    }
}
