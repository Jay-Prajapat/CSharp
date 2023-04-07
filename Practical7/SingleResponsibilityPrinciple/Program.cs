using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student std1 = new Student()
            {
                StudentID = 1,
                FirstName = "Jay",
                LastName = "Prajapati",
                Email = "jay@abc.com",
                City = "Ahemadabad"
            };

            Course course1 = new Course()
            {
                CourseID = 1,
                Title = "SOLID Principles",
                Type = "online"
            };

            StudentRepository sr1= new StudentRepository();
            sr1.Save(std1);
            course1.Subscribe(std1);
            sr1.SaveCourse(std1, course1);

        }
    }
}
