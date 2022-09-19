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

namespace WpfApp1
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

        private void BackB_Click(object sender, RoutedEventArgs e)
        {
            if (!Class1.MainFrame.CanGoBack)
            {
                MainBar.Visibility = Visibility.Hidden;
                MainFrame.Margin = new Thickness(0, 0, 0, 0);
            }

            else
                Class1.MainFrame.GoBack();
        }

        private void MainFrame_Navigated(object sender, NavigationEventArgs e)
        {
            if (e.Content is MainScreen page)
            {
                MainBar.Visibility = Visibility.Hidden;
                MainFrame.Margin = new Thickness(0);
                return;
            }
            else
            {
                MainBar.Visibility = Visibility.Visible;
                MainFrame.Margin = new Thickness(0, 70, 0, 0);
            }
            //if (e.Content is EventAdministratorMenu || e.Content is TechnicalAdministratorMenu || e.Content is ManageSeason || e.Content is ManageTeams || e.Content is ManagePlayers || e.Content is ManageMatchups)
            //    btnLogout.Visibility = Visibility.Visible;
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(new MainScreen());
            Class1.MainFrame = MainFrame;
        }
    }
}
