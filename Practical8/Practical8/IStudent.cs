﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practical8
{
    public interface IStudent
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        int Age { get; set; }
        string Email { get; set; }
        long PhoneNumber { get; set; }
    }
}
