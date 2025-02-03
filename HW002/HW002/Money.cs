using System;

namespace HW002
{
    public class Money
    {
        public int Uah { get; set; }
        public int Coins { get; set; }
        public Money(int Uah, int Coins)
        {
            if (Uah < 0 || Coins < 0)
            {
                throw new ArgumentException("Amount of money cannot be negative.");
            }

            if (Coins >= 100)
            {
                Uah += Coins / 100;
                Coins %=  100;
            }
            this.Uah = Uah;
            this.Coins = Coins;
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Your money: {Uah}.{Coins }");
        }
    }
}
