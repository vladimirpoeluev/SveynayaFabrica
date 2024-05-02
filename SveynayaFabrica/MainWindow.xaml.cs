using System.Windows;
using System.Windows.Controls;
using SveynayaFabrica.data.migrations;

namespace SveynayaFabrica
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NavigationFrame.SetFrame(mainFrame);
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            if (mainFrame.CanGoBack)
                mainFrame.GoBack();
            if(!mainFrame.CanGoBack)
                ((Button) sender).Visibility = Visibility.Hidden;
        }

        private void MainFrame_Navigated(object sender, System.Windows.Navigation.NavigationEventArgs e)
        {
            if (e.IsNavigationInitiator)
                btnBack.Visibility = Visibility.Visible;
        }
    }
}
