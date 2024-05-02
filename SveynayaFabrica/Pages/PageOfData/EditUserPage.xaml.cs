using System.Windows.Controls;
using System.Windows;
using SveynayaFabrica.data.migrations;
using System.Linq;

namespace SveynayaFabrica.Pages.PageOfData
{
    /// <summary>
    /// Логика взаимодействия для EditUserPage.xaml
    /// </summary>
    public partial class EditUserPage : Page
    {
        private User _user;
        public EditUserPage(User user)
        {
            if (user?.Role == null)
            {
                NavigationFrame.NavigateTo(new DirectorPage());
                return;
            }
            InitializeComponent();
            _user = user;
            
        }

        private void LoadedInfo(object sender, RoutedEventArgs e)
        {
            
            var data = new DatabaseTestsEntities();
            cbRole.ItemsSource = data.Role.ToArray();
            cbRole.SelectedValue = _user?.Role ?? new Role() { Name = "Какая то штука. Ты зачем так кнопки жмал? Все сломалось, молодец." };
            tbLogin.Text = _user?.Login ?? "Все пойду чинить эту кнопку";
            pbPassword.Password = _user?.Password ?? "Угадай, что написано";

        }

        private void EditInfo(object sender, RoutedEventArgs e)
        {
            var data = new DatabaseTestsEntities();
            User user = data.User.Where(u => u.Id == _user.Id).FirstOrDefault();
            user.Login = tbLogin.Text;
            user.Password = pbPassword.Password;
            user.Role = (cbRole.SelectedItem as Role ?? _user.Role);
            data.SaveChanges();
        }
    }
}
