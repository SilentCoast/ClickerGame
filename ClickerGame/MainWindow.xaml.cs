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
        


        public MainWindow()
        {           
            InitializeComponent();
            userData = new UserData() { LvlKick = 1, Price = 10, Price2 = 10 };
            DataContext = userData;


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

        private void btnImproveKick_Click(object sender, RoutedEventArgs e)
        {
            if (userData.Price > userData.Money)
            {
                MessageBox.Show("You need more money!");
            }
            else
            {
                userData.TakeMoney(userData.Price);
                userData.LvlKick += 1;
                userData.Price *= 2;
            }
        }

        private void btnImprovePassiveKick_Click(object sender, RoutedEventArgs e)
        {
            if (userData.Price2 > userData.Money)
            {
                MessageBox.Show("You need more money!");
            }
            else
            {
                userData.TakeMoney(userData.Price2);
                userData.LvlPassiveKick += 1;
                userData.Price2 *= 2;
            }
        }
    }
}
