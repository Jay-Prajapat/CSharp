using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //EmployeeBusinessLogic employeeBusinessLogic = new EmployeeBusinessLogic();
            //Employee emp = employeeBusinessLogic.GetEmployeeDetails(101);
            //Console.WriteLine($"ID: {emp.ID} , Name : {emp.Name}, Department: {emp.Department}, Salary: {emp.Salary}");

            IPerson owner = DataAccessFactory.CreatePerson();

            owner.FirstName = "Jay";
            owner.LastName = "Prajapati";
            owner.EmailAddress = "jay.123@gmail.com";
            owner.PhoneNumber = "9586475896";


            ITask task = DataAccessFactory.CreateTask();

            task.TaskName = "Take the Backup";
            task.Owner = owner;
            

            task.PerformedWork(3);
            task.PerformedWork(1.5);
            task.TaskCompolete();
        }

    }
}
