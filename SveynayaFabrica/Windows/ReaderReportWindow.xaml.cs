using Microsoft.Win32;
using System;
using System.Windows;

namespace SveynayaFabrica.Windows
{
    /// <summary>
    /// Логика взаимодействия для ViewReportWindow.xaml
    /// </summary>
    public partial class ReaderReportWindow : Window
    {
        public ReaderReportWindow()
        {
            InitializeComponent();
        }

        private string GetPathOfFile()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog(this).Value)
                return openFileDialog.FileName;

            return null;
        }

        private void OpenFile_Click(object sender, RoutedEventArgs e)
        {
            pdfReader.Source = new Uri(GetPathOfFile());
        }
    }
}
