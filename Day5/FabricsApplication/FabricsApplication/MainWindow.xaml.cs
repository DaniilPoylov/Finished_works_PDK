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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FabricsApplication
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
        public bool correctCapthaAnswer = false;
        private void Authorization_button_Click(object sender, RoutedEventArgs e)
        {
            if (App.Database.User.Where
                (data => data.UserLogin == Login_textBox.Text
                && data.UserPassword == Password_textBox.Text).Count() > 0)
            {
                User user = App.Database.User.Where
                    (data => data.UserLogin == Login_textBox.Text
                    && data.UserPassword == Password_textBox.Text).First();
                switch (user.UserRole)
                {
                    case 1://Администратор
                        AdministratorProductWindow administratorProductWindow =
                            new AdministratorProductWindow(user.UserFullName);
                        administratorProductWindow.Show();
                        this.Close();
                        break;
                    case 2: //Клиент
                        ClientProductWindow clientProductWindow = 
                            new ClientProductWindow(user.UserFullName);
                        clientProductWindow.Show();
                        this.Close();
                        break;
                    case 3: //Менеджер
                        ManagerProductWindow managerProductWindow = 
                            new ManagerProductWindow(user.UserFullName);
                        managerProductWindow.Show();
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show
                    ("Данного пользователя не существует", "Ошибка");
                Captha captha = new Captha((MainWindow)AuthorizationForm);
                captha.ShowDialog();
                if (!correctCapthaAnswer)
                {
                    System.Windows.Threading.DispatcherTimer timer =
                        new System.Windows.Threading.DispatcherTimer();
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Interval = new TimeSpan(0, 0, 10);
                    Login_textBox.IsEnabled = false;
                    Password_textBox.IsEnabled = false;
                    Out_button.IsEnabled = false;
                    Authorization_button.IsEnabled = false;
                    timer.Start();
                }
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Login_textBox.IsEnabled = true;
            Password_textBox.IsEnabled = true;
            Out_button.IsEnabled = true;
            Authorization_button.IsEnabled = true;
        }

        private void Out_button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Guest_button_Click(object sender, RoutedEventArgs e)
        {
            GuestProductWindow guestProductWindow = new GuestProductWindow();
            guestProductWindow.Show();
            this.Close();
        }
    }
}
