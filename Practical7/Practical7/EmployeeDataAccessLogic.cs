using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    public class EmployeeDataAccessLogic:IEmployeeDataAccessLogic
    {
       public Employee GetEmployeeDetails(int id)
        {
            Employee emp = new Employee()
            {
                ID = id,
                Name = "Jay",
                Department = ".Net",
                Salary = 400000
            };
            return emp;
        }
    }
}
