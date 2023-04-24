using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrigationPrinciple
{
    public class HPPrinter : IPrinter, IPrintDuplicates, IPrintColour
    {
        /// <summary>
        /// This will print the content.
        /// </summary>
        /// <param name="printContent"></param>
        public void Print(string printContent)
        {
            Console.WriteLine($"HPPrinter : Printing Complete : {printContent}");
        }
        /// <summary>
        /// This will scan the content and print the message.
        /// </summary>
        /// <param name="scanContent"></param>
        public void Scan(string scanContent)
        {
            Console.WriteLine($"HPPrinter : Sacn Complete: {scanContent}");
        }
        /// <summary>
        /// This will print the duplicate content.
        /// </summary>
        /// <param name="duplicateContent"></param>
        public void PrintDuplicates(string duplicateContent)
        {
            Console.WriteLine($"HPPrinter : Printing Duplicate Content: {duplicateContent}");
        }
        /// <summary>
        /// This will print the colour content.
        /// </summary>
        /// <param name="colourContent"></param>
        public void ColourPrint(string colourContent)
        {
            Console.WriteLine($"HPPrinter : Printing Complete : {colourContent}");
        }
    }
}
