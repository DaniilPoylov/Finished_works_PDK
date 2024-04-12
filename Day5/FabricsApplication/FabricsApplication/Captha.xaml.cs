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
    /// Логика взаимодействия для Captha.xaml
    /// </summary>
    public partial class Captha : Window
    {
        MainWindow mainWindow;
        public Captha(MainWindow mainWindow)
        {
            InitializeComponent();
            this.mainWindow = mainWindow;
            GenerateCaptha();
        }
        string CapthaAnswer = "";
        public void GenerateCaptha()
        {
            CharSpawnArea.Children.Clear();
            Captha_textBlock.Text = "";
            string charSet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwyz1234567890";
            Random rd = new Random();
            for (int i = 0; i < 4; i++)
            {
                char ch = charSet[rd.Next(0, charSet.Length - 1)];
                Captha_textBlock.Text += ch.ToString();
                CapthaAnswer += ch.ToString();
                for (int j = 0; j < rd.Next(0, 4); j++)
                    Captha_textBlock.Text += " ";
            }
            switch (rd.Next(0, 4))
            {
                case 0:
                    Captha_textBlock.FontFamily = new FontFamily("Segoe Script");
                    break;
                case 1:
                    Captha_textBlock.FontFamily = new FontFamily("MV Boli");
                    break;
                case 2:
                    Captha_textBlock.FontFamily = new FontFamily("Frank Ruehl CLM");
                    break;
                case 3:
                    Captha_textBlock.FontFamily = new FontFamily("Ink Free");
                    break;
                case 4:
                    Captha_textBlock.FontFamily = new FontFamily("Gabriola");
                    break;
            }
            Captha_textBlock.FontSize = rd.Next(20, 30);
            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                Ellipse ellipse = new Ellipse();
                ellipse.Fill = new SolidColorBrush(Color.FromRgb((byte)r.Next(255), (byte)r.Next(255), (byte)r.Next(255)));
                ellipse.Width = 5;
                ellipse.Height = 5;
                ellipse.Margin = new Thickness(r.Next(-300, 300), r.Next(-100, 100), 0, 0);
                CharSpawnArea.Children.Add(ellipse);
            }
        }

        private void ReGenerate_button_Click(object sender, RoutedEventArgs e)
        {
            GenerateCaptha();
        }
        int misstake = 0;
        private void GiveAnswer_button_Click(object sender, RoutedEventArgs e)
        {
            if (Answer_textBox.Text == CapthaAnswer)
            {
                MessageBox.Show("Капча успешно пройдена", "Успех");
                mainWindow.correctCapthaAnswer = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Капча введена не верно", "Ошибка");
                misstake++;
                if (misstake == 3)
                {
                    MessageBox.Show("Вы совершили слишком много ошибок", "Ошибка");
                    mainWindow.correctCapthaAnswer = false;
                    this.Close();
                }
                GenerateCaptha();
            }
        }
    }
}
