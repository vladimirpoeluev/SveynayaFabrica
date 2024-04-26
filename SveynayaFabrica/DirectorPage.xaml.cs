using SveynayaFabrica.data.migrations;
using System.Windows;
using System.Windows.Controls;


namespace SveynayaFabrica
{
    /// <summary>
    /// Логика взаимодействия для DirectorPage.xaml
    /// </summary>
    public partial class DirectorPage : Page
    {
        public DirectorPage()
        {
            InitializeComponent();
        }

        private void DataLoaded(object sender, RoutedEventArgs e)
        {
            DatabaseTestsEntities data = new DatabaseTestsEntities();

            foreach(User user in data.User)
            {
                dgUsers.Items.Add(user);
            }
        }
    }
}
