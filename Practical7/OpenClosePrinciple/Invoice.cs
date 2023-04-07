using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpenClosePrinciple
{
    public class Invoice
    {
        /// <summary>
        /// This will calculate the invoice.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>The amount after discount.</returns>
        public virtual double GetInvoiceDiscount(double amount)
        {
            return amount - 10;
        }
    }
    public class FinalInvoice : Invoice
    {
        /// <summary>
        /// This will calculate final invoice and call base class method.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>The amount after final discount.</returns>
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }

    public class ProposedInvoice : Invoice
    {
        /// <summary>
        /// This will calculate the proposed invoice and call the base class method.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>The amount after propose invoice.</returns>
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 40;
        }
    }

    public class RecurringInvoice: Invoice
    {
        /// <summary>
        /// This will calculate recurring invoice and call the base class method.
        /// </summary>
        /// <param name="amount"></param>
        /// <returns>The recurring Invoice.</returns>
        public override double GetInvoiceDiscount(double amount)
        {
            return base.GetInvoiceDiscount(amount) - 30;
        }
    }
}
