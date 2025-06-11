using System;

namespace HW_003
{
    public class Array : IOutput
    {
        private int[] elements;

        public Array(int[] array)
        {
            elements = array;
        }

        public void Show()
        {
            foreach (var element in elements)
            {
                Console.Write($"{element} ");
            }
            Console.WriteLine();
        }

        public void Show(string info)
        {
            Console.Write($"{info}: ");
            Show();
        }
    }
}