using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public class Transaction
    {
        public string Description { get; set; }
        public double Amount { get; set; }
        public bool IsCredit { get; set; }
        public Transaction(string description,double amount,bool isCredit)
        {
            this.Description = description;
            this.Amount = amount;
            this.IsCredit = isCredit;
        }

        public void DisplayTransactionDetails()
        {
            string transactionType = IsCredit ? "Credit" : "Debit";
            Console.WriteLine($"Description : {Description}\nAmount : {Amount}\nType : {transactionType}");
        }

    }
}
