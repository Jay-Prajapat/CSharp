using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter Amount");
            double amount = Convert.ToDouble(Console.ReadLine());

            Invoice FInvoice = new FinalInvoice();
            double FInvoiceAmount = FInvoice.GetInvoiceDiscount(amount);
            Console.WriteLine($"Final Invoice : {FInvoiceAmount}");

            Invoice PInvoice = new ProposedInvoice();
            double PInvoiceAmount = PInvoice.GetInvoiceDiscount(amount);
            Console.WriteLine($"Proposed Invoice : {PInvoiceAmount}");

            Invoice RInvoice = new RecurringInvoice();
            double RInvoiceAmount = RInvoice.GetInvoiceDiscount(amount);
            Console.WriteLine($"Final Invoice : {RInvoiceAmount}");

        }
    }
}
