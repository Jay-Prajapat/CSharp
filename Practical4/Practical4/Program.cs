using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            Console.WriteLine("Enter name of student.");
            student1.Name = Console.ReadLine();
            Console.WriteLine("Enter marks of student.");
            for (int i = 0; i < 5; i++)
            {
                student1.Marks[i] = Convert.ToDecimal(Console.ReadLine());
            }

            Console.WriteLine("Choose Option from Below :");
            Console.WriteLine("1.Aggregate:\n2.MinMark\n3.MaxMarks\n4.Grades\n5.Exit");
            while (true)
            {

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case (int)Student.Options.Aggregate:
                        Console.WriteLine($"The name of student is {student1.Name} and the average marks is {student1.CalculateAverageMarks(student1.Marks)}");
                        break;
                    case (int)Student.Options.MinMark:
                        Console.WriteLine($"The Minimum marks is {student1.FindMinimumMarks(student1.Marks)}");
                        break;
                    case (int)Student.Options.MaximumMark:
                        Console.WriteLine($"The Maximum marks is {student1.FindMaximumMarks(student1.Marks)}");
                        break;
                    case (int)Student.Options.Grade:
                        decimal averageMarks = student1.CalculateAverageMarks(student1.Marks);
                        Console.WriteLine($"The Grade is {student1.CalculateGrade(averageMarks)}");
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default: 
                        Console.WriteLine("Choose Valid option!!!");
                        break;

                }
            }

        }
    }
    public class Student
    {
        public string Name;
        public decimal[] Marks = new decimal[5];
        static decimal AverageMarks;
        /// <summary>
        /// This method will calculate an average marks.
        /// </summary>
        /// <param name="marks"></param>
        /// <returns>decimal value of average marks</returns>
        public decimal CalculateAverageMarks(decimal[] marks)
        {
            decimal sum = 0;
            for (int i = 0; i < marks.Length; i++)
            {
                sum += marks[i];
            }
            AverageMarks = sum / marks.Length;
            return AverageMarks;
        }
        /// <summary>
        /// This method will find the minimum mark from the given marks.
        /// </summary>
        /// <param name="marks"></param>
        /// <returns>The minimum value from marks.</returns>
        public decimal FindMinimumMarks(decimal[] marks)
        {
            return marks.Min();
        }
        /// <summary>
        /// This will find the maximum mark from the given marks.
        /// </summary>
        /// <param name="marks"></param>
        /// <returns>The maximum value from marks.</returns>
        public decimal FindMaximumMarks(decimal[] marks)
        {
            return marks.Max();
        }
        /// <summary>
        /// This will calculate the grade based on the marks.
        /// </summary>
        /// <param name="mark"></param>
        /// <returns>Grade of the student based on marks.</returns>
        public string CalculateGrade(decimal mark)
        {
            string grade = "";
            switch (mark)
            {
                case decimal a when mark > 90:
                    grade = "A";
                    break;
                case decimal a when mark > 80:
                    grade = "B";
                    break;
                case decimal a when mark > 70:
                    grade = "C";
                    break;
                case decimal a when mark < 70:
                    grade = "D";
                    break;
                default:
                    Console.WriteLine("Wrong option selection");
                    break;
            }
            return grade;
        }
        public enum Options
        {
            Aggregate = 1,
            MinMark = 2,
            MaximumMark = 3,
            Grade = 4
        }
    }
}
