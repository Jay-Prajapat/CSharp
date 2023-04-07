using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    internal class Program
    {
        public abstract class Parent
        {
            public abstract void Add(int a, int b);
            public abstract void Sub(int a, int b);
            public void Mul(int a, int b)
            {
                Console.WriteLine($"The Multiplication of a and b is :{a*b}");
            }
            public void Div(int a, int b)
            {
                Console.WriteLine($"The Division of a abd b is : {a / b}");
            }
        }
        public class Child : Parent

        {
            public override void Add(int a, int b)
            {
                Console.WriteLine($"The Addition of a and b is : {a+b}");
            }
            public override void Sub(int a, int b)
            {
                Console.WriteLine($"The Subtraction of a and b is :{a-b}");
            }
        }


        static void Main(string[] args)
        {
            Child c1 = new Child();
            c1.Add(10, 2);
            c1.Sub(10, 2);
            c1.Mul(10, 2);
            c1.Div(10, 2);
        }
    }
}
