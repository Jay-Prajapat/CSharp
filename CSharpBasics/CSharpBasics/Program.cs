using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public delegate void HelloFunctionDelegate(string message);

namespace CSharpBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Reach Dad Poor Dad");
            //book.AddGrade(12.3);
            //book.AddGrade(15.3);
            //book.AddGrade(3.23);

            HelloFunctionDelegate del = new HelloFunctionDelegate(Hello);
            del("Helllo from delegate");

            while (true)
            {
                Console.WriteLine("Enter a grade or 'q' to quite.");
                var input = Console.ReadLine();

                if(input == "q")
                {
                    break;
                }
                var grade = double.Parse(input);
                book.AddGrade(grade);
            }
            book.showStatstics();
        }

        public static void Hello(string strMessage)
        {
            Console.WriteLine(strMessage);
        }
    
    }

    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Salary { get; set;}
        public int Experience { get; set;}

        //public static void PromoteEmplpoyee(List<Employee> employeesList)
        //{
        //    foreach(Employee employee in employeesList)
        //    {
                
        //    }
        //}
            
    }
}
