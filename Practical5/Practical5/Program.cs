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
            int[] arr = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < 6; i++)
            {
                try
                {
                    Console.WriteLine(arr[i]);
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
