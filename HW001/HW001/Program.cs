using System;

namespace HW001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            while (true)
            {
                Console.Write("Enter first value: ");
                double firstValue = double.Parse(Console.ReadLine());
                Console.Write("Enter second value: ");
                double secondValue = double.Parse(Console.ReadLine());

                Console.WriteLine("select operation: '+', '-', '*', '/'");
                string operation = Console.ReadLine();

                switch (operation)
                {
                    case "+":
                        Console.WriteLine($"{firstValue} + {secondValue} = " + calculator.Addition(firstValue, secondValue));
                        break;
                    case "-":
                        Console.WriteLine($"{firstValue} - {secondValue} = " + calculator.Subtraction(firstValue, secondValue));
                        break;
                    case "*":
                        Console.WriteLine($"{firstValue} * {secondValue} = " + calculator.Multiplication(firstValue, secondValue));
                        break;
                    case "/":
                        Console.WriteLine($"{firstValue} / {secondValue} = " + calculator.Division(firstValue, secondValue));
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }

                Console.WriteLine("if you want to exit write the 'end'. ");
                string exit = Console.ReadLine();
                if (exit == "end")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}
