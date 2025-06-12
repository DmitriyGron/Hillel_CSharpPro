using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_004_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix1 = new Matrix(4, 4);
            Matrix matrix2 = new Matrix(4, 4);


            matrix1.FillingMatrix();
            matrix2.FillingMatrix();

            Console.WriteLine("Matrix 1:");
            matrix1.Print();

            Console.WriteLine("Matrix 2:");
            matrix2.Print();

            Console.WriteLine("Matrix 1 + Matrix 2:");
            Matrix sum = matrix1 + matrix2;
            sum.Print();

            Console.WriteLine("Matrix 1 * Matrix 2:");
            Matrix sum1 = matrix1 * matrix2;
            sum1.Print();

            Console.WriteLine("Matrix 1 - Matrix 2:");
            Matrix difference = matrix1 - matrix2;
            difference.Print();

            Console.WriteLine("Matrix 1 * 5:");
            Matrix product1 = matrix1 * 5;
            product1.Print();

            Console.WriteLine("Matrix 2 * 7:");
            Matrix product2 = matrix2 * 7;
            product2.Print();

            Console.WriteLine("Matrix 1 == Matrix 2: " + (matrix1 == matrix2));
            Console.WriteLine("Matrix 1 != Matrix 2: " + (matrix1 != matrix2));
            Console.WriteLine("Matrix 1 equals Matrix 2: " + matrix1.Equals(matrix2));
            Console.WriteLine("Matrix 1 hash code: " + matrix1.GetHashCode());
            Console.WriteLine("Matrix 2 hash code: " + matrix2.GetHashCode());

        }
    }
}
