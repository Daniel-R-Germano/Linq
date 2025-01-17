﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace FixationLinq
{
    internal class PeopleData
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public PeopleData(string name, string email, double salary)
        {
            Name = name;
            Email = email;
            Salary = salary;
        }
    }
}
