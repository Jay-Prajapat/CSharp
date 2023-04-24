using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            Person person = new Person(1,"Jay", "9685964592", "556965", 21);
            List<Transaction> transactions = new List<Transaction>();
            Dictionary<long, Transaction> transactionList = new Dictionary<long, Transaction>();
            Transaction transaction1 = new Transaction("Credited 5000 Rs.", 5000, true);
            Transaction transaction2 = new Transaction("Credited 1000 Rs.", 1000, true);
            Transaction transaction3 = new Transaction("Debited 500 Rs.", 500, false);
            Transaction transaction4 = new Transaction("Debited 1000 Rs.", 1000, false);
            Transaction transaction5 = new Transaction("Credited 2000 Rs.", 2000, true);
            person.Transactions.Add(transaction1);
            person.Transactions.Add(transaction2);
            person.Transactions.Add(transaction5);
            person.Transactions.Add(transaction4);
            person.Transactions.Add(transaction3);

            

            persons.Add(person);
            ManagePersonList personList = new ManagePersonList();
            personList.Persons = persons;

            ManageUser user = new ManageUser();
            user.ManagePersons(personList);
        }
    }
}
