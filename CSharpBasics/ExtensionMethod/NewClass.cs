using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ExtensionMethod.Program;

namespace ExtensionMethod
{
    public static  class NewClass
    {
        public static void Test3(this OldClass o)
        {
            Console.WriteLine("Method Three");
        }
        public static void Test4(this OldClass o,int x)
        {
            Console.WriteLine("Method Four: " + x);
        }
        public static void Test5(this OldClass o)
        {
            Console.WriteLine("Method Four: " + o.x);
        }
    }
}
