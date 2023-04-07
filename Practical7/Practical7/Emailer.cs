using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    public class Emailer : IEmailer
    {
        /// <summary>
        /// This will send email to the person with the given message.
        /// </summary>
        /// <param name="person"></param>
        /// <param name="message"></param>
        public void SendEmail(IPerson person, string message)
        {
            Console.WriteLine($"Sending an email to {person.EmailAddress}");
        }
    }
}
