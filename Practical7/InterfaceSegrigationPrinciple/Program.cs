using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceSegrigationPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HPPrinter hp = new HPPrinter();
            hp.Print("hello world");
            hp.Scan("Scan pdf file");
            hp.PrintDuplicates("print 10 coppies");
            hp.ColourPrint("Print Colour page");

            DellPrinter dl = new DellPrinter();
            dl.Print("Print dell message");
            dl.Scan("Scan word file");

        }
    }
}
