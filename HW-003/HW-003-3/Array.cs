using System;

namespace HW_003_3
{
    internal class Array : ISort
    {
        private int[] elements;

        public Array(int[] array)
        {
            elements = array;
        }

        public void SortAsc()
        {
            int temp;
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length - 1; j++)
                {
                    if (elements[j] > elements[j + 1])
                    {
                        temp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = temp;
                    }
                }
            }
        }

        public void SortDesc()
        {
            int temp;
            for (int i = 0; i < elements.Length; i++)
            {
                for (int j = 0; j < elements.Length - 1; j++)
                {
                    if (elements[j] < elements[j + 1])
                    {
                        temp = elements[j];
                        elements[j] = elements[j + 1];
                        elements[j + 1] = temp;
                    }
                }
            }
        }

        public void SortByParam(bool isAsc)
        {
            if (isAsc.Equals(true))
                SortAsc();
            else
                SortDesc();
        }
        public void Show()
        {
            foreach (var element in elements)
                Console.Write($"{element} ");
            Console.WriteLine();
        }
    }
}
