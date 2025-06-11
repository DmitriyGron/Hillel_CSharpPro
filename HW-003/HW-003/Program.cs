using System;

namespace HW_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Array array = new Array(new int[] { 1, 2, 3, 4, 5 });

            array.Show();
            array.Show("Array");
        }
    }
}
