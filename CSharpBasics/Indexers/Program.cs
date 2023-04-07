using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp["Id"] = 1;
            emp["name"] = "Jay";
            emp["Address"] = "Ahemadabad";
            emp["city"] = "Vyara";

            Console.WriteLine(emp["Id"] + " " + emp["name"] + " " + emp["Address"]);
        }
        public class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            
            public object this [string index]
            {
                get
                {
                    if(index == "Id") return Id;
                    else if(index == "name") return Name;
                    else if(index == "Address") return Address;
                    else if(index == "city") return City;
                    else return null;
                }
                set
                {
                    if(index == "Id")Id = Convert.ToInt32(value);
                    else if(index == "name") Name = value.ToString();
                    else if(index=="Address") Address = value.ToString();
                    else if(index == "city") City = value.ToString();

                }
            }
        }
    }
}
