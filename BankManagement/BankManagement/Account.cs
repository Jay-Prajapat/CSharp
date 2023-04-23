using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public abstract class Account
    {
        public abstract void DisplayInformation(ManagePersonList personList);
        public abstract void DisplayInformation(string accountNumber, ManagePersonList personList);
        public abstract void DisplayInformation(Person person);
        public abstract void ShowMinMaxAmount(List<Transaction> transactionList);
    }
}
