namespace SveynayaFabrica
{
    using SveynayaFabrica.data.migrations;
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Defines the <see cref="EntrancePage" />
    /// </summary>
    public partial class EntrancePage : Page
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EntrancePage"/> class.
        /// </summary>
        public EntrancePage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The Button_Click
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/></param>
        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            DatabaseTestsEntities data = new DatabaseTestsEntities();
            string login = tboxLogin.Text;
            string password = tboxPassword.Password;
            try
            {
                await Task.Run(() =>
                {

                    User userActive = new User();
                    if ((userActive = data.User.First(user => user.Password == login
                                                              && user.Login == password)) != null)
                    {
                        Dispatcher.InvokeAsync(() =>
                        {

                            switch (userActive.Role.Id)
                            {
                                case 1:
                                    NavigationFrame.NavigateTo(new MenagerPage());
                                    break;
                                case 2:
                                    NavigationFrame.NavigateTo(new CustomerPage());
                                    break;
                                case 3:
                                    NavigationFrame.NavigateTo(new StockmanPage());
                                    break;
                                case 4:
                                    NavigationFrame.NavigateTo(new DirectorPage());
                                    break;
                                default:
                                    MessageBox.Show("Пользователя с такой ролью нет или страница для данного вида пользователя не была предусмотрена");
                                    break;
                            }
                        });
                    }

                });
            }
            catch(Exception ex)
            {
                MessageBox.Show("Введены неверные данные" + ex.Message);
            }
        }

        /// <summary>
        /// The Button_Click_1
        /// </summary>
        /// <param name="sender">The sender<see cref="object"/></param>
        /// <param name="e">The e<see cref="RoutedEventArgs"/></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NavigationFrame.NavigateTo(new RegistationPage());
        }
    }
}
