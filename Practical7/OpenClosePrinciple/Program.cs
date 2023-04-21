using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle circle = new Circle();
            circle.Radius = 10;
            double circleArea = circle.CalculateArea();
            Console.WriteLine($"Circle Area : {circleArea}");

            Rectangle rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 25;
            double rectangleArea = rectangle.CalculateArea();
            Console.WriteLine($"Rectangle Area : {rectangleArea}");

            Square square= new Square();
            square.SideLength = 10;
            double squareArea = square.CalculateArea();
            Console.WriteLine($"Square Area : {squareArea}");
        }
    }
    public interface IShape
    {
        double CalculateArea();
    }
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius,2);
        }
    }
    public class Rectangle : IShape
    {
        public double Width { get; set; }
        public double Height { get; set; }  
        public double CalculateArea()
        {
            return Width* Height;
        }
    }

    public class Square : IShape
    {
        public double SideLength { get; set; }
        public double CalculateArea()
        {
            return Math.Pow(SideLength, 2);
        }
    }
}
