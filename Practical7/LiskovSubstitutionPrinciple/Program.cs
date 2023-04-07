using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiskovSubstitutionPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IFruit fruit = new Orange();
            fruit.GetColor();
            fruit = new Apple();
            fruit.GetColor();
        }
    }

    public interface IFruit
    {
        void GetColor();
    }

    public class Apple : IFruit
    {
        /// <summary>
        /// The apple class method will print the color of apple.
        /// </summary>
        public void GetColor()
        {
            Console.WriteLine("Color is Red");
        }
    }

    public class Orange : IFruit
    {
        /// <summary>
        /// The Orange class meethod will print the color of orange.
        /// </summary>
        public void GetColor()
        {
            Console.WriteLine("Color is Orange");
        }
    }
}
