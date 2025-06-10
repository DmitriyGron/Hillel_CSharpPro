using System;

namespace HW_003_2
{
    internal class Array : IMath
    {
        private int[] elements;

        public Array(int[] array)
        {
            elements = array;
        }

        public float Avg()
        {
            float sum = 0;
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] < 0)
                    throw new ArgumentException("Array contains negative values.");

                sum += elements[i];
            }
            return sum / elements.Length;
        }

        public int Max()
        {
            int max = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] > max)
                    max = elements[i];
            }
            return max;
        }

        public int Min()
        {
            int min = elements[0];
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] < min)
                    min = elements[i];
            }
            return min;
        }

        public bool Search(int valueToSearch)
        {
            for (int i = 0; i < elements.Length; i++)
            {
                if (elements[i] == valueToSearch)
                    return true;
            }
            return false;
        }
    }
}
