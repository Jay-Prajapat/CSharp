using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class StudentRepository
    {
        /// <summary>
        /// This will add the student and print the message.
        /// </summary>
        /// <param name="student"></param>
        public void Save(Student student)
        {
            Logger.Log("Starting Save()");
            Logger.Log($"{student.FirstName} is added");
            Logger.Log("Ending Saving()");
        }
        /// <summary>
        /// This will delete the student and print the message.
        /// </summary>
        /// <param name="student"></param>
        public void Delete(Student student) 
        {
            Logger.Log("Starting Delete()");
            Logger.Log($"{student.FirstName} is deleted");
            Logger.Log("Ending Delete()");
        }
        /// <summary>
        /// This will save the course and print the message.
        /// </summary>
        /// <param name="student"></param>
        /// <param name="course"></param>
        public void SaveCourse(Student student, Course course)
        {
            Logger.Log("Starting SaveCourse()");
            Logger.Log($"{student.FirstName} have taken {course.Title} Course.");
            Logger.Log("Ending SaveCourse()");
        }
    }
}
