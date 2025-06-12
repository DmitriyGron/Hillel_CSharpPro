using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_004_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CreditCard card1 = new CreditCard(123, 6000);
            CreditCard card2 = new CreditCard(456, 3000);

            Console.WriteLine("Card 1: " + card1);
            Console.WriteLine("Card 2: " + card2 + "\n");

            Console.WriteLine("Adding 2000 to Card 1's balance...");
            card1 += 2000;
            Console.WriteLine("Card 1: " + card1 + "\n");

            Console.WriteLine("Subtracting 1500 from Card 2's balance...");
            card2 -= 1500;
            Console.WriteLine("Card 2: " + card2 + "\n");

            Console.WriteLine("Card 1 (CVC) == Card 2 (CVC): " + (card1.CVC == card2.CVC));
            Console.WriteLine("Card 1 (CVC) != Card 2 (CVC): " + (card1.CVC != card2.CVC));
            Console.WriteLine("Card 1 > Card 2: " + (card1 > card2));
            Console.WriteLine("Card 1 < Card 2: " + (card1 < card2));
            Console.WriteLine("Equals (CVC): " + card1.CVC.Equals(card2.CVC));
            Console.WriteLine("Card 1 hash code: " + card1.GetHashCode());
            Console.WriteLine("Card 2 hash code: " + card2.GetHashCode() + "\n");

            Console.WriteLine("Card 1: " + card1.ToString());
            Console.WriteLine("Card 2: " + card2.ToString());

        }
    }
}
