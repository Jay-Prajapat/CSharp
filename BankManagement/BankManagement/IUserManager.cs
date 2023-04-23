using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankManagement
{
    public interface IUserManager
    { 
        void UpdateUserDetails(ManagePersonList personList);
        void DeleteUser(ManagePersonList personList,int id);
    }
}
