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

namespace ShopZvonochek.View
{
    /// <summary>
    /// Логика взаимодействия для HomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        public HomeWindow()
        {
            InitializeComponent();
            PhoneLstView.ItemsSource = App.db.Phone.ToList();
            if(App.User.IdRole == 1) // владелец
            {
                AddClientBtn.Visibility = Visibility.Visible;  
                BuyCrashMaterialsBtn.Visibility = Visibility.Collapsed;
                CreateAktBtn.Visibility= Visibility.Collapsed;
            }
            else if(App.User.IdRole == 2) // админ
            {
                AddClientBtn.Visibility = Visibility.Visible;
                BuyCrashMaterialsBtn.Visibility = Visibility.Collapsed;
                CreateAktBtn.Visibility = Visibility.Collapsed;
            }
            else if(App.User.IdRole == 3) // мастер
            {
                AddClientBtn.Visibility = Visibility.Collapsed;
                BuyCrashMaterialsBtn.Visibility = Visibility.Visible;
                CreateAktBtn.Visibility = Visibility.Visible;
            }
            else if(App.User.IdRole == 4) // склад
            {
                AddClientBtn.Visibility = Visibility.Collapsed;
                BuyCrashMaterialsBtn.Visibility = Visibility.Collapsed;
                CreateAktBtn.Visibility = Visibility.Collapsed;
            }
        }

        private void QuitBtn_Click(object sender, RoutedEventArgs e)
        {
            new AutorizationWindow().Show();
            this.Close();
        }

        private void AddClientBtn_Click(object sender, RoutedEventArgs e)
        {
            new AddClientWindow().Show();
        }

        private void BuyBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CreateAktBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BuyCrashMaterialsBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
