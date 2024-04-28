using SveynayaFabrica.Pages.PageOfData;
using System.Windows;
using System.Windows.Controls;

namespace SveynayaFabrica
{
    /// <summary>
    /// Логика взаимодействия для MenagerPage.xaml
    /// </summary>
    public partial class MenagerPage : Page
    {
        public MenagerPage()
        {
            InitializeComponent();
        }

        private void GoToProduct(object sender, RoutedEventArgs e)
        {
            menegerFrame.Navigate(new ProductPage());
        }

        private void GoToOrder(object sender, RoutedEventArgs e)
        {
            menegerFrame.Navigate(new OrderPage());
        }
    }
}
