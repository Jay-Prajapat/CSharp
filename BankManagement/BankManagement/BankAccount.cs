using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace BankManagement
{
    public class BankAccount : Account,IUserManager
    {
        public void DeleteUser(ManagePersonList personList, int id)
        {
            if(personList.Persons.Exists(person => person.Id == id))
            {
                Person person = personList.Persons.Find(p => p.Id == id);
                if (person != null)
                {
                    int index = personList.Persons.IndexOf(person);
                    personList.Persons.RemoveAt(index);
                }
            }
            else
            {
                Console.WriteLine($"Person with id {id} does not exist!!!");
            }
        }

        public void UpdateUserDetails(ManagePersonList personList)
        {
            Console.WriteLine("----- Update Person Information -----");
            Console.WriteLine("Enter Person Id Which you want to update.");
            try
            {
                int id;
                if(int.TryParse(Console.ReadLine(),out id))
                {
                    Person person = personList.Persons.Find(p => p.Id == id);
                    if(person != null)
                    {
                        int index = personList.Persons.IndexOf(person);

                        Console.WriteLine("Enter Name of Person : ");
                        personList.Persons[index].Name = Console.ReadLine();

                        Console.WriteLine("Enter Mobile Number : ");

                        Regex reg = new Regex(@"^[0-9]{10}$");
                        string mobileNumber = Console.ReadLine();
                        if (reg.IsMatch(mobileNumber))
                        {
                            personList.Persons[index].MobileNumber = mobileNumber;
                        }
                        else
                        {
                            Console.WriteLine("Please enter valid Mobile Number like '9658457123'");
                        }

                        Console.WriteLine("Enter Age of Person : ");
                        int age;
                        if(int.TryParse(Console.ReadLine(),out age))
                        {
                            if(age >= 18 && age <= 100)
                            {
                                personList.Persons[index].Age = age;
                            }
                            else
                            {
                                Console.WriteLine("Enter Valid Age, Age should be greater than 18.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Enter Valid Age.");
                        }
                    }
                    else
                    {
                        Console.WriteLine($"Person with {id} does not exist.");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter a Valid Number...");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        public override void DisplayInformation(ManagePersonList personList)
        {
            List<Person> persons = personList.Persons;
            Console.WriteLine("----- Persons List -----");
            foreach(Person person in persons)
            {
                Console.WriteLine($"Id : {person.Id}\nName : {person.Name} \nMobile Number : {person.MobileNumber}" +
                    $"\nAge : {person.Age}\nBalance : {person.Balance}\n");
                Console.WriteLine("\n----- Transactions -----\n");
                person.Transactions.ForEach((transaction) => Console.WriteLine($"Description : {transaction.Description}\n" +
                    $"Amount : {transaction.Amount}\n"));
            }
        }
        public override void DisplayInformation(string accountNumber, ManagePersonList personList)
        {
            Console.WriteLine("----- Transactions -----");
            Person person = personList.Persons.Find(p => p.AccountNumber == accountNumber);
            person.Transactions.ForEach((transaction) => Console.WriteLine($"Description : {transaction.Description}\n" +
                    $"Amount : {transaction.Amount}"));
            Console.WriteLine($"Balance : {person.Balance}");
        }
        public override void DisplayInformation(Person person)
        {
            if(person != null)
            {
                Console.WriteLine("----- Person -----");
                Console.WriteLine($"Id : {person.Id}\nName : {person.Name}\nMobile Number : {person.MobileNumber}" +
                    $"\nAge : {person.Age}");
            }
            else
            {
                Console.WriteLine("Person does not exist...");
            }
            
        }

        public override void ShowMinMaxAmount(List<Transaction> transactionList)
        {
            Console.WriteLine("----- Minimum & Maximum amount -----");
            double minimumAmount = transactionList.Min(transaction => transaction.Amount);
            double maximumAmount = transactionList.Max(transaction => transaction.Amount);

            Console.WriteLine($"Mimimum amount : {minimumAmount}\nMaximum amount : {maximumAmount}");
        }
    }
}
