using System;

namespace HW_001
{
    internal class Calc
    {
        private double _firstValue;
        private double _secondValue;

        public double result { get; private set; }

        public Calc(double a, double b)
        {
            _firstValue = a;
            _secondValue = b;
        }

        public double Add()
        {
            return result = _firstValue + _secondValue;
        }
        public double Subtraction()
        {
            return result = _firstValue - _secondValue;
        }

        public double Multiplication()
        {
            return result = _firstValue * _secondValue;
        }

        public double Division()
        {
            if (_secondValue == 0)
            {
                throw new ArgumentException("Ошибка деления на ноль");
            }

            return result = _firstValue / _secondValue;
        }
        public void ShowInfo(string operation)
        {
            Console.WriteLine($"{_firstValue} {operation} {_secondValue} = {result}");
        }
    }
}
