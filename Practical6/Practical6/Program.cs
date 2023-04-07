using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProcessBusinessLogic bl  = new ProcessBusinessLogic();
            bl.ProcessCompleted += bl_ProcessCompleted;
            bl.StartProcess();
          
        }
        /// <summary>
        /// This method will complete the process.
        /// </summary>
        public static void bl_ProcessCompleted()
        {
            Console.WriteLine("Process Completed!");
        }
    }
}
