using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    public class StudentInfo : IStudentInfo
    {
        /// <summary>
        /// This method will print the specific student information that is given in id.
        /// </summary>
        /// <param name="studentList"></param>
        /// <param name="id"></param>
        public void ViewStudent(ManageStudentList studentList, int id)
        {
            List<Student> students = studentList.Students;
            try
            {
               
                Student student = students.Find(std => std.Id == id);
                if(student != null) { 
                    Console.WriteLine("---------------------------------");

                    Console.WriteLine($"ID : {student.Id} \nName : {student.FirstName + " " + student.LastName} \n" +
                        $"Age : {student.Age} \nEmail : {student.Email} \nContact No: {student.PhoneNumber}");
                    Console.WriteLine("---------------------------------");

                }
                else
                {
                    Console.WriteLine($"Student with ID : {id} doesn't exist!!!");
                }
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }
        /// <summary>
        /// This method will print all students details from the student list.
        /// </summary>
        /// <param name="studentList"></param>
        public void ViewStudent(ManageStudentList studentList)
        {
            List<Student> students = studentList.Students;
            if (students.Count != 0)
            {
                Console.WriteLine("---------------------------------");
                foreach (Student student in students)
                {
                    Console.WriteLine($"ID : {student.Id} \nName : {student.FirstName + " " + student.LastName} \n" +
                        $"Age : {student.Age} \nEmail : {student.Email} \nContact No: {student.PhoneNumber}");
                    Console.WriteLine();
                }
                Console.WriteLine("---------------------------------");

            }
            else
            {
                Console.WriteLine("No student is in the list");
            }
        }
    }
}
