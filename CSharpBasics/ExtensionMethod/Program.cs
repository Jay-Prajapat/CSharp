using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    class Program
    {

        
        static void Main(string[] args)
        {
            OldClass o1= new OldClass();
            o1.Test1();
            o1.Test2();
            o1.Test3();
            o1.Test4(10);
            o1.Test5();
        }
    }
}
