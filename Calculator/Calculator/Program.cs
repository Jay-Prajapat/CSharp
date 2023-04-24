using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while(true)
            {
                Console.WriteLine("Enter first number: ");
                int.TryParse(Console.ReadLine(), out int number1);
                Console.WriteLine("Enter second number: ");
                int.TryParse(Console.ReadLine(), out int number2);
                Console.WriteLine("Choose Options : \\n1.Addition \\n2.Subtraction\\n3.Multiplication\\n4.Division\\n5.Exit");
                int.TryParse(Console.ReadLine(), out int option);
                switch (option)
                {
                    case (int)Options.Addition:
                        Console.WriteLine($"Addition of {number1} and {number2} is {number1 + number2}");
                        break;
                    case (int)Options.Subtraction:
                        Console.WriteLine($"Subtraction of {number1} and {number2} is {number1 - number2}");
                        break;
                    case (int)Options.Multiplication:
                        Console.WriteLine($"Multiplication of {number1} and {number2} is {number1 * number2}");
                        break;
                    case (int)Options.Division:
                        Console.WriteLine($"Division of {number1} and {number2} is {number1 / number2}");
                        break;
                    case (int)Options.Exit:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Please enter valid option");
                        break;
                }
            }

        }
        public enum Options{
            Addition = 1,
            Subtraction = 2,
            Multiplication = 3,
            Division = 4,
            Exit=5
        }
    }
}
