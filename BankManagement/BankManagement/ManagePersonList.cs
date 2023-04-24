using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BankManagement
{
    public sealed class ManagePersonList
    {
        private List<Person> _persons = new List<Person>();
        public List<Person> Persons 
        {
            get { return _persons; }
            set { _persons = value; } 
        }

        public void AddPerson(ManagePersonList personList)
        {
            try
            {
                Console.WriteLine("Enter Id of person : ");
                int id;
                if(!int.TryParse(Console.ReadLine(),out id))
                {
                    Console.WriteLine("Enter Valid id");
                }
                Console.WriteLine("Enter name : ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter mobile number : ");
                Regex reg = new Regex(@"^[0-9]{10}$");
                string mobileNumber = Console.ReadLine();
                if (!reg.IsMatch(mobileNumber))
                {
                    Console.WriteLine("Please enter valid Mobile Number like '9658457123'");
                }

                Console.WriteLine("Enter Age of Person : ");
                int age;
                if (int.TryParse(Console.ReadLine(), out age))
                {
                    if (!(age >= 18 && age <= 100))
                    {
                        Console.WriteLine("Enter Valid Age, Age should be greater than 18.");

                    }
                }
                else
                {
                    Console.WriteLine("Enter Valid Age.");
                }
                Console.WriteLine("Enter Account Number : ");
                string accountNumber = Console.ReadLine();
                Regex regExp = new Regex(@"^[0-9]{6}$");
                if (!regExp.IsMatch(accountNumber))
                {
                    Console.WriteLine("Enter valid acount number...");
                }
                Person person = new Person(id,name,mobileNumber,accountNumber,age);
                List<Person> persons = personList.Persons;
                persons.Add(person);

                personList.Persons = persons;
                Console.WriteLine("\n----- User Added Successfully -----\n");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
