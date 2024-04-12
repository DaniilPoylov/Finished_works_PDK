using FabricsApplication.Entity;
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
using System.Windows.Shapes;

namespace FabricsApplication
{
    /// <summary>
    /// Логика взаимодействия для GuestProductWindow.xaml
    /// </summary>
    public partial class GuestProductWindow : Window
    {
        List<Product> products = App.Database.Product.ToList();
        bool FiltDataCheck = false;
        bool SortDataCheck = false;
        bool FindDataCheck = false;
        public GuestProductWindow()
        {
            InitializeComponent();
            ProductList.ItemsSource = App.Database.Product.ToList();
            ElementsCount_textBlock.Text = "Количесвто выведенных записей: "
                + products.Count.ToString() + "/" +
                App.Database.Product.Count().ToString();
        }
        
        public void FiltrData()
        { 
            switch (Filtr_comboBox.SelectedIndex)
            {
                case 0:
                    products = products.ToList();
                    FiltDataCheck = true;
                    if (Sort_comboBox != null &&
                        Sort_comboBox.SelectedIndex > 0 &&
                        SortDataCheck == false)
                        SortData();
                    if (Sort_comboBox != null &&
                        Find_textBox.Text != "" &&
                        FindDataCheck == false)
                        FindData();
                    ProductList.ItemsSource = products.ToList();
                    break;
                case 1:
                    products = products.Where
                    (mf => mf.ProductManufacturer ==
                    "БТК Текстиль").ToList();
                    FiltDataCheck = true;
                    if (Sort_comboBox.SelectedIndex > 0 &&
                        SortDataCheck == false)
                        SortData();
                    if (Find_textBox.Text != "" &&
                        FindDataCheck == false)
                        FindData();
                    ProductList.ItemsSource = products.ToList();
                    break;
                case 2:
                    products = products.Where
                    (mf => mf.ProductManufacturer ==
                    "Империя ткани").ToList();
                    FiltDataCheck = true;
                    if (Sort_comboBox.SelectedIndex > 0 &&
                        SortDataCheck == false)
                        SortData();
                    if (Find_textBox.Text != "" &&
                        FindDataCheck == false)
                        FindData();
                    ProductList.ItemsSource = products.ToList();
                    break;
                case 3:
                    products = products.Where
                    (mf => mf.ProductManufacturer ==
                    "Комильфо").ToList();
                    FiltDataCheck = true;
                    if (Sort_comboBox.SelectedIndex > 0 &&
                        SortDataCheck == false)
                        SortData();
                    if (Find_textBox.Text != "" &&
                        FindDataCheck == false)
                        FindData();
                    ProductList.ItemsSource = products.ToList();
                    break;
                case 4:
                    products = products.Where
                    (mf => mf.ProductManufacturer ==
                    "Май Фабрик").ToList();
                    FiltDataCheck = true;
                    if (Sort_comboBox.SelectedIndex > 0 &&
                        SortDataCheck == false)
                        SortData();
                    if (Find_textBox.Text != "" &&
                        FindDataCheck == false)
                        FindData();
                    ProductList.ItemsSource = products.ToList();
                    break;
            }
        }

        public void SortData()
        {
            switch (Sort_comboBox.SelectedIndex)
            { 
                case 0:
                    products = products.ToList();
                    SortDataCheck = true;
                    if (Filtr_comboBox != null &&
                        Filtr_comboBox.SelectedIndex > 0 &&
                        FiltDataCheck == false)
                        FiltrData();
                    if (Find_textBox.Text != "" &&
                        FindDataCheck == false)
                        FindData();
                    ProductList.ItemsSource = products.ToList();
                    break;
                case 1:
                    products = products.OrderBy
                        (pr => pr.ProductCost).ToList();
                    SortDataCheck = true;
                    if (Filtr_comboBox != null &&
                        Filtr_comboBox.SelectedIndex > 0 &&
                        FiltDataCheck == false)
                        FiltrData();
                    if (Find_textBox.Text != "" && FindDataCheck == false)
                        FindData();
                    ProductList.ItemsSource = products.ToList();
                    break;
                case 2:
                    products = products.OrderByDescending
                        (pr => pr.ProductCost).ToList();
                    SortDataCheck = true;
                    if (Filtr_comboBox != null &&
                        Filtr_comboBox.SelectedIndex > 0 &&
                        FiltDataCheck == false)
                        FiltrData();
                    if (Find_textBox.Text != "" && 
                        FindDataCheck == false)
                        FindData();
                    ProductList.ItemsSource = products.ToList();
                    break;
            }
        }

        public void FindData()
        {
            if (App.Database.Product.Where
                (data => data.ProductName == Find_textBox.Text ||
                data.ProductArticleNumber == Find_textBox.Text ||
                data.ProductCategory == Find_textBox.Text ||
                data.ProductProvider == Find_textBox.Text ||
                data.ProductDescription == Find_textBox.Text).Count() > 0)
            { 
                products = products.Where
                (data => data.ProductName == Find_textBox.Text ||
                data.ProductArticleNumber == Find_textBox.Text ||
                data.ProductCategory == Find_textBox.Text ||
                data.ProductProvider == Find_textBox.Text ||
                data.ProductDescription == Find_textBox.Text).ToList();
                if (Filtr_comboBox != null &&
                    Filtr_comboBox.SelectedIndex != 0 &&
                        FiltDataCheck == false)
                    FiltrData();
                if (Sort_comboBox != null &&
                    Sort_comboBox.SelectedIndex != 0 &&
                    SortDataCheck == false)
                    SortData();
            }
            ProductList.ItemsSource = products.ToList();
        }

        private void Filtr_comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            products = App.Database.Product.ToList();
            FiltrData();
            ElementsCount_textBlock.Text = "Количесвто выведенных записей: "
                + products.Count.ToString() + "/" +
                App.Database.Product.Count().ToString();
            FiltDataCheck = SortDataCheck = FindDataCheck = false;
        }

        private void Sort_comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            products = App.Database.Product.ToList();
            SortData();
            ElementsCount_textBlock.Text = "Количесвто выведенных записей: "
                + products.Count.ToString() + "/" +
                App.Database.Product.Count().ToString();
            FiltDataCheck = SortDataCheck = FindDataCheck = false;
        }

        private void Find_textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            products = App.Database.Product.ToList();
            FindData();
            ElementsCount_textBlock.Text = "Количесвто выведенных записей: "
                + products.Count.ToString() + "/" +
                App.Database.Product.Count().ToString();
            FiltDataCheck = SortDataCheck = FindDataCheck = false;
        }

        private void Out_button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
