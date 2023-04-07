using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    public interface IManageStudentList
    {
        List<IStudent> Students { get; set; }
    }
}
