using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<IStudent> students = new List<IStudent>();
            IStudent student = FactoryClass.GetStudent();

            student.Id = 1;
            student.FirstName = "Jay";
            student.LastName = "Prajapati";
            student.Age = 21;
            student.Email = "jay.12@gmail.com";
            student.PhoneNumber = 598547451;

            students.Add(student);
            IManageStudentList studentList = FactoryClass.GetManageStudentList();
            studentList.Students = students;
            IManageUserThings m = FactoryClass.GetManageUserThings();
            m.ManageUsers(studentList);
        }
    }
}
