using SveynayaFabrica.data.migrations;
using System.Windows;
using System.Windows.Controls;
using System.Linq;

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
            dgUsers.ItemsSource = data.User.ToArray();
        }

        private void SelectedUsers_Click(object sender, SelectedCellsChangedEventArgs e)
        {
            MessageBox.Show(((DataGrid)sender).SelectedIndex.ToString());
        }
    }
}
