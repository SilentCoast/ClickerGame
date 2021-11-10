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

namespace ClickerGame
{
    /// <summary>
    /// Interaction logic for ShopWindow.xaml
    /// </summary>
    
    public partial class ShopWindow : Window
    {
        
        public int lvlKick { get; set; }
        public int lvlPassiveKick { get; set; }

        public int amountMoney { get; set; }
        public ShopWindow()
        {
            InitializeComponent();
            
        }
        
        private void btnImproveKick_Click(object sender, RoutedEventArgs e)
        {
            lvlKick++;
            txtImproveKick.Text = $"Kick LVL: {lvlKick}";
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            e.Cancel = true;
            Hide();
        }

        private void btnImprovePassiveKick_Click(object sender, RoutedEventArgs e)
        {
            lvlPassiveKick++;
            txtImprovePassiveKick.Text = $"Passive Kick LVL: {lvlPassiveKick}";
        }
    }
}
