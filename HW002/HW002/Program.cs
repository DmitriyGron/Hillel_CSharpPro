using System;

namespace HW002
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Uah: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Сoins: ");
            b = Convert.ToInt32(Console.ReadLine());

            Money money = new Money(a,b);
            money.ShowInfo();
        }
    }
}
