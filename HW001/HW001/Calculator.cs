using System;

namespace HW001
{
    public class Calculator
    {
        public double Addition(double firstValue, double secondValue)
        {
            return firstValue + secondValue;
        }
        public double Subtraction(double firstValue, double secondValue)
        {
            return firstValue - secondValue;
        }
        public double Multiplication(double firstValue, double secondValue)
        {
            return firstValue * secondValue;
        }
        public double Division(double firstValue, double secondValue)
        {
            if (secondValue == 0)
            {
                Console.WriteLine("Error: Division by zero!");
                return double.NaN; 
            }
            return firstValue / secondValue;
        }
    }
}
