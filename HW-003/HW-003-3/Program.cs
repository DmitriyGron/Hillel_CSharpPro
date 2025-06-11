using System;

namespace HW_003_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(new int[] { 6, 7, 5, 12, 2, 25 });
            Console.WriteLine("Original array: ");
            array.Show();

            Console.WriteLine("Asc: ");
            array.SortAsc();
            array.Show();
            Console.WriteLine("Desc: ");
            array.SortDesc();
            array.Show();
            Console.WriteLine("Sort by param true:");
            array.SortByParam(true);
            array.Show();
            Console.WriteLine("Sort by param false:");
            array.SortByParam(false);
            array.Show();

        }
    }
}
