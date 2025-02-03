using System;

namespace HW002
{
    public class Money
    {
        public int Uah { get; set; }
        public int Coins { get; set; }
        public Money(int uah, int coins)
        {
            if (coins >= 100)
            {
                uah += coins / 100;
                coins %=  100;
            }
            Uah = uah;
            Coins = coins;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Your money: {Uah}.{Coins }");
        }
    }
}
