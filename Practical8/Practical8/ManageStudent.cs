using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    public class ManageStudent:IManageUserThings 
    {
        public enum Options
        {
            Add = 1,
            Update = 2,
            ViewStudentByID = 3,
            ViewAllStudents = 4,
            DeleteStudent = 5,
            Exit = 6
        }
        /// <summary>
        /// This method will give different options and based on the 
        /// option selection we can do different CRUD operation.
        /// </summary>
        /// <param name="studentList"></param>
        public void ManageUsers(ManageStudentList studentList)
        {
            while (true)
            {
                Console.WriteLine("Choose Options : \n1.Add Student \n2.Update Student Details\n3.View Student By ID " +
                    "\n4.View All Students \n5.Delete Student \n6.Exit");
                int option;
                try
                {
                    if (int.TryParse(Console.ReadLine(), out option))
                    {
                        //IStudent student = FactoryClass.GetStudent();

                        switch (option)
                        {
                            case (int)Options.Add:
                                IAddStudent addStudent = FactoryClass.GetAddStudent();
                                addStudent.AddNewStudent(studentList);
                                break;
                            case (int)Options.Update:
                                ManageTeacher teacher = FactoryClass.GetTeacher();
                                teacher.UpdateStudent(studentList);
                                break;
                            case (int)Options.ViewStudentByID:
                                Console.WriteLine("Enter id you want to see : ");
                                IStudentInfo studentInfo = FactoryClass.GetStudentInfo();
                                int id = int.Parse(Console.ReadLine());
                                studentInfo.ViewStudent(studentList, id);
                                break;
                            case (int)Options.ViewAllStudents:
                                studentInfo = FactoryClass.GetStudentInfo();
                                studentInfo.ViewStudent(studentList);
                                break;
                            case (int)Options.DeleteStudent:
                                Console.WriteLine("Enter id you want to delete : ");
                                int deleteId = int.Parse(Console.ReadLine());
                                teacher = FactoryClass.GetTeacher();
                                teacher.DeleteStudent(studentList, deleteId);
                                break;
                            case (int)Options.Exit:
                                Environment.Exit(0);
                                break;
                            default:
                                Console.WriteLine("Choose valid option.");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Enter Valid option.\n");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                Console.WriteLine("\n\n");
                
            }
        }
    }
}
