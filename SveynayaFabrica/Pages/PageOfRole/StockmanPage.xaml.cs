using SveynayaFabrica.Pages.PageOfData;
using System.Windows;
using System.Windows.Controls;

namespace SveynayaFabrica
{
    /// <summary>
    /// Логика взаимодействия для StockmanPage.xaml
    /// </summary>
    public partial class StockmanPage : Page
    {
        public StockmanPage()
        {
            InitializeComponent();
        }

        private void GoToProduct(object sender, RoutedEventArgs e)
        {
            menegerFrame.Navigate(new ProductPage());
        }

        private void CreateProduct(object sender, RoutedEventArgs e)
        {
            menegerFrame.Navigate(new ProductConstPage());
        }
    }
}
