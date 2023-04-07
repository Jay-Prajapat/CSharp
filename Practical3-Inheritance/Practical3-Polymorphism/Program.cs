using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3_Polymorphism
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Bird myBrid = new Bird();
            Bird myDuck = new Duck();
            Duck myDuck1 = new Duck();
            myBrid.Voice();
            myDuck.Voice();
            myDuck1.Voice();

        }
    }
    public class Bird
    {
        /// <summary>
        /// This is a Brid class method and will print the voice of bird.
        /// </summary>
        public void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }
    public class Duck : Bird
    {
        /// <summary>
        /// This is a method of Duck class and will print the voice Duck.
        /// </summary>
        public void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
