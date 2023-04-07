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
using Excel = Microsoft.Office.Interop.Excel;

namespace Diplom1.Pages
{
    /// <summary>
    /// Логика взаимодействия для ReportPage.xaml
    /// </summary>
    public partial class ReportPage : Page
    {
        public ReportPage()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Spisok = Diplom1Entities.GetContext().Sale.OrderBy(x => x.IdSale).ToList();
            var catw = Diplom1Entities.GetContext().Sale.OrderBy(x => x.IdProduct).ToList();
            var cat = Diplom1Entities.GetContext().Sale.Select(x => x.KolVo).Distinct().ToList();
            var cata = Diplom1Entities.GetContext().Sale.Select(x => x.Discount).Distinct().ToList();
            var application = new Excel.Application();
            Excel.Workbook workbook = application.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = application.Worksheets.Item[1];
            int RowIndex = 1;
            worksheet.Cells[1][1] = "Продукт";
            worksheet.Cells[2][1] = "Продажа";
            worksheet.Cells[3][1] = "Кол-во";
            worksheet.Cells[4][1] = "Скидка";
            Excel.Range header = worksheet.Range[worksheet.Cells[1, 1], worksheet.Cells[1, 3]];
            header.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter;
            header.Font.Bold = true;
            header.Interior.ColorIndex = 6;
            for (int i = 0; i < cat.Count(); i++)
            {
                RowIndex++;
                Excel.Range categ2 = worksheet.Range[worksheet.Cells[RowIndex, 1], worksheet.Cells[RowIndex, 4]];

                worksheet.Cells[1][RowIndex] = Spisok[i].Product.Name;
                worksheet.Cells[2][RowIndex] = Spisok[i].PriceSale;
                worksheet.Cells[3][RowIndex] = Spisok[i].KolVo;
                worksheet.Cells[4][RowIndex] = Spisok[i].Discount;
                categ2.BorderAround2();
                categ2.Borders.Value = 1;

                application.Visible = true;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AppFrrame.frameMain.GoBack();
        }
    }
}
