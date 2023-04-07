using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrigationPrinciple
{
    public class DellPrinter : IPrinter
    {
        /// <summary>
        /// This will print the content.
        /// </summary>
        /// <param name="PrintContent"></param>
        public void Print(string PrintContent)
        {
            Console.WriteLine($"DellPrinter : Printing Complete : {PrintContent}");
        }
        /// <summary>
        /// This will scan the content and prints the messsage.
        /// </summary>
        /// <param name="ScanContent"></param>
        public void Scan(string ScanContent)
        {
            Console.WriteLine($"DellPrinter : Scanning Content : {ScanContent}");
        }
    }
}
