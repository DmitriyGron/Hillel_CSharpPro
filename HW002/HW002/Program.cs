using System;

namespace HW002
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Uah: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сoins: ");
            b = Convert.ToInt32(Console.ReadLine());

            Money money = new Money(a,b);
            money.ShowInfo();

            Product product = new Product("Bread", money);
            product.ShowInfo();

            Console.WriteLine();

            Console.WriteLine("How much do you want to reduce the price? ");
            Console.Write("Uah: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Coins: ");
            b = Convert.ToInt32(Console.ReadLine());
            Money changingPrice = new Money(a, b);
            product.ReducePrice(changingPrice);
            product.ShowInfo();
        }
    }
}
