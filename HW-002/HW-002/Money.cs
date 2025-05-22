using System;

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

        public void Show()
        {
            Console.WriteLine($"Money: {_uah}.{_coins}");
        }
    }
}
