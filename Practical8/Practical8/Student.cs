using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    public class Student 
    {
        private int _id;
        private string _firstName;
        private string _lastName;   
        private string _email;
        private long _phone;
        private int _age;
        public int Id 
        { 
            get { return _id; }
            set { _id = value; }
        }
        public string FirstName 
        {
            get { return _firstName; }
            set { _firstName = value; }
        }
        public string LastName 
        {
            get { return _lastName; }
            set
            {
                _lastName = value;
            }
        }
        public int Age 
        {
            get { return _age; }
            set
            {
                _age = value;
            }
        }
        public string Email 
        {
            get { return _email; }
            set
            {
                _email = value;
            }
        }
        public long PhoneNumber 
        {
            get { return _phone; }
            set
            {
                _phone = value;
            }
        }
    }
}
