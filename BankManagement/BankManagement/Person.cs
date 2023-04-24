using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class Person
    {
        private int _id;
        private string _name;
        private string _mobileNumber;
        private string _accountNumber;
        private double _balance;
        private int _age;
        public int Id 
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name= value; }
        }
        public string MobileNumber 
        {
            get { return _mobileNumber; }
            set { _mobileNumber = value; }
        }
       public string AccountNumber 
        {
            get { return _accountNumber; }
            set { _accountNumber = value; }
        }
        public double Balance 
        {
            get { return _balance; } 
            set { _balance = value; }
        }
        public int Age 
        {
            get { return _age; }
            set { _age = value; }
        }
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
