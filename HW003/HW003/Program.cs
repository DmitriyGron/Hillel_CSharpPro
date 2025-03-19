using System;

namespace HW003
{
    public class Program
    {
        static void Main(string[] args)
        {
            double[] array = { 12, 4, 123, 5, 2123, 4 };
            string str = "That's array: ";

            Array arr = new Array();
            arr.Arr = array;
            arr.Show();
            arr.Show(str);
            
        }
    }
}
