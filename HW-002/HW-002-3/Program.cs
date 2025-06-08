using System;

namespace HW_002_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            DecimalNumber decimalNumber = new DecimalNumber(255);

            decimalNumber.Show();
            Console.WriteLine("In binary system: " + decimalNumber.ToBinary());
            Console.WriteLine("In octal system: " + decimalNumber.ToOctal());
            Console.WriteLine("In hexadecimal: " + decimalNumber.ToHexadecimal());
        }

    }
}

