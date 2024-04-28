using SveynayaFabrica.data.migrations;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace SveynayaFabrica
{
    /// <summary>
    /// Логика взаимодействия для ProductPage.xaml
    /// </summary>
    public partial class ProductPage : Page
    {
        public ProductPage()
        {
            InitializeComponent();
        }

        private async void LoadedPage(object sender, RoutedEventArgs e)
        {

            await Task.Run(() =>
            {
                DatabaseTestsEntities data = new DatabaseTestsEntities();
                var products = data.Product.ToArray();
                Dispatcher.InvokeAsync(() =>
                {
                    MessageBox.Show("Данные прогрузились ты просто слепой");
                    dgProduct.ItemsSource = products;
                });

            });
        }
    }
}
