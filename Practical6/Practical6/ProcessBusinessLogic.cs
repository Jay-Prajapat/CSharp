using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical6
{
    
    public delegate void Notify();
    public class ProcessBusinessLogic
    {
        public event Notify ProcessCompleted;
        /// <summary>
        /// This method will start the process and call the OnProcessCompleted method.
        /// </summary>
        public void StartProcess()
        {
            Console.WriteLine("Process Started");
            OnProcessCompleted();
        }
        /// <summary>
        /// This will invoke the ProcessCompleted event.
        /// </summary>
        protected virtual void OnProcessCompleted()
        {
            ProcessCompleted?.Invoke();
        }
    }
}
