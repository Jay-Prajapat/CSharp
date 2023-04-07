using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bool Equal = Calculator.AreEqual<int>(20, 30);
            //bool Eqalstr = Calculator.AreEqual<string>("Hello", "ello");
            //if (Eqalstr)
            //{
            //    Console.WriteLine("Equal");
            //}
            //else
            //{
            //    Console.WriteLine("NotEqual");
            //}

            //GenericClass<string> stringClass = new GenericClass<string>();
            //stringClass.Message = "Hello";
            //stringClass.GenericMethod("Jay", "Prajapati");

            //GenericClass<Employee> EmployeeClass = new GenericClass<Employee>();
            //Employee emp1 = new Employee() { Name = "Jay", Location = "Simform" };
            //Employee emp2 = new Employee() { Name = "Dev", Location = "Simform2" };
            //Employee emp3 = new Employee() { Name = "John", Location = "Simform3" };

            //EmployeeClass.Message = emp1;
            //EmployeeClass.GenericMethod(emp2, emp3);

            //List<string> strList = new List<string>();
            //strList.Add("Hello");
            //strList.Add("Hi");
            //Console.WriteLine("----------------------------------");

            //foreach (string item in strList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------------------------------");

            //List<string> strList2 = new List<string>();
            //strList2.Add("Jay");
            //strList2.Add("Prajapati");
            //strList2.Add("Hello");

            //foreach (string item in strList2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------------------------------");


            //strList2.AddRange(strList);

            //foreach (string item in strList2)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("----------------------------------");

            //Console.WriteLine("After using distinct method");

            //List<string> distinct = strList2.Distinct().ToList();
            //foreach (string item in distinct)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(distinct.Count);
            //Console.WriteLine("----------------------------------");
            //if (distinct.Contains("Hello"))
            //{
            //    Console.WriteLine("true");
            //}
            //else { Console.WriteLine("false"); }

            //strList.Insert(1, "Hello woeld");
            //Console.WriteLine("After adding hello world at index 1");
            //foreach (string item in strList)
            //{
            //    Console.WriteLine(item);
            //}
            List<string> str1 = new List<string>();
            str1.Add("hi");
            str1.Add("hello");
            str1.Add("hello world");
            Console.WriteLine("Str1");
            foreach (string item in str1)
            {
                Console.WriteLine(item);
            }

            List<string> str2 = new List<string>();
            str2.Add("Jay");
            str2.Add("Prajapati");
            str2.Add("hi");
            str2.Add("hello");
            str2.Add("Simform");
            Console.WriteLine("Str2");
            foreach (string item in str2)
            {
                Console.WriteLine(item);
            }

            str1.AddRange(str2.Distinct().ToList());
            str1 = str1.Distinct().ToList();
            Console.WriteLine("Str1 after adding str2");
            foreach(string item in str1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------------");
            int str = str2.FindIndex(ele => ele.Contains("Jay"));
            Console.WriteLine(str);

            string trimStr = "<h1> GeekforGeeks Sudo Placement</h1>";
            Console.WriteLine(trimStr.StartsWith("<"));

            List<int> number = new List<int>{ 6,5,10,31,7,8};
           IReadOnlyCollection<int> readOnlyNumList =  number.AsReadOnly();
            //readOnlyNumList.Add(3);
            number.Add(4);
            if (number.TrueForAll(num => num > 4))
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine($"Capacity of list is {number.Capacity}");
            number.TrimExcess();
            Console.WriteLine($"Capacity after trim {number.Capacity}");
            List<int> numCapacity = new List<int>();
            numCapacity.Add(0);
            numCapacity.Add(1);
            numCapacity.Add(55454);
            numCapacity.Add(6);
            numCapacity.Add(46);

            Console.WriteLine(numCapacity.Capacity);
        }
    }

    class Calculator
    {
        public static bool AreEqual<T>(T Value1, T value2)
        {
            return Value1.Equals(value2);
        }
    }
    public class Employee
    {
        public string Name { get; set; }
        public string Location { get; set; }
    }
    public class GenericClass<T> where T : class
    {
        public T Message;
        public void GenericMethod(T Parm1, T Parm2)
        {
            Console.WriteLine($"Message : {Message}");
            Console.WriteLine($"Parm1 : {Parm1}");
            Console.WriteLine($"Parm2: {Parm2}");

        }
    }
}
