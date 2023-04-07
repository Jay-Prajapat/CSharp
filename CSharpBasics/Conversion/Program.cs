using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee()
            {
                ID = 101,
                Name = "Jhon",
                Gender = "Male",
                Salary = 5000
            };
            Employee emp2 = new Employee()
            {
                ID = 102,
                Name = "Alpha",
                Gender = "Male",
                Salary = 6500
            };
            Employee emp3 = new Employee()
            {
                ID = 103,
                Name = "Sow",
                Gender = "Female",
                Salary = 7000
            };

            Employee[] arrEmployees = new Employee[3];
            arrEmployees[0] = emp1;
            arrEmployees[1] = emp2;
            arrEmployees[2] = emp3;
            //convert array to list
            List<Employee> empList = arrEmployees.ToList<Employee>();
            foreach (Employee emp in empList)
            {
                Console.WriteLine($"ID : {emp.ID}, Name : {emp.Name}, Gender : {emp.Gender}, salary : {emp.Salary}");
            }
            Console.WriteLine("-----------------------------------");
            //convert list to dictionary
            Dictionary<int, Employee> empDictionary = arrEmployees.ToDictionary(employee => employee.ID, employee => employee);
            Dictionary<int, Employee> empDicFromList = empList.ToDictionary(employee => employee.ID, employee => employee);

            Employee[] arrFromdic = empDictionary.Values.ToArray();
            List<Employee> listFromDic = empDictionary.Values.ToList();
        }
    }
    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
    }

}
