using SveynayaFabrica.data.migrations;
using System;  
using System.Linq;
using System.Windows.Controls;

namespace SveynayaFabrica.Pages.PageOfData
{
    /// <summary>
    /// Логика взаимодействия для OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();
        }

        private void DataLoaded(Object sender, EventArgs e)
        {
            DatabaseTestsEntities data  = new DatabaseTestsEntities();
            dgOrder.ItemsSource         = data.Order
                                            .Where(or => or.IdUser == Model.Records.User.UserActual.Id).ToArray();
        }
    }
}
