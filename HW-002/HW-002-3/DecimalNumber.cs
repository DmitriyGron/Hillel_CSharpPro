using System;

namespace HW_002_3
{
    struct DecimalNumber
    {
        private int number;

        public DecimalNumber(int number)
        {
            this.number = number;
        }

        public void Show()
        {
            Console.WriteLine($"Decimal number: {number}");
        }

        private string ConvertToBase(int baseValue)
        {
            if (number == 0)
                return "0";

            string result = "";
            int temp = number;

            string digits = "0123456789ABCDEF";

            while (temp > 0)
            {
                int remainder = temp % baseValue;
                result = digits[remainder] + result;
                temp /= baseValue;
            }

            return result;
        }

        public string ToBinary()
        {
            return ConvertToBase(2);
        }

        public string ToOctal()
        {
            return ConvertToBase(8);
        }

        public string ToHexadecimal()
        {
            return ConvertToBase(16);
        }

    }
}
