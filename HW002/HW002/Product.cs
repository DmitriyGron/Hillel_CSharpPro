using System;

namespace HW002
{
    public class Product
    {
        private string name { get; set; }

        private Money price { get; set; }

        public Product(string name, Money price)
        {
            this.name = name;
            this.price = price;
        }

        public Money ReducePrice(Money changingPrice)
        {
            if (changingPrice.Uah > price.Uah || changingPrice.Uah == price.Uah && changingPrice.Coins > price.Coins)
            {
                Console.WriteLine("You entered an amount greater than it is");
                return new Money(price.Uah, price.Coins);

            }

            int newUah = price.Uah - changingPrice.Uah;
            int newCoins = price.Coins - changingPrice.Coins;

            if (newCoins < 0)
            {
                newUah -= 1;
                newCoins += 100;
            }

            return price  = new Money(newUah, newCoins);
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Product: {name}, Price: {price.Uah}.{price.Coins}");
        }
    }
}
