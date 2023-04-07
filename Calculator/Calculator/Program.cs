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
            int number1;
            int number2;

            Console.WriteLine("Enter first number: ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Addition of {number1} and {number2} is {number1 + number2}");
            Console.WriteLine($"Subtraction of {number1} and {number2} is {number1 - number2}");
            Console.WriteLine($"Multiplication of {number1} and {number2} is {number1 * number2}");
            Console.WriteLine($"Division of {number1} and {number2} is {number1 / number2}");

        }
    }
}
