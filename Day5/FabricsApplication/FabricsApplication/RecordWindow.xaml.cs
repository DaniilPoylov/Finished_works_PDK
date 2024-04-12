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
    /// Логика взаимодействия для RecordWindow.xaml
    /// </summary>
    public partial class RecordWindow : Window
    {
        Product product;
        int AddOrEdit;
        public RecordWindow(Product product, int AddOrEdit)
        {
            InitializeComponent();
            this.product = product;
            this.AddOrEdit = AddOrEdit;
            this.DataContext = this.product;
            string[] categories = { "Постельные ткани", "Ткани для изделий", "Детские ткани" };
            for(int i =0;i<categories.Length;i++)
                Category_comboBox.Items.Add(categories[i]);
            Category_comboBox.SelectedValue = product.ProductCategory;
        }

        private void Cancel_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Save_button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                product.ProductCategory = (string)Category_comboBox.SelectedValue;
                if (AddOrEdit == 0)
                    App.Database.Product.Add(product);
                App.Database.SaveChanges();
                this.Close();
            }
            catch 
            {
                MessageBox.Show("Данные указаны не верно","Ошибка");
            }
        }

        public bool DataCheck()
        {
            string message = "";
            if (Article_textBox.Text == "")
                message += "Вы не указали артикул\n";
            if (Name_textBox.Text == "")
                message += "Вы не указали название\n";
            if (Unit_textBox.Text == "")
                message += "Вы не указали меру исчесления\n";
            if (Price_textBox.Text == "")
                message += "Вы не указали стоймость\n";
            if (Manufacture_textBox.Text == "")
                message += "Вы не указали производителя\n";
            if (Provider_textBox.Text == "")
                message += "Вы не указали поставщика\n";
            if (Category_comboBox.SelectedIndex == -1)
                message += "Вы не указали категорию\n";

            if (message == "")
                return true;
            else
            {
                MessageBox.Show(message, "Ошибка");
                return false;
            }
        }
    }
}
