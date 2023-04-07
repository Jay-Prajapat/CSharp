using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    public sealed class Teacher : ManageTeacher
    {
        /// <summary>
        /// This method will update the student information in the student list.
        /// </summary>
        /// <param name="studentList"></param>
        public override void UpdateStudent(IManageStudentList studentList)
        {
            Console.WriteLine("---- Update Student Info. ----");
            Console.WriteLine("Enter student id which you want to update");
            try
            {
               
                int id = int.Parse(Console.ReadLine());
               
                IStudent student = studentList.Students.Find(std => std.Id == id);
                int x = studentList.Students.IndexOf(student);
                Console.WriteLine("Enter first name : ");
                studentList.Students[x].FirstName = Console.ReadLine();

                Console.WriteLine("Enter last name : ");
                studentList.Students[x].LastName = Console.ReadLine();

                Console.WriteLine("Enter email id of student : ");
                studentList.Students[x].Email = Console.ReadLine();

                Console.WriteLine("Enter age of student : ");
                studentList.Students[x].Age = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter phone number of student : ");
                studentList.Students[x].PhoneNumber = Convert.ToInt64(Console.ReadLine());

            }
            catch (Exception ex)
            { 
                Console.WriteLine(ex.Message); 
            }
        }
        /// <summary>
        /// This method will delete the student information from student list by given specific id.
        /// </summary>
        /// <param name="studentList"></param>
        /// <param name="id"></param>
        public override void DeleteStudent(IManageStudentList studentList, int id)
        {
            if(studentList.Students.Exists(std => std.Id == id))
            {
                IStudent student = studentList.Students.Find(std => std.Id == id);
                int x = studentList.Students.IndexOf(student);
                studentList.Students.Remove(studentList.Students[x]);
            }
            else
            {
                Console.WriteLine($"Student with id {id} doesn't exist!!!");
            }
        }
    }
}
