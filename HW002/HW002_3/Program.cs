using System;

namespace HW002_3
{
    public  class Program
    {
        static void Main(string[] args)
        {
            int value = Convert.ToInt32(Console.ReadLine());

            Decimal_Number decimalNumber = new Decimal_Number();

            decimalNumber.toBinary(value);
            decimalNumber.toOctal(value);
            decimalNumber.toHex(value);

        }
    }
}
