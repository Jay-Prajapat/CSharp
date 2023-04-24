using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class EmailManager
    {
        /// <summary>
        /// This will send an email to the student and print the message.
        /// </summary>
        /// <param name="student"></param>
        public static void SendEmail(Student student)
        {
            Console.WriteLine($"Email sent successfully sent to {student.Email} ID");
        }
    }
}
