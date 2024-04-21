using SveynayaFabrica.data.migrations;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

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

        private async void LoadedPage(object sender, RoutedEventArgs e)
        {

            await Task.Run(() =>
            {
                DatabaseTestsEntities data = new DatabaseTestsEntities();
                var products = data.Product.ToArray();
                Dispatcher.InvokeAsync(() =>
                {
                    dgProduct.ItemsSource = products;
                });

            });
        }
    }
}
