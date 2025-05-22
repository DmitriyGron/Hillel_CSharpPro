using System;

namespace HW_002
{
    public class Product
    {
        private string _name;
        public Money money { get; set; }

        public Product(string name, Money money)
        {
            _name = name;
            this.money = money;
        }

        public void ChangePrice(Money changePrice)
        {
            if (changePrice.Uah > money.Uah || changePrice.Uah > money.Uah && changePrice.Coins > money.Coins)
            {
                throw new ArgumentException("The price cannot be negative");
            }
            else
            {
                money.Uah -= changePrice.Uah;
                money.Coins -= changePrice.Coins;

                if (money.Coins < 0)
                {
                    money.Uah -= 1;
                    money.Coins += 100;
                }
            }
            
        }

        public void Show()
        {
            Console.WriteLine($"Product: {_name}");
            money.Show("Price: ");
        }
    }
}
