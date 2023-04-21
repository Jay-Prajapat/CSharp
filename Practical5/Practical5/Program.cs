using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter value of Arrays");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 6; i++)
            {
                try
                {
                    Console.WriteLine($"Array[{i}] : {arr[i]}");
                }
                catch(IndexOutOfRangeException ex) 
                {
                    Console.WriteLine("EXCEPTION: " + ex.Message);    
                }
                finally 
                {
                    Console.WriteLine("This is finaly block"); 
                }
               
            }
        }
    }
}
