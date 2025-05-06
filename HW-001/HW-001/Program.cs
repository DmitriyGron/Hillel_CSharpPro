using System;
using System.Diagnostics.Eventing.Reader;

namespace HW_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

                Console.WriteLine("Enter first value: ");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second value: ");
                double b = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Choose operation: ");
                string chooseOperation = Console.ReadLine();

                Calc calc = new Calc(a, b);

                if (chooseOperation == string.Empty)
                {
                    Console.WriteLine("You have not selected an operation or it is incorrect");
                }
                else
                {

                    switch (chooseOperation)
                    {
                        case "+":
                            calc.Add();
                            calc.ShowInfo("+");
                            break;
                        case "-":
                            calc.Subtraction();
                            calc.ShowInfo("-");
                            break;
                        case "*":
                            calc.Multiplication();
                            calc.ShowInfo("*");
                            break;
                        case "/":
                            calc.Division();
                            calc.ShowInfo("/");
                            break;
                        default:
                            Console.WriteLine("You have not selected a valid operation.");
                            break;
                    }
                }
                Console.WriteLine("Enter 'exit' if u want to leave or press 'enter' for continue");
                string exit = Console.ReadLine();
                if (exit == "exit")
                    break;
            }
        }
    }
}
