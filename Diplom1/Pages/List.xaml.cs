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
    /// Логика взаимодействия для List.xaml
    /// </summary>
    public partial class List : Page
    {
        public List()
        {
            InitializeComponent();
        }

        private void BtnB_Click(object sender, RoutedEventArgs e)
        {
            AppFrrame.frameMain.GoBack();
        }

        private void BtnCl_Click(object sender, RoutedEventArgs e)
        {
             AppFrrame.frameMain.Navigate(new ListClients());
        }

        private void BtnO_Click(object sender, RoutedEventArgs e)
        {
           AppFrrame.frameMain.Navigate(new ReportPage());
        }

        private void BtnSl_Click(object sender, RoutedEventArgs e)
        {
            AppFrrame.frameMain.Navigate(new ListSupplier());
        }

        private void BtnOP_Click(object sender, RoutedEventArgs e)
        {
            AppFrrame.frameMain.Navigate(new ListSupplier());
        }
    }
}
