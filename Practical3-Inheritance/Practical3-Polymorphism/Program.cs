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
            Bird eagle = new Bird();
            Bird crow = new Duck();
            Duck duck = new Duck();
            eagle.Voice();
            crow.Voice();
            duck.Voice();

        }
    }
    public class Bird
    {
        /// <summary>
        /// This is a Brid class virtual method and will print the voice of bird.
        /// </summary>
        public virtual void Voice()
        {
            Console.WriteLine("Turr Turr");
        }
    }
    public class Duck : Bird
    {
        /// <summary>
        /// This is override method of Duck class and will print the voice Duck.
        /// </summary>
        public override void Voice()
        {
            Console.WriteLine("Quack Quack");
        }
    }
}
