using System;

namespace HW002
{
    public class Program
    {
        static void Main(string[] args)
        {
            int firstValue, secondValue;
            Console.Write("Uah: ");
            firstValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сoins: ");
            secondValue = Convert.ToInt32(Console.ReadLine());

            Money money = new Money(firstValue,secondValue);
            money.ShowInfo();

            Product product = new Product("Bread", money);
            product.ShowInfo();

            Console.WriteLine();

            Console.WriteLine("How much do you want to reduce the price? ");
            Console.Write("Uah: ");
            firstValue = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coins: ");
            secondValue = Convert.ToInt32(Console.ReadLine());
            Money changingPrice = new Money(firstValue, secondValue);
            product.ReducePrice(changingPrice);
            product.ShowInfo();
        }
    }
}
