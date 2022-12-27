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

namespace ShopZvonochek.View
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AutorizationWindow : Window
    {
        public AutorizationWindow()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            App.User = App.db.User.Where(x=>x.Login == LoginTxt.Text && x.Password == PassTxt.Password).FirstOrDefault();   

            if(App.User == null )
            {
                MessageBox.Show("Неправильный пароль или логин!");
                return;
            }

            new HomeWindow().Show();
            this.Close();
        }
    }
}
