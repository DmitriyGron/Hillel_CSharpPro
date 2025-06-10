using System;

namespace HW_003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            intArray array = new intArray(new int[] { 1, 2, 3, 4, 5 });

            array.Show();
            array.Show("Array");
        }
    }
}
