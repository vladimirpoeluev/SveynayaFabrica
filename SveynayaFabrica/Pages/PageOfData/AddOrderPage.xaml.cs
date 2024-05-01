using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using SveynayaFabrica.data.migrations;

namespace SveynayaFabrica.Pages.PageOfData
{
    /// <summary>
    /// Логика взаимодействия для AddOrderPage.xaml
    /// </summary>
    public partial class AddOrderPage : Page
    {
        public AddOrderPage()
        {
            InitializeComponent();
        }

        private void AddOrder_Click(object sender, RoutedEventArgs e) // Добавление заказа
        {
            try
            {
                DatabaseTestsEntities data = new DatabaseTestsEntities();
                Order addOrder = data.Order.Add(new Order()
                {
                    Id = 1,
                    IdUser = ((User)cbUsers.SelectedItem).Id,
                    Date = DateTime.Now,
                    IdState = 1,
                    IdManager = Model.Records.User.UserActual.Id,
                    Price = double.Parse(tbOrderProce.Text)

                });
                data.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Что то пошло не так");
            }
            
        }

        private void LoadUsers(object sender, RoutedEventArgs e) // Подгрузка пользователей в Combox
        {
            DatabaseTestsEntities data = new DatabaseTestsEntities();

            cbUsers.ItemsSource = data.User.ToArray();
        }
    }
}
