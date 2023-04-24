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
        public override void UpdateStudent(ManageStudentList studentList)
        {
            Console.WriteLine("---- Update Student Info. ----");
            Console.WriteLine("Enter student id which you want to update");
            try
            {
               
                int id = int.Parse(Console.ReadLine());
               
                Student student = studentList.Students.Find(std => std.Id == id);
                if(student != null)
                {
                    int index = studentList.Students.IndexOf(student);
                    Console.WriteLine("Enter first name : ");
                    studentList.Students[index].FirstName = Console.ReadLine();

                    Console.WriteLine("Enter last name : ");
                    studentList.Students[index].LastName = Console.ReadLine();

                    Console.WriteLine("Enter email id of student : ");
                    studentList.Students[index].Email = Console.ReadLine();

                    Console.WriteLine("Enter age of student : ");
                    studentList.Students[index].Age = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter phone number of student : ");
                    studentList.Students[index].PhoneNumber = Convert.ToInt64(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine($"Student with id {id} does exist!!!" );
                }

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
        public override void DeleteStudent(ManageStudentList studentList, int id)
        {
            
            Student student = studentList.Students.Find(std => std.Id == id);
            if(student != null) { 
                int index = studentList.Students.IndexOf(student);
                studentList.Students.RemoveAt(index);
            }
            else
            {
                Console.WriteLine($"Student with id {id} doesn't exist!!!");
            }
        }
    }
}
