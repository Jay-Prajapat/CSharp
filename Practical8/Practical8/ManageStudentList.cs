using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    public class ManageStudentList 
    {
        private List<Student> _students = new List<Student>();
        public List<Student> Students 
        {
            get { return _students; }
            set { _students = value; }
        }
    }
}
