using System;

namespace HW_004_2
{
    internal class Matrix
    {
        private double[,] _matrix;
        private int _rows;
        private int _columns;
        private static Random random = new Random();

        public Matrix(int rows, int columns)
        {
            _rows = rows;
            _columns = columns;
            _matrix = new double[rows, columns];
        }

        public double this[int row, int column]
        {
            get => _matrix[row, column];
            set => _matrix[row, column] = value;
        }

        public static Matrix operator +(Matrix a, Matrix b)
        {
            if (a._columns != b._columns || a._rows != b._rows)
                throw new InvalidOperationException("Matrices must have the same dimensions for addition.");

            Matrix result = new Matrix(a._rows, a._columns);
            for (int i = 0; i < a._rows; i++)
                for (int j = 0; j < a._columns; j++)
                    result[i, j] = a[i, j] + b[i, j];
            return result;
        }

        public static Matrix operator -(Matrix a, Matrix b)
        {
            if (a._columns != b._columns || a._rows != b._rows)
                throw new InvalidOperationException("Matrices must have the same dimensions for subtraction.");
            Matrix result = new Matrix(a._rows, a._columns);
            for (int i = 0; i < a._rows; i++)
                for (int j = 0; j < a._columns; j++)
                    result[i, j] = a[i, j] - b[i, j];
            return result;
        }

        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a._columns != b._rows)
                throw new InvalidOperationException("Invalid matrix dimensions for multiplication.");
            Matrix result = new Matrix(a._rows, b._columns);
            for (int i = 0; i < a._rows; i++)
            {
                for (int j = 0; j < b._columns; j++)
                {
                    for (int k = 0; k < a._columns; k++)
                    {
                        result[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix a, double scalar)
        {
            Matrix result = new Matrix(a._rows, a._columns);
            for (int i = 0; i < a._rows; i++)
                for (int j = 0; j < a._columns; j++)
                    result[i, j] = a[i, j] * scalar;
            return result;
        }

        public static bool operator ==(Matrix a, Matrix b)
        {
            if (a._rows != b._rows || a._columns != b._columns)
                return false;
            for (int i = 0; i < a._rows; i++)
            {
                for (int j = 0; j < a._columns; j++)
                {
                    if (a[i, j] != b[i, j])
                        return false;
                }
            }
            return true;
        }
        public static bool operator !=(Matrix a, Matrix b) => !(a == b);

        public override bool Equals(object obj)
        {
            if (obj is Matrix other)
            {
                return this == other;
            }
            return false;
        }
        public override int GetHashCode() => _matrix.GetHashCode();

        public void FillingMatrix()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    _matrix[i, j] = random.Next(1, 20);
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < _rows; i++)
            {
                for (int j = 0; j < _columns; j++)
                {
                    Console.Write($"{_matrix[i, j],5} ");
                }
                Console.WriteLine();
            }
        }
    }
}
