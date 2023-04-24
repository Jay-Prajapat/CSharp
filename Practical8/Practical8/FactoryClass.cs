using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    /// <summary>
    /// This class provides instance of classes and it makes application loosly coupled.
    /// </summary>
    public static class FactoryClass
    {
        public static IStudent GetStudent()
        {
            return new Student();
        }
        public static IAddStudent GetAddStudent()
        {
            return new AddStudent();
        }
        public static IManageStudentList GetManageStudentList()
        {
            return new ManageStudentList();
        }
        public static IManageUserThings GetManageUserThings() 
        {
            return new ManageStudent();    
        }
        public static IStudentInfo GetStudentInfo()
        {
            return new StudentInfo();
        }
        public static ManageTeacher GetTeacher()
        {
            return new Teacher();
        }
    }
}
