using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClickerGame
{
    public class UserData : INotifyPropertyChanged
    {
        private int money;
        public int Money { get { return money; } set { money = value; OnPropertyChanged("Money"); } }

        private int lvlKick;
        public int LvlKick { get { return lvlKick; } set { lvlKick = value; OnPropertyChanged("LvlKick"); } }

        private int lvlPassiveKick;
        public int LvlPassiveKick { get { return lvlPassiveKick; } set { lvlPassiveKick = value; OnPropertyChanged("LvlPassiveKick"); } }
        /// <summary>
        /// 
        /// </summary>
        public void GetMoneyFromKick()
        {
            Money += 1 * LvlKick;
        }

        public void GetMoneyFromPassiveKick()
        {
            Money += 1 * LvlPassiveKick;
        }
        /// <summary>
        /// subract from Money number equals amount
        /// </summary>
        /// <param name="amount">sum of money to take</param>
        public void TakeMoney(int amount) 
        {
            Money -= amount;
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string prop)
        {           
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop)); 
        }
    }
}
