using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical3_Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            laptop.Brand = "HP";
            laptop.Model = "Pavilion Series";
            laptop.LaptopDetails();
            //laptop.MotherBoardInfo();
           //MotherBoardInfo is not accessible because it is private in laptop class so we can only access it into
           //Laptop class only so this way we can protect our implementation and achive abstraction.                                                  
        }
    }
    public class Laptop
    {
        private string _brand;
        private string _model;
        //public property that get and sets the brand of laptop.
        public string Brand {
            get { return _brand; }
            set { _brand = value; }
        }
        //public property that get and sets the model of laptop.

        public string Model {
            get { return _model; }
            set { _model = value; }  
        }
        /// <summary>
        /// This method will print the laptop details like brand and model of laptop.
        /// </summary>
        public void LaptopDetails()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
        }
        /// <summary>
        /// This private method will print the mother board information of laptop.
        /// </summary>
        private void MotherBoardInfo()
        {
            Console.WriteLine("Mother board information");
        }
    }
}
