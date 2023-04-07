using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    public class DataAccessFactory
    {
        /// <summary>
        /// This will create an instance of EmployeeDataAccessLogic class.
        /// </summary>
        /// <returns>This will returns an instance of EmployeeDataAccessLogic class. </returns>
        public static IEmployeeDataAccessLogic GetEmployeeDataAccessObj()
        {
            return new EmployeeDataAccessLogic();
        }
        /// <summary>
        /// This will create an instance of CreatePerson class.
        /// </summary>
        /// <returns>This will returns an instance of CreatePerson class.</returns>
        public static IPerson CreatePerson()
        {
            return new Person();
        }
        /// <summary>
        /// This will create an instance of CreateLogger class.
        /// </summary>
        /// <returns>This will returns an instance of CreateLogger class.</returns>
        public static ILogger CreateLogger()
        {
            return new Logger();    
        }
        /// <summary>
        /// This will create an instance of CreateTask class.
        /// </summary>
        /// <returns>This will returns an instance of CreateTask class.</returns>
        public static ITask CreateTask()
        {
            return new Task(CreateLogger(), CreateEmailer());  
        }
        /// <summary>
        /// This will create an instance of CreateEmailer class.
        /// </summary>
        /// <returns>This will returns an instance of CreateEmailer class.</returns>
        public static IEmailer CreateEmailer()
        {
            return new Emailer();
        }
    }
}
