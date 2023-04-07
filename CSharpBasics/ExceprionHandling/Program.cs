using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceprionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("In try block");
                int a = 7;
                int b = 0;
                int c = a / b;
                Console.WriteLine($"the answer of {a} / {b} is {c}");
            }
            finally
            {
                Console.WriteLine("In finaly block");
            }
        }
       
        


    }
}
