using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class PaymentManager
    {
        /// <summary>
        /// This will complete payment process and print the message.
        /// </summary>
        /// <param name="student"></param>
        public static void PaymentProcess(Student student)
        {
            Console.WriteLine($"Payment Completed for {student.FirstName}");
        }
    }
}
