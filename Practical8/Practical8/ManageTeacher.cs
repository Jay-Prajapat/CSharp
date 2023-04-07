using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    public abstract class ManageTeacher
    {
        public abstract void UpdateStudent(IManageStudentList studentList);
        public abstract void DeleteStudent(IManageStudentList studentList, int id);
    }
}
