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
    /// Логика взаимодействия для AddSaleMaterial.xaml
    /// </summary>
    public partial class AddSaleMaterial : Window
    {
        private Material _currentPrakt = new Material();
        public AddSaleMaterial(Material material)
        {
            InitializeComponent();
            if (material != null)
                _currentPrakt = material;
            DataContext = _currentPrakt;
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (_currentPrakt.IdMaterial == 0)
                Diplom1Entities.GetContext().Material.Add(_currentPrakt);
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
    }
}
