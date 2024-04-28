using SveynayaFabrica.data.migrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SveynayaFabrica
{
    /// <summary>
    /// Логика взаимодействия для RegistationPage.xaml
    /// </summary>
    public partial class RegistationPage : Page
    {
        public RegistationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(tboxPassword.Password == tboxPasswordRepeat.Password 
                && tboxPassword.Password != String.Empty 
                && tboxLogin.Text != String.Empty)
            {
                DatabaseTestsEntities data = new DatabaseTestsEntities();
                data.User.Add(new User()
                {
                    Login = tboxLogin.Text,
                    Password = tboxPasswordRepeat.Password,
                    IdRole = 2
                });
                NavigationFrame.NavigateTo(new EntrancePage());
            }
        }
    }
}
