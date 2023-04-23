using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string MobileNumber {get;set;}
       public string AccountNumber { get; set; }
        public double Balance { get; set; }
        public int Age { get; set; }
        private List<Transaction> _transactions = new List<Transaction>();
        public List<Transaction> Transactions
        {
            get { return _transactions; }
            set { _transactions = value; }
        }

        public Person(int id,string name,string mobileNumber,string accountNumber, int age)
        {
            this.Id = id;
            this.Name = name;
            this.MobileNumber = mobileNumber;
            this.AccountNumber = accountNumber;
            this.Age = age;
            this.Balance = 500;
        }

        public void DisplayPersonDetails()
        {
            Console.WriteLine($"Name : {Name}\nMobile Number : {MobileNumber}\nAge : {Age}\nBalance : {Balance}");
        }
        public void Withdraw()
        {
            Console.WriteLine("Enter amount : ");
            double amount;
            if (double.TryParse(Console.ReadLine(), out amount))
            {
                if (this.Balance > amount && amount > 0)
                {
                    this.Balance -= amount;
                    Transaction transaction = new Transaction($"Debited {amount} Rs.", amount, false);
                    this.Transactions.Add(transaction);

                    Console.WriteLine($"Dear User your A/C {this.AccountNumber} Debited by Rs {amount}");
                }
                else
                {
                    Console.WriteLine("Insufficient Balance!!!");
                }
            }
            else
            {
                Console.WriteLine("Enter valid amount!!!");
            }

        }
        public void Deposit()
        {
            Console.WriteLine("Enter amount : ");
            double amount;
            if(double.TryParse(Console.ReadLine(),out amount))
            {
                if (amount > 0)
                {
                    
                    this.Balance += amount;
                    Transaction transaction = new Transaction($"Credited {amount} Rs.", amount, true);
                    this.Transactions.Add(transaction);
                    Console.WriteLine($"Dear User your A/C {this.AccountNumber} Credited by Rs {amount}");
                }
                else
                {
                    Console.WriteLine("Value should be grater than zero.");
                }
            }
            else
            {
                Console.WriteLine("Enter valid amount!!!");
            }
        }
    }
}
