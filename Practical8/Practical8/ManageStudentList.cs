using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    public class ManageStudentList : IManageStudentList
    {
        private List<IStudent> _students = new List<IStudent>();
        public List<IStudent> Students 
        {
            get { return _students; }
            set { _students = value; }
        }
    }
}
