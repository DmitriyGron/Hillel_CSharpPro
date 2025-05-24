using System;

namespace HW_002
{
    public class Program
    {
        static void Main()
        {
            Money mon = new Money(8,70);
            Product prod = new Product("Bread", mon);
            prod.Show();

            mon = new Money(2, 50);
            prod.ChangePrice(mon);
            prod.Show();
        }

    }
}
