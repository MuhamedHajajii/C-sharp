﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    internal class Employee
    {
        public string FirstName { get; set; } = null!;
        public string? LastName { get; set; } = null;

        // By Defult Paramater Less Constructor The Compiler Generate it for the class
        // there are a non-nullable variable it must contain a nun-null value
        public Employee() {
            //FirstName = "";
        }
    }
}
