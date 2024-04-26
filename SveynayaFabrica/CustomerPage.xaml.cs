using SveynayaFabrica.data.migrations;
using System;
using System.Windows.Controls;
using System.Linq;

namespace SveynayaFabrica
{
    /// <summary>
    /// Логика взаимодействия для CustomerPage.xaml
    /// </summary>
    public partial class CustomerPage : Page
    {
        public CustomerPage()
        {
            InitializeComponent();
        }

        private void DataLoaded(Object sender, EventArgs e)
        {
            DatabaseTestsEntities data = new DatabaseTestsEntities();

            foreach (Order order in data.Order
                                        .Where(or => or.IdUser == Model.Records.User.UserActual.Id))
            {
                dgOrder.Items.Add(order);
            }
        }
    }

    
}
