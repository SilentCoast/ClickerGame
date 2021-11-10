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
using System.Windows.Threading;

namespace ClickerGame
{
    
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserData userData;
        ShopWindow shopWindow;


        public MainWindow()
        {           
            InitializeComponent();
            userData = new UserData();
            DataContext = userData;

            shopWindow = new ShopWindow() ;
            

            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += timmer_Tick;
            timer.Start();
        }
        private void timmer_Tick(object sender,EventArgs e)
        {
            userData.GetMoneyFromPassiveKick();
        }

        private void btnKick_Click(object sender, RoutedEventArgs e)
        {
            userData.GetMoneyFromKick();            
        }

        private void btnShop_Click(object sender, RoutedEventArgs e)
        {
            shopWindow.Show();                 
        }

        private void mainWindow_GotFocus(object sender, RoutedEventArgs e)
        {
            userData.LvlKick = shopWindow.lvlKick;
            userData.LvlPassiveKick = shopWindow.lvlPassiveKick;          
        }

       
    }
}
