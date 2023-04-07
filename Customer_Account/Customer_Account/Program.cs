using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Customer_Account
{
    internal class Customer_Account
    {
        public string bankName;
        public long customerAccountNo;
        public string customerName;

        public Customer_Account(long customer_accountNo, string customer_name)
        {
            customerAccountNo = customer_accountNo;
            customerName = customer_name;
        }
        /// <summary>
        /// This will print the information of customers.
        /// </summary>
        public void printInfo()
        {
            Console.WriteLine("Customer Information:");
            Console.WriteLine($"Customer Name: {customerName}");
            Console.WriteLine($"Bank name: {bankName}");
            Console.WriteLine($"Customer Account No: {customerAccountNo}");
        }
        static void Main(string[] args)
        {
            Customer_Account customer1 = new Customer_Account(56452522,"Jay Prajapati");
            customer1.bankName = "State Bank Of India";
            customer1.printInfo();

        }
    }
}
