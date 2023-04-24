using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    public abstract class ManageTeacher
    {
        public abstract void UpdateStudent(ManageStudentList studentList);
        public abstract void DeleteStudent(ManageStudentList studentList, int id);
    }
}
