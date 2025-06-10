using System;

namespace HW_003_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(new int[] { 6, 7, 5, 12, 5, 25 });

            Console.WriteLine($"Averege: {array.Avg()}");
            Console.WriteLine($"Maximum: {array.Max()}");
            Console.WriteLine($"Minimum: {array.Min()}");

            if (array.Search(7).Equals(true))
            {
                Console.WriteLine($"Number found");
            }
            else
            {
                Console.WriteLine($"Number not found");
            }
        }
    }
}
