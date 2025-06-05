using System;

namespace HW_002
{
    internal class Product
    {
        private string _name;
        public Money Money { get; set; }

        public Product(string name, Money money)
        {
            _name = name;
            this.Money = money;
        }

        public void ChangePrice(Money changePrice)
        {
            if (changePrice.IsLessThan(changePrice))
            {
                throw new ArgumentException("The price cannot be negative");
            }
            else
            {
                Money.Uah -= changePrice.Uah;
                Money.Coins -= changePrice.Coins;

                if (Money.Coins < 0)
                {
                    Money.Uah -= 1;
                    Money.Coins += 100;
                }
            }
        }

        public void Show()
        {
            Console.WriteLine($"Product: {_name}");
            Money.Show("Price: ");
        }
    }
}
