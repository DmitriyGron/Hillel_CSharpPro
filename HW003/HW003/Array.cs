using System;
using System.Windows.Markup;

namespace HW003
{
    public class Array : IOutput
    {
        private double[] array;

        public double[] Arr
        {
            get { return array; }
            set { array = value; }
        }
        public void Show()
        {
            Console.WriteLine("Array");
        }

        public void Show(string info)
        {
            Console.Write(info);
            foreach (var item in array)
            {
                Console.Write($"{item}, ");
            }
        }
    }
}
