using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerAccount
{
    public class CustomerAccount
    {
        public string bankName;
        private long customerAccountNo;
        private string customerName;

        public CustomerAccount(long customer_accountNo, string customer_name)
        {
            this.customerAccountNo = customer_accountNo;
            this.customerName = customer_name;
        }
        /// <summary>
        /// This will print the information of customers.
        /// </summary>
        public void printInfo()
        {
            Console.WriteLine($"Customer Information:\nCustomer Name: {customerName}\nBank name: {bankName}\n" +
                $"Customer Account No: {customerAccountNo}");
        }
        static void Main(string[] args)
        {
            CustomerAccount customer1 = new CustomerAccount(56452522,"Jay Prajapati");
            customer1.bankName = "State Bank Of India";
            customer1.printInfo();

        }
    }
}
