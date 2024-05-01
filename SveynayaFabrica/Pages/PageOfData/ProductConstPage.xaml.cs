using System.Linq;
using System.Windows;
using System.Windows.Controls;
using SveynayaFabrica.data.migrations;
using System;

namespace SveynayaFabrica.Pages.PageOfData
{
    /// <summary>
    /// Логика взаимодействия для ProductConstPage.xaml
    /// </summary>
    public partial class ProductConstPage : Page
    {
        public ProductConstPage()
        {
            InitializeComponent();
        }

        private void LoadedInfo_Loaded(object sender, RoutedEventArgs e) // Загрузка информации
        {
            var data = new DatabaseTestsEntities();
            cbHeigth.ItemsSource = data.Unit.ToList();
            cbWidth.ItemsSource = data.Unit.ToList();
        }

        private void CreateProduct_Click(object sender, RoutedEventArgs e) // Создание продукта
        {
            var data = new DatabaseTestsEntities();
            try
            {
                data.Product.Add(new Product()
                {
                    Id = tbId.Text,
                    Name = tbName.Text,
                    Description = tbDescription.Text,
                    Width = double.Parse(tbWidth.Text),
                    Height = double.Parse(tbHeight.Text),
                    IdUnitHeight = ((Unit)cbHeigth.SelectedValue).Id,
                    IdUnitWidth = ((Unit)cbWidth.SelectedValue).Id,

                });

                data.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Что то пошло не так {ex.Message}");
            }
        }
    }
}
