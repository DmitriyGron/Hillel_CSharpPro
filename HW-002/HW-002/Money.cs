using System;
using System.Runtime.CompilerServices;

namespace HW_002
{
    public class Money
    {
        private int _uah;
        private int _coins;

        public Money(int uah, int coins)
        {
            if (coins >= 100)
            {
                uah += coins / 100;
                coins = coins % 100;
            }
            _uah = uah;
            _coins = coins;
        }

        public int Uah
        {
            get { return _uah; }
            set { _uah = value; }
        }

        public int Coins
        {
            get { return _coins; }
            set { _coins = value; }
        }

        public void Show(string text)
        {
            Console.WriteLine($"{text}: {_uah}.{_coins}");
        }
    }
}
