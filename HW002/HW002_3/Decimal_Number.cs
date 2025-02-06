using System;

namespace HW002_3
{
    public struct Decimal_Number
    {
        public void toBinary(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("0");
                return;
            }

            string binary = "";
            while (number > 0)
            {
                binary = (number % 2) + binary;
                number /= 2; 
            }

            Console.WriteLine(binary);
        }

        public void toOctal(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("0");
                return;
            }

            string octal = "";
            while (number > 0)
            {
                octal = (number % 8) + octal; 
                number /= 8; 
            }

            Console.WriteLine(octal);
        }

        public void toHex(int number)
        {
            if (number == 0)
            {
                Console.WriteLine("0");
                return;
            }

            string hexadecimal = "";
            string hexDigits = "0123456789ABCDEF"; 

            while (number > 0)
            {
                hexadecimal = hexDigits[number % 16] + hexadecimal; 
                number /= 16; 
            }

            Console.WriteLine(hexadecimal);
        }
    }
}
