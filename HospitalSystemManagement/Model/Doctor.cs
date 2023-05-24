﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Project.Model
{
    internal class Doctor
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; }
        public string Address { get; set; }
        public DateTime BirthDate { get; set; }
        public Department Department { get; set; }

    }
}
